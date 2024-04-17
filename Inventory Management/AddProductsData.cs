using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management
{
    internal class AddProductsData
    {
        public int ID { set; get; }
        public string ProdID { set; get; }
        public string ProdName { set; get; }
        public string Category { set; get; }
        public string Price { set; get; }
        public string Stock { set; get; }
        public string Status { set; get; }

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reiyane\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string SelectData = "SELECT * FROM productss";

                using (SqlCommand cmd = new SqlCommand(SelectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["ID"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.Status = reader["status"].ToString();

                        listData.Add(apData);
                    }
                }
            }

            return listData;
        }
    }
}
