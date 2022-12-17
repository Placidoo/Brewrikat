using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BREWRIKAT
{
    public partial class orderComplete : Form
    {
        public orderComplete()
        {
            InitializeComponent();
            string path = @"C:\Brewrikat\Orders\Total.txt";
            lblTotal.Text = "PHP " + File.ReadAllText(path) + ".00";

            Random rng = new Random();
            lblReference.Text = "Ref. No. " + rng.Next(1000000, 9999999);

            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("dd/MM/yyyy");
            lblDate.Text = dateString;

        }

        private void orderComplete_FormClosed(object sender, FormClosedEventArgs e) // Close the app entirely when terminated
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            landingPage menu = new landingPage();
            menu.Show();
            this.Hide();
        }
    }
}
