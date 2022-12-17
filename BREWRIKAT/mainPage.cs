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
    public partial class mainPage : Form
    {
        // Variables
        public int orderQuantity = 1;
        public int page = 1;
        public int orderPrice;
        public int orderTotal;
        public string orderName;

        public mainPage()
        {
            InitializeComponent();
            orderDisplay.Image = null;
            this.Opacity = 0;
            bootAnimation.Enabled = true;
        }

        private void bootAnimation_Tick(object sender, EventArgs e) // Boot Animation Purpose
        {
            this.Opacity += 0.1;
            if (this.Opacity == 1)
            {
                bootAnimation.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // Return to Landing Page
        {
            landingPage mainMenu = new landingPage();
            mainMenu.Show(); // Opens another form
            this.Hide(); // Close the existing form
        }

        private void btnCart_Click(object sender, EventArgs e) // Open Cart Page
        {
            shoppingCart cart = new shoppingCart();
            cart.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e) // Open Finalize Order Page
        {
            shoppingCart cart = new shoppingCart();
            cart.Show();
            this.Hide();
        }

        private void btnCheck_MouseHover(object sender, EventArgs e)
        {
            btnCheck.Image = Properties.Resources.btnFinalize;
            btnCheck.Location = new Point(185, 658);
        } // Check Button Animation

        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.Image = Properties.Resources.btnCheck;
            btnCheck.Location = new Point(360, 658);
        } // Check Button Animation

        private void btnCoffee_Click(object sender, EventArgs e) // Chooses Coffee tab
        {
            page = 1;
            tabLine.Location = new Point(90, 65);
            order1.Image = Properties.Resources.orderChocolateDrink;
            order2.Image = Properties.Resources.orderMatcha;
            order3.Image = Properties.Resources.orderLatte;
            Reset();
        }

        private void btnBread_Click(object sender, EventArgs e) // Chooses Bread and Pastries tab
        {
            page = 2;
            tabLine.Location = new Point(343, 65);
            order1.Image = Properties.Resources.orderMuffins;
            order2.Image = Properties.Resources.orderCroissant;
            order3.Image = Properties.Resources.orderBrownies;
            Reset();
        }

        private void btnSandwich_Click(object sender, EventArgs e) // Chooses Sandwich tab
        {
            page = 3;
            tabLine.Location = new Point(599, 65);
            order1.Image = Properties.Resources.orderEggdrop;
            order2.Image = Properties.Resources.orderClubhouse;
            order3.Image = Properties.Resources.orderGrilledSandwich;
            Reset();
        }

        void Reset() // Reset the Price, Quantity, and Display Image
        {
            orderDisplay.Image = null;
            orderPrice = 0;
            orderQuantity = 1;
            orderName = null;
            lblResult.Hide();
        }

        private void order1_Click(object sender, EventArgs e)
        {
            Reset();
            switch (page)
            {
                case 1:
                    orderDisplay.Image = Properties.Resources.chocolateDrink;
                    orderName = "Chocolate Drink";
                    orderPrice = 60;
                    break;
                case 2:
                    orderDisplay.Image = Properties.Resources.bananaMuffins;
                    orderName = "Banana Muffins";
                    orderPrice = 10;
                    break;
                case 3:
                    orderDisplay.Image = Properties.Resources.eggdrop;
                    orderName = "Eggdrop Sandwich";
                    orderPrice = 50;
                    break;
            }
        } // Clicking orders display a picture and set price

        private void order2_Click(object sender, EventArgs e)
        {
            Reset();
            switch (page)
            {
                case 1:
                    orderDisplay.Image = Properties.Resources.matchaTea;
                    orderName = "Matcha Green Tea";
                    orderPrice = 75;
                    break;
                case 2:
                    orderDisplay.Image = Properties.Resources.croissant;
                    orderName = "Croissant";
                    orderPrice = 30;
                    break;
                case 3:
                    orderDisplay.Image = Properties.Resources.clubhouse;
                    orderName = "Clubhouse Sandwich";
                    orderPrice = 60;
                    break;
            }
        }

        private void order3_Click(object sender, EventArgs e)
        {
            Reset();
            switch (page)
            {
                case 1:
                    orderDisplay.Image = Properties.Resources.icedSpanish;
                    orderName = "Iced Spanish Latte";
                    orderPrice = 80;
                    break;
                case 2:
                    orderDisplay.Image = Properties.Resources.brownies;
                    orderName = "Brownies";
                    orderPrice = 25;
                    break;
                case 3:
                    orderDisplay.Image = Properties.Resources.grilledSandwich;
                    orderName = "Grilled Cheese";
                    orderPrice = 40;
                    break;
            }
        }

        private void priceUpdater_Tick(object sender, EventArgs e) // Updates the total Price and Quantity all the time
        {
            lblQuantity.Text = orderQuantity.ToString();
            orderTotal = orderPrice * orderQuantity;
            lblPrice.Text = "PHP " + orderTotal + ".00";
        }

        private void btnAdd_Click(object sender, EventArgs e) // Add Quantity
        {
            orderQuantity++;
        }

        private void btnMinus_Click(object sender, EventArgs e) // Reduce Quantity
        {
            if (orderQuantity != 1)
            {
                orderQuantity--;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (orderName != null)
            {
                string path = @"C:\Brewrikat\Orders\";
                File.WriteAllText(path + orderName + ".txt", $"{orderName}\n{orderQuantity}\n{orderPrice}\n{orderTotal}");
                Reset();
                System.Threading.Thread.Sleep(200);
                lblResult.Show();
            }
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e) // Close the app entirely when terminated
        {
            Application.Exit();
        }

    }
}
