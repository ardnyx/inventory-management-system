using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addCategory1.Visible = false;
            addProducts1.Visible = false;

            Dashboard adForm = dashboard1 as Dashboard;

            if (adForm != null)
            {
                adForm.RefreshData();
            }
        }

        private void categories_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addCategory1.Visible = true;
            addProducts1.Visible = false;

            AddCategory cForm = addCategory1 as AddCategory;

            if (cForm != null)
            {
                cForm.refreshData();
            }
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addCategory1.Visible = false;
            addProducts1.Visible = true;

            AddProducts pForm = addProducts1 as AddProducts;

            if (pForm != null)
            {
                pForm.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
