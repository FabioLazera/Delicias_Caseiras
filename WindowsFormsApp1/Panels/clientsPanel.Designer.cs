namespace WindowsFormsApp1.Panels
{
    partial class clientsPanel
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
            this.clientPanel = new System.Windows.Forms.Panel();
            this.calculatorImg = new System.Windows.Forms.PictureBox();
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.gridDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.clientsPImg = new System.Windows.Forms.PictureBox();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.calculatorImg);
            this.clientPanel.Controls.Add(this.clientsGrid);
            this.clientPanel.Controls.Add(this.searchLabel);
            this.clientPanel.Controls.Add(this.searchImg);
            this.clientPanel.Controls.Add(this.separator);
            this.clientPanel.Controls.Add(this.searchTB);
            this.clientPanel.Controls.Add(this.clientsPImg);
            this.clientPanel.Controls.Add(this.clientsLabel);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(824, 768);
            this.clientPanel.TabIndex = 0;
            // 
            // calculatorImg
            // 
            this.calculatorImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculatorImg.Image = global::WindowsFormsApp1.Properties.Resources.calculator;
            this.calculatorImg.Location = new System.Drawing.Point(122, 77);
            this.calculatorImg.Name = "calculatorImg";
            this.calculatorImg.Size = new System.Drawing.Size(65, 65);
            this.calculatorImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calculatorImg.TabIndex = 29;
            this.calculatorImg.TabStop = false;
            this.calculatorImg.Click += new System.EventHandler(this.calculatorImg_Click);
            // 
            // clientsGrid
            // 
            this.clientsGrid.AllowUserToAddRows = false;
            this.clientsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsGrid.BackgroundColor = System.Drawing.Color.White;
            this.clientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.clientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientsGrid.ColumnHeadersHeight = 40;
            this.clientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cPhoneNumber,
            this.cAddress,
            this.cNIF,
            this.gridEdit,
            this.gridDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.clientsGrid.EnableHeadersVisualStyles = false;
            this.clientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clientsGrid.Location = new System.Drawing.Point(35, 204);
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersVisible = false;
            this.clientsGrid.RowHeadersWidth = 51;
            this.clientsGrid.RowTemplate.Height = 28;
            this.clientsGrid.Size = new System.Drawing.Size(755, 535);
            this.clientsGrid.TabIndex = 28;
            this.clientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsGrid_CellClick);
            // 
            // cName
            // 
            this.cName.FillWeight = 125F;
            this.cName.HeaderText = "Name";
            this.cName.MinimumWidth = 125;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cPhoneNumber
            // 
            this.cPhoneNumber.FillWeight = 150F;
            this.cPhoneNumber.HeaderText = "Phone Number";
            this.cPhoneNumber.MinimumWidth = 150;
            this.cPhoneNumber.Name = "cPhoneNumber";
            this.cPhoneNumber.ReadOnly = true;
            // 
            // cAddress
            // 
            this.cAddress.FillWeight = 200F;
            this.cAddress.HeaderText = "Address";
            this.cAddress.MinimumWidth = 200;
            this.cAddress.Name = "cAddress";
            this.cAddress.ReadOnly = true;
            // 
            // cNIF
            // 
            this.cNIF.HeaderText = "NIF";
            this.cNIF.MinimumWidth = 100;
            this.cNIF.Name = "cNIF";
            this.cNIF.ReadOnly = true;
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
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchLabel.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.DimGray;
            this.searchLabel.Location = new System.Drawing.Point(590, 95);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(91, 18);
            this.searchLabel.TabIndex = 27;
            this.searchLabel.Text = "Search Here";
            // 
            // searchImg
            // 
            this.searchImg.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(557, 85);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(29, 27);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImg.TabIndex = 26;
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
            this.separator.TabIndex = 25;
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
            this.searchTB.TabIndex = 24;
            // 
            // clientsPImg
            // 
            this.clientsPImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsPImg.Image = global::WindowsFormsApp1.Properties.Resources.addPerson;
            this.clientsPImg.Location = new System.Drawing.Point(41, 77);
            this.clientsPImg.Name = "clientsPImg";
            this.clientsPImg.Size = new System.Drawing.Size(65, 65);
            this.clientsPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clientsPImg.TabIndex = 23;
            this.clientsPImg.TabStop = false;
            this.clientsPImg.Click += new System.EventHandler(this.clientsPImg_Click);
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.clientsLabel.Location = new System.Drawing.Point(36, 38);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(91, 26);
            this.clientsLabel.TabIndex = 22;
            this.clientsLabel.Text = "Clients";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::WindowsFormsApp1.Properties.Resources.recycle;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // clientsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.Controls.Add(this.clientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientsPanel";
            this.Text = "clientsPanel";
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
        public System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.Label separator;
        public System.Windows.Forms.TextBox searchTB;
        public System.Windows.Forms.PictureBox clientsPImg;
        private System.Windows.Forms.Label clientsLabel;
        public System.Windows.Forms.PictureBox calculatorImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNIF;
        private System.Windows.Forms.DataGridViewImageColumn gridEdit;
        private System.Windows.Forms.DataGridViewImageColumn gridDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}