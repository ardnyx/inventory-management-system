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
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_pass.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Main_Form mForm = new Main_Form();
                            this.Hide();
                            mForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Pass", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void register_label_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }
    }
}
