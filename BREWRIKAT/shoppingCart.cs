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
    public partial class shoppingCart : Form
    {

        public bool checkout = false;

        public shoppingCart()
        {
            InitializeComponent();
            CheckOrder();
        }

        private void shoppingCart_FormClosed(object sender, FormClosedEventArgs e) // Close the app entirely when terminated
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e) // Return the page to order form
        {
            mainPage order = new mainPage();
            order.Show();
            this.Hide();
        }

        private void shoppingCart_Load(object sender, EventArgs e)
        {

            string path = @"C:\Brewrikat\Orders\";
            string[] orderNames = { "Banana Muffins.txt", "Brownies.txt", "Chocolate Drink.txt",
            "Clubhouse Sandwich.txt", "Croissant.txt", "Eggdrop Sandwich.txt",
            "Grilled Cheese.txt", "Iced Spanish Latte.txt", "Matcha Green Tea.txt"};

                string Muffins = File.ReadAllText(path + orderNames[0]);
                if (Muffins != "")
                {
                    string[] muffins = Muffins.Split('\n');
                    orders.Rows.Add(muffins[0], muffins[1], muffins[2], muffins[3]);
                }

                string Brownies = File.ReadAllText(path + orderNames[1]);
                if (Brownies != "")
                {
                    string[] brownies = Brownies.Split('\n');
                    orders.Rows.Add(brownies[0], brownies[1], brownies[2], brownies[3]);
                }

                string Chocolate = File.ReadAllText(path + orderNames[2]);
                if (Chocolate != "")
                {
                    string[] chocolate = Chocolate.Split('\n');
                    orders.Rows.Add(chocolate[0], chocolate[1], chocolate[2], chocolate[3]);
                }

                string Clubhouse = File.ReadAllText(path + orderNames[3]);
                if (Clubhouse != "")
                {
                    string[] clubhouse = Clubhouse.Split('\n');
                    orders.Rows.Add(clubhouse[0], clubhouse[1], clubhouse[2], clubhouse[3]);
                }

                string Croissant = File.ReadAllText(path + orderNames[4]);
                if (Croissant != "")
                {
                    string[] croissant = Croissant.Split('\n');
                    orders.Rows.Add(croissant[0], croissant[1], croissant[2], croissant[3]);
                }

                string Eggdrop = File.ReadAllText(path + orderNames[5]);
                if (Eggdrop != "")
                {
                    string[] eggdrop = Eggdrop.Split('\n');
                    orders.Rows.Add(eggdrop[0], eggdrop[1], eggdrop[2], eggdrop[3]);
                }

                string Grilled = File.ReadAllText(path + orderNames[6]);
                if (Grilled != "")
                {
                    string[] grilled = Grilled.Split('\n');
                    orders.Rows.Add(grilled[0], grilled[1], grilled[2], grilled[3]);
                }

                string Latte = File.ReadAllText(path + orderNames[7]);
                if (Latte != "")
                {
                    string[] latte = Latte.Split('\n');
                    orders.Rows.Add(latte[0], latte[1], latte[2], latte[3]);
                }

                string Matcha = File.ReadAllText(path + orderNames[8]);
                if (Matcha != "")
                {
                    string[] matcha = Matcha.Split('\n');
                    orders.Rows.Add(matcha[0], matcha[1], matcha[2], matcha[3]);
                }

            orders.ClearSelection();
            CheckOrder();
            TotalOrder();



        } // Gets Order from Database and Insert it to table

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            mainPage order = new mainPage();
            order.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e) // Remove selected order
        {
            if (orders.Rows.Count != 0 && orders.SelectedRows.Count > 0)
            {
                string path = @"C:\Brewrikat\Orders\";

                int index = orders.SelectedRows[0].Index;
                    var name = orders.Rows[index].Cells[0].Value;
                    File.WriteAllText($"{path}{name}.txt", null);
                    orders.Rows.RemoveAt(index);
                    orders.ClearSelection();

                    CheckOrder();
                    TotalOrder();
            }
        }

        void CheckOrder()
        {
            int numRows = orders.Rows.Count;
            if (numRows == 0)
            {
                lblNoOrder.Show();
                btnTakeOrder.Show();
                btnFinalize.Cursor = Cursors.No;
                checkout = false;
            }
            else if (numRows != 0)
            {
                lblNoOrder.Hide();
                btnTakeOrder.Hide();
                btnFinalize.Cursor = Cursors.Hand;
                checkout = true;
            }
        } // Checks if you have order or not

        void TotalOrder()
        {
            string path = @"C:\Brewrikat\Orders\";

            if (orders.Rows.Count == 0)
            {
                lblPrice.Text = "PHP 0.00";
            }
            int numRows = orders.Rows.Count;
            int _total = 0;
            for (int i = 0; i < numRows; i++)
            {
                var total = orders.Rows[i].Cells[3].Value;
                _total += Convert.ToInt32(total);
                lblPrice.Text = $"PHP {_total}.00";
                File.WriteAllText(path + "Total.txt", _total.ToString());
            }
        } // Computes the total price of the order


        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (checkout)
            {
                orderComplete complete = new orderComplete();
                complete.Show();
                this.Hide();
            }
        } // Finalize Order

    }
}
