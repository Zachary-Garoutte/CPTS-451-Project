﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{
    public partial class FeedbackMenu : DraggableForm
    {
        private string currentUserEmail;
        public FeedbackMenu(string email)
        {
            currentUserEmail = email;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewFeedback newFeedback = new NewFeedback(currentUserEmail);
            newFeedback.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewFeedback viewFeedback = new ViewFeedback(currentUserEmail);
            viewFeedback.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
