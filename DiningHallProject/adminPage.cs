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
    public partial class adminPage : DraggableForm
    {
        private string currentEmail;
        public adminPage(string email)
        {
            currentEmail = email;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            newAdmin newAdminForm = new newAdmin();
            newAdminForm.ShowDialog();
        }

        private void EditMenus_Click(object sender, EventArgs e)
        {
            editMenu editForm = new editMenu();
            editForm.ShowDialog();
        }

        private void EditHalls_Click(object sender, EventArgs e)
        {
            hallEditor editor = new hallEditor();
            editor.ShowDialog();
        }

        private void adminPage_Load(object sender, EventArgs e)
        {

        }

        private void ViewReports_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewFeedback feedback = new ViewFeedback(currentEmail);
            feedback.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateAccountForm newUser = new CreateAccountForm();
            newUser.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
