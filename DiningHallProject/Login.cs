using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DiningHallProject
{
    public partial class Login : DraggableForm
    {
        public Login()
        {
            InitializeComponent();
            Console.WriteLine("LoginInitialized");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.ShowDialog();
        }

        private void Form1(object sender, EventArgs e)
        {
            string email = userName.Text.Trim();
            string pwd = password.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pwd))
            {
                UserRepository userRepository = new UserRepository();
                bool success = userRepository.Login(email, pwd);

                if (success)
                {
                    DatabaseHelper database = new DatabaseHelper();
                    string role = database.getUserRole(email);
                    int userID = database.getUserID(email);

                    if (role == "admin")
                    {
                        adminPage adminPage = new adminPage(email);
                        adminPage.Show();
                    }
                    else
                    {
                        UserMainMenu userHome = new UserMainMenu(email, userID);
                        userHome.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login credentials.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid username/password.");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 menusWindow = new Form4();
            menusWindow.ShowDialog();
        }
        private void userName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
