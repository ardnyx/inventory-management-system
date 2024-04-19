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
            UpdateInventoryValues();
        }

        private void dashbord_BTN_Click(object sender, EventArgs e)
        {

        }

        private void categories_BTN_Click(object sender, EventArgs e)
        {

        }

        private void products_BTN_Click(object sender, EventArgs e)
        {
            if (productManagement == null || productManagement.IsDisposed)
            {
                productManagement = new ProductManagement(this);
                productManagement.Show();
            }
            else
            {
                productManagement.Show();
                productManagement.BringToFront();
            }
        }
        public void UpdateInventoryValues()
        {
            double totalPrice = 0;
            int totalStock = 0;

            // Iterate through each row in the inventory DataTable
            foreach (DataRow row in ProductManagement.inventory.Rows)
            {
                double price = Convert.ToDouble(row["Price"]);
                int stock = Convert.ToInt32(row["Stock"]);

                totalPrice += price * stock;
                totalStock += stock;
            }

            // Update the labels with the new values
            inventoryValue.Text = totalPrice.ToString();
            remainingStocks.Text = totalStock.ToString();
        }
        private void inventoryValue_Click(object sender, EventArgs e)
        {

        }
    }
}
