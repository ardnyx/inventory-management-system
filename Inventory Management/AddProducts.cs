using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management
{
    public partial class AddProducts : UserControl
    {
        public DataTable inventory = new DataTable();
        public event EventHandler InventoryUpdated;
        public AddProducts()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
        }

        private void addProduct_addBTN_Click(object sender, EventArgs e)
        {

            string prodId = addProduct_ID.Text;
            string prodName = addProduct_prodName.Text;
            string category = addProduct_category.Text;

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

            string status = (string)addProduct_status.SelectedItem;

            inventory.Rows.Add(prodId, prodName, category, price, stock, status);

            ClearBoxes();
            InventoryUpdated?.Invoke(this, EventArgs.Empty);
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

        private void addProduct_clearBTN_Click(object sender, EventArgs e)
        {
            ClearBoxes();
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


        private void addProduct_updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    // Get the index of the selected row
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    // Update the values in the DataRow associated with the selected row
                    inventory.Rows[rowIndex]["Product ID"] = addProduct_ID.Text;
                    inventory.Rows[rowIndex]["Product Name"] = addProduct_prodName.Text;
                    inventory.Rows[rowIndex]["Category"] = addProduct_category.Text;

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
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid stock quantity.", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    inventory.Rows[rowIndex]["Status"] = addProduct_status.SelectedItem;

                    // Refresh the DataGridView to reflect the changes
                    dataGridView1.Refresh();
                    InventoryUpdated?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void addProduct_removeBTN_Click(object sender, EventArgs e)
        {
           try
            {
                inventory.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
                ClearBoxes();
                InventoryUpdated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Product ID");
            inventory.Columns.Add("Product Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Stock");
            inventory.Columns.Add("Status");

            dataGridView1.DataSource = inventory;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
