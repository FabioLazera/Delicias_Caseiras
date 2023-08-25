namespace WindowsFormsApp1.Panels
{
    partial class ordersPanel
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
            this.orderPanel = new System.Windows.Forms.Panel();
            this.plusDay = new System.Windows.Forms.PictureBox();
            this.plusHour = new System.Windows.Forms.PictureBox();
            this.printer = new System.Windows.Forms.PictureBox();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.ordersPImg = new System.Windows.Forms.PictureBox();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.oID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oForecast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plusDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.plusDay);
            this.orderPanel.Controls.Add(this.plusHour);
            this.orderPanel.Controls.Add(this.printer);
            this.orderPanel.Controls.Add(this.ordersGrid);
            this.orderPanel.Controls.Add(this.searchLabel);
            this.orderPanel.Controls.Add(this.searchImg);
            this.orderPanel.Controls.Add(this.separator);
            this.orderPanel.Controls.Add(this.searchTB);
            this.orderPanel.Controls.Add(this.ordersPImg);
            this.orderPanel.Controls.Add(this.ordersLabel);
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPanel.Location = new System.Drawing.Point(0, 0);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(824, 768);
            this.orderPanel.TabIndex = 0;
            // 
            // plusDay
            // 
            this.plusDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusDay.Image = global::WindowsFormsApp1.Properties.Resources.tomorrow;
            this.plusDay.Location = new System.Drawing.Point(118, 691);
            this.plusDay.Name = "plusDay";
            this.plusDay.Size = new System.Drawing.Size(65, 65);
            this.plusDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plusDay.TabIndex = 40;
            this.plusDay.TabStop = false;
            this.plusDay.Click += new System.EventHandler(this.plusDay_Click);
            // 
            // plusHour
            // 
            this.plusHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusHour.Image = global::WindowsFormsApp1.Properties.Resources._15minutes;
            this.plusHour.Location = new System.Drawing.Point(38, 691);
            this.plusHour.Name = "plusHour";
            this.plusHour.Size = new System.Drawing.Size(65, 65);
            this.plusHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plusHour.TabIndex = 39;
            this.plusHour.TabStop = false;
            this.plusHour.Click += new System.EventHandler(this.plusHour_Click);
            // 
            // printer
            // 
            this.printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printer.Image = global::WindowsFormsApp1.Properties.Resources.printer;
            this.printer.Location = new System.Drawing.Point(725, 691);
            this.printer.Name = "printer";
            this.printer.Size = new System.Drawing.Size(65, 65);
            this.printer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printer.TabIndex = 37;
            this.printer.TabStop = false;
            this.printer.Click += new System.EventHandler(this.printer_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.AllowUserToAddRows = false;
            this.ordersGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGrid.BackgroundColor = System.Drawing.Color.White;
            this.ordersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ordersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ordersGrid.ColumnHeadersHeight = 40;
            this.ordersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oID,
            this.oClient,
            this.oStatus,
            this.oType,
            this.oTime,
            this.oForecast,
            this.oAmount,
            this.gridDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordersGrid.EnableHeadersVisualStyles = false;
            this.ordersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ordersGrid.Location = new System.Drawing.Point(35, 204);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.ReadOnly = true;
            this.ordersGrid.RowHeadersVisible = false;
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowTemplate.Height = 32;
            this.ordersGrid.Size = new System.Drawing.Size(755, 470);
            this.ordersGrid.TabIndex = 35;
            this.ordersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGrid_CellClick);
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
            this.searchLabel.TabIndex = 34;
            this.searchLabel.Text = "Search Here";
            // 
            // searchImg
            // 
            this.searchImg.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(557, 85);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(29, 27);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImg.TabIndex = 33;
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
            this.separator.TabIndex = 32;
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
            this.searchTB.TabIndex = 31;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // ordersPImg
            // 
            this.ordersPImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersPImg.Image = global::WindowsFormsApp1.Properties.Resources.addBasket;
            this.ordersPImg.Location = new System.Drawing.Point(41, 77);
            this.ordersPImg.Name = "ordersPImg";
            this.ordersPImg.Size = new System.Drawing.Size(65, 65);
            this.ordersPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ordersPImg.TabIndex = 30;
            this.ordersPImg.TabStop = false;
            this.ordersPImg.Click += new System.EventHandler(this.ordersPImg_Click);
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.ordersLabel.Location = new System.Drawing.Point(36, 38);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(88, 26);
            this.ordersLabel.TabIndex = 29;
            this.ordersLabel.Text = "Orders";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.recycle;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // oID
            // 
            this.oID.FillWeight = 50F;
            this.oID.HeaderText = "Nr.";
            this.oID.MinimumWidth = 50;
            this.oID.Name = "oID";
            this.oID.ReadOnly = true;
            // 
            // oClient
            // 
            this.oClient.FillWeight = 125F;
            this.oClient.HeaderText = "Client";
            this.oClient.MinimumWidth = 125;
            this.oClient.Name = "oClient";
            this.oClient.ReadOnly = true;
            // 
            // oStatus
            // 
            this.oStatus.FillWeight = 175F;
            this.oStatus.HeaderText = "Status";
            this.oStatus.MinimumWidth = 175;
            this.oStatus.Name = "oStatus";
            this.oStatus.ReadOnly = true;
            this.oStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // oType
            // 
            this.oType.HeaderText = "Type";
            this.oType.MinimumWidth = 100;
            this.oType.Name = "oType";
            this.oType.ReadOnly = true;
            // 
            // oTime
            // 
            this.oTime.FillWeight = 175F;
            this.oTime.HeaderText = "Order Time";
            this.oTime.MinimumWidth = 175;
            this.oTime.Name = "oTime";
            this.oTime.ReadOnly = true;
            // 
            // oForecast
            // 
            this.oForecast.FillWeight = 175F;
            this.oForecast.HeaderText = "Next Stage";
            this.oForecast.MinimumWidth = 175;
            this.oForecast.Name = "oForecast";
            this.oForecast.ReadOnly = true;
            // 
            // oAmount
            // 
            this.oAmount.HeaderText = "Amount(€)";
            this.oAmount.MinimumWidth = 100;
            this.oAmount.Name = "oAmount";
            this.oAmount.ReadOnly = true;
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
            // ordersPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.Controls.Add(this.orderPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ordersPanel";
            this.Text = "ordersPanel";
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plusDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel orderPanel;
        public System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.Label separator;
        public System.Windows.Forms.TextBox searchTB;
        public System.Windows.Forms.PictureBox ordersPImg;
        private System.Windows.Forms.Label ordersLabel;
        public System.Windows.Forms.PictureBox printer;
        public System.Windows.Forms.PictureBox plusHour;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.PictureBox plusDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn oID;
        private System.Windows.Forms.DataGridViewTextBoxColumn oClient;
        private System.Windows.Forms.DataGridViewButtonColumn oStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn oType;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn oForecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn oAmount;
        private System.Windows.Forms.DataGridViewImageColumn gridDelete;
    }
}