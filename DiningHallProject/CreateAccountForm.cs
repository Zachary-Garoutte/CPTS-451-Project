
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
            DatabaseInteraction interaction = new DatabaseInteraction();
            if (UserNameText != null)
            {
                if ((PasswordText.Text == ConfirmText.Text) && (PasswordText != null))
                {
                    String Password = PasswordText.Text;

                    if (StudentID.Text != string.Empty)
                    {
                        if (StudentEmail.Text != string.Empty)
                        {
                            if (firstName.Text != string.Empty && lastName.Text != string.Empty)
                            {
                                if (plan1radial.Checked == true)
                                {
                                    interaction.AddAccountToDB(StudentID.Text, firstName.Text, lastName.Text, UserNameText.Text, Password, StudentEmail.Text, 1120);
                                    this.Close();
                                }
                                else if (plan2radial.Checked == true)
                                {
                                    interaction.AddAccountToDB(StudentID.Text, firstName.Text, lastName.Text, UserNameText.Text, Password, StudentEmail.Text, 1475);
                                    this.Close();
                                }
                                else if (plan3radial.Checked == true)
                                {
                                    interaction.AddAccountToDB(StudentID.Text, firstName.Text, lastName.Text, UserNameText.Text, Password, StudentEmail.Text, 1795);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("You Must Choose A Plan!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("You Must Submit Your Full Name!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You must Input Your Email!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Must Input Your Student ID!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Must Be the Same!");
                }
            }
            else 
            {
                MessageBox.Show("You Must Choose A Username!");
            }
        }

    }

    
}

