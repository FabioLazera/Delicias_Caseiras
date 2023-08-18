namespace WindowsFormsApp1.Panels
{
    partial class dishesPanel
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
            this.dishPanel = new System.Windows.Forms.Panel();
            this.dishesGrid = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.dishesPImg = new System.Windows.Forms.PictureBox();
            this.dishesLabel = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.gridDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dishPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dishPanel
            // 
            this.dishPanel.Controls.Add(this.dishesGrid);
            this.dishPanel.Controls.Add(this.searchLabel);
            this.dishPanel.Controls.Add(this.searchImg);
            this.dishPanel.Controls.Add(this.separator);
            this.dishPanel.Controls.Add(this.searchTB);
            this.dishPanel.Controls.Add(this.dishesPImg);
            this.dishPanel.Controls.Add(this.dishesLabel);
            this.dishPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishPanel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishPanel.Location = new System.Drawing.Point(0, 0);
            this.dishPanel.Name = "dishPanel";
            this.dishPanel.Size = new System.Drawing.Size(824, 768);
            this.dishPanel.TabIndex = 0;
            // 
            // dishesGrid
            // 
            this.dishesGrid.AllowUserToAddRows = false;
            this.dishesGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dishesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dishesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishesGrid.BackgroundColor = System.Drawing.Color.White;
            this.dishesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dishesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dishesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dishesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dishesGrid.ColumnHeadersHeight = 40;
            this.dishesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dName,
            this.dDescription,
            this.dPrice,
            this.dStock,
            this.gridEdit,
            this.gridDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dishesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dishesGrid.EnableHeadersVisualStyles = false;
            this.dishesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dishesGrid.Location = new System.Drawing.Point(35, 204);
            this.dishesGrid.Name = "dishesGrid";
            this.dishesGrid.ReadOnly = true;
            this.dishesGrid.RowHeadersVisible = false;
            this.dishesGrid.RowHeadersWidth = 51;
            this.dishesGrid.RowTemplate.Height = 24;
            this.dishesGrid.Size = new System.Drawing.Size(755, 535);
            this.dishesGrid.TabIndex = 42;
            this.dishesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishesGrid_CellClick);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchLabel.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.DimGray;
            this.searchLabel.Location = new System.Drawing.Point(590, 95);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(91, 18);
            this.searchLabel.TabIndex = 41;
            this.searchLabel.Text = "Search Here";
            // 
            // searchImg
            // 
            this.searchImg.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(557, 85);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(29, 27);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImg.TabIndex = 40;
            this.searchImg.TabStop = false;
            // 
            // separator
            // 
            this.separator.AutoSize = true;
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.separator.Location = new System.Drawing.Point(34, 163);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(855, 20);
            this.separator.TabIndex = 39;
            this.separator.Text = "_________________________________________________________________________________" +
    "_____________";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(557, 115);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(230, 30);
            this.searchTB.TabIndex = 38;
            // 
            // dishesPImg
            // 
            this.dishesPImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dishesPImg.Image = global::WindowsFormsApp1.Properties.Resources.addStock;
            this.dishesPImg.Location = new System.Drawing.Point(41, 77);
            this.dishesPImg.Name = "dishesPImg";
            this.dishesPImg.Size = new System.Drawing.Size(65, 65);
            this.dishesPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dishesPImg.TabIndex = 37;
            this.dishesPImg.TabStop = false;
            this.dishesPImg.Click += new System.EventHandler(this.dishesPImg_Click);
            // 
            // dishesLabel
            // 
            this.dishesLabel.AutoSize = true;
            this.dishesLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.dishesLabel.Location = new System.Drawing.Point(36, 38);
            this.dishesLabel.Name = "dishesLabel";
            this.dishesLabel.Size = new System.Drawing.Size(88, 26);
            this.dishesLabel.TabIndex = 36;
            this.dishesLabel.Text = "Dishes";
            // 
            // dName
            // 
            this.dName.FillWeight = 125F;
            this.dName.HeaderText = "Name";
            this.dName.MinimumWidth = 125;
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
            // 
            // dDescription
            // 
            this.dDescription.FillWeight = 200F;
            this.dDescription.HeaderText = "Description";
            this.dDescription.MinimumWidth = 200;
            this.dDescription.Name = "dDescription";
            this.dDescription.ReadOnly = true;
            // 
            // dPrice
            // 
            this.dPrice.HeaderText = "Price";
            this.dPrice.MinimumWidth = 100;
            this.dPrice.Name = "dPrice";
            this.dPrice.ReadOnly = true;
            // 
            // dStock
            // 
            this.dStock.HeaderText = "Stock";
            this.dStock.MinimumWidth = 100;
            this.dStock.Name = "dStock";
            this.dStock.ReadOnly = true;
            // 
            // gridEdit
            // 
            this.gridEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gridEdit.FillWeight = 50F;
            this.gridEdit.HeaderText = "";
            this.gridEdit.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.gridEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.gridEdit.MinimumWidth = 50;
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.ReadOnly = true;
            this.gridEdit.Width = 50;
            // 
            // gridDelete
            // 
            this.gridDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gridDelete.FillWeight = 50F;
            this.gridDelete.HeaderText = "";
            this.gridDelete.Image = global::WindowsFormsApp1.Properties.Resources.recycle;
            this.gridDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.gridDelete.MinimumWidth = 50;
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.ReadOnly = true;
            this.gridDelete.Width = 50;
            // 
            // dishesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.Controls.Add(this.dishPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dishesPanel";
            this.Text = "dishesPanel";
            this.dishPanel.ResumeLayout(false);
            this.dishPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesPImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel dishPanel;
        public System.Windows.Forms.DataGridView dishesGrid;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.Label separator;
        public System.Windows.Forms.TextBox searchTB;
        public System.Windows.Forms.PictureBox dishesPImg;
        private System.Windows.Forms.Label dishesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dStock;
        private System.Windows.Forms.DataGridViewImageColumn gridEdit;
        private System.Windows.Forms.DataGridViewImageColumn gridDelete;
    }
}