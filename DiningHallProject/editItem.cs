using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace DiningHallProject
{
    public partial class editItem : Form
    {
        int menuID = 0;
        DataRow itemInfo;
        public editItem(int menuId, DataRow row)
        {
            InitializeComponent();
            menuID = menuId;
            itemInfo = row;
            
        }

        private void editItem_load (object sender, EventArgs e)
        {
            name.Enabled = true;
            if (itemInfo != null)
            {
                name.Text = itemInfo["item_name"].ToString();
                name.Enabled = false;
                description.Text = itemInfo["item_desc"].ToString();
                ingredients.Text = itemInfo["ingredients"].ToString();
                price.Text = itemInfo["price"].ToString();
                calories.Text = itemInfo["calories"].ToString();
                string type = itemInfo["item_type"].ToString();
                for (int i = 0; i < itemType.Items.Count; i++)
                {
                    if (itemType.Items[i].ToString().Equals(type, StringComparison.OrdinalIgnoreCase))
                    {
                        itemType.SetItemChecked(i, true);
                        break;
                    }
                }
                string availability = itemInfo["available"].ToString();
                if (availability == "True")
                {
                   available.SetItemChecked(0, true);
                }
                else
                {
                    available.SetItemChecked(1, true);
                }

            }
        }

        private void available_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < available.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        available.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void itemType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < itemType.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        itemType.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string type;
            int availability;

            if (itemType.SelectedIndex == 0)
            {
                type = "side";
            }
            else if(itemType.SelectedIndex == 1)
            {
                type = "entree";
                
            }
            else
            {
                type = "drink";
            }

            if(available.SelectedIndex == 0)
            {
                availability = 1;
            }
            else
            {
                availability = 0;
            }

            DatabaseHelper database = new DatabaseHelper();

            if (itemInfo == null)
            {

                database.AddItem(menuID, name.Text, description.Text, ingredients.Text, Convert.ToSingle(price.Text), Convert.ToInt32(calories.Text), type, availability);

            }
            else
            {
                database.UpdateItem(menuID, name.Text, description.Text, ingredients.Text, Convert.ToSingle(price.Text), Convert.ToInt32(calories.Text), type, availability);
            }

            this.Close();
        }

        private void itemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
