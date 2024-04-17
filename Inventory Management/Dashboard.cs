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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reiyane\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
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
            try
            {
                connect.Open();

                string query = "SELECT SUM(price * stock) AS TotalValue FROM productss";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        double totalValue = Convert.ToDouble(result);
                        inventoryValue.Text = totalValue.ToString("C2");
                    }
                    else
                    {
                        inventoryValue.Text = "$0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory value: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void UpdateRemainingItems()
        {
            try
            {
                connect.Open();

                string query = "SELECT SUM(stock) AS TotalStock FROM productss";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalStock = Convert.ToInt32(result);
                        remainingItems.Text = totalStock.ToString();
                    }
                    else
                    {
                        remainingItems.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating remaining items: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void inventoryValue_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLowStockItemsCount()
        {
            try
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM productss WHERE stock <= 5";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    int lowStockCount = (int)cmd.ExecuteScalar();
                    items_lowOnStock.Text = lowStockCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating low stock items count: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
