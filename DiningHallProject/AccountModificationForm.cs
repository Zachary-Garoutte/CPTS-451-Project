using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DiningHallProject
{
    public partial class AccountModificationForm : DraggableForm
    {
        private string currentUserEmail;

        public AccountModificationForm(string email)
        {
            InitializeComponent();
            currentUserEmail = email;
            LoadUserData();
            LoadMealPlans();
        }

        private void LoadUserData()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT userEmail FROM Users WHERE userEmail = @UserEmail";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserEmail", currentUserEmail);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtEmail.Text = reader["userEmail"].ToString(); // display email in textbox
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
                string getCurrentPlanQuery = @"
            SELECT S.plan_id
            FROM Student S
            JOIN Users U ON S.user_id = U.user_id
            WHERE U.userEmail = @UserEmail";

                string getAvailablePlansQuery = @"
            SELECT plan_id, plan_name
            FROM MealPlans
            WHERE plan_id >= @CurrentPlanId";

                try
                {
                    conn.Open();

                    // Step 1: Get current plan_id
                    SqlCommand getPlanCmd = new SqlCommand(getCurrentPlanQuery, conn);
                    getPlanCmd.Parameters.AddWithValue("@UserEmail", currentUserEmail);
                    object result = getPlanCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Could not retrieve current plan.");
                        return;
                    }

                    int currentPlanId = Convert.ToInt32(result);

                    // Step 2: Get only equal or higher-tier plans
                    SqlCommand getPlansCmd = new SqlCommand(getAvailablePlansQuery, conn);
                    getPlansCmd.Parameters.AddWithValue("@CurrentPlanId", currentPlanId);

                    SqlDataReader reader = getPlansCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ComboBoxItem item = new ComboBoxItem(
                            reader["plan_name"].ToString(),
                            Convert.ToInt32(reader["plan_id"])
                        );

                        cmbMealPlans.Items.Add(item);

                        // Step 3: Pre-select current plan
                        if (item.Value == currentPlanId)
                        {
                            cmbMealPlans.SelectedItem = item;
                        }
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
            string newPassword = txtPassword.Text.Trim();
            ComboBoxItem selectedPlan = cmbMealPlans.SelectedItem as ComboBoxItem;

            if (string.IsNullOrEmpty(newPassword) || selectedPlan == null)
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
                    string updateUser = "UPDATE Users SET userPassword = @Password, Salt = @Salt WHERE userEmail = @UserEmail";
                    SqlCommand cmdUser = new SqlCommand(updateUser, conn, transaction);
                    cmdUser.Parameters.AddWithValue("@Password", hashedPassword);
                    cmdUser.Parameters.AddWithValue("@Salt", handler.Salt);
                    cmdUser.Parameters.AddWithValue("@UserEmail", currentUserEmail);
                    cmdUser.ExecuteNonQuery();

                    // Update Student table
                    string updateStudent = "UPDATE Student SET plan_id = @PlanId WHERE user_id = (SELECT user_id FROM Users WHERE userEmail = @UserEmail)";
                    SqlCommand cmdStudent = new SqlCommand(updateStudent, conn, transaction);
                    cmdStudent.Parameters.AddWithValue("@PlanId", selectedPlan.Value);
                    cmdStudent.Parameters.AddWithValue("@UserEmail", currentUserEmail);
                    cmdStudent.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Account updated successfully.");
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}