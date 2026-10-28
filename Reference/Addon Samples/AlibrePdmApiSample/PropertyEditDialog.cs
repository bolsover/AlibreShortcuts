using AlibreX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlibrePdmApiSample
{
    // Dynamic dialog that is shown when user wants to modify the value of any property
    public partial class PropertyEditDialog : Form
    {
        private readonly PropertyItem _propertyItem;
        private string _originalSerializedValue;
        private Control _editorControl;

        public string NewValueString { get; private set; }

        // For SINGLE_SELECT and MULTI_SELECT types, we hold onto the mapping (between dataItem and its name shown in UI):
        private List<ClassDataItemOption> _classDataOptions;

        // For SINGLE_SELECT:
        public IADPDMClassDataItem SelectedClassDataItem { get; private set; }

        // For MULTI_SELECT:
        public IADPDMClassDataItem[] SelectedClassDataItems { get; private set; }

        public PropertyEditDialog (PropertyItem propertyItem)
        {
            InitializeComponent ();
            _propertyItem = propertyItem ?? throw new ArgumentNullException (nameof (propertyItem));
        }

        private void PropertyEditDialog_Load (object sender, EventArgs e)
        {
            lblPropertyName.Text = _propertyItem.DisplayName;
            lblPropertyType.Text = _propertyItem.ValueType.ToString ();

            BuildEditorForType ();
        }

        private void BuildEditorForType ()
        {
            var valueObj = _propertyItem.Property;
            var type = _propertyItem.ValueType;

            // current value as string
            string currentString = valueObj?.Value ?? string.Empty;

            _editorControl = null;
            panelEditor.Controls.Clear ();

            switch (type)
            {
                case ADPDMPropertyValueType.AD_PDM_INTEGER:
                    {
                        var txt = new TextBox
                        {
                            Dock = DockStyle.Fill,
                            Text = valueObj != null && valueObj.HasValue ? valueObj.IntValue.ToString () : ""
                        };
                        txt.TextChanged += OnEditorValueChanged;
                        _editorControl = txt;
                        break;
                    }

                case ADPDMPropertyValueType.AD_PDM_REAL:
                    {
                        var txt = new TextBox
                        {
                            Dock = DockStyle.Fill,
                            Text = valueObj != null && valueObj.HasValue ? valueObj.DoubleValue.ToString () : ""
                        };
                        txt.TextChanged += OnEditorValueChanged;
                        _editorControl = txt;
                        break;
                    }

                case ADPDMPropertyValueType.AD_PDM_TEXT:
                    {
                        var txt = new TextBox
                        {
                            Dock = DockStyle.Fill,
                            Text = valueObj != null && valueObj.HasValue ? valueObj.TextValue : currentString
                        };
                        txt.TextChanged += OnEditorValueChanged;
                        _editorControl = txt;
                        break;
                    }

                case ADPDMPropertyValueType.AD_PDM_MULTILINE_TEXT:
                    {
                        var txt = new TextBox
                        {
                            Dock = DockStyle.Fill,
                            Multiline = true,
                            ScrollBars = ScrollBars.Vertical,
                            Height = panelEditor.Height,
                            Text = valueObj != null && valueObj.HasValue ? valueObj.MultilineTextValue : currentString
                        };
                        txt.TextChanged += OnEditorValueChanged;
                        _editorControl = txt;
                        break;
                    }

                case ADPDMPropertyValueType.AD_PDM_DATETIME:
                    {
                        var dt = new DateTimePicker
                        {
                            Dock = DockStyle.Left,
                            Width = 200,
                            Format = DateTimePickerFormat.Custom,
                            CustomFormat = "yyyy-MM-dd HH:mm:ss"
                        };

                        if (valueObj != null && valueObj.HasValue)
                        {
                            try
                            {
                                dt.Value = valueObj.DateTimeValue;
                            }
                            catch
                            {
                                // fallback if value is invalid
                                dt.Value = DateTime.Now;
                            }
                        }
                        dt.ValueChanged += OnEditorValueChanged;
                        _editorControl = dt;
                        break;
                    }

                case ADPDMPropertyValueType.AD_PDM_SINGLE_SELECT:
                    {
                        var combo = new ComboBox
                        {
                            Dock = DockStyle.Fill,
                            DropDownStyle = ComboBoxStyle.DropDownList
                        };

                        _classDataOptions = GetClassDataOptionsForCurrentProperty ();

                        // Fill items manually – no DataSource, no BindingSource
                        combo.Items.Clear ();
                        foreach (var opt in _classDataOptions)
                        {
                            combo.Items.Add (opt);   // ClassDataItemOption
                        }

                        // Current value from the property
                        string current = valueObj != null && valueObj.HasValue ?
                                            valueObj.SelectValue ?? (valueObj?.Value ?? string.Empty) :
                                            string.Empty;

                        if (!string.IsNullOrEmpty (current) && combo.Items.Count > 0)
                        {
                            for (int i = 0; i < combo.Items.Count; i++)
                            {
                                if (combo.Items[i] is ClassDataItemOption opt &&
                                    string.Equals (opt.Name, current, StringComparison.OrdinalIgnoreCase))
                                {
                                    combo.SelectedIndex = i;
                                    break;
                                }
                            }
                        }

                        // If nothing matched, default to first item (optional)
                        if (combo.SelectedIndex < 0 && combo.Items.Count > 0)
                        {
                            combo.SelectedIndex = 0;
                        }

                        combo.SelectedIndexChanged += OnEditorValueChanged;
                        _editorControl = combo;
                        break;
                    }

                case ADPDMPropertyValueType.AD_PDM_MULTI_SELECT:
                    {
                        var chk = new CheckedListBox
                        {
                            Dock = DockStyle.Fill,
                            CheckOnClick = true
                        };

                        _classDataOptions = GetClassDataOptionsForCurrentProperty ();

                        string[] currentValues = valueObj != null && valueObj.HasValue ?
                                                    valueObj.MultiSelectValue ?? Array.Empty<string>() :
                                                    Array.Empty<string>();

                        // Populate and check items based on current values
                        foreach (var opt in _classDataOptions)
                        {
                            bool isChecked = Array.IndexOf (currentValues, opt.Name) >= 0;
                            chk.Items.Add (opt, isChecked);
                        }

                        // ItemCheck fires before the new check state is applied,
                        // so we defer the update using BeginInvoke.
                        chk.ItemCheck += (s, ev) =>
                        {
                            this.BeginInvoke (new Action (() =>
                            {
                                OnEditorValueChanged (s, EventArgs.Empty);
                            }));
                        };

                        _editorControl = chk;
                        break;
                    }

                default:
                    {
                        // Fallback: simple text editing of string representation
                        var txt = new TextBox
                        {
                            Dock = DockStyle.Fill,
                            Text = currentString
                        };
                        _editorControl = txt;
                        break;
                    }
            }

            if (_editorControl != null)
            {
                panelEditor.Controls.Add (_editorControl);

                // Capture original value for dirty checking
                _originalSerializedValue = SerializeEditorValue ();
                UpdateOkButtonEnabled ();
            }
        }

        private void OnEditorValueChanged (object sender, EventArgs e)
        {
            UpdateOkButtonEnabled ();
        }

        private void UpdateOkButtonEnabled ()
        {
            if (_editorControl == null)
            {
                btnOK.Enabled = false;
                return;
            }

            string current = SerializeEditorValue ();
            btnOK.Enabled = !string.Equals (current, _originalSerializedValue, StringComparison.Ordinal);
        }

        private string SerializeEditorValue ()
        {
            if (_editorControl == null)
                return string.Empty;

            var type = _propertyItem.ValueType;

            switch (type)
            {
                case ADPDMPropertyValueType.AD_PDM_INTEGER:
                case ADPDMPropertyValueType.AD_PDM_REAL:
                case ADPDMPropertyValueType.AD_PDM_TEXT:
                case ADPDMPropertyValueType.AD_PDM_MULTILINE_TEXT:
                    {
                        var txt = _editorControl as TextBox;
                        return txt?.Text ?? string.Empty;
                    }

                case ADPDMPropertyValueType.AD_PDM_DATETIME:
                    {
                        var dt = _editorControl as DateTimePicker;
                        return dt?.Value.ToString ("o") ?? string.Empty; // stable string
                    }

                case ADPDMPropertyValueType.AD_PDM_SINGLE_SELECT:
                    {
                        var combo = _editorControl as ComboBox;
                        
                        if (combo?.SelectedItem is ClassDataItemOption opt)
                            return opt.Name;
                        return combo?.Text ?? string.Empty;
                    }

                case ADPDMPropertyValueType.AD_PDM_MULTI_SELECT:
                    {
                        var chk = _editorControl as CheckedListBox;
                        if (chk == null)
                            return string.Empty;

                        var names = new List<string> ();
                        foreach (var obj in chk.CheckedItems)
                        {
                            if (obj is ClassDataItemOption opt)
                                names.Add (opt.Name);
                        }

                        return string.Join ("|", names);
                    }

                default:
                    {
                        var txt = _editorControl as TextBox;
                        return txt?.Text ?? string.Empty;
                    }
            }
        }


        private List<ClassDataItemOption> GetClassDataOptionsForCurrentProperty ()
        {
            // This method is relevant only for properties of type SINGLE_SELECT and MULTI_SELECT
            var prop = _propertyItem.Property;
            if (prop == null)
                return new List<ClassDataItemOption> ();

            var def = prop.PropertyDefinition;     // IADPDMPropertyDefinition
            var cls = def?.ClassItem;              // IADPDMClass
            var items = cls?.DataItems;            // IADPDMClassDataItems

            var result = new List<ClassDataItemOption> ();
            if (items == null)
                return result;

            foreach (IADPDMClassDataItem di in items)
            {
                if (di != null && !string.IsNullOrEmpty (di.Name))
                    result.Add (new ClassDataItemOption (di));
            }

            return result;
        }


        private void btnOK_Click (object sender, EventArgs e)
        {
            if (_editorControl == null)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            var type = _propertyItem.ValueType;

            try
            {
                switch (type)
                {
                    case ADPDMPropertyValueType.AD_PDM_INTEGER:
                        {
                            var txt = (TextBox)_editorControl;
                            if (!int.TryParse (txt.Text, out _))
                            {
                                MessageBox.Show (this, "Please enter a valid integer.", "Invalid value",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            NewValueString = txt.Text;
                            break;
                        }

                    case ADPDMPropertyValueType.AD_PDM_REAL:
                        {
                            var txt = (TextBox)_editorControl;
                            if (!double.TryParse (txt.Text, out _))
                            {
                                MessageBox.Show (this, "Please enter a valid number.", "Invalid value",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            NewValueString = txt.Text;
                            break;
                        }

                    case ADPDMPropertyValueType.AD_PDM_TEXT:
                    case ADPDMPropertyValueType.AD_PDM_MULTILINE_TEXT:
                        {
                            var txt = (TextBox)_editorControl;
                            NewValueString = txt.Text;
                            break;
                        }

                    case ADPDMPropertyValueType.AD_PDM_DATETIME:
                        {
                            var dt = (DateTimePicker)_editorControl;
                            // store as ISO-like string; you can choose your actual format
                            NewValueString = dt.Value.ToString ("o");
                            break;
                        }

                    case ADPDMPropertyValueType.AD_PDM_SINGLE_SELECT:
                        {
                            var combo = (ComboBox)_editorControl;
                            var opt = combo.SelectedItem as ClassDataItemOption;

                            SelectedClassDataItem = opt?.DataItem;
                            NewValueString = opt?.Name ?? string.Empty;
                            break;
                        }

                    case ADPDMPropertyValueType.AD_PDM_MULTI_SELECT:
                        {
                            var chk = (CheckedListBox)_editorControl;

                            var selectedDataItems = new List<IADPDMClassDataItem> ();
                            var selectedNames = new List<string> ();

                            foreach (var obj in chk.CheckedItems)
                            {
                                if (obj is ClassDataItemOption opt)
                                {
                                    selectedDataItems.Add (opt.DataItem);
                                    selectedNames.Add (opt.Name);
                                }
                            }

                            SelectedClassDataItems = selectedDataItems.ToArray ();
                            NewValueString = string.Join (", ", selectedNames);
                            break;
                        }

                    default:
                        {
                            var txt = (TextBox)_editorControl;
                            NewValueString = txt.Text;
                            break;
                        }
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show (this, "Error reading value: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
