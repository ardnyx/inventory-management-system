using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management
{
    public partial class Dashboard : UserControl
    {
        private AddProducts addProducts;
        private double InventoryValue = 0;
        private int RemainingStocks = 0;

        public Dashboard()
        {
            InitializeComponent();
            addProducts = MainForm.Instance.AddProductsControl; // Access the same instance
            addProducts.InventoryUpdated += AddProducts_InventoryUpdated; // Subscribe to event
            RefreshData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            UpdateInventoryValue();
            UpdateRemainingItems();
            UpdateLowStockItemsCount();
        }

        private void UpdateInventoryValue()
        {
            // Calculate the inventory value by summing up the prices of all products
            InventoryValue = 0;
            foreach (DataRow row in addProducts.inventory.Rows)
            {
                double price = Convert.ToDouble(row["Price"]);
                int stock = Convert.ToInt32(row["Stock"]);
                InventoryValue += price * stock;
            }

            // Update the inventoryValue label
            inventoryValue.Text = InventoryValue.ToString("C");
        }

        private void UpdateRemainingItems()
        {
            // Calculate the total remaining stocks
            RemainingStocks = 0;
            foreach (DataRow row in addProducts.inventory.Rows)
            {
                int stock = Convert.ToInt32(row["Stock"]);
                RemainingStocks += stock;
            }

            // Update the remainingStocks label
            remainingItems.Text = RemainingStocks.ToString();
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            addProducts.InventoryUpdated += AddProducts_InventoryUpdated;
        }

        private void inventoryValue_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLowStockItemsCount()
        {
            // Count the number of items with stock below 5
            int lowStockCount = 0;
            foreach (DataRow row in addProducts.inventory.Rows)
            {
                int stock = Convert.ToInt32(row["Stock"]);
                if (stock <= 5)
                {
                    lowStockCount++;
                }
            }

            // Update the itemsLowOnStock label
            items_lowOnStock.Text = lowStockCount.ToString();
        }

        private void AddProducts_InventoryUpdated(object sender, EventArgs e)
        {
            // When inventory is updated, refresh data in the Dashboard
            RefreshData();
        }
    }
}
