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

namespace DiningHallProject
{
    public partial class UserMainMenu: Form
    {
        private string currentUserId;
        public UserMainMenu(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void viewMenuButton_Click(object sender, EventArgs e)
        {
            Form4 menuPage = new Form4();
            menuPage.Show();
        }

        private void modifyAccountButton_Click(object sender, EventArgs e)
        {
            AccountModificationForm modForm = new AccountModificationForm(currentUserId);
            modForm.Show();
        }
    }
}
