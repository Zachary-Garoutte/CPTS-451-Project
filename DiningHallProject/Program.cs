using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningHallProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show($"Unhandled exception: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            Console.WriteLine("Next It loads the Form");
            Application.Run(new Login());
        }
    }
}
