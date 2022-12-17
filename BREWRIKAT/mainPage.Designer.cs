
namespace BREWRIKAT
{
    partial class mainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnCart = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.PictureBox();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.btnMinus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.order3 = new System.Windows.Forms.PictureBox();
            this.order2 = new System.Windows.Forms.PictureBox();
            this.order1 = new System.Windows.Forms.PictureBox();
            this.btnSandwich = new System.Windows.Forms.Label();
            this.btnBread = new System.Windows.Forms.Label();
            this.btnCoffee = new System.Windows.Forms.Label();
            this.tabLine = new System.Windows.Forms.PictureBox();
            this.orderDisplay = new System.Windows.Forms.PictureBox();
            this.priceUpdater = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.bootAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::BREWRIKAT.Properties.Resources.btnBack;
            this.btnBack.Location = new System.Drawing.Point(-71, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 89);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Image = global::BREWRIKAT.Properties.Resources.btnCart;
            this.btnCart.Location = new System.Drawing.Point(-58, 658);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(172, 89);
            this.btnCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCart.TabIndex = 0;
            this.btnCart.TabStop = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Image = global::BREWRIKAT.Properties.Resources.btnCheck;
            this.btnCheck.Location = new System.Drawing.Point(360, 658);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(172, 89);
            this.btnCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCheck.TabIndex = 0;
            this.btnCheck.TabStop = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.btnCheck_MouseHover);
            this.btnCheck.MouseLeave += new System.EventHandler(this.btnCheck_MouseLeave);
            this.btnCheck.MouseHover += new System.EventHandler(this.btnCheck_MouseHover);
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOrder.Controls.Add(this.btnMinus);
            this.panelOrder.Controls.Add(this.btnAdd);
            this.panelOrder.Controls.Add(this.lblQuantity);
            this.panelOrder.Controls.Add(this.btnPlaceOrder);
            this.panelOrder.Controls.Add(this.lblPrice);
            this.panelOrder.Controls.Add(this.order3);
            this.panelOrder.Controls.Add(this.order2);
            this.panelOrder.Controls.Add(this.order1);
            this.panelOrder.Controls.Add(this.btnSandwich);
            this.panelOrder.Controls.Add(this.btnBread);
            this.panelOrder.Controls.Add(this.btnCoffee);
            this.panelOrder.Controls.Add(this.tabLine);
            this.panelOrder.Location = new System.Drawing.Point(465, 102);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(787, 697);
            this.panelOrder.TabIndex = 1;
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Location = new System.Drawing.Point(78, 625);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(32, 30);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(182, 625);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.lblQuantity.Location = new System.Drawing.Point(77, 625);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(139, 30);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.btnPlaceOrder.Location = new System.Drawing.Point(470, 619);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(227, 45);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.lblPrice.Location = new System.Drawing.Point(461, 565);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(195, 54);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "PHP 0.00";
            // 
            // order3
            // 
            this.order3.BackColor = System.Drawing.Color.Transparent;
            this.order3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order3.Image = global::BREWRIKAT.Properties.Resources.orderLatte;
            this.order3.Location = new System.Drawing.Point(45, 414);
            this.order3.Name = "order3";
            this.order3.Size = new System.Drawing.Size(692, 128);
            this.order3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.order3.TabIndex = 2;
            this.order3.TabStop = false;
            this.order3.Click += new System.EventHandler(this.order3_Click);
            // 
            // order2
            // 
            this.order2.BackColor = System.Drawing.Color.Transparent;
            this.order2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order2.Image = global::BREWRIKAT.Properties.Resources.orderMatcha;
            this.order2.Location = new System.Drawing.Point(45, 274);
            this.order2.Name = "order2";
            this.order2.Size = new System.Drawing.Size(692, 128);
            this.order2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.order2.TabIndex = 2;
            this.order2.TabStop = false;
            this.order2.Click += new System.EventHandler(this.order2_Click);
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.Transparent;
            this.order1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order1.Image = global::BREWRIKAT.Properties.Resources.orderChocolateDrink;
            this.order1.Location = new System.Drawing.Point(45, 134);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(692, 128);
            this.order1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.order1.TabIndex = 2;
            this.order1.TabStop = false;
            this.order1.Click += new System.EventHandler(this.order1_Click);
            // 
            // btnSandwich
            // 
            this.btnSandwich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSandwich.Location = new System.Drawing.Point(578, 26);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(146, 36);
            this.btnSandwich.TabIndex = 3;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // btnBread
            // 
            this.btnBread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBread.Location = new System.Drawing.Point(286, 26);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(216, 36);
            this.btnBread.TabIndex = 3;
            this.btnBread.Click += new System.EventHandler(this.btnBread_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoffee.Location = new System.Drawing.Point(103, 26);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(76, 36);
            this.btnCoffee.TabIndex = 3;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // tabLine
            // 
            this.tabLine.BackColor = System.Drawing.Color.Transparent;
            this.tabLine.Image = global::BREWRIKAT.Properties.Resources.tabLine;
            this.tabLine.Location = new System.Drawing.Point(90, 65);
            this.tabLine.Name = "tabLine";
            this.tabLine.Size = new System.Drawing.Size(107, 2);
            this.tabLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tabLine.TabIndex = 2;
            this.tabLine.TabStop = false;
            // 
            // orderDisplay
            // 
            this.orderDisplay.BackColor = System.Drawing.Color.Transparent;
            this.orderDisplay.Image = global::BREWRIKAT.Properties.Resources.chocolateDrink;
            this.orderDisplay.Location = new System.Drawing.Point(-24, 167);
            this.orderDisplay.Name = "orderDisplay";
            this.orderDisplay.Size = new System.Drawing.Size(535, 519);
            this.orderDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderDisplay.TabIndex = 2;
            this.orderDisplay.TabStop = false;
            // 
            // priceUpdater
            // 
            this.priceUpdater.Enabled = true;
            this.priceUpdater.Tick += new System.EventHandler(this.priceUpdater_Tick);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.lblResult.Location = new System.Drawing.Point(-1, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(460, 488);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "ORDER\r\nCOMPLETE";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // bootAnimation
            // 
            this.bootAnimation.Tick += new System.EventHandler(this.bootAnimation_Tick);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BREWRIKAT.Properties.Resources.mainPage;
            this.ClientSize = new System.Drawing.Size(1264, 796);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.orderDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brewrikat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnCart;
        private System.Windows.Forms.PictureBox btnCheck;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.PictureBox tabLine;
        private System.Windows.Forms.Label btnSandwich;
        private System.Windows.Forms.Label btnBread;
        private System.Windows.Forms.Label btnCoffee;
        private System.Windows.Forms.PictureBox order3;
        private System.Windows.Forms.PictureBox order2;
        private System.Windows.Forms.PictureBox order1;
        private System.Windows.Forms.PictureBox orderDisplay;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Timer priceUpdater;
        private System.Windows.Forms.Label btnMinus;
        private System.Windows.Forms.Label btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label btnPlaceOrder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer bootAnimation;
    }
}