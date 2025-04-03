using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiningHallProject
{
    public partial class hallEditor : Form
    {

        DatabaseHelper database = new DatabaseHelper();


        public hallEditor()
        {
            InitializeComponent();
            

            DataTable items = database.getDiningHalls();

            hallBox.Items.Clear();

            foreach (DataRow row in items.Rows)
            {
                    string itemDetails = $"Hall Name: {row["name"]}, Adress: {row["street"]},{row["city"]} {row["zip_code"]}, Capacity: {row["capacity"]}";
                    hallBox.Items.Add(itemDetails);
            }
        }

        private void hallBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable items = database.getDiningHalls();
            DataRow row = items.Rows[hallBox.SelectedIndex];
            
            editHall hallEditor = new editHall(Convert.ToInt32(row["dining_hall_id"]), Convert.ToInt32(row["menu_id"]), row);
            hallEditor.ShowDialog();
        }

        private void newHall_Click(object sender, EventArgs e)
        {
            DataTable items = database.getDiningHalls();

            int menuID = database.getMaxMenuID() + 1;
            int hallID = database.getMaxHallID() + 1;

            editHall hallEditor = new editHall(hallID, menuID, null);
            hallEditor.ShowDialog();
        }
    }
}
