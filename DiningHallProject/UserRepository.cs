using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{
    class UserRepository
    {
        public bool Login(string email, string passwordEntered)
        {
            if (DatabaseHelper.UserExists(email)) 
            {
                string storedPassword = null;
                string storedSalt = null;
                string connectionString = "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                string query = "SELECT userPassword, Salt FROM Users WHERE userEmail = @UserEmail";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserEmail", email);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    storedPassword = reader["userPassword"].ToString();
                                    storedSalt = reader["Salt"].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
                try
                {
                    PasswordHandler handler = new PasswordHandler();

                    string attemptedHash = handler.HashPassword($"{storedSalt}{passwordEntered}");
                    if (attemptedHash.Equals(storedPassword))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                        return false;
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
