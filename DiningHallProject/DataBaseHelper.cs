using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiningHallProject
{
    class DatabaseHelper
    {
        private static string connectionString = "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //"Server=tcp:dininghallsql.database.windows.net,1433;" +
            //"Initial Catalog=DiningHallSQLDatabase;" +
            //"Encrypt=True;" +
            //"TrustServerCertificate=False;" +
            //"Connection Timeout=30;" +
            //"Authentication=Active Directory Interactive;";

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
            string query1 = "INSERT INTO dbo.Users (user_id, userPassword, userEmail, phone, DOB, first_name, last_name, streetAdress, city, userRole, last_login, Salt) " +
                           "VALUES (@UserID, @Password, @UserEmail, @Phone, @DOB, @FirstName, @LastName, @Adress, @City, @userRole, @LastLogin, @Salt);";

            string query2 = "INSERT INTO dbo.Student (user_id, balance, plan_id) " +
                           "VALUES (@UserID, @Balance, @PlanID);";

            // Handle Password Hashing
            PasswordHandler handler = new PasswordHandler();
            string hashedPassword = handler.HashPassword($"{handler.Salt}{password}");

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                        command.Parameters.AddWithValue("@LastLogin", (Object)DBNull.Value);
                        command.Parameters.AddWithValue("@Salt", handler.Salt);

                        if (UserExists(userEmail))
                        {
                            MessageBox.Show("User Already Exists. Please enter a different username and email");
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                            using (SqlCommand command2 = new SqlCommand(query2, connection))
                            {
                                command2.Parameters.AddWithValue("@UserID", userID);
                                command2.Parameters.AddWithValue("@Balance", balance);
                                command2.Parameters.AddWithValue("@PlanID", planID);


                                command2.ExecuteNonQuery();
                            }
                            Console.WriteLine("Account Created Successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static bool UserExists(string userEmail)
        {
            //Change connection strings eventually not use sensitive information. CUrrently in use for development
            string connectionString = "Server=tcp:dininghallsql.database.windows.net,1433;Initial Catalog=DiningHallSQLDatabase;Persist Security Info=False;User ID=SqlAdmin;Password=Dininghalladmin!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 

            // SQL query to verify the username and email
            string query = "SELECT COUNT(*) FROM Users WHERE userEmail = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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

        public System.Data.DataTable getMenuItems(int menuId)
        {
            string query = "SELECT item_name, item_desc, ingredients, price, calories, item_type, available FROM dbo.Menu WHERE menu_id = @Menu;";
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Menu", menuId);

                System.Data.DataTable item_table = new System.Data.DataTable();
                da.Fill(item_table);

                return item_table;
            }
        }

        public System.Data.DataTable getDiningHalls()
        {
            string query = "SELECT dining_hall_id, menu_id, street, city, zip_code, name, capacity FROM dbo.diningHalls;";
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                System.Data.DataTable item_table = new System.Data.DataTable();
                da.Fill(item_table);

                return item_table;
            }
        }

        public void AddItem(int menuId, string item_name, string item_desc, string ingredients, float price, int calories, string item_type, int available)
        {
            string query1 = "INSERT INTO dbo.Menu (menu_id, item_name, item_desc, ingredients, price, calories, item_type, available)" +
                            "VALUES(@MenuID, @ItemName, @ItemDesc, @Ingredients, @Price, @Calories, @ItemType, @Available)";

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@MenuID", menuId);
                        command.Parameters.AddWithValue("@ItemName", item_name);
                        command.Parameters.AddWithValue("@ItemDesc", item_desc);
                        command.Parameters.AddWithValue("@Ingredients", ingredients);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Calories", calories);
                        command.Parameters.AddWithValue("@ItemType", item_type);
                        command.Parameters.AddWithValue("@Available", available);


                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Item successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateItem(int menuId, string item_name, string item_desc, string ingredients, float price, int calories, string item_type, int available)
        {
            string query1 = "UPDATE dbo.Menu SET item_desc = @ItemDesc, ingredients = @Ingredients, price = @Price, calories = @Calories, item_type = @ItemType, available = @Available WHERE menu_id = @MenuID and item_name = @ItemName";

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@MenuID", menuId);
                        command.Parameters.AddWithValue("@ItemName", item_name);
                        command.Parameters.AddWithValue("@ItemDesc", item_desc);
                        command.Parameters.AddWithValue("@Ingredients", ingredients);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Calories", calories);
                        command.Parameters.AddWithValue("@ItemType", item_type);
                        command.Parameters.AddWithValue("@Available", available);


                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Item updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddHall(int diningHallId, int menuID, string street, string city, string zip, int capacity, string name)
        {
            string query = "INSERT INTO dbo.diningHalls (dining_hall_id, menu_id, street, city, zip_code, name, capacity)" +
                            "VALUES(@DiningHallID, @MenuID, @Street, @City, @ZipCode, @Name, @Capacity);";
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DiningHallID", diningHallId);
                        command.Parameters.AddWithValue("@MenuID", menuID);
                        command.Parameters.AddWithValue("@Street", street);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@ZipCode", zip);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Capacity", capacity);


                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Hall successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateHall(int diningHallId, int menuID, string street, string city, string zip, int capacity, string name)
        {
            string query = "UPDATE dbo.diningHalls SET street = @Street, city = @City, zip_code = @ZipCode, name = @Name, capacity = @Capacity WHERE dining_hall_id = @DiningHallID;";

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DiningHallID", diningHallId);
                        command.Parameters.AddWithValue("@MenuID", menuID);
                        command.Parameters.AddWithValue("@Street", street);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@ZipCode", zip);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Capacity", capacity);


                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Hall successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int getMaxHallID()
        {
            int maxHallID = 0;
            string query = "SELECT max(dining_hall_id) from dbo.diningHalls;";

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        maxHallID = Convert.ToInt32(result);
                    }
                }
 
            }
            return maxHallID;
        }

        public int getMaxMenuID()
        {
            int maxMenuID = 0;
            string query = "SELECT max(menu_id) from dbo.diningHalls;";

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        maxMenuID = Convert.ToInt32(result);
                    }
                }

            }
            return maxMenuID;
        }
    }
}

