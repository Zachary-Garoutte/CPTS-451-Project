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
    public partial class ViewFeedback : DraggableForm
    {
        private string currentEmail;
        public ViewFeedback(string userEmail)
        {
            // "admin" for admin users, handle accordingly
            currentEmail = userEmail;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diningHallSQLDatabaseDataSet4.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter2.Fill(this.diningHallSQLDatabaseDataSet4.diningHalls);
            // TODO: This line of code loads data into the 'diningHallNames.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter1.Fill(this.diningHallNames.diningHalls);
            // TODO: This line of code loads data into the 'diningHallSQLDatabaseDataSet3.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.diningHallSQLDatabaseDataSet3.Feedback);
            // TODO: This line of code loads data into the 'diningHallsData.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter.Fill(this.diningHallsData.diningHalls);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.feedbackTableAdapter.FillBy(this.diningHallSQLDatabaseDataSet3.Feedback);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHelper helper = new DatabaseHelper();

            string diningHallName = comboBox1.Text.ToString();

            DataTable entries = helper.GetFeedback(diningHallName, currentEmail);
            
            listBox1.Items.Clear();
            if (helper.getUserRole(currentEmail) == "admin")
            {
                foreach (DataRow row in entries.Rows)
                {
                    string feedbackDetails = $"Date: {row["feedbackDate"]} - Rating: {row["rating"]} - Comments: {row["comments"]} - DiningHall: {row["dining_hall_id"]} - User: {row["user_id"]}";
                    listBox1.Items.Add(feedbackDetails);
                }
            } else
            {
                foreach (DataRow row in entries.Rows)
                {
                    string feedbackDetails = $"Date: {row["feedbackDate"]} - Rating: {row["rating"]} - Comments: {row["comments"]}";
                    listBox1.Items.Add(feedbackDetails);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
