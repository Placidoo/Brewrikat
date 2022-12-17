
namespace BREWRIKAT
{
    partial class shoppingCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shoppingCart));
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnFinalize = new System.Windows.Forms.PictureBox();
            this.orders = new System.Windows.Forms.DataGridView();
            this.orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.lblNoOrder = new System.Windows.Forms.Label();
            this.btnTakeOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTakeOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::BREWRIKAT.Properties.Resources.btnBack;
            this.btnBack.Location = new System.Drawing.Point(-52, 151);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 89);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalize.Image = global::BREWRIKAT.Properties.Resources.btnFinalize;
            this.btnFinalize.Location = new System.Drawing.Point(978, 12);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(368, 89);
            this.btnFinalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnFinalize.TabIndex = 0;
            this.btnFinalize.TabStop = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // orders
            // 
            this.orders.AllowUserToAddRows = false;
            this.orders.AllowUserToDeleteRows = false;
            this.orders.AllowUserToResizeColumns = false;
            this.orders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(202)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(226)))));
            this.orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.orders.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(93)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(93)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orders.ColumnHeadersHeight = 50;
            this.orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderName,
            this.orderQuantity,
            this.orderPrice,
            this.orderTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(202)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orders.DefaultCellStyle = dataGridViewCellStyle3;
            this.orders.EnableHeadersVisualStyles = false;
            this.orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(226)))));
            this.orders.Location = new System.Drawing.Point(115, 256);
            this.orders.Name = "orders";
            this.orders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.orders.RowHeadersVisible = false;
            this.orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(232)))), ((int)(((byte)(226)))));
            this.orders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.orders.RowTemplate.Height = 35;
            this.orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orders.ShowEditingIcon = false;
            this.orders.Size = new System.Drawing.Size(1103, 308);
            this.orders.TabIndex = 1;
            // 
            // orderName
            // 
            this.orderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderName.HeaderText = "Order Name";
            this.orderName.Name = "orderName";
            this.orderName.ReadOnly = true;
            this.orderName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.orderName.Width = 350;
            // 
            // orderQuantity
            // 
            this.orderQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderQuantity.HeaderText = "Quantity";
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.ReadOnly = true;
            this.orderQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.orderQuantity.Width = 200;
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderPrice.HeaderText = "Price";
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.ReadOnly = true;
            this.orderPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderTotal.HeaderText = "Total";
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.ReadOnly = true;
            this.orderTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.lblPrice.Location = new System.Drawing.Point(195, 647);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(195, 54);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "PHP 0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(202)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(148, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 10);
            this.panel1.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.lblTotal.Location = new System.Drawing.Point(199, 617);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 30);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Image = global::BREWRIKAT.Properties.Resources.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(935, 647);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(243, 65);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRemove.TabIndex = 7;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblNoOrder
            // 
            this.lblNoOrder.AutoSize = true;
            this.lblNoOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblNoOrder.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(70)))));
            this.lblNoOrder.Location = new System.Drawing.Point(485, 375);
            this.lblNoOrder.Name = "lblNoOrder";
            this.lblNoOrder.Size = new System.Drawing.Size(379, 54);
            this.lblNoOrder.TabIndex = 5;
            this.lblNoOrder.Text = "You have no Order.";
            this.lblNoOrder.Visible = false;
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnTakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeOrder.Image = global::BREWRIKAT.Properties.Resources.btnTakeOrder;
            this.btnTakeOrder.Location = new System.Drawing.Point(557, 432);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(243, 65);
            this.btnTakeOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnTakeOrder.TabIndex = 8;
            this.btnTakeOrder.TabStop = false;
            this.btnTakeOrder.Visible = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // shoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BREWRIKAT.Properties.Resources.shoppingCart;
            this.ClientSize = new System.Drawing.Size(1264, 796);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNoOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "shoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brewrikat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.shoppingCart_FormClosed);
            this.Load += new System.EventHandler(this.shoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTakeOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnFinalize;
        private System.Windows.Forms.DataGridView orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox btnRemove;
        private System.Windows.Forms.Label lblNoOrder;
        private System.Windows.Forms.PictureBox btnTakeOrder;
    }
}