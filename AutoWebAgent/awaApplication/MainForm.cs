using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace awaApplication
{
    public partial class MainForm : Form
    {
        awaAboutBox aBox;
        public MainForm()
        {
            InitializeComponent();
            aBox = new awaAboutBox();
            aBox.Hide();
        }

        private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aBox.IsDisposed)
            {
                aBox = null;
                aBox = new awaAboutBox();
            }
            aBox.Show();
            aBox.Activate();
        }
    }
}
