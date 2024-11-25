using Microsoft.Data.SqlClient;
using OnlineShop.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Businessees
{
    public class CategoryBusiness
    {
        const string connectionString = "Data Source =.; Initial Catalog = OnlineShop; Integrated Security = True; Encrypt=False;";


        public List<Categories> GetCategoriess()
        {
            List<Categories> Categoriess = new List<Categories>();

            // Replace "YourTableName" with the actual name of the table you want to query
            string tableName = "[CategoryTable]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command to select data from the table
                    string query = $"SELECT Id,CategoryName,Description FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a data reader to fetch the data
                    SqlDataReader reader = command.ExecuteReader();

                    // Read data and map it to Person objects
                    while (reader.Read())
                    {
                        Categories Categories = new Categories
                        {
                            Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                            CategoryName = reader["CategoryName"]?.ToString(),
                            Description = reader["Description"]?.ToString(),
                        };
                        Categoriess.Add(Categories);
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
                return Categoriess;
            }
        }
    }
}
