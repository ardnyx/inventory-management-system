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
    public partial class Main_Form : Form
    {
        ProductManagement productManagement;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void dashbord_BTN_Click(object sender, EventArgs e)
        {

        }

        private void categories_BTN_Click(object sender, EventArgs e)
        {

        }

        private void products_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            productManagement = new ProductManagement();
            productManagement.Show();
        }
    }
}
