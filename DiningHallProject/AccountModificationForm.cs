using System.Collections.Generic;
using System.ComponentModel;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DiningHallProject
{
    public partial class AccountModificationForm : Form
    {
        private string currentUserId;

        public AccountModificationForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadUserData();
            LoadMealPlans();
        }

        private void LoadUserData()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT user_id, userPassword, userEmail, phone, DOB, first_name, last_name, streetAdress, city, userRole FROM Users WHERE user_id = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["user_id"].ToString();
                            // Don't fill in the password for security
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }
        }

        private void LoadMealPlans()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT plan_id, plan_name FROM MealPlans";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbMealPlans.Items.Add(new ComboBoxItem(
                            reader["plan_name"].ToString(),
                            Convert.ToInt32(reader["plan_id"])
                        ));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading meal plans: " + ex.Message);
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newUserId = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            ComboBoxItem selectedPlan = cmbMealPlans.SelectedItem as ComboBoxItem;

            if (string.IsNullOrEmpty(newUserId) || string.IsNullOrEmpty(newPassword) || selectedPlan == null)
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            PasswordHandler handler = new PasswordHandler();
            string hashedPassword = handler.HashPassword($"{handler.Salt}{newPassword}");

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Update Users table
                    string updateUser = "UPDATE Users SET user_id = @NewUserId, userPassword = @Password, Salt = @Salt WHERE user_id = @OldUserId";
                    SqlCommand cmdUser = new SqlCommand(updateUser, conn, transaction);
                    cmdUser.Parameters.AddWithValue("@NewUserId", newUserId);
                    cmdUser.Parameters.AddWithValue("@Password", hashedPassword);
                    cmdUser.Parameters.AddWithValue("@Salt", handler.Salt);
                    cmdUser.Parameters.AddWithValue("@OldUserId", currentUserId);
                    cmdUser.ExecuteNonQuery();

                    // Update Student table
                    string updateStudent = "UPDATE Student SET user_id = @NewUserId, plan_id = @PlanId WHERE user_id = @OldUserId";
                    SqlCommand cmdStudent = new SqlCommand(updateStudent, conn, transaction);
                    cmdStudent.Parameters.AddWithValue("@NewUserId", newUserId);
                    cmdStudent.Parameters.AddWithValue("@PlanId", selectedPlan.Value);
                    cmdStudent.Parameters.AddWithValue("@OldUserId", currentUserId);
                    cmdStudent.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Account updated successfully.");
                    currentUserId = newUserId;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; }
            public int Value { get; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
