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
    public partial class adminPage : Form
    {
        public adminPage()
        {
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
    }
}
