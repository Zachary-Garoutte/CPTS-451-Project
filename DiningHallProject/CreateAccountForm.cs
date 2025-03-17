
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameText.Text))
            {
                MessageBox.Show("You must choose a username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordText.Text) || PasswordText.Text != ConfirmText.Text)
            {
                MessageBox.Show("Passwords must match and cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(StudentID.Text))
            {
                MessageBox.Show("You must input your Student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(StudentEmail.Text))
            {
                MessageBox.Show("You must input your Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName.Text) || string.IsNullOrWhiteSpace(lastName.Text))
            {
                MessageBox.Show("You must submit your full name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int budget = 0;
            if (plan1radial.Checked) budget = 1120;
            else if (plan2radial.Checked) budget = 1475;
            else if (plan3radial.Checked) budget = 1795;
            else
            {
                MessageBox.Show("You must choose a meal plan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Call DatabaseHelper to add account to the database
                DatabaseHelper.AddAccountToDB(StudentID.Text, firstName.Text, lastName.Text, UserNameText.Text, PasswordText.Text, StudentEmail.Text, budget);

                MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    
}

