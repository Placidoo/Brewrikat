using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BREWRIKAT
{
    public partial class landingPage : Form
    {
        // Variables
        public int miniPictureCount = 1;

        public landingPage()
        {
            InitializeComponent();
            string path = @"C:\Brewrikat\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path + @"Accounts\");
            }
                prerequisite();
        }

        public void prerequisite() // Create pre-requisite files
        {
            string path = @"C:\Brewrikat\Orders\";
            Directory.CreateDirectory(path);
            File.WriteAllText(path + "Chocolate Drink.txt", null);
            File.WriteAllText(path + "Iced Spanish Latte.txt", null);
            File.WriteAllText(path + "Matcha Green Tea.txt", null);
            File.WriteAllText(path + "Eggdrop Sandwich.txt", null);
            File.WriteAllText(path + "Clubhouse Sandwich.txt", null);
            File.WriteAllText(path + "Grilled Cheese.txt", null);
            File.WriteAllText(path + "Banana Muffins.txt", null);
            File.WriteAllText(path + "Croissant.txt", null);
            File.WriteAllText(path + "Brownies.txt", null);
            File.WriteAllText(path + "Total.txt", null);
        }

        private void miniPictureDisplay_Tick(object sender, EventArgs e) // Displays Mini Picture and cycles it
        {
            miniPictureCount++;
            switch (miniPictureCount)
            {
                case 1:
                    miniPicture.Image = Properties.Resources._1;
                    break;
                case 2:
                    miniPicture.Image = Properties.Resources._2;
                    break;
                case 3:
                    miniPicture.Image = Properties.Resources._3;
                    break;
                case 4:
                    miniPicture.Image = Properties.Resources._4;
                    break;
                case 5:
                    miniPicture.Image = Properties.Resources._5;
                    break;
                case 6:
                    miniPicture.Image = Properties.Resources._6;
                    break;
                case 7:
                    miniPicture.Image = Properties.Resources._7;
                    break;
                case 8:
                    miniPicture.Image = Properties.Resources._8;
                    break;
                case 9:
                    miniPicture.Image = Properties.Resources._9;
                    break;
                case 10:
                    miniPicture.Image = Properties.Resources._10;
                    break;
                case 11:
                    miniPicture.Image = Properties.Resources._11;
                    break;
                case 12:
                    miniPicture.Image = Properties.Resources._12;
                    break;
                case 13:
                    miniPicture.Image = Properties.Resources._13;
                    break;
                case 14:
                    miniPicture.Image = Properties.Resources._14;
                    break;
                case 15:
                    miniPicture.Image = Properties.Resources._15;
                    break;
                case 16:
                    miniPicture.Image = Properties.Resources._16;
                    break;
                case 17:
                    miniPicture.Image = Properties.Resources._17;
                    break;
                case 18:
                    miniPicture.Image = Properties.Resources._18;
                    break;
                case 19:
                    miniPicture.Image = Properties.Resources._19;
                    break;
                case 20:
                    miniPicture.Image = Properties.Resources._20;
                    break;
                default:
                    miniPictureCount = 1;
                    break;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e) // Open Next Page
        {
            mainPage order = new mainPage();
            order.Show(); // Opens the Next Form
            this.Hide(); // Hides the existing Form
        }

        private void landingPage_FormClosed(object sender, FormClosedEventArgs e) // Close all forms when exit and reset the orders
        {
            prerequisite();
            Application.Exit();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.delivery;
            miniPicture.Hide();
            btnOrder.Hide();
            btnDelivery.Hide();
            btnBack.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.aboutUs;
            miniPicture.Hide();
            btnOrder.Hide();
            btnDelivery.Hide();
            btnBack.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.landingPage;
            miniPicture.Show();
            btnOrder.Show();
            btnDelivery.Show();
            btnBack.Hide();
        }

    }
}
