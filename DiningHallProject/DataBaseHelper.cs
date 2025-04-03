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

        public static void AddAccountToDB(string userID, string firstName, string lastName, string password, string userEmail, string phoneNumber, string adress, string city, DateTime DOB, string userRole, int balance, int planID)
        {
            string query1 = "INSERT INTO dbo.Users (user_id, userPassword, userEmail, phone, DOB, first_name, last_name, streetAdress, city, userRole, last_login) " +
                           "VALUES (@UserID, @Password, @UserEmail, @Phone, @DOB, @FirstName, @LastName, @Adress, @City, @userRole, @LastLogin, @Salt);";

            string query2 = "INSERT INTO dbo.Student (user_id, balance, plan_id) " +
                           "VALUES (@UserID, @Balance, @PlanID);";

            // Handle Password Hashing
            PasswordHandler handler = new PasswordHandler();
            string hashedPassword = handler.HashPassword($"{handler.Salt}{password}");

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@UserEmail", userEmail);
                        command.Parameters.AddWithValue("@Phone", phoneNumber);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@Adress", adress);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@userRole", userRole);
                        command.Parameters.AddWithValue("@LastLogin", (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Salt", handler.Salt);


                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command2 = new SqlCommand(query2, connection))
                    {
                        command2.Parameters.AddWithValue("@UserID", userID);
                        command2.Parameters.AddWithValue("@Balance", balance);
                        command2.Parameters.AddWithValue("@PlanID", planID);


                        command2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Account successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


