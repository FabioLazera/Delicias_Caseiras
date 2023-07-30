namespace WindowsFormsApp1.Panels
{
    partial class drinksPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drinksGrid = new System.Windows.Forms.DataGridView();
            this.eID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.drinksPImg = new System.Windows.Forms.PictureBox();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drinksGrid);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.searchImg);
            this.panel1.Controls.Add(this.separator);
            this.panel1.Controls.Add(this.searchTB);
            this.panel1.Controls.Add(this.drinksPImg);
            this.panel1.Controls.Add(this.drinksLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 768);
            this.panel1.TabIndex = 0;
            // 
            // drinksGrid
            // 
            this.drinksGrid.AllowUserToAddRows = false;
            this.drinksGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drinksGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.drinksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drinksGrid.BackgroundColor = System.Drawing.Color.White;
            this.drinksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drinksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.drinksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drinksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.drinksGrid.ColumnHeadersHeight = 40;
            this.drinksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eID,
            this.eName,
            this.ePhoneNumber,
            this.eAddress,
            this.eJob});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drinksGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.drinksGrid.EnableHeadersVisualStyles = false;
            this.drinksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.drinksGrid.Location = new System.Drawing.Point(34, 203);
            this.drinksGrid.Name = "drinksGrid";
            this.drinksGrid.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drinksGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.drinksGrid.RowHeadersVisible = false;
            this.drinksGrid.RowHeadersWidth = 51;
            this.drinksGrid.RowTemplate.Height = 24;
            this.drinksGrid.Size = new System.Drawing.Size(755, 535);
            this.drinksGrid.TabIndex = 35;
            // 
            // eID
            // 
            this.eID.FillWeight = 50F;
            this.eID.HeaderText = "ID";
            this.eID.MinimumWidth = 50;
            this.eID.Name = "eID";
            this.eID.ReadOnly = true;
            // 
            // eName
            // 
            this.eName.FillWeight = 125F;
            this.eName.HeaderText = "Name";
            this.eName.MinimumWidth = 125;
            this.eName.Name = "eName";
            this.eName.ReadOnly = true;
            // 
            // ePhoneNumber
            // 
            this.ePhoneNumber.FillWeight = 150F;
            this.ePhoneNumber.HeaderText = "Phone Number";
            this.ePhoneNumber.MinimumWidth = 150;
            this.ePhoneNumber.Name = "ePhoneNumber";
            this.ePhoneNumber.ReadOnly = true;
            // 
            // eAddress
            // 
            this.eAddress.FillWeight = 200F;
            this.eAddress.HeaderText = "Address";
            this.eAddress.MinimumWidth = 200;
            this.eAddress.Name = "eAddress";
            this.eAddress.ReadOnly = true;
            // 
            // eJob
            // 
            this.eJob.HeaderText = "NIF";
            this.eJob.MinimumWidth = 100;
            this.eJob.Name = "eJob";
            this.eJob.ReadOnly = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchLabel.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.DimGray;
            this.searchLabel.Location = new System.Drawing.Point(589, 94);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(91, 18);
            this.searchLabel.TabIndex = 34;
            this.searchLabel.Text = "Search Here";
            // 
            // searchImg
            // 
            this.searchImg.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(556, 84);
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
            this.separator.Location = new System.Drawing.Point(33, 162);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(855, 20);
            this.separator.TabIndex = 32;
            this.separator.Text = "_________________________________________________________________________________" +
    "_____________";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(556, 114);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(230, 27);
            this.searchTB.TabIndex = 31;
            // 
            // drinksPImg
            // 
            this.drinksPImg.Image = global::WindowsFormsApp1.Properties.Resources.addPerson;
            this.drinksPImg.Location = new System.Drawing.Point(40, 76);
            this.drinksPImg.Name = "drinksPImg";
            this.drinksPImg.Size = new System.Drawing.Size(65, 65);
            this.drinksPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drinksPImg.TabIndex = 30;
            this.drinksPImg.TabStop = false;
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.drinksLabel.Location = new System.Drawing.Point(35, 37);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(88, 26);
            this.drinksLabel.TabIndex = 29;
            this.drinksLabel.Text = "Drinks";
            // 
            // drinksPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "drinksPanel";
            this.Text = "drinksPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksPImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView drinksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn eJob;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.Label separator;
        public System.Windows.Forms.TextBox searchTB;
        public System.Windows.Forms.PictureBox drinksPImg;
        private System.Windows.Forms.Label drinksLabel;
    }
}