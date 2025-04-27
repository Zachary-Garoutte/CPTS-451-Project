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
    public partial class newAdmin : DraggableForm
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

        private void newAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void StudentIDText_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
