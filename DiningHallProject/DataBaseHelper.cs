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
            "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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
            string query = "INSERT INTO dbo.Students (userID, username, userPassword, userEmail, balance, firstName, lastName) " +
                           "VALUES (@UserID, @Username, @Password, @UserEmail, @Budget, @FirstName, @LastName);";

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@UserEmail", userEmail);
                        command.Parameters.AddWithValue("@Budget", budget);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Account successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public System.Data.DataTable getMenuItems(int menuId)
        {
            string query = "SELECT item_name, item_desc, ingredients, price, calories, item_type FROM dbo.Menu WHERE available = 1 and menu_id = @Menu;";
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Menu", menuId);

                System.Data.DataTable item_table = new System.Data.DataTable();
                da.Fill(item_table);

                return item_table;
            }
        }

    }

}


