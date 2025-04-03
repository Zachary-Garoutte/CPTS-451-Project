using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{
    public partial class newAdmin : Form
    {
        public newAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper.AddAccountToDB(StudentID.Text, firstName.Text, lastName.Text, "NewAdmin", StudentEmail.Text, PhoneText.Text, AdressText.Text, CityText.Text, DOBpicker.Value, "admin", 0, 0);

            this.Close();
        }
    }
}
