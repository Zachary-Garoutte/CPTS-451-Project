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
    public partial class addFunds : Form
    {

        int userID;
        public addFunds(int userId)
        {
            InitializeComponent();
            userID = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            TransactionHandler transactionHandler = new TransactionHandler();
            transactionHandler.transaction(0, userID, Convert.ToDouble(funds.Value), "Mock Funds", DateTime.Now);
        }
    }
}

