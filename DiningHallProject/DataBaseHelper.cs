using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DiningHallProject
{
    class DatabaseHelper
    {
        private static string connectionString =
            "Server=tcp:dininghallsql.database.windows.net,1433;" +
            "Initial Catalog=DiningHallSQLDatabase;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;" +
            "Authentication=Active Directory Interactive;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static void TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void AddAccountToDB(string userID, string firstName, string lastName, string username, string password, string userEmail, int budget)
        {
            string connectionString = "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO dbo.Students (userID,username, userPassword, userEmail, balance, firstName, lastName)" +
                "Values('" + userID + "', '" + username + "', '" + password + "', '" + userEmail + "'," + budget + ",'" + firstName + "', '" + lastName + "');";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (UserExists(username, userEmail))
                    {
                        MessageBox.Show("User Already Exists. Please enter a different username and email");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Account Created Successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static bool UserExists(string username, string userEmail)
        {
            string connectionString = "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 

            // SQL query to verify the username and email
            string query = "SELECT COUNT(*) FROM Students WHERE username = @username AND userEmail = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", userEmail);

                        int userExists = (int)cmd.ExecuteScalar(); // Executes the query and gets the count

                        // If the query returns 1, the user exists; otherwise, it doesn't
                        return userExists > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}

