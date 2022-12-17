
namespace BREWRIKAT
{
    partial class landingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingPage));
            this.miniPicture = new System.Windows.Forms.PictureBox();
            this.miniPictureDisplay = new System.Windows.Forms.Timer(this.components);
            this.btnDelivery = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.miniPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // miniPicture
            // 
            this.miniPicture.BackColor = System.Drawing.Color.Transparent;
            this.miniPicture.Location = new System.Drawing.Point(732, 499);
            this.miniPicture.Name = "miniPicture";
            this.miniPicture.Size = new System.Drawing.Size(441, 285);
            this.miniPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.miniPicture.TabIndex = 0;
            this.miniPicture.TabStop = false;
            // 
            // miniPictureDisplay
            // 
            this.miniPictureDisplay.Enabled = true;
            this.miniPictureDisplay.Interval = 3000;
            this.miniPictureDisplay.Tick += new System.EventHandler(this.miniPictureDisplay_Tick);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.Transparent;
            this.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivery.Location = new System.Drawing.Point(948, 35);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(177, 43);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Location = new System.Drawing.Point(1156, 45);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(96, 21);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Location = new System.Drawing.Point(469, 565);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(172, 41);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::BREWRIKAT.Properties.Resources.btnBack2;
            this.btnBack.Location = new System.Drawing.Point(1115, 67);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(262, 89);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // landingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BREWRIKAT.Properties.Resources.landingPage;
            this.ClientSize = new System.Drawing.Size(1264, 796);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.miniPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "landingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brewrikat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.landingPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.miniPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox miniPicture;
        private System.Windows.Forms.Timer miniPictureDisplay;
        private System.Windows.Forms.Label btnDelivery;
        private System.Windows.Forms.Label btnAbout;
        private System.Windows.Forms.Label btnOrder;
        private System.Windows.Forms.PictureBox btnBack;
    }
}

