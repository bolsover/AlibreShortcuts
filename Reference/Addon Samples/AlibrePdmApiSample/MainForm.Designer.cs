namespace AlibrePdmApiSample
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblActiveContainer;
        private System.Windows.Forms.TextBox txtActiveContainer;

        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.ListBox lstContainerItems;

        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.ListBox lstProperties;

        private System.Windows.Forms.Label lblPropertyValue;
        private System.Windows.Forms.TextBox txtPropertyValue;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbSafe;
        private System.Windows.Forms.Label lblServerUrl;
        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSafe;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblStatusMsg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnModifyProperty;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent ()
        {
            this.lblActiveContainer = new System.Windows.Forms.Label();
            this.txtActiveContainer = new System.Windows.Forms.TextBox();
            this.lblContents = new System.Windows.Forms.Label();
            this.lstContainerItems = new System.Windows.Forms.ListBox();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lblPropertyValue = new System.Windows.Forms.Label();
            this.txtPropertyValue = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbSafe = new System.Windows.Forms.ComboBox();
            this.lblServerUrl = new System.Windows.Forms.Label();
            this.lblDomainName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSafe = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblStatusMsg = new System.Windows.Forms.Label();
            this.btnModifyProperty = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActiveContainer
            // 
            this.lblActiveContainer.AutoSize = true;
            this.lblActiveContainer.Location = new System.Drawing.Point(12, 189);
            this.lblActiveContainer.Name = "lblActiveContainer";
            this.lblActiveContainer.Size = new System.Drawing.Size(87, 13);
            this.lblActiveContainer.TabIndex = 0;
            this.lblActiveContainer.Text = "Active container:";
            // 
            // txtActiveContainer
            // 
            this.txtActiveContainer.Location = new System.Drawing.Point(15, 205);
            this.txtActiveContainer.Name = "txtActiveContainer";
            this.txtActiveContainer.ReadOnly = true;
            this.txtActiveContainer.Size = new System.Drawing.Size(336, 20);
            this.txtActiveContainer.TabIndex = 0;
            this.txtActiveContainer.TabStop = false;
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Location = new System.Drawing.Point(12, 245);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(52, 13);
            this.lblContents.TabIndex = 12;
            this.lblContents.Text = "Contents:";
            // 
            // lstContainerItems
            // 
            this.lstContainerItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstContainerItems.FormattingEnabled = true;
            this.lstContainerItems.IntegralHeight = false;
            this.lstContainerItems.Location = new System.Drawing.Point(13, 261);
            this.lstContainerItems.Name = "lstContainerItems";
            this.lstContainerItems.Size = new System.Drawing.Size(338, 476);
            this.lstContainerItems.TabIndex = 13;
            this.lstContainerItems.SelectedIndexChanged += new System.EventHandler(this.lstContainerItems_SelectedIndexChanged);
            this.lstContainerItems.DoubleClick += new System.EventHandler(this.lstContainerItems_DoubleClick);
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Location = new System.Drawing.Point(366, 245);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(57, 13);
            this.lblProperties.TabIndex = 16;
            this.lblProperties.Text = "Properties:";
            // 
            // lstProperties
            // 
            this.lstProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.IntegralHeight = false;
            this.lstProperties.Location = new System.Drawing.Point(369, 261);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(203, 361);
            this.lstProperties.TabIndex = 17;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // lblPropertyValue
            // 
            this.lblPropertyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPropertyValue.AutoSize = true;
            this.lblPropertyValue.Location = new System.Drawing.Point(366, 638);
            this.lblPropertyValue.Name = "lblPropertyValue";
            this.lblPropertyValue.Size = new System.Drawing.Size(78, 13);
            this.lblPropertyValue.TabIndex = 18;
            this.lblPropertyValue.Text = "Property value:";
            // 
            // txtPropertyValue
            // 
            this.txtPropertyValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPropertyValue.Location = new System.Drawing.Point(369, 654);
            this.txtPropertyValue.Multiline = true;
            this.txtPropertyValue.Name = "txtPropertyValue";
            this.txtPropertyValue.ReadOnly = true;
            this.txtPropertyValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPropertyValue.Size = new System.Drawing.Size(203, 44);
            this.txtPropertyValue.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(116, 751);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 45);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForward.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(179, 751);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 45);
            this.btnForward.TabIndex = 14;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(508, 793);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 24);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(12, 31);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(189, 20);
            this.txtServerUrl.TabIndex = 2;
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(12, 79);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(189, 20);
            this.txtDomainName.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(260, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(260, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // cmbSafe
            // 
            this.cmbSafe.FormattingEnabled = true;
            this.cmbSafe.Location = new System.Drawing.Point(15, 151);
            this.cmbSafe.Name = "cmbSafe";
            this.cmbSafe.Size = new System.Drawing.Size(336, 21);
            this.cmbSafe.TabIndex = 11;
            this.cmbSafe.SelectedIndexChanged += new System.EventHandler(this.cmbSafe_SelectedIndexChanged);
            // 
            // lblServerUrl
            // 
            this.lblServerUrl.AutoSize = true;
            this.lblServerUrl.Location = new System.Drawing.Point(9, 15);
            this.lblServerUrl.Name = "lblServerUrl";
            this.lblServerUrl.Size = new System.Drawing.Size(54, 13);
            this.lblServerUrl.TabIndex = 1;
            this.lblServerUrl.Text = "Server Url";
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.Location = new System.Drawing.Point(9, 63);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(74, 13);
            this.lblDomainName.TabIndex = 3;
            this.lblDomainName.Text = "Domain Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(257, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(257, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblSafe
            // 
            this.lblSafe.AutoSize = true;
            this.lblSafe.Location = new System.Drawing.Point(12, 135);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(29, 13);
            this.lblSafe.TabIndex = 10;
            this.lblSafe.Text = "Safe";
            // 
            // btnConnect
            // 
            this.btnConnect.AllowDrop = true;
            this.btnConnect.Location = new System.Drawing.Point(472, 43);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 37);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeparator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(-2, 118);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(586, 3);
            this.lblSeparator.TabIndex = 27;
            // 
            // lblStatusMsg
            // 
            this.lblStatusMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusMsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatusMsg.Location = new System.Drawing.Point(369, 151);
            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.Size = new System.Drawing.Size(215, 74);
            this.lblStatusMsg.TabIndex = 28;
            this.lblStatusMsg.Text = "Status message..\r\n";
            // 
            // btnModifyProperty
            // 
            this.btnModifyProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyProperty.Enabled = false;
            this.btnModifyProperty.Location = new System.Drawing.Point(372, 713);
            this.btnModifyProperty.Name = "btnModifyProperty";
            this.btnModifyProperty.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProperty.TabIndex = 29;
            this.btnModifyProperty.Text = "Modify...";
            this.btnModifyProperty.UseVisualStyleBackColor = true;
            this.btnModifyProperty.Click += new System.EventHandler(this.btnModifyProperty_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckIn.Enabled = false;
            this.btnCheckIn.Location = new System.Drawing.Point(276, 763);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 30;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 829);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnModifyProperty);
            this.Controls.Add(this.lblStatusMsg);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblSafe);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDomainName);
            this.Controls.Add(this.lblServerUrl);
            this.Controls.Add(this.cmbSafe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.txtServerUrl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPropertyValue);
            this.Controls.Add(this.lblPropertyValue);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lstContainerItems);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.txtActiveContainer);
            this.Controls.Add(this.lblActiveContainer);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alibre PDM API Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
