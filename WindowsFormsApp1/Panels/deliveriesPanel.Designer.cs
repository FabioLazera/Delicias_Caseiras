namespace WindowsFormsApp1
{
    partial class deliveriesPanel
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
            this.deliveryPanel = new System.Windows.Forms.Panel();
            this.deliveriesGrid = new System.Windows.Forms.DataGridView();
            this.separator = new System.Windows.Forms.Label();
            this.deliveriesPImg = new System.Windows.Forms.PictureBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dForecast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dExpected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryPanel
            // 
            this.deliveryPanel.Controls.Add(this.deliveriesGrid);
            this.deliveryPanel.Controls.Add(this.separator);
            this.deliveryPanel.Controls.Add(this.deliveriesPImg);
            this.deliveryPanel.Controls.Add(this.deliveryLabel);
            this.deliveryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryPanel.Location = new System.Drawing.Point(0, 0);
            this.deliveryPanel.Name = "deliveryPanel";
            this.deliveryPanel.Size = new System.Drawing.Size(824, 768);
            this.deliveryPanel.TabIndex = 0;
            // 
            // deliveriesGrid
            // 
            this.deliveriesGrid.AllowUserToAddRows = false;
            this.deliveriesGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deliveriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deliveriesGrid.BackgroundColor = System.Drawing.Color.White;
            this.deliveriesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveriesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deliveriesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.deliveriesGrid.ColumnHeadersHeight = 40;
            this.deliveriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.dClient,
            this.dStatus,
            this.dTime,
            this.dForecast,
            this.dExpected,
            this.dAddress,
            this.dContact});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveriesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.deliveriesGrid.EnableHeadersVisualStyles = false;
            this.deliveriesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deliveriesGrid.Location = new System.Drawing.Point(35, 204);
            this.deliveriesGrid.Name = "deliveriesGrid";
            this.deliveriesGrid.ReadOnly = true;
            this.deliveriesGrid.RowHeadersVisible = false;
            this.deliveriesGrid.RowHeadersWidth = 51;
            this.deliveriesGrid.RowTemplate.Height = 32;
            this.deliveriesGrid.Size = new System.Drawing.Size(755, 535);
            this.deliveriesGrid.TabIndex = 48;
            this.deliveriesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveriesGrid_CellContentClick);
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
            this.separator.TabIndex = 45;
            this.separator.Text = "_________________________________________________________________________________" +
    "_____________";
            // 
            // deliveriesPImg
            // 
            this.deliveriesPImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveriesPImg.Image = global::WindowsFormsApp1.Properties.Resources.road;
            this.deliveriesPImg.Location = new System.Drawing.Point(41, 77);
            this.deliveriesPImg.Name = "deliveriesPImg";
            this.deliveriesPImg.Size = new System.Drawing.Size(65, 65);
            this.deliveriesPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deliveriesPImg.TabIndex = 43;
            this.deliveriesPImg.TabStop = false;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.deliveryLabel.Location = new System.Drawing.Point(36, 38);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(102, 26);
            this.deliveryLabel.TabIndex = 42;
            this.deliveryLabel.Text = "Delivery";
            // 
            // dID
            // 
            this.dID.FillWeight = 50F;
            this.dID.HeaderText = "Nr.";
            this.dID.MinimumWidth = 50;
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            // 
            // dClient
            // 
            this.dClient.FillWeight = 125F;
            this.dClient.HeaderText = "Client";
            this.dClient.MinimumWidth = 125;
            this.dClient.Name = "dClient";
            this.dClient.ReadOnly = true;
            // 
            // dStatus
            // 
            this.dStatus.FillWeight = 175F;
            this.dStatus.HeaderText = "Status";
            this.dStatus.MinimumWidth = 175;
            this.dStatus.Name = "dStatus";
            this.dStatus.ReadOnly = true;
            // 
            // dTime
            // 
            this.dTime.FillWeight = 175F;
            this.dTime.HeaderText = "Order Time";
            this.dTime.MinimumWidth = 175;
            this.dTime.Name = "dTime";
            this.dTime.ReadOnly = true;
            // 
            // dForecast
            // 
            this.dForecast.FillWeight = 175F;
            this.dForecast.HeaderText = "Next Stage";
            this.dForecast.MinimumWidth = 175;
            this.dForecast.Name = "dForecast";
            this.dForecast.ReadOnly = true;
            // 
            // dExpected
            // 
            this.dExpected.FillWeight = 175F;
            this.dExpected.HeaderText = "Expected ";
            this.dExpected.MinimumWidth = 175;
            this.dExpected.Name = "dExpected";
            this.dExpected.ReadOnly = true;
            // 
            // dAddress
            // 
            this.dAddress.FillWeight = 150F;
            this.dAddress.HeaderText = "Address";
            this.dAddress.MinimumWidth = 150;
            this.dAddress.Name = "dAddress";
            this.dAddress.ReadOnly = true;
            // 
            // dContact
            // 
            this.dContact.FillWeight = 125F;
            this.dContact.HeaderText = "Contact";
            this.dContact.MinimumWidth = 125;
            this.dContact.Name = "dContact";
            this.dContact.ReadOnly = true;
            // 
            // deliveriesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.Controls.Add(this.deliveryPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deliveriesPanel";
            this.Text = "DeliveriesPanel";
            this.deliveryPanel.ResumeLayout(false);
            this.deliveryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesPImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel deliveryPanel;
        public System.Windows.Forms.DataGridView deliveriesGrid;
        private System.Windows.Forms.Label separator;
        public System.Windows.Forms.PictureBox deliveriesPImg;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dClient;
        private System.Windows.Forms.DataGridViewButtonColumn dStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dForecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn dExpected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dContact;
    }
}