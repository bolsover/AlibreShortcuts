using System.Drawing;
using System.Windows.Forms;

namespace Shortcuts.View
{
    partial class CommandPickerDialog
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Label lblWorkspace;
        private Label lblKeyCombination;
        private Label lblCurrentBinding;
        private Panel panelFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblWorkspaceFilter;
        private ComboBox cmbWorkspace;
        private Label lblCategoryFilter;
        private ComboBox cmbCategory;
        private Label lblShortcutFilter;
        private ComboBox cmbShortcutFilter;
        private ListView listViewCommands;
        private ColumnHeader colName;
        private ColumnHeader colWorkspace;
        private ColumnHeader colCategory;
        private ColumnHeader colCommandId;
        private ColumnHeader colShortcut;
        private Panel panelBottom;
        private Label lblStatus;
        private Button btnAssign;
        private Button btnClear;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.lblHeaderTitle = new Label();
            this.lblWorkspace = new Label();
            this.lblKeyCombination = new Label();
            this.lblCurrentBinding = new Label();

            this.panelFilter = new Panel();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.lblWorkspaceFilter = new Label();
            this.cmbWorkspace = new ComboBox();
            this.lblCategoryFilter = new Label();
            this.cmbCategory = new ComboBox();
            this.lblShortcutFilter = new Label();
            this.cmbShortcutFilter = new ComboBox();

            this.listViewCommands = new ListView();
            this.colName = new ColumnHeader();
            this.colWorkspace = new ColumnHeader();
            this.colCategory = new ColumnHeader();
            this.colCommandId = new ColumnHeader();
            this.colShortcut = new ColumnHeader();

            this.panelBottom = new Panel();
            this.lblStatus = new Label();
            this.btnAssign = new Button();
            this.btnClear = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            //
            // panelHeader
            //
            this.panelHeader.BackColor = Color.FromArgb(245, 247, 250);
            this.panelHeader.BorderStyle = BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Controls.Add(this.lblWorkspace);
            this.panelHeader.Controls.Add(this.lblKeyCombination);
            this.panelHeader.Controls.Add(this.lblCurrentBinding);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new Padding(12, 8, 12, 8);
            this.panelHeader.Size = new Size(840, 95);
            this.panelHeader.TabIndex = 0;

            //
            // lblHeaderTitle
            //
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblHeaderTitle.ForeColor = Color.FromArgb(30, 40, 60);
            this.lblHeaderTitle.Location = new Point(12, 8);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new Size(200, 20);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Assign Keyboard Shortcut";

            //
            // lblWorkspace
            //
            this.lblWorkspace.AutoSize = true;
            this.lblWorkspace.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblWorkspace.ForeColor = Color.FromArgb(60, 70, 80);
            this.lblWorkspace.Location = new Point(13, 30);
            this.lblWorkspace.Name = "lblWorkspace";
            this.lblWorkspace.Size = new Size(160, 15);
            this.lblWorkspace.TabIndex = 1;
            this.lblWorkspace.Text = "Active Workspace: Design Part Browser";

            //
            // lblKeyCombination
            //
            this.lblKeyCombination.AutoSize = true;
            this.lblKeyCombination.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblKeyCombination.ForeColor = Color.FromArgb(0, 102, 204);
            this.lblKeyCombination.Location = new Point(13, 48);
            this.lblKeyCombination.Name = "lblKeyCombination";
            this.lblKeyCombination.Size = new Size(110, 19);
            this.lblKeyCombination.TabIndex = 2;
            this.lblKeyCombination.Text = "Key: Ctrl + K";

            //
            // lblCurrentBinding
            //
            this.lblCurrentBinding.AutoSize = true;
            this.lblCurrentBinding.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCurrentBinding.Location = new Point(13, 70);
            this.lblCurrentBinding.Name = "lblCurrentBinding";
            this.lblCurrentBinding.Size = new Size(160, 15);
            this.lblCurrentBinding.TabIndex = 3;
            this.lblCurrentBinding.Text = "Current Binding: Unassigned";

            //
            // panelFilter
            //
            this.panelFilter.BackColor = Color.FromArgb(250, 251, 253);
            this.panelFilter.BorderStyle = BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblWorkspaceFilter);
            this.panelFilter.Controls.Add(this.cmbWorkspace);
            this.panelFilter.Controls.Add(this.lblCategoryFilter);
            this.panelFilter.Controls.Add(this.cmbCategory);
            this.panelFilter.Controls.Add(this.lblShortcutFilter);
            this.panelFilter.Controls.Add(this.cmbShortcutFilter);
            this.panelFilter.Dock = DockStyle.Top;
            this.panelFilter.Location = new Point(0, 95);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new Padding(10, 8, 10, 8);
            this.panelFilter.Size = new Size(840, 72);
            this.panelFilter.TabIndex = 1;

            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblSearch.Location = new Point(10, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(45, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";

            //
            // txtSearch
            //
            this.txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSearch.Location = new Point(60, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(320, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.FilterControl_Changed);

            //
            // lblWorkspaceFilter
            //
            this.lblWorkspaceFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblWorkspaceFilter.AutoSize = true;
            this.lblWorkspaceFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblWorkspaceFilter.Location = new Point(395, 11);
            this.lblWorkspaceFilter.Name = "lblWorkspaceFilter";
            this.lblWorkspaceFilter.Size = new Size(68, 15);
            this.lblWorkspaceFilter.TabIndex = 2;
            this.lblWorkspaceFilter.Text = "Workspace:";

            //
            // cmbWorkspace
            //
            this.cmbWorkspace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmbWorkspace.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbWorkspace.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbWorkspace.FormattingEnabled = true;
            this.cmbWorkspace.Location = new Point(470, 8);
            this.cmbWorkspace.Name = "cmbWorkspace";
            this.cmbWorkspace.Size = new Size(355, 23);
            this.cmbWorkspace.TabIndex = 3;
            this.cmbWorkspace.SelectedIndexChanged += new System.EventHandler(this.cmbWorkspace_SelectedIndexChanged);

            //
            // lblCategoryFilter
            //
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCategoryFilter.Location = new Point(10, 41);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new Size(106, 15);
            this.lblCategoryFilter.TabIndex = 4;
            this.lblCategoryFilter.Text = "Project / Category:";

            //
            // cmbCategory
            //
            this.cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new Point(122, 38);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new Size(258, 23);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.FilterControl_Changed);

            //
            // lblShortcutFilter
            //
            this.lblShortcutFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblShortcutFilter.AutoSize = true;
            this.lblShortcutFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblShortcutFilter.Location = new Point(395, 41);
            this.lblShortcutFilter.Name = "lblShortcutFilter";
            this.lblShortcutFilter.Size = new Size(59, 15);
            this.lblShortcutFilter.TabIndex = 6;
            this.lblShortcutFilter.Text = "Shortcuts:";

            //
            // cmbShortcutFilter
            //
            this.cmbShortcutFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cmbShortcutFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbShortcutFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbShortcutFilter.FormattingEnabled = true;
            this.cmbShortcutFilter.Location = new Point(470, 38);
            this.cmbShortcutFilter.Name = "cmbShortcutFilter";
            this.cmbShortcutFilter.Size = new Size(355, 23);
            this.cmbShortcutFilter.TabIndex = 7;
            this.cmbShortcutFilter.SelectedIndexChanged += new System.EventHandler(this.FilterControl_Changed);

            //
            // listViewCommands
            //
            this.listViewCommands.Columns.AddRange(new ColumnHeader[] {
                this.colName,
                this.colWorkspace,
                this.colCategory,
                this.colCommandId,
                this.colShortcut
            });
            this.listViewCommands.Dock = DockStyle.Fill;
            this.listViewCommands.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.listViewCommands.FullRowSelect = true;
            this.listViewCommands.GridLines = true;
            this.listViewCommands.HideSelection = false;
            this.listViewCommands.Location = new Point(0, 167);
            this.listViewCommands.MultiSelect = false;
            this.listViewCommands.Name = "listViewCommands";
            this.listViewCommands.Size = new Size(840, 345);
            this.listViewCommands.TabIndex = 2;
            this.listViewCommands.UseCompatibleStateImageBehavior = false;
            this.listViewCommands.View = System.Windows.Forms.View.Details;
            this.listViewCommands.SelectedIndexChanged += new System.EventHandler(this.listViewCommands_SelectedIndexChanged);
            this.listViewCommands.DoubleClick += new System.EventHandler(this.listViewCommands_DoubleClick);
            this.listViewCommands.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewCommands_ColumnClick);

            //
            // colName
            //
            this.colName.Text = "Command";
            this.colName.Width = 220;

            //
            // colWorkspace
            //
            this.colWorkspace.Text = "Workspace";
            this.colWorkspace.Width = 160;

            //
            // colCategory
            //
            this.colCategory.Text = "Project / Category";
            this.colCategory.Width = 140;

            //
            // colCommandId
            //
            this.colCommandId.Text = "Command ID";
            this.colCommandId.Width = 180;

            //
            // colShortcut
            //
            this.colShortcut.Text = "Shortcut";
            this.colShortcut.Width = 110;

            //
            // panelBottom
            //
            this.panelBottom.Controls.Add(this.lblStatus);
            this.panelBottom.Controls.Add(this.btnAssign);
            this.panelBottom.Controls.Add(this.btnClear);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(0, 512);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new Padding(12);
            this.panelBottom.Size = new Size(840, 48);
            this.panelBottom.TabIndex = 3;

            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblStatus.ForeColor = Color.FromArgb(80, 90, 100);
            this.lblStatus.Location = new Point(12, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(130, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Showing 0 commands";

            //
            // btnAssign
            //
            this.btnAssign.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnAssign.Enabled = false;
            this.btnAssign.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnAssign.Location = new Point(540, 10);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new Size(95, 28);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            //
            // btnClear
            //
            this.btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnClear.Location = new Point(642, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(95, 28);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            //
            // btnCancel
            //
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCancel.Location = new Point(744, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(84, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            //
            // CommandPickerDialog
            //
            this.AcceptButton = this.btnAssign;
            this.CancelButton = this.btnCancel;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(840, 560);
            this.Controls.Add(this.listViewCommands);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MinimizeBox = false;
            this.MinimumSize = new Size(720, 480);
            this.Name = "CommandPickerDialog";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Keyboard Shortcut Assignment";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
