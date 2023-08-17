namespace WindowsFormsApp1.Panels
{
    partial class addEmployeePanel
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
            this.addEmployeesPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.eJobTB = new System.Windows.Forms.TextBox();
            this.eSalaryTB = new System.Windows.Forms.TextBox();
            this.eAddressTB = new System.Windows.Forms.TextBox();
            this.ePNTB = new System.Windows.Forms.TextBox();
            this.eAgeTB = new System.Windows.Forms.TextBox();
            this.eNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addEL = new System.Windows.Forms.Label();
            this.addEmployeesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmployeesPanel
            // 
            this.addEmployeesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployeesPanel.Controls.Add(this.closeBtn);
            this.addEmployeesPanel.Controls.Add(this.saveBtn);
            this.addEmployeesPanel.Controls.Add(this.eJobTB);
            this.addEmployeesPanel.Controls.Add(this.eSalaryTB);
            this.addEmployeesPanel.Controls.Add(this.eAddressTB);
            this.addEmployeesPanel.Controls.Add(this.ePNTB);
            this.addEmployeesPanel.Controls.Add(this.eAgeTB);
            this.addEmployeesPanel.Controls.Add(this.eNameTB);
            this.addEmployeesPanel.Controls.Add(this.label6);
            this.addEmployeesPanel.Controls.Add(this.label5);
            this.addEmployeesPanel.Controls.Add(this.label4);
            this.addEmployeesPanel.Controls.Add(this.label3);
            this.addEmployeesPanel.Controls.Add(this.label2);
            this.addEmployeesPanel.Controls.Add(this.label1);
            this.addEmployeesPanel.Controls.Add(this.panel2);
            this.addEmployeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployeesPanel.Location = new System.Drawing.Point(0, 0);
            this.addEmployeesPanel.Name = "addEmployeesPanel";
            this.addEmployeesPanel.Size = new System.Drawing.Size(571, 504);
            this.addEmployeesPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(305, 447);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(180, 45);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(88, 447);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 45);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // eJobTB
            // 
            this.eJobTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eJobTB.Location = new System.Drawing.Point(318, 379);
            this.eJobTB.Multiline = true;
            this.eJobTB.Name = "eJobTB";
            this.eJobTB.Size = new System.Drawing.Size(220, 35);
            this.eJobTB.TabIndex = 13;
            // 
            // eSalaryTB
            // 
            this.eSalaryTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eSalaryTB.Location = new System.Drawing.Point(318, 287);
            this.eSalaryTB.Multiline = true;
            this.eSalaryTB.Name = "eSalaryTB";
            this.eSalaryTB.Size = new System.Drawing.Size(220, 35);
            this.eSalaryTB.TabIndex = 12;
            // 
            // eAddressTB
            // 
            this.eAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eAddressTB.Location = new System.Drawing.Point(318, 193);
            this.eAddressTB.Multiline = true;
            this.eAddressTB.Name = "eAddressTB";
            this.eAddressTB.Size = new System.Drawing.Size(220, 35);
            this.eAddressTB.TabIndex = 11;
            // 
            // ePNTB
            // 
            this.ePNTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ePNTB.Location = new System.Drawing.Point(35, 379);
            this.ePNTB.Multiline = true;
            this.ePNTB.Name = "ePNTB";
            this.ePNTB.Size = new System.Drawing.Size(220, 35);
            this.ePNTB.TabIndex = 10;
            // 
            // eAgeTB
            // 
            this.eAgeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eAgeTB.Location = new System.Drawing.Point(35, 287);
            this.eAgeTB.Multiline = true;
            this.eAgeTB.Name = "eAgeTB";
            this.eAgeTB.Size = new System.Drawing.Size(220, 35);
            this.eAgeTB.TabIndex = 9;
            // 
            // eNameTB
            // 
            this.eNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eNameTB.Location = new System.Drawing.Point(36, 193);
            this.eNameTB.Multiline = true;
            this.eNameTB.Name = "eNameTB";
            this.eNameTB.Size = new System.Drawing.Size(220, 35);
            this.eNameTB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(314, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Job";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(314, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(314, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.addEL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 141);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.addProcess;
            this.pictureBox1.Location = new System.Drawing.Point(35, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addEL
            // 
            this.addEL.AutoSize = true;
            this.addEL.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.addEL.ForeColor = System.Drawing.Color.White;
            this.addEL.Location = new System.Drawing.Point(116, 62);
            this.addEL.Name = "addEL";
            this.addEL.Size = new System.Drawing.Size(120, 26);
            this.addEL.TabIndex = 0;
            this.addEL.Text = "Employee";
            // 
            // addEmployeePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(571, 504);
            this.Controls.Add(this.addEmployeesPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addEmployeePanel";
            this.Text = "addEmployeePanel";
            this.addEmployeesPanel.ResumeLayout(false);
            this.addEmployeesPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addEmployeesPanel;
        private System.Windows.Forms.Label addEL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.TextBox eJobTB;
        public System.Windows.Forms.TextBox eSalaryTB;
        public System.Windows.Forms.TextBox eAddressTB;
        public System.Windows.Forms.TextBox ePNTB;
        public System.Windows.Forms.TextBox eAgeTB;
        public System.Windows.Forms.TextBox eNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}