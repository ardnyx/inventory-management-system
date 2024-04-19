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
    public partial class ProductManagement : Form
    {
        Main_Form main_Form;
        public static DataTable inventory = new DataTable();
        public static double finalPrice { get; set; }
        public static int finalStock { get; set; }
        public ProductManagement(Main_Form mainForm)
        {
            InitializeComponent();
            main_Form = mainForm;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool ValidateProduct(string prodId, string prodName, int rowIndexToUpdate)
        {
            // Trim the input strings
            prodId = prodId.Trim();
            prodName = prodName.Trim();

            // Check if the product ID, product name, or category already exists
            for (int i = 0; i < inventory.Rows.Count; i++)
            {
                if (i == rowIndexToUpdate) // Skip the current row being updated
                {
                    continue;
                }

                string existingProdId = inventory.Rows[i]["Product ID"].ToString().Trim();
                string existingProdName = inventory.Rows[i]["Product Name"].ToString().Trim();
                string existingCategory = inventory.Rows[i]["Category"].ToString().Trim();

                if (String.Equals(existingProdId, prodId, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Product ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false indicating validation failed
                }

                if (String.Equals(existingProdName, prodName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Product Name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false indicating validation failed
                }
            }

            // Validation passed if no match is found
            return true;
        }
        private void addProduct_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_addBTN_Click(object sender, EventArgs e)
        {

            string prodId = addProduct_ID.Text;
            string prodName = addProduct_prodName.Text;
            string category = addProduct_category.Text;

            if (!ValidateProduct(prodId, prodName, -1))
            {
                return;
            }

            double price;
            if (!double.TryParse(addProduct_price.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stock;
            if (!int.TryParse(addProduct_stock.Text, out stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string status = addProduct_status.Text;
            if (stock == 0)
            {
                status = "OUT OF STOCK";
            }
            else if (stock < 5)
            {
                status = "LOW ON STOCKS";
            }
            else status = (string)addProduct_status.SelectedItem;

            inventory.Rows.Add(prodId, prodName, category, price, stock, status);
            main_Form.UpdateInventoryValues();
            main_Form.UpdateLowStockCount();
            ClearBoxes();
        }
        private void ClearBoxes()
        {
            addProduct_ID.Text = "";
            addProduct_prodName.Text = "";
            addProduct_category.Text = "";
            addProduct_price.Text = "";
            addProduct_stock.Text = "";
            addProduct_status.SelectedIndex = -1;
        }
        private void addProduct_removeBTN_Click(object sender, EventArgs e)
        {     
            inventory.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            main_Form.UpdateInventoryValues();
            main_Form.UpdateLowStockCount();
            ClearBoxes();
        }

        private void addProduct_updateBTN_Click(object sender, EventArgs e)
        {
            
            // Check if a row is selected
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Get the existing values
                string existingProdId = inventory.Rows[rowIndex]["Product ID"].ToString();
                string existingProdName = inventory.Rows[rowIndex]["Product Name"].ToString();
                string existingCategory = inventory.Rows[rowIndex]["Category"].ToString();

                // Get the new values
                string newProdId = addProduct_ID.Text;
                string newProdName = addProduct_prodName.Text;
                string newCategory = addProduct_category.Text;

                // Validate the product
                if (!ValidateProduct(newProdId, newProdName, rowIndex))
                {
                    return; // Exit the method if validation failed
                }

                // Update the values in the DataRow associated with the selected row
                inventory.Rows[rowIndex]["Product ID"] = newProdId;
                inventory.Rows[rowIndex]["Product Name"] = newProdName;
                inventory.Rows[rowIndex]["Category"] = newCategory;

                double price;
                if (double.TryParse(addProduct_price.Text, out price))
                {
                    inventory.Rows[rowIndex]["Price"] = price;
                }
                else
                {
                    MessageBox.Show("Please enter a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int stock;
                if (int.TryParse(addProduct_stock.Text, out stock))
                {
                    inventory.Rows[rowIndex]["Stock"] = stock;

                    // Update status based on stock quantity
                    string status = (stock == 0) ? "OUT OF STOCK" : (stock < 5) ? "LOW ON STOCKS" : (string)addProduct_status.SelectedItem;
                    inventory.Rows[rowIndex]["Status"] = status;
                }
                else
                {
                    MessageBox.Show("Please enter a valid stock quantity.", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Refresh the DataGridView to reflect the changes
                dataGridView1.Refresh();
                main_Form.UpdateInventoryValues();
                main_Form.UpdateLowStockCount();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void addProduct_clearBTN_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void dashboard_BTN_Click(object sender, EventArgs e)
        {
            if (main_Form == null || main_Form.IsDisposed)
            {
                main_Form = new Main_Form();
                main_Form.Show();
            }
            else
            {
                main_Form.Show();
                main_Form.BringToFront();
            }
        }

        private void products_BTN_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                addProduct_ID.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
                addProduct_prodName.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
                addProduct_category.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
                addProduct_price.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
                addProduct_stock.Text = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[4].ToString();

                string statusToLookFor = inventory.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[5].ToString();
                addProduct_status.SelectedIndex = addProduct_status.Items.IndexOf(statusToLookFor);
            }
            catch (Exception ex)
            {
                // Handle the exception silently (do nothing)
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            if (inventory.Columns.Count == 0)
            {
                inventory.Columns.Add("Product ID");
                inventory.Columns.Add("Product Name");
                inventory.Columns.Add("Category");
                inventory.Columns.Add("Price");
                inventory.Columns.Add("Stock");
                inventory.Columns.Add("Status");
            }

            dataGridView1.DataSource = inventory;
        }
    }
}