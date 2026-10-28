using AlibreX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlibrePdmApiSample
{
    public partial class MainForm : Form
    {
        private IADRoot _apiRoot;
        private IADPDMServerConnection _serverConnection;
        private IADPDMSafe _currentSafe;

        // Current active container (Safe / Library / Project / Folder)
        private ContainerItem _currentContainer;

        // Navigation history stacks
        private readonly Stack<ContainerItem> _backStack = new Stack<ContainerItem> ();
        private readonly Stack<ContainerItem> _forwardStack = new Stack<ContainerItem> ();

        private bool _checkInInProgress = false;
        private string _pendingCheckInFileName = null;


        public MainForm ()
        {
            InitializeComponent ();
        }

        private void MainForm_Load (object sender, EventArgs e)
        {
            txtActiveContainer.Text = "";
            lblStatusMsg.Text = "";
            try
            {
                // Initialize Alibre Design API to run in GUI-less mode.
                // This will cause Alibre to execute in the process space of 'this' application.
                Type alibreType = Type.GetTypeFromProgID ("AlibreX.AutomationHook");
                IAutomationHook hook = (IAutomationHook)Activator.CreateInstance (alibreType);
                hook.Initialize (null, null, null, false, 0);
                _apiRoot = (IADRoot)hook.Root;

                _serverConnection = null;

                // Initial active container is the logical root of the PDM hierarchy.
                txtActiveContainer.Text = "Root";
            }
            catch (Exception ex)
            {
                lblStatusMsg.Text = "Failed to initialize API.\n";
                lblStatusMsg.Text = lblStatusMsg + ex.Message + "\n";
                if (ex.InnerException != null)
                {
                    lblStatusMsg.Text = lblStatusMsg + ex.InnerException.Message;
                }
            }
        }

        private void btnConnect_Click (object sender, EventArgs e)
        {
            lblStatusMsg.Text = "";

            // logout any previous connection.
            if (_serverConnection != null)
                LogoutPDM ();

            Cursor previousCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string url = txtServerUrl.Text;
                string domain = txtDomainName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (url.Contains (":") && domain != "" && username != "" && password != null)
                {
                    if (!url.EndsWith ("/"))
                        url = url + "/";

                    _serverConnection = _apiRoot.ConnectToPDM (url, domain, username, password);
                }

                if (_serverConnection != null && _serverConnection.IsOnline)
                {
                    LoadSafes ();
                    if (cmbSafe.Items.Count > 0)
                        lblStatusMsg.Text = "Select the Safe you want to access";
                }
                else
                {
                    if (_serverConnection != null && !_serverConnection.IsOnline)
                        lblStatusMsg.Text = "This server is offline";
                    else
                    {
                        lblStatusMsg.Text = "Did you enter server url, domain and username/password?\n";
                        lblStatusMsg.Text = lblStatusMsg.Text + "Example of url: http://localhost:8099/";
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                lblStatusMsg.Text = ex.Message + "\n";
                if (ex.InnerException != null)
                    lblStatusMsg.Text = lblStatusMsg.Text + ex.InnerException.Message;
            }
            finally
            {
                this.Cursor = previousCursor; // always restore
            }
        }

        private void cmbSafe_SelectedIndexChanged (object sender, EventArgs e)
        {
            lblStatusMsg.Text = "";

            if (cmbSafe.SelectedIndex < 0)
            {
                txtActiveContainer.Text = "";
                lstContainerItems.Items.Clear ();
                _currentContainer = null;
                _backStack.Clear ();
                _forwardStack.Clear ();
                UpdateNavButtons ();
                return;
            }

            var item = cmbSafe.SelectedItem as ContainerItem;
            if (item == null)
                return;

            // Selecting a safe resets navigation
            _backStack.Clear ();
            _forwardStack.Clear ();

            ShowContainerChildren (item);
        }

        private void lstContainerItems_SelectedIndexChanged (object sender, EventArgs e)
        {
            lblStatusMsg.Text = "";

            // Load the properties of the selected item

            if (lstContainerItems.SelectedIndex < 0)
            {
                lstProperties.Items.Clear ();
                txtPropertyValue.Clear ();
                UpdateNavButtons ();
                return;
            }

            var item = lstContainerItems.SelectedItem as ContainerItem;
            if (item == null)
                return;

            // Load properties for whatever was selected folder or file item
            LoadPropertiesForContainerItem (item);

            RefreshUiState ();
            UpdateNavButtons ();
        }

        private void lstContainerItems_DoubleClick (object sender, EventArgs e)
        {
            if (lstContainerItems.SelectedIndex < 0)
                return;

            // No navigation possible if there is no selection or if selection is a file
            var selected = lstContainerItems.SelectedItem as ContainerItem;
            if (selected == null || !selected.IsContainer)
                return;

            //  - current container becomes a "back" target
            //  - forward history is discarded
            if (_currentContainer != null)
                _backStack.Push (_currentContainer);

            _forwardStack.Clear ();

            ShowContainerChildren (selected);
        }

        private void btnBack_Click (object sender, EventArgs e)
        {
            // - Navigate to the parent container of the current active container.
            // - Update txtActiveContainer and lstContainerItems.
            // - Update enabled/disabled state of btnBack and btnForward.

            if (_backStack.Count == 0)
                return;

            var previous = _backStack.Pop ();

            if (_currentContainer != null)
                _forwardStack.Push (_currentContainer);

            ShowContainerChildren (previous);
        }

        private void btnForward_Click (object sender, EventArgs e)
        {
            // - Navigate into the selected child container (Safe/Project/Folder).
            // - Update txtActiveContainer and lstContainerItems.
            // - Update enabled/disabled state of btnBack and btnForward.

            // History takes precedence
            if (_forwardStack.Count > 0)
            {
                var next = _forwardStack.Pop ();
                if (_currentContainer != null)
                    _backStack.Push (_currentContainer);

                ShowContainerChildren (next);
                return;
            }

            if (lstContainerItems.SelectedIndex < 0)
                return;

            var selected = lstContainerItems.SelectedItem as ContainerItem;
            if (selected == null || !selected.IsContainer)
            {
                // Files are not containers; don’t navigate into them.
                return;
            }

            if (_currentContainer != null)
                _backStack.Push (_currentContainer);

            _forwardStack.Clear ();
            ShowContainerChildren (selected);
        }

        private void lstProperties_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (lstProperties.SelectedIndex < 0)
            {
                txtPropertyValue.Clear ();
                btnModifyProperty.Enabled = false;
                return;
            }

            var propertyItem = lstProperties.SelectedItem as PropertyItem;
            if (propertyItem == null)
            {
                txtPropertyValue.Clear ();
                btnModifyProperty.Enabled = false;
                return;
            }

            txtPropertyValue.Text = propertyItem.GetValueAsString ();
            btnModifyProperty.Enabled = true;

            RefreshUiState ();
        }

        private void btnModifyProperty_Click (object sender, EventArgs e)
        {
            if (lstProperties.SelectedIndex < 0)
                return;

            var containerItem = lstContainerItems.SelectedItem as ContainerItem;
            var propertyItem = lstProperties.SelectedItem as PropertyItem;

            if (containerItem == null || propertyItem == null)
                return;

            using (var dlg = new PropertyEditDialog (propertyItem))
            {
                if (dlg.ShowDialog (this) != DialogResult.OK)
                    return;

                // User confirmed changes
                var valueType = propertyItem.ValueType;

                Cursor previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;

                try
                {
                    // Create a new property value based on type
                    object newPropValue = CreateNewPropertyValueFromDialog (valueType, dlg);

                    if (newPropValue == null)
                    {
                        MessageBox.Show (this, "Failed to create new property value.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create a new IADPDMProperty instance using its definition
                    var definition = propertyItem.Property.PropertyDefinition;   // IADPDMPropertyDefinition

                    IADPDMProperty newPropertyInstance =
                        _currentSafe.CreatePropertyInstance (definition, newPropValue);

                    if (newPropertyInstance == null)
                    {
                        MessageBox.Show (this, "Failed to create property instance.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Apply this property to the current container item
                    ApplyPropertyToContainer (containerItem, newPropertyInstance);

                    // Refresh UI: reload properties for the selected item
                    LoadPropertiesForContainerItem (containerItem);
                    ReselectPropertyByName (propertyItem.DisplayName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show (this, "Error updating property:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = previousCursor;
                }
            }
        }

        private void btnCheckIn_Click (object sender, EventArgs e)
        {
            if (_checkInInProgress)
                return;

            var selected = lstContainerItems.SelectedItem as ContainerItem;
            if (selected == null || selected.Kind != ContainerItemKind.File)
                return;

            var fileItem = selected.Get<IADPDMFileItem> ();
            if (fileItem == null)
                return;

            // Extra validation: only allow check-in if locally modified by current user
            if (!fileItem.LocallyModified)
                return;

            // UI state: disable immediately
            _checkInInProgress = true;
            _pendingCheckInFileName = selected.Name;

            Cursor previous = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            btnCheckIn.Enabled = false;
            btnCheckIn.Text = "Checking in...";

            try
            {
                string versionComment = "Checked in from AlibrePdmApiSample";

                // Callback may happen on a non-UI thread: marshal back to UI thread in handler.
                var callback = new PdmTaskCallback (() =>
                {
                    // Always marshal to UI thread:
                    if (this.IsHandleCreated)
                    {
                        this.BeginInvoke (new Action (() =>
                        {
                            OnCheckInCompleted (previous);
                        }));
                    }
                });

                fileItem.CheckIn (versionComment, callback);
            }
            catch (Exception ex)
            {
                MessageBox.Show (this, "Error checking in file:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If the async call throws immediately, restore UI state
                this.Cursor = previous;
                _checkInInProgress = false;
                btnCheckIn.Text = "Check in";
                RefreshUiState ();
            }
        }


        private void btnClose_Click (object sender, EventArgs e)
        {
            LogoutPDM ();
            _apiRoot.TerminateAll ();
            _apiRoot = null;

            // Shutdown the Windows Form
            Close ();
        }

        private void LoadSafes ()
        {
            cmbSafe.Items.Clear ();

            if (_serverConnection == null)
                return;
            Cursor previousCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                IADPDMSafes safes = _serverConnection.Safes;
                foreach (IADPDMSafe safe in safes)
                {
                    // Use ContainerItem for safes too
                    var item = new ContainerItem (safe);
                    cmbSafe.Items.Add (item);
                }
            }
            catch (Exception ex)
            {
                lblStatusMsg.Text = ex.Message + "\n";
                if (ex.InnerException != null)
                    lblStatusMsg.Text = lblStatusMsg.Text + ex.InnerException.Message;
            }
            finally
            {
                this.Cursor = previousCursor; // always restore
            }
        }

        private void ShowContainerChildren (ContainerItem container)
        {
            Cursor previousCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                lstContainerItems.Items.Clear ();
                _currentContainer = container;

                txtActiveContainer.Text = container.ToString ();

                switch (container.Kind)
                {
                    case ContainerItemKind.Safe:
                        {
                            var safe = container.Get<IADPDMSafe> ();
                            _currentSafe = safe;

                            // Libraries
                            foreach (IADPDMSafeLibrary lib in safe.Libraries)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (lib));
                            }

                            // Projects
                            foreach (IADPDMSafeProject proj in safe.Projects)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (proj));
                            }

                            break;
                        }

                    case ContainerItemKind.Library:
                        {
                            var library = container.Get<IADPDMSafeLibrary> ();

                            // Folders
                            foreach (IADPDMFolder folder in library.Folders)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (folder));
                            }

                            // Files
                            foreach (IADPDMFileItem file in library.FileItems)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (file));
                            }

                            break;
                        }

                    case ContainerItemKind.Project:
                        {
                            var project = container.Get<IADPDMSafeProject> ();

                            foreach (IADPDMFolder folder in project.Folders)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (folder));
                            }

                            foreach (IADPDMFileItem file in project.FileItems)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (file));
                            }

                            break;
                        }

                    case ContainerItemKind.Folder:
                        {
                            var folder = container.Get<IADPDMFolder> ();

                            foreach (IADPDMFolder subFolder in folder.Folders)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (subFolder));
                            }

                            foreach (IADPDMFileItem file in folder.FileItems)
                            {
                                lstContainerItems.Items.Add (new ContainerItem (file));
                            }

                            break;
                        }

                    // case ContainerItemKind.File is not required as this should never happen
                }

                UpdateNavButtons ();
                RefreshUiState ();

                lblStatusMsg.Text = "Click any item to view its properties. Double-click to traverse folder structure";
            }
            catch (Exception ex)
            {
                lblStatusMsg.Text = ex.Message + "\n";
                if (ex.InnerException != null)
                    lblStatusMsg.Text = lblStatusMsg.Text + ex.InnerException.Message;
            }
            finally
            {
                this.Cursor = previousCursor; // always restore
            }
        }

        private void UpdateNavButtons ()
        {
            // Back is enabled only if:
            //   - back stack has items AND
            //   - current container is NOT a Safe (Safe = root)
            //
            bool atRoot = (_currentContainer != null && _currentContainer.Kind == ContainerItemKind.Safe);
            btnBack.Enabled = (!atRoot && _backStack.Count > 0);


            // Forward is enabled if:
            //   A) forward history exists, OR
            //   B) user has selected a container to enter (Library/Project/Folder)
            //
            if (_forwardStack.Count > 0)
            {
                btnForward.Enabled = true;
                return;
            }

            // Forward as "enter container"
            var selected = lstContainerItems.SelectedItem as ContainerItem;

            if (selected != null && selected.IsContainer)
            {
                btnForward.Enabled = true;
            }
            else
            {
                // Selected item is null or a File (leaf)
                btnForward.Enabled = false;
            }
        }

        private void LoadPropertiesForContainerItem (ContainerItem item)
        {
            Cursor previousCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                lstProperties.Items.Clear ();
                txtPropertyValue.Clear ();

                if (item == null)
                    return;

                IADPDMProperties props = null;

                switch (item.Kind)
                {
                    case ContainerItemKind.Library:
                        {
                            var library = item.Get<IADPDMSafeLibrary> ();
                            props = library?.Properties;
                            break;
                        }
                    case ContainerItemKind.Project:
                        {
                            var project = item.Get<IADPDMSafeProject> ();
                            props = project?.Properties;
                            break;
                        }
                    case ContainerItemKind.Folder:
                        {
                            var folder = item.Get<IADPDMFolder> ();
                            props = folder?.Properties;
                            break;
                        }
                    case ContainerItemKind.File:
                        {
                            var file = item.Get<IADPDMFileItem> ();
                            props = file?.Properties;
                            break;
                        }
                    // If Safe also has Properties, we could handle it in future
                    // case ContainerItemKind.Safe:
                    // {
                    //     var safe = item.Get<IADPDMSafe>();
                    //     props = safe?.Properties;
                    //     break;
                    // }
                    default:
                        break;
                }

                if (props == null)
                    return;

                foreach (IADPDMProperty prop in props)
                {
                    lstProperties.Items.Add (new PropertyItem (prop));
                }

                RefreshUiState ();
            }
            catch (Exception ex)
            {
                lblStatusMsg.Text = ex.Message + "\n";
                if (ex.InnerException != null)
                    lblStatusMsg.Text = lblStatusMsg.Text + ex.InnerException.Message;
            }
            finally
            {
                this.Cursor = previousCursor;
            }
        }

        private object CreateNewPropertyValueFromDialog (ADPDMPropertyValueType valueType,
                                                         PropertyEditDialog dlg)
        {
            // We use dlg.NewValueString, dlg.SelectedClassDataItem, dlg.SelectedClassDataItems here
            switch (valueType)
            {
                case ADPDMPropertyValueType.AD_PDM_INTEGER:
                    {
                        if (!int.TryParse (dlg.NewValueString, out int intVal))
                            throw new InvalidOperationException ("Invalid integer value.");
                        return intVal;
                    }

                case ADPDMPropertyValueType.AD_PDM_REAL:
                    {
                        if (!double.TryParse (dlg.NewValueString, out double dblVal))
                            throw new InvalidOperationException ("Invalid real value.");
                        return dblVal;
                    }

                case ADPDMPropertyValueType.AD_PDM_TEXT:
                    {
                        string text = dlg.NewValueString ?? string.Empty;
                        return text;
                    }

                case ADPDMPropertyValueType.AD_PDM_MULTILINE_TEXT:
                    {
                        string text = dlg.NewValueString ?? string.Empty;
                        return text;
                    }

                case ADPDMPropertyValueType.AD_PDM_DATETIME:
                    {
                        // We stored ISO-ish string in dialog; parse it here
                        if (!DateTime.TryParse (dlg.NewValueString, out DateTime dt))
                            throw new InvalidOperationException ("Invalid date/time value.");
                        return dt;
                    }

                case ADPDMPropertyValueType.AD_PDM_SINGLE_SELECT:
                    {
                        var dataItem = dlg.SelectedClassDataItem;
                        if (dataItem == null)
                            throw new InvalidOperationException ("No single-select option chosen.");
                        return dataItem;
                    }

                case ADPDMPropertyValueType.AD_PDM_MULTI_SELECT:
                    {
                        var dataItems = dlg.SelectedClassDataItems;
                        if (dataItems == null || dataItems.Length == 0)
                            throw new InvalidOperationException ("No multi-select options chosen.");
                        return dataItems;
                    }

                default:
                    {
                        // Should not reach here..
                        throw new InvalidOperationException ("Unexpected value type.");
                    }
            }
        }

        private void ApplyPropertyToContainer (ContainerItem containerItem, IADPDMProperty newProperty)
        {
            switch (containerItem.Kind)
            {
                case ContainerItemKind.Folder:
                    {
                        var folder = containerItem.Get<IADPDMFolder> ();
                        folder.SetProperty (newProperty);
                        break;
                    }

                case ContainerItemKind.File:
                    {
                        var file = containerItem.Get<IADPDMFileItem> (); // or IADPDMFileItem if that's the specific type
                        file.SetProperty (newProperty);
                        break;
                    }

                default:
                    throw new InvalidOperationException ("SetProperty can be called on Folder and File items only.");
            }
        }

        private void ReselectPropertyByName (string displayName)
        {
            if (string.IsNullOrEmpty (displayName))
                return;

            for (int i = 0; i < lstProperties.Items.Count; i++)
            {
                if (lstProperties.Items[i] is PropertyItem pi &&
                    string.Equals (pi.DisplayName, displayName, StringComparison.OrdinalIgnoreCase))
                {
                    lstProperties.SelectedIndex = i;
                    break;
                }
            }
        }

        private void RefreshUiState ()
        {
            // Modify button: enabled only if a property is selected
            btnModifyProperty.Enabled = (lstProperties.SelectedItem is PropertyItem);

            if (_checkInInProgress)
            {
                btnCheckIn.Enabled = false;
                return;
            }

            // Check-in button: enabled only if selected container item is a file modified by current user
            btnCheckIn.Enabled = IsSelectedFileModifiedByCurrentUser ();
        }

        private bool IsSelectedFileModifiedByCurrentUser ()
        {
            var selected = lstContainerItems.SelectedItem as ContainerItem;
            if (selected == null || selected.Kind != ContainerItemKind.File)
                return false;

            var file = selected.Get<IADPDMFileItem> ();
            if (file == null)
                return false;

            try
            {
                return file.LocallyModified;
            }
            catch
            {
                // If API fails, keep button disabled.
                return false;
            }
        }

        private void OnCheckInCompleted (Cursor previousCursor)
        {
            // Restore cursor & UI state
            this.Cursor = previousCursor;
            _checkInInProgress = false;
            btnCheckIn.Text = "Check in";

            // Refresh current container view
            if (_currentContainer != null)
                ShowContainerChildren (_currentContainer);

            // Re-select the file we checked in (by name)
            if (!string.IsNullOrEmpty (_pendingCheckInFileName))
            {
                ReselectContainerItemByName (_pendingCheckInFileName);
                _pendingCheckInFileName = null;
            }

            // Reload properties for current selection (optional but nice)
            var selected = lstContainerItems.SelectedItem as ContainerItem;
            if (selected != null)
                LoadPropertiesForContainerItem (selected);

            // Recompute buttons (Check in should disable now because the file was checked in)
            RefreshUiState ();
        }

        private void ReselectContainerItemByName (string name)
        {
            for (int i = 0; i < lstContainerItems.Items.Count; i++)
            {
                if (lstContainerItems.Items[i] is ContainerItem ci &&
                    string.Equals (ci.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    lstContainerItems.SelectedIndex = i;
                    return;
                }
            }
        }


        private void LogoutPDM ()
        {
            lstContainerItems.Items.Clear ();
            txtActiveContainer.Clear ();
            cmbSafe.Items.Clear ();

            if (_serverConnection != null)
            {
                Cursor previousCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    _serverConnection.Logout ();
                    _serverConnection = null;
                    lblStatusMsg.Text = "Logout successfull";
                }
                catch (Exception ex)
                {
                    lblStatusMsg.Text = ex.Message + "\n";
                    if (ex.InnerException != null)
                        lblStatusMsg.Text = lblStatusMsg.Text + ex.InnerException.Message;
                }
                finally
                {
                    this.Cursor = previousCursor;
                }
            }
        }
    }
}

