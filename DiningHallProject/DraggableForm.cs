using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{

    public class DraggableForm : Form
    {
        private bool dragging = false;
        private Point offset;

        public DraggableForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += DraggableForm_MouseDown;
            this.MouseMove += DraggableForm_MouseMove;
            this.MouseUp += DraggableForm_MouseUp;
        }

        private void DraggableForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                offset = new Point(e.X, e.Y);
            }
        }

        private void DraggableForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                this.Location = new Point(this.Location.X + e.X - offset.X, this.Location.Y + e.Y - offset.Y);
            }
        }

        private void DraggableForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
