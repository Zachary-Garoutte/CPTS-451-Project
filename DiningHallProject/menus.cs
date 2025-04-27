using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;

namespace DiningHallProject
{
    public partial class Form4 : DraggableForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHelper database = new DatabaseHelper();

            int menuId = Convert.ToInt32(comboBox1.SelectedValue);

            DataTable items = database.getMenuItems(menuId);

            listBox1.Items.Clear();

            foreach (DataRow row in items.Rows)
            {
                if (row["available"].ToString() == "True")
                {
                    string itemDetails = $"{row["item_name"]} - {row["item_desc"]} - {row["ingredients"]} - ${row["price"]} - {row["calories"]} cal - {row["item_type"]}";
                    listBox1.Items.Add(itemDetails);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diningHallsData.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter2.Fill(this.diningHallsData.diningHalls);
            // TODO: This line of code loads data into the 'diningHallSQLDatabaseDataSet2.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter1.Fill(this.diningHallSQLDatabaseDataSet2.diningHalls);
            // TODO: This line of code loads data into the 'diningHallSQLDatabaseDataSet1.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.diningHallSQLDatabaseDataSet1.Menu);
            // TODO: This line of code loads data into the 'diningHallSQLDatabaseDataSet.diningHalls' table. You can move, or remove it, as needed.
            this.diningHallsTableAdapter.Fill(this.diningHallSQLDatabaseDataSet.diningHalls);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.diningHallsTableAdapter.FillBy(this.diningHallSQLDatabaseDataSet.diningHalls);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
