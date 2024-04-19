using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reiyane\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "admin" && login_pass.Text == "admin")
            {
                MessageBox.Show("Login Successful", "Information Dialogue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_Form main_Form = new Main_Form();
                main_Form.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username: admin\nPassword: admin", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void register_label_Click(object sender, EventArgs e)
        {

        }
    }
}
