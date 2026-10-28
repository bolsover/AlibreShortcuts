using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Svg;
using Shortcuts.Model;

namespace Shortcuts.View
{
    public partial class CommandPickerDialog : Form
    {
        private readonly List<WorkspaceCommand> _allCommands;
        private readonly string _workspace;
        private readonly Keys _targetKeys;
        private readonly string _keyDisplayString;
        private readonly string _currentAssignedCommandId;
        private readonly string _currentAssignedHint;
        private readonly ImageList _imageList = new();

        private bool _isInitializingFilters;
        private int _sortColumn = -1;
        private SortOrder _sortOrder = SortOrder.None;

        public WorkspaceCommand SelectedCommand { get; private set; }
        public bool IsClearRequested { get; private set; }

        public CommandPickerDialog(
            string workspace,
            Keys targetKeys,
            string keyDisplayString,
            string currentAssignedCommandId,
            string currentAssignedHint,
            List<WorkspaceCommand> availableCommands)
        {
            _workspace = workspace;
            _targetKeys = targetKeys;
            _keyDisplayString = keyDisplayString;
            _currentAssignedCommandId = currentAssignedCommandId;
            _currentAssignedHint = currentAssignedHint;
            _allCommands = availableCommands ?? new List<WorkspaceCommand>();

            InitializeComponent();
            Icon = Globals.Icon;
            SetupDialogData();
        }

        private void SetupDialogData()
        {
            lblWorkspace.Text = $"Active Workspace: {_workspace}";
            lblKeyCombination.Text = $"Key: {_keyDisplayString}";

            if (!string.IsNullOrEmpty(_currentAssignedCommandId))
            {
                var assignedDesc = !string.IsNullOrEmpty(_currentAssignedHint)
                    ? $"{_currentAssignedHint} ({_currentAssignedCommandId})"
                    : _currentAssignedCommandId;
                lblCurrentBinding.Text = $"Current Binding in '{_workspace}': {assignedDesc}";
                lblCurrentBinding.ForeColor = Color.DarkBlue;
                btnClear.Enabled = true;
            }
            else
            {
                lblCurrentBinding.Text = $"Current Binding in '{_workspace}': Unassigned";
                lblCurrentBinding.ForeColor = Color.DarkGray;
                btnClear.Enabled = false;
            }

            SetupImageList();
            SetupFilterControls();
            ApplyFilters();
        }

        private void SetupImageList()
        {
            _imageList.ImageSize = new Size(20, 20);
            _imageList.ColorDepth = ColorDepth.Depth32Bit;

            var defaultBmp = new Bitmap(20, 20);
            using (var g = Graphics.FromImage(defaultBmp))
            {
                g.Clear(Color.Transparent);
            }
            _imageList.Images.Add("default", defaultBmp);

            var added = new HashSet<string>();
            foreach (var cmd in _allCommands)
            {
                if (cmd.SvgImage != null && !added.Contains(cmd.CommandId))
                {
                    try
                    {
                        var bmp = SvgBitmap.Create(cmd.SvgImage).Render(new Size(20, 20), null);
                        _imageList.Images.Add(cmd.CommandId, bmp);
                        added.Add(cmd.CommandId);
                    }
                    catch
                    {
                        // Ignore image rendering failure
                    }
                }
            }

            listViewCommands.SmallImageList = _imageList;
        }

        private void SetupFilterControls()
        {
            _isInitializingFilters = true;

            // Workspace Filter
            cmbWorkspace.Items.Clear();
            cmbWorkspace.Items.Add("[All Workspaces]");

            var distinctWorkspaces = _allCommands
                .Select(c => c.Workspace)
                .Where(w => !string.IsNullOrEmpty(w))
                .Distinct()
                .OrderBy(w => w)
                .ToList();

            foreach (var ws in distinctWorkspaces)
            {
                cmbWorkspace.Items.Add(ws);
            }

            var wsIndex = cmbWorkspace.FindStringExact(_workspace);
            cmbWorkspace.SelectedIndex = wsIndex >= 0 ? wsIndex : 0;

            // Shortcuts Filter
            cmbShortcutFilter.Items.Clear();
            cmbShortcutFilter.Items.Add("[All Commands]");
            cmbShortcutFilter.Items.Add("Assigned Shortcuts Only");
            cmbShortcutFilter.Items.Add("Unassigned Commands Only");
            cmbShortcutFilter.Items.Add($"Assigned to Target Key ({_keyDisplayString})");
            cmbShortcutFilter.SelectedIndex = 0;

            // Categories Filter
            PopulateCategoryFilter();

            _isInitializingFilters = false;
        }

        private void PopulateCategoryFilter()
        {
            var previousSelection = cmbCategory.SelectedItem?.ToString();

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("[All Projects / Categories]");

            var selectedWs = cmbWorkspace.SelectedItem?.ToString();
            var query = _allCommands.AsEnumerable();

            if (!string.IsNullOrEmpty(selectedWs) && selectedWs != "[All Workspaces]")
            {
                query = query.Where(c => string.Equals(c.Workspace, selectedWs, StringComparison.OrdinalIgnoreCase));
            }

            var distinctCategories = query
                .Select(c => c.Category)
                .Where(cat => !string.IsNullOrEmpty(cat))
                .Distinct()
                .OrderBy(cat => cat)
                .ToList();

            foreach (var cat in distinctCategories)
            {
                cmbCategory.Items.Add(cat);
            }

            if (!string.IsNullOrEmpty(previousSelection))
            {
                var idx = cmbCategory.FindStringExact(previousSelection);
                cmbCategory.SelectedIndex = idx >= 0 ? idx : 0;
            }
            else
            {
                cmbCategory.SelectedIndex = 0;
            }
        }

        private void cmbWorkspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializingFilters) return;

            _isInitializingFilters = true;
            PopulateCategoryFilter();
            _isInitializingFilters = false;

            ApplyFilters();
        }

        private void FilterControl_Changed(object sender, EventArgs e)
        {
            if (_isInitializingFilters) return;
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var search = txtSearch.Text.Trim();
            var selectedWorkspace = cmbWorkspace.SelectedItem?.ToString();
            var selectedCategory = cmbCategory.SelectedItem?.ToString();
            var shortcutFilterIndex = cmbShortcutFilter.SelectedIndex;

            var filtered = _allCommands.AsEnumerable();

            if (!string.IsNullOrEmpty(selectedWorkspace) && selectedWorkspace != "[All Workspaces]")
            {
                filtered = filtered.Where(cmd => string.Equals(cmd.Workspace, selectedWorkspace, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "[All Projects / Categories]")
            {
                filtered = filtered.Where(cmd => string.Equals(cmd.Category, selectedCategory, StringComparison.OrdinalIgnoreCase));
            }

            if (shortcutFilterIndex == 1) // Assigned Shortcuts Only
            {
                filtered = filtered.Where(cmd => cmd.ShortcutKeys != Keys.None);
            }
            else if (shortcutFilterIndex == 2) // Unassigned Commands Only
            {
                filtered = filtered.Where(cmd => cmd.ShortcutKeys == Keys.None);
            }
            else if (shortcutFilterIndex == 3) // Matches Target Key
            {
                filtered = filtered.Where(cmd => cmd.ShortcutKeys == _targetKeys);
            }

            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(cmd =>
                    (cmd.DisplayName != null && cmd.DisplayName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (cmd.Hint != null && cmd.Hint.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (cmd.CommandId != null && cmd.CommandId.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (cmd.Category != null && cmd.Category.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (cmd.Workspace != null && cmd.Workspace.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (cmd.ShortcutKeys != Keys.None && new KeysConverter().ConvertToString(cmd.ShortcutKeys).IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                );
            }

            var resultList = filtered.ToList();
            PopulateCommandList(resultList);
        }

        private void PopulateCommandList(List<WorkspaceCommand> commands)
        {
            listViewCommands.BeginUpdate();
            listViewCommands.Items.Clear();

            var kc = new KeysConverter();

            foreach (var cmd in commands)
            {
                var item = new ListViewItem(cmd.DisplayName)
                {
                    Tag = cmd,
                    ImageKey = _imageList.Images.ContainsKey(cmd.CommandId) ? cmd.CommandId : "default"
                };

                item.SubItems.Add(cmd.Workspace ?? "");
                item.SubItems.Add(cmd.Category ?? "");
                item.SubItems.Add(cmd.CommandId);

                var shortcutStr = cmd.ShortcutKeys != Keys.None ? kc.ConvertToString(cmd.ShortcutKeys) : "";
                item.SubItems.Add(shortcutStr);

                // Highlight if this is the currently assigned command in the active workspace
                if (!string.IsNullOrEmpty(_currentAssignedCommandId) &&
                    cmd.CommandId == _currentAssignedCommandId &&
                    string.Equals(cmd.Workspace, _workspace, StringComparison.OrdinalIgnoreCase))
                {
                    item.BackColor = Color.FromArgb(230, 240, 255);
                    item.Font = new Font(listViewCommands.Font, FontStyle.Bold);
                }

                listViewCommands.Items.Add(item);
            }

            listViewCommands.EndUpdate();
            lblStatus.Text = $"Showing {commands.Count} of {_allCommands.Count} commands";
            UpdateActionButtons();
        }

        private void listViewCommands_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _sortColumn)
            {
                _sortOrder = _sortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                _sortColumn = e.Column;
                _sortOrder = SortOrder.Ascending;
            }

            listViewCommands.ListViewItemSorter = new ListViewItemComparer(_sortColumn, _sortOrder);
            listViewCommands.Sort();
        }

        private void listViewCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateActionButtons();
        }

        private void UpdateActionButtons()
        {
            if (listViewCommands.SelectedItems.Count > 0)
            {
                SelectedCommand = listViewCommands.SelectedItems[0].Tag as WorkspaceCommand;
                btnAssign.Enabled = SelectedCommand != null;
            }
            else
            {
                SelectedCommand = null;
                btnAssign.Enabled = false;
            }
        }

        private void listViewCommands_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCommands.SelectedItems.Count > 0)
            {
                btnAssign_Click(sender, e);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (SelectedCommand == null) return;

            var targetWorkspace = !string.IsNullOrEmpty(SelectedCommand.Workspace)
                ? SelectedCommand.Workspace
                : _workspace;

            // Conflict check 1: Target key already bound to a different command in the same workspace
            if (!string.IsNullOrEmpty(_currentAssignedCommandId) &&
                string.Equals(targetWorkspace, _workspace, StringComparison.OrdinalIgnoreCase) &&
                _currentAssignedCommandId != SelectedCommand.CommandId)
            {
                var existingName = !string.IsNullOrEmpty(_currentAssignedHint)
                    ? _currentAssignedHint
                    : _currentAssignedCommandId;

                var result = MessageBox.Show(
                    $"Shortcut '{_keyDisplayString}' in '{targetWorkspace}' is currently assigned to '{existingName}'.\n\nDo you want to reassign this shortcut to '{SelectedCommand.DisplayName}'?",
                    "Shortcut Conflict",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            // Conflict check 2: Selected command already bound to another key in its workspace
            if (SelectedCommand.ShortcutKeys != Keys.None && SelectedCommand.ShortcutKeys != _targetKeys)
            {
                var existingKey = new KeysConverter().ConvertToString(SelectedCommand.ShortcutKeys);
                var result = MessageBox.Show(
                    $"Command '{SelectedCommand.DisplayName}' in '{targetWorkspace}' is currently assigned to '{existingKey}'.\n\nDo you want to change its shortcut to '{_keyDisplayString}'?",
                    "Reassign Command Shortcut",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            IsClearRequested = false;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var targetDesc = !string.IsNullOrEmpty(_currentAssignedHint)
                ? _currentAssignedHint
                : _currentAssignedCommandId;

            var result = MessageBox.Show(
                $"Are you sure you want to remove the shortcut '{_keyDisplayString}' from '{targetDesc}' in '{_workspace}'?",
                "Remove Shortcut",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                IsClearRequested = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private class ListViewItemComparer : IComparer
        {
            private readonly int _col;
            private readonly SortOrder _order;

            public ListViewItemComparer(int column, SortOrder order)
            {
                _col = column;
                _order = order;
            }

            public int Compare(object x, object y)
            {
                if (x is not ListViewItem itemX || y is not ListViewItem itemY) return 0;

                var textX = itemX.SubItems.Count > _col ? itemX.SubItems[_col].Text : "";
                var textY = itemY.SubItems.Count > _col ? itemY.SubItems[_col].Text : "";

                var result = string.Compare(textX, textY, StringComparison.OrdinalIgnoreCase);
                return _order == SortOrder.Descending ? -result : result;
            }
        }
    }
}
