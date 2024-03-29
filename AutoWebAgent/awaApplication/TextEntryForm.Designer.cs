﻿namespace awaApplication
{
    partial class TextEntryForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.labelFieldName = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(3, 46);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(237, 46);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxField
            // 
            this.textBoxField.Location = new System.Drawing.Point(3, 20);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(309, 20);
            this.textBoxField.TabIndex = 2;
            // 
            // labelFieldName
            // 
            this.labelFieldName.AutoSize = true;
            this.labelFieldName.Location = new System.Drawing.Point(0, 4);
            this.labelFieldName.Name = "labelFieldName";
            this.labelFieldName.Size = new System.Drawing.Size(35, 13);
            this.labelFieldName.TabIndex = 3;
            this.labelFieldName.Text = "label1";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.labelError);
            this.panelContainer.Controls.Add(this.buttonOK);
            this.panelContainer.Controls.Add(this.labelFieldName);
            this.panelContainer.Controls.Add(this.buttonCancel);
            this.panelContainer.Controls.Add(this.textBoxField);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(323, 92);
            this.panelContainer.TabIndex = 4;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(4, 74);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            // 
            // TextEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "TextEntryForm";
            this.Size = new System.Drawing.Size(323, 92);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.Label labelFieldName;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelError;
    }
}
