using Microsoft.Data.SqlClient;
using OnlineShop.Utility;
using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Text;

namespace OnlineShop.Businessees
{
   public class ProductBusinesse
    {
        const string connectionString = "Data Source=.;Initial Catalog=OnlineShop;Integrated Security=True;";

        public ProductBusinesse()
        {

        }

        public List<Product> GetProducts()
        {
            List<Product> Products = new List<Product>();

            // Replace "YourTableName" with the actual name of the table you want to query
            string tableName = "[ProductTable]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command to select data from the table
                    string query = $"SELECT Id,ProductName, Quantity, IsAvailable,CategoryId {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data reader to fetch the data
                    SqlDataReader reader = command.ExecuteReader();

                    // Read data and map it to Person objects
                    while (reader.Read())
                    {
                        Product Product = new Product
                        {
                            Id = (int)reader["Id"],
                            ProductName = reader["ProductName"].ToString(),
                            Quantity = (int)reader["Quantity"],
                            IsAvailable =(bool) reader["IsAvailable"],
                            CategoryId=(int) reader["CategoryId"]
                        };
                        Products.Add(Product);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();

                }
                return Products;
            }
        }

        public bool AddProduct(Product Product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string tableName = "[ProductTable]";
                    string query = $"INSERT INTO {tableName} (ProductName, Quantity, IsAvailable,CategoryId) " +
                                   "VALUES (@ProductName, @Quantity, @IsAvailable.@CategoryId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", Product.ProductName);
                    command.Parameters.AddWithValue("@Quantity", Product.Quantity);
                    command.Parameters.AddWithValue("@IsAvailable", Product.IsAvailable);
                    command.Parameters.AddWithValue("@CategoryId", Product.CategoryId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool UpdateProduct(Product Product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string tableName = "[ProductTable]";
                    string query = $"UPDATE {tableName} " +
                        $"SET FirstName = @FirstName," +
                        $"LastName = @LastName, " +
                        $"PhoneNumber = @PhoneNumber " +
                        $"WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", Product.ProductName);
                    command.Parameters.AddWithValue("@Quantity", Product.Quantity);
                    command.Parameters.AddWithValue("@IsAvailable", Product.IsAvailable);
                    command.Parameters.AddWithValue("@CategoryId", Product.CategoryId);
                    command.Parameters.AddWithValue("@Id", Product.Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool DeleteProduct(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string tableName = "[ProductTable]";
                    string query = $"DELETE {tableName} WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
