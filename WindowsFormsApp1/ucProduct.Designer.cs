﻿namespace WindowsFormsApp1
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productPrice = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Bookman Old Style", 7.8F);
            this.productPrice.Location = new System.Drawing.Point(66, 50);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(47, 18);
            this.productPrice.TabIndex = 9;
            this.productPrice.Text = "label1";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(21, 85);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(92, 18);
            this.description.TabIndex = 6;
            this.description.Text = "Description :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(21, 48);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(50, 18);
            this.price.TabIndex = 7;
            this.price.Text = "Price :";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(20, 9);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(130, 21);
            this.productName.TabIndex = 5;
            this.productName.Text = "Product Name";
            // 
            // productDescription
            // 
            this.productDescription.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescription.Location = new System.Drawing.Point(21, 114);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(129, 69);
            this.productDescription.TabIndex = 11;
            this.productDescription.Text = "Texto para verificar se o tamanho da label é suficiente ou não";
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.description);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productName);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(170, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label price;
        public System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productDescription;
    }
}
