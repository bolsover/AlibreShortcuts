﻿using System.ComponentModel;

namespace Bolsover.Sample
{
    partial class SampleUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(380, 411);
            this.textBox.TabIndex = 0;
            // 
            // SampleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SampleUserControl";
            this.Size = new System.Drawing.Size(380, 411);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.WebBrowser textBox;

     

        #endregion
    }
}