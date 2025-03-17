using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Contexts;

namespace DiningHallProject
{
    internal class DatabaseInteraction
    {
        public void AddAccountToDB(string userID, string firstName, string lastName, string username, string password, string userEmail, int budget)
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

        private bool UserExists(string username, string userEmail)
        {
            string connectionString = "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; // Replace with your actual connection string

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
