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

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
