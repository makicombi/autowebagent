using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using awaDAL;
namespace awaApplication
{
    public partial class Login : Form
    {
        private DAL dal;
        public int UserID { get; set; }
        public Login(DAL dal)
        {
            this.dal = dal;
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
                Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text;
            string password = textBoxPassword.Text;
            UserID = dal.Login(user, password);
            if (UserID > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("No such username or password","Login Failure",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                this.DialogResult = DialogResult.Abort;
            }
            
        }
    }
}
