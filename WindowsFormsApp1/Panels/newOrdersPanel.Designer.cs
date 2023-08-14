namespace WindowsFormsApp1
{
    partial class newOrdersPanel
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
            this.newOrderPanel = new System.Windows.Forms.Panel();
            this.checkoutGrid = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.drinksBtn = new System.Windows.Forms.Button();
            this.dishesBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.noID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrderPanel
            // 
            this.newOrderPanel.Controls.Add(this.checkoutGrid);
            this.newOrderPanel.Controls.Add(this.searchLabel);
            this.newOrderPanel.Controls.Add(this.searchImg);
            this.newOrderPanel.Controls.Add(this.searchTB);
            this.newOrderPanel.Controls.Add(this.flowLayoutPanel1);
            this.newOrderPanel.Controls.Add(this.drinksBtn);
            this.newOrderPanel.Controls.Add(this.dishesBtn);
            this.newOrderPanel.Controls.Add(this.panel2);
            this.newOrderPanel.Controls.Add(this.panel1);
            this.newOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.newOrderPanel.Name = "newOrderPanel";
            this.newOrderPanel.Size = new System.Drawing.Size(1024, 768);
            this.newOrderPanel.TabIndex = 0;
            // 
            // checkoutGrid
            // 
            this.checkoutGrid.AllowUserToAddRows = false;
            this.checkoutGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkoutGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.checkoutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkoutGrid.BackgroundColor = System.Drawing.Color.White;
            this.checkoutGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkoutGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.checkoutGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkoutGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.checkoutGrid.ColumnHeadersHeight = 40;
            this.checkoutGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noID,
            this.noProduct,
            this.noQty,
            this.noPrice,
            this.noAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkoutGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.checkoutGrid.EnableHeadersVisualStyles = false;
            this.checkoutGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.checkoutGrid.Location = new System.Drawing.Point(610, 177);
            this.checkoutGrid.Name = "checkoutGrid";
            this.checkoutGrid.ReadOnly = true;
            this.checkoutGrid.RowHeadersVisible = false;
            this.checkoutGrid.RowHeadersWidth = 51;
            this.checkoutGrid.RowTemplate.Height = 24;
            this.checkoutGrid.Size = new System.Drawing.Size(414, 521);
            this.checkoutGrid.TabIndex = 31;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchLabel.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.DimGray;
            this.searchLabel.Location = new System.Drawing.Point(57, 177);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(91, 18);
            this.searchLabel.TabIndex = 30;
            this.searchLabel.Text = "Search Here";
            // 
            // searchImg
            // 
            this.searchImg.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(24, 167);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(29, 27);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImg.TabIndex = 29;
            this.searchImg.TabStop = false;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(24, 198);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(162, 30);
            this.searchTB.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 521);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // drinksBtn
            // 
            this.drinksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(129)))));
            this.drinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinksBtn.ForeColor = System.Drawing.Color.White;
            this.drinksBtn.Location = new System.Drawing.Point(24, 322);
            this.drinksBtn.Name = "drinksBtn";
            this.drinksBtn.Size = new System.Drawing.Size(162, 45);
            this.drinksBtn.TabIndex = 3;
            this.drinksBtn.Text = "Drinks";
            this.drinksBtn.UseVisualStyleBackColor = false;
            // 
            // dishesBtn
            // 
            this.dishesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(129)))));
            this.dishesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishesBtn.ForeColor = System.Drawing.Color.White;
            this.dishesBtn.Location = new System.Drawing.Point(24, 254);
            this.dishesBtn.Name = "dishesBtn";
            this.dishesBtn.Size = new System.Drawing.Size(162, 45);
            this.dishesBtn.TabIndex = 2;
            this.dishesBtn.Text = "Dishes";
            this.dishesBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.checkoutBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 699);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 69);
            this.panel2.TabIndex = 1;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(187)))), ((int)(((byte)(101)))));
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Location = new System.Drawing.Point(850, 12);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(162, 45);
            this.checkoutBtn.TabIndex = 31;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 110);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(971, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.shoppingCart;
            this.pictureBox1.Location = new System.Drawing.Point(27, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // noID
            // 
            this.noID.FillWeight = 40F;
            this.noID.HeaderText = "ID";
            this.noID.MinimumWidth = 40;
            this.noID.Name = "noID";
            this.noID.ReadOnly = true;
            // 
            // noProduct
            // 
            this.noProduct.FillWeight = 80F;
            this.noProduct.HeaderText = "Product";
            this.noProduct.MinimumWidth = 80;
            this.noProduct.Name = "noProduct";
            this.noProduct.ReadOnly = true;
            // 
            // noQty
            // 
            this.noQty.FillWeight = 40F;
            this.noQty.HeaderText = "Qty";
            this.noQty.MinimumWidth = 40;
            this.noQty.Name = "noQty";
            this.noQty.ReadOnly = true;
            // 
            // noPrice
            // 
            this.noPrice.FillWeight = 70F;
            this.noPrice.HeaderText = "Price";
            this.noPrice.MinimumWidth = 70;
            this.noPrice.Name = "noPrice";
            this.noPrice.ReadOnly = true;
            // 
            // noAmount
            // 
            this.noAmount.FillWeight = 70F;
            this.noAmount.HeaderText = "Amount";
            this.noAmount.MinimumWidth = 70;
            this.noAmount.Name = "noAmount";
            this.noAmount.ReadOnly = true;
            // 
            // newOrdersPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.newOrderPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newOrdersPanel";
            this.Text = "newOrdersPanel";
            this.newOrderPanel.ResumeLayout(false);
            this.newOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel newOrderPanel;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button drinksBtn;
        private System.Windows.Forms.Button dishesBtn;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox searchImg;
        public System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button checkoutBtn;
        public System.Windows.Forms.DataGridView checkoutGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn noID;
        private System.Windows.Forms.DataGridViewTextBoxColumn noProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn noQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn noAmount;
    }
}