using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{
    public partial class NewFeedback : DraggableForm
    {
        private string currentUserEmail;
        public NewFeedback(string email)
        {
            currentUserEmail = email;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diningHallsData.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter.Fill(this.diningHallsData.diningHalls);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calls data helper to add feedback to feedback table
            string rating = FeedbackRating.Value.ToString();
            string diningHall = DiningHallSelection.Text.ToString();
            string comment = commentBox.Text.ToString();
            DatabaseHelper.AddFeedbackToDB(currentUserEmail, diningHall, rating, comment);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiningHallSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
