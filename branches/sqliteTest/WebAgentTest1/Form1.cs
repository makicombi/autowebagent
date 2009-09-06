using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WebAgentTest1
{
    public partial class Form1 : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter UsersDataAdapter;
        DataTable UsersTable;

        public Form1()
        {
            SQLiteConnectionStringBuilder scb = new SQLiteConnectionStringBuilder();
            con = new SQLiteConnection(Properties.Settings.Default.WebAgentDB);
            con.Open();
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users;";
            IDataReader r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            
            InitializeComponent();
            usersDataGrid.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ~Form1()
        {
            con.Close();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            
        }
    }
}
