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
    public partial class editHall : Form
    {
        int diningHallID;
        int menuID;
        DataRow hallInfo;
        public editHall(int diningHallID, int nextMenuID, DataRow row)
        {
            InitializeComponent();

            this.diningHallID = diningHallID;
            this.menuID = nextMenuID;
            this.hallInfo = row;


        }

        private void editHall_Load(object sender, EventArgs e)
        {
            if (hallInfo != null)
            {
                name.Text = hallInfo["name"].ToString();
                street.Text = hallInfo["street"].ToString();
                city.Text = hallInfo["city"].ToString();
                zip.Text = hallInfo["zip_code"].ToString();
                capacity.Value = Convert.ToInt32(hallInfo["capacity"]);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DatabaseHelper database = new DatabaseHelper();
            if (hallInfo != null)
            {
                database.UpdateHall(diningHallID, menuID, street.Text, city.Text, zip.Text, Convert.ToInt32(capacity.Value), name.Text);
            }
            else
            {
                database.AddHall(diningHallID, menuID, street.Text, city.Text, zip.Text, Convert.ToInt32(capacity.Value), name.Text);
            }
            this.Close();
        }
    }
}
