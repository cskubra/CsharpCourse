using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // sql ile bağlantıyı açmak için
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }


           //komut oluşturuşldu
            SqlCommand command = new SqlCommand("Select * from Products",connection);

            //komut çalıştırıldı
            SqlDataReader reader = command.ExecuteReader();

           //ürün oluşturuldu
            
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;

        }

        public DataTable GetAll2()
        {
            // sql ile bağlantıyı açmak için
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }


            //komut oluşturuşldu
            SqlCommand command = new SqlCommand("Select * from Products", connection);

            //komut çalıştırıldı
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;

        }


    }
}
