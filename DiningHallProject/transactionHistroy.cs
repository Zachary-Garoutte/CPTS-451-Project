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
    public partial class transactionHistroy : Form
    {
        public transactionHistroy(int userID)
        {
            InitializeComponent();
            DatabaseHelper database = new DatabaseHelper();

            DataTable items = database.getTransactionHistory(userID);

            listBox1.Items.Clear();

            foreach (DataRow row in items.Rows)
            {
                string itemDetails = $"Amount: {row["amount"]}, Payment Method: {row["paymentMethod"]}, Date of Transaction: {row["dot"]}, Place of Sale: {row["name"]}";
                listBox1.Items.Add(itemDetails);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
