using Microsoft.Data.SqlClient;
using OnlineShop.Businessees.Interfaces;
using OnlineShop.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using System.Text;

namespace OnlineShop.Businessees
{
    public class ProductBusinesse : IBaseBusiness<Product>
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OnlineShopDb"].ToString();

        public ProductBusinesse()
        {

        }

        public List<Product> GetAll()
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
                    string query = $"SELECT Id,ProductName, Quantity, IsAvailable,CategoryId FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data reader to fetch the data
                    SqlDataReader reader = command.ExecuteReader();

                    // Read data and map it to Person objects
                    while (reader.Read())
                    {
                        Product Product = new Product
                        {
                            Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                            ProductName = reader["ProductName"]?.ToString(),
                            Quantity = reader["Quantity"] != DBNull.Value ? (int)reader["Quantity"] : 0,
                            IsAvailable = reader["IsAvailable"] != DBNull.Value && (bool)reader["IsAvailable"],
                            CategoryId = reader["CategoryId"] != DBNull.Value ? (int)reader["CategoryId"] : 0
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

        public bool Add(Product item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string tableName = "[ProductTable]";
                    string query = $"INSERT INTO {tableName} (ProductName, Quantity, IsAvailable, CategoryId) " +
                                   "VALUES (@ProductName, @Quantity, @IsAvailable, @CategoryId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", item.ProductName);
                    command.Parameters.AddWithValue("@Quantity", item.Quantity);
                    command.Parameters.AddWithValue("@IsAvailable", item.IsAvailable);
                    command.Parameters.AddWithValue("@CategoryId", item.CategoryId);
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

        public bool Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string tableName = "[ProductTable]";
                    string query = $"DELETE FROM {tableName} WHERE Id = @Id";
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

        public bool Update(Product item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string tableName = "[ProductTable]";
                    string query = $"UPDATE {tableName} " +
                        $"SET ProductName = @ProductName," +
                        $"Quantity = @Quantity, " +
                        $"IsAvailable = @IsAvailable, " +
                        $"CategoryId = @CategoryId " +
                        $"WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", item.ProductName);
                    command.Parameters.AddWithValue("@Quantity", item.Quantity);
                    command.Parameters.AddWithValue("@IsAvailable", item.IsAvailable);
                    command.Parameters.AddWithValue("@CategoryId", item.CategoryId);
                    command.Parameters.AddWithValue("@Id", item.Id);
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
