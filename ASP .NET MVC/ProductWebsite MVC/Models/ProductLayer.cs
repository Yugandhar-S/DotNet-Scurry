using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProductWebsite.Models
{
    public class ProductLayer
    {
        public List<Product> Products
        {
            get
            {
                string ConnectionStr = ConfigurationManager.ConnectionStrings["ProductConn"].ConnectionString;
                List<Product> products = new List<Product>();
                using (SqlConnection connection = new SqlConnection(ConnectionStr))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Product", connection);
                    connection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Product product = new Product();
                        product.Id = Convert.ToInt32(rdr["Id"]);
                        product.Name = rdr["Name"].ToString();
                        product.Quantity = Convert.ToInt32(rdr["Quantity"]);
                        product.Price = Convert.ToInt32(rdr["Price"]);
                        products.Add(product);

                    }
                }
                return products;
            }
        }
    }
}
