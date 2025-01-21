using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {

        string connectionString = @"Server=PRUCKO\SQLEXPRESS;Database=CompanyDB;Integrated Security=true;TrustServerCertificate=True;";


        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connection successful!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Connection failed: {ex.Message}");
        }
    }
}
