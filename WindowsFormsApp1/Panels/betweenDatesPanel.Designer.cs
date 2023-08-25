namespace WindowsFormsApp1.Panels
{
    partial class betweenDatesPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(betweenDatesPanel));
            this.betweenDatePanel = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.Label();
            this.betweenDatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // betweenDatePanel
            // 
            this.betweenDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betweenDatePanel.Controls.Add(this.total);
            this.betweenDatePanel.Controls.Add(this.label3);
            this.betweenDatePanel.Controls.Add(this.combo);
            this.betweenDatePanel.Controls.Add(this.clientList);
            this.betweenDatePanel.Controls.Add(this.label2);
            this.betweenDatePanel.Controls.Add(this.label1);
            this.betweenDatePanel.Controls.Add(this.endDate);
            this.betweenDatePanel.Controls.Add(this.startDate);
            this.betweenDatePanel.Controls.Add(this.panel1);
            this.betweenDatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.betweenDatePanel.Location = new System.Drawing.Point(0, 0);
            this.betweenDatePanel.Name = "betweenDatePanel";
            this.betweenDatePanel.Size = new System.Drawing.Size(481, 361);
            this.betweenDatePanel.TabIndex = 0;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(355, 294);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(36, 21);
            this.total.TabIndex = 52;
            this.total.Text = "0 €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total spent :";
            // 
            // combo
            // 
            this.combo.AutoSize = true;
            this.combo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.Location = new System.Drawing.Point(29, 267);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(60, 21);
            this.combo.TabIndex = 50;
            this.combo.Text = "Client";
            // 
            // clientList
            // 
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(33, 291);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(200, 24);
            this.clientList.TabIndex = 49;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.clientList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(248, 210);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 22);
            this.endDate.TabIndex = 3;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(33, 210);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 22);
            this.startDate.TabIndex = 2;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 141);
            this.panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(438, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 36);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 53;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.calculator;
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(127, 57);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(291, 26);
            this.text.TabIndex = 6;
            this.text.Text = "Calculate Between Dates";
            // 
            // betweenDatesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(481, 361);
            this.Controls.Add(this.betweenDatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "betweenDatesPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "betweenDatesPanel";
            this.betweenDatePanel.ResumeLayout(false);
            this.betweenDatePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel betweenDatePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label combo;
        private System.Windows.Forms.ComboBox clientList;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}