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
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reiyane\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AddProducts()
        {
            InitializeComponent();

            DisplayCategories();
            DisplayAllProducts();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            addProduct_category.Items.Clear();

            DisplayCategories();
            DisplayAllProducts();
        }
        public void DisplayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();

            dataGridView1.DataSource = listData;
        }
        public bool EmptyFields()
        {
            if (addProduct_ID.Text == "" || addProduct_prodName.Text == "" || addProduct_category.SelectedIndex == -1
                || addProduct_price.Text == "" || addProduct_stock.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayCategories()
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addProduct_category.Items.Add(reader["category"].ToString()); 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void addProduct_addBTN_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM productss WHERE prod_id = @prodID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", addProduct_ID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + addProduct_ID.Text.Trim() + " is already existing"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO productss " +
                                    "(prod_id, prod_name, category, price, stock, status) " +
                                    "VALUES(@prodID, @prodName, @cat, @price, @stock, @status)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", addProduct_ID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", addProduct_prodName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", addProduct_category.Text.Trim());
                                    insertD.Parameters.AddWithValue("@price", addProduct_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", addProduct_stock.Text.Trim());

                                    // Set the status based on the stock value
                                    string status = addProduct_status.Text.Trim();
                                    int stock = Convert.ToInt32(addProduct_stock.Text.Trim());
                                    if (stock <= 5)
                                    {
                                        status = "LOW ON STOCKS";
                                    }
                                    insertD.Parameters.AddWithValue("@status", status);

                                    insertD.ExecuteNonQuery();
                                    ClearFields();
                                    DisplayAllProducts();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void ClearFields()
        {
            addProduct_ID.Text = "";
            addProduct_prodName.Text = "";
            addProduct_category.SelectedIndex = -1;
            addProduct_price.Text = "";
            addProduct_stock.Text = "";
            addProduct_status.Text = "";
        }
        public bool CheckConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void addProduct_clearBTN_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addProduct_ID.Text = row.Cells[1].Value.ToString();
                addProduct_prodName.Text = row.Cells[2].Value.ToString();
                addProduct_category.Text = row.Cells[3].Value.ToString();
                addProduct_price.Text = row.Cells[4].Value.ToString();
                addProduct_stock.Text = row.Cells[5].Value.ToString();
                addProduct_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void addProduct_updateBTN_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update Product ID: " 
                    + addProduct_ID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE productss SET prod_id = @prodID, prod_name = @prodName, category = @cat, " +
                                "stock = @stock, price = @price, status = @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", addProduct_ID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProduct_prodName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addProduct_category.Text.Trim());
                                updateD.Parameters.AddWithValue("@price", addProduct_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", addProduct_stock.Text.Trim());

                                string status = addProduct_status.Text.Trim();
                                int stock = Convert.ToInt32(addProduct_stock.Text.Trim());
                                if (stock == 0)
                                {
                                    updateD.Parameters.AddWithValue("@status", "Out of Stock");
                                }
                                else if (stock <= 5)
                                {
                                    updateD.Parameters.AddWithValue("@status", "Low on Stocks");
                                }
                                else
                                {
                                    updateD.Parameters.AddWithValue("@status", status);
                                }
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                ClearFields();
                                DisplayAllProducts();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void addProduct_removeBTN_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove Product ID: "
                    + addProduct_ID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM productss WHERE id = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                ClearFields();
                                DisplayAllProducts();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
