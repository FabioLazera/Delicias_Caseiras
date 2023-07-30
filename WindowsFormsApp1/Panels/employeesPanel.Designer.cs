﻿namespace WindowsFormsApp1.Panels
{
    partial class employeesPanel
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
            this.employeePanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.employeesPImg = new System.Windows.Forms.PictureBox();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            this.eID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.employeesGrid);
            this.employeePanel.Controls.Add(this.searchLabel);
            this.employeePanel.Controls.Add(this.searchImg);
            this.employeePanel.Controls.Add(this.separator);
            this.employeePanel.Controls.Add(this.searchTB);
            this.employeePanel.Controls.Add(this.employeesPImg);
            this.employeePanel.Controls.Add(this.employeesLabel);
            this.employeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePanel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePanel.Location = new System.Drawing.Point(0, 0);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(824, 768);
            this.employeePanel.TabIndex = 0;
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
            this.searchLabel.TabIndex = 20;
            this.searchLabel.Text = "Search Here";
            // 
            // searchImg
            // 
            this.searchImg.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(557, 85);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(29, 27);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImg.TabIndex = 19;
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
            this.separator.TabIndex = 17;
            this.separator.Text = "_________________________________________________________________________________" +
    "_____________";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(557, 115);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(230, 27);
            this.searchTB.TabIndex = 16;
            // 
            // employeesPImg
            // 
            this.employeesPImg.Image = global::WindowsFormsApp1.Properties.Resources.addPerson;
            this.employeesPImg.Location = new System.Drawing.Point(41, 77);
            this.employeesPImg.Name = "employeesPImg";
            this.employeesPImg.Size = new System.Drawing.Size(65, 65);
            this.employeesPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeesPImg.TabIndex = 15;
            this.employeesPImg.TabStop = false;
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.employeesLabel.Location = new System.Drawing.Point(36, 38);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(132, 26);
            this.employeesLabel.TabIndex = 14;
            this.employeesLabel.Text = "Employees";
            // 
            // employeesGrid
            // 
            this.employeesGrid.AllowUserToAddRows = false;
            this.employeesGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesGrid.BackgroundColor = System.Drawing.Color.White;
            this.employeesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.employeesGrid.ColumnHeadersHeight = 40;
            this.employeesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eID,
            this.eName,
            this.eAge,
            this.ePhoneNumber,
            this.eAddress,
            this.eSalary,
            this.eJob});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.employeesGrid.EnableHeadersVisualStyles = false;
            this.employeesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeesGrid.Location = new System.Drawing.Point(35, 204);
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.employeesGrid.RowHeadersVisible = false;
            this.employeesGrid.RowHeadersWidth = 51;
            this.employeesGrid.RowTemplate.Height = 24;
            this.employeesGrid.Size = new System.Drawing.Size(755, 535);
            this.employeesGrid.TabIndex = 21;
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
            // eAge
            // 
            this.eAge.FillWeight = 50F;
            this.eAge.HeaderText = "Age";
            this.eAge.MinimumWidth = 50;
            this.eAge.Name = "eAge";
            this.eAge.ReadOnly = true;
            // 
            // ePhoneNumber
            // 
            this.ePhoneNumber.HeaderText = "PNumber";
            this.ePhoneNumber.MinimumWidth = 100;
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
            // eSalary
            // 
            this.eSalary.FillWeight = 79F;
            this.eSalary.HeaderText = "Salary";
            this.eSalary.MinimumWidth = 79;
            this.eSalary.Name = "eSalary";
            this.eSalary.ReadOnly = true;
            // 
            // eJob
            // 
            this.eJob.HeaderText = "Job";
            this.eJob.MinimumWidth = 100;
            this.eJob.Name = "eJob";
            this.eJob.ReadOnly = true;
            // 
            // employeesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.Controls.Add(this.employeePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeesPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeesPanel";
            this.Load += new System.EventHandler(this.employeesPanel_Load);
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Label employeesLabel;
        public System.Windows.Forms.TextBox searchTB;
        public System.Windows.Forms.PictureBox employeesPImg;
        public System.Windows.Forms.DataGridView employeesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eName;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn eJob;
        public System.Windows.Forms.Panel employeePanel;
    }
}