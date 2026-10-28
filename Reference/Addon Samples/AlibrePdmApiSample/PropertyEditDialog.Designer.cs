using System;
using System.Windows.Forms;

namespace AlibrePdmApiSample
{
    partial class PropertyEditDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCaptionName;
        private Label lblCaptionType;
        private Label lblCaptionValue;
        private Label lblPropertyName;
        private Label lblPropertyType;
        private Panel panelEditor;
        private Button btnOK;
        private Button btnCancel;

        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose ();
            base.Dispose (disposing);
        }

        private void InitializeComponent ()
        {
            this.lblCaptionName = new Label ();
            this.lblCaptionType = new Label ();
            this.lblCaptionValue = new Label ();
            this.lblPropertyName = new Label ();
            this.lblPropertyType = new Label ();
            this.panelEditor = new Panel ();
            this.btnOK = new Button ();
            this.btnCancel = new Button ();
            this.SuspendLayout ();
            // 
            // lblCaptionName
            // 
            this.lblCaptionName.AutoSize = true;
            this.lblCaptionName.Location = new System.Drawing.Point (12, 9);
            this.lblCaptionName.Text = "Property:";
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.AutoSize = true;
            this.lblPropertyName.Location = new System.Drawing.Point (80, 9);
            this.lblPropertyName.Text = "<name>";
            // 
            // lblCaptionType
            // 
            this.lblCaptionType.AutoSize = true;
            this.lblCaptionType.Location = new System.Drawing.Point (12, 30);
            this.lblCaptionType.Text = "Type:";
            // 
            // lblPropertyType
            // 
            this.lblPropertyType.AutoSize = true;
            this.lblPropertyType.Location = new System.Drawing.Point (80, 30);
            this.lblPropertyType.Text = "<type>";
            // 
            // lblCaptionValue
            // 
            this.lblCaptionValue.AutoSize = true;
            this.lblCaptionValue.Location = new System.Drawing.Point (12, 60);
            this.lblCaptionValue.Text = "Value:";
            // 
            // panelEditor
            // 
            this.panelEditor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.panelEditor.Location = new System.Drawing.Point (15, 80);
            this.panelEditor.Size = new System.Drawing.Size (360, 80);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnOK.Location = new System.Drawing.Point (219, 175);
            this.btnOK.Size = new System.Drawing.Size (75, 25);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new EventHandler (this.btnOK_Click);
            this.btnOK.Enabled = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point (300, 175);
            this.btnCancel.Size = new System.Drawing.Size (75, 25);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new EventHandler (this.btnCancel_Click);
            // 
            // PropertyEditDialog
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size (387, 212);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnOK);
            this.Controls.Add (this.panelEditor);
            this.Controls.Add (this.lblCaptionValue);
            this.Controls.Add (this.lblPropertyType);
            this.Controls.Add (this.lblCaptionType);
            this.Controls.Add (this.lblPropertyName);
            this.Controls.Add (this.lblCaptionName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit Property";
            this.Load += new EventHandler (this.PropertyEditDialog_Load);
            this.ResumeLayout (false);
            this.PerformLayout ();
        }
    }

}