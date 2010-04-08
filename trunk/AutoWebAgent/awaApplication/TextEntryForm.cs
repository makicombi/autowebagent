using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace awaApplication
{
    public partial class TextEntryForm : UserControl
    {

        public event EventHandler Submitted;
        public string Value { get; private set; }
        public DialogResult DialogResult { get; private set; }
        public int MyProperty { get; set; }
        public TextEntryForm(string label)
        {
            InitializeComponent();
            labelFieldName.Text = label;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            labelError.Text = string.Empty;
            Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Value = textBoxField.Text;
            this.DialogResult = DialogResult.OK;
            Visible = false;
            if (Submitted !=null)
            {
                Submitted(this, e);
            }
            
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                foreach (Control control in Controls)
                {
                    control.BringToFront();
                }
            }
            
        }

        internal void Clear()
        {
            textBoxField.Text = string.Empty;
        }
        
    }
}
