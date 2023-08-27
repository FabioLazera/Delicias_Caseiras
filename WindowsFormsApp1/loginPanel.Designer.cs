namespace WindowsFormsApp1
{
    partial class loginPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nifTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.PictureBox();
            this.hidden = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo_transparent1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nifTB
            // 
            this.nifTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nifTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nifTB.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nifTB.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nifTB.Location = new System.Drawing.Point(93, 310);
            this.nifTB.Multiline = true;
            this.nifTB.Name = "nifTB";
            this.nifTB.Size = new System.Drawing.Size(189, 27);
            this.nifTB.TabIndex = 1;
            this.nifTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(89, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(89, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordTB.Location = new System.Drawing.Point(93, 403);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(189, 27);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInBtn.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(93, 476);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(189, 34);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Bookman Old Style", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(0)))));
            this.cancelBtn.Location = new System.Drawing.Point(326, 546);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(48, 16);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.Image = global::WindowsFormsApp1.Properties.Resources.view1;
            this.view.Location = new System.Drawing.Point(251, 385);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(13, 13);
            this.view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.view.TabIndex = 7;
            this.view.TabStop = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // hidden
            // 
            this.hidden.BackColor = System.Drawing.Color.Transparent;
            this.hidden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidden.Image = global::WindowsFormsApp1.Properties.Resources.hidden1;
            this.hidden.Location = new System.Drawing.Point(269, 385);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(13, 13);
            this.hidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidden.TabIndex = 8;
            this.hidden.TabStop = false;
            this.hidden.Click += new System.EventHandler(this.hidden_Click);
            // 
            // loginPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 573);
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.view);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nifTB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nifTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        public System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label cancelBtn;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.PictureBox hidden;
    }
}