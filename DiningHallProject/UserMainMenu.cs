using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Data.SqlClient;

namespace DiningHallProject
{
    public partial class UserMainMenu: DraggableForm
    {
        private string currentUserEmail;
        private int currentUserId;
        public UserMainMenu(string email, int userID)
        {
            InitializeComponent();
            currentUserEmail = email;
            currentUserId = userID;
            LoadUserDetails();
            LoadMealHistory();
        }

        private void viewMenuButton_Click(object sender, EventArgs e)
        {
            Form4 menuPage = new Form4();
            menuPage.ShowDialog();
        }

        private void modifyAccountButton_Click(object sender, EventArgs e)
        {
            AccountModificationForm modForm = new AccountModificationForm(currentUserEmail);
            modForm.ShowDialog();
        }
        private void LoadUserDetails()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"
            SELECT U.user_id, U.first_name, S.balance
            FROM Users U
            JOIN Student S ON U.user_id = S.user_id
            WHERE U.userEmail = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", currentUserEmail);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentUserId = Convert.ToInt32(reader["user_id"]);  // <-- CRITICAL
                            string firstName = reader["first_name"].ToString();
                            decimal balance = Convert.ToDecimal(reader["balance"]);

                            lblWelcome.Text = $"Welcome, {firstName}!";
                            lblBalance.Text = $"Current Balance: ${balance:F2}";
                        }
                        else
                        {
                            MessageBox.Show("User not found for email: " + currentUserEmail);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user details: " + ex.Message);
                }
            }
        }

        private void transHistory_Click(object sender, EventArgs e)
        {
            transactionHistroy transactionHistroy = new transactionHistroy(currentUserId);
            transactionHistroy.ShowDialog();
        }

        private void charge_Click(object sender, EventArgs e)
        {
            TransactionHandler transactionHandler = new TransactionHandler();
            transactionHandler.transaction(1, currentUserId, -1.00, "DemoCharge", System.DateTime.Now);
            LoadUserDetails();
        }
        private void LoadMealHistory()
        {
            try
            {
                DataTable historyTable = DatabaseHelper.GetMealHistory(currentUserId);

                if (historyTable.Rows.Count == 0)
                {
                    MessageBox.Show("No meal history found for user ID: " + currentUserId);
                }
                else
                {
                    mealHistoryDataGridView.DataSource = historyTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meal history: " + ex.Message);
            }
        }
        private void mealHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feedback_Click(object sender, EventArgs e)
        {
            Console.WriteLine("in feedback clik (main menu): " + currentUserEmail);
            FeedbackMenu feedbackWindow = new FeedbackMenu(currentUserEmail);
            feedbackWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addFunds_Click(object sender, EventArgs e)
        {
            addFunds addFunds = new addFunds(currentUserId);
            addFunds.ShowDialog();
            LoadUserDetails();
        }
    }


}
