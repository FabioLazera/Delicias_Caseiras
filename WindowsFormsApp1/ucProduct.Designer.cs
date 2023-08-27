namespace WindowsFormsApp1
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
            this.price = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.Label();
            this.imageUC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageUC)).BeginInit();
            this.SuspendLayout();
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Bookman Old Style", 7.8F);
            this.productPrice.Location = new System.Drawing.Point(73, 173);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(47, 18);
            this.productPrice.TabIndex = 9;
            this.productPrice.Text = "label1";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(28, 171);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(50, 18);
            this.price.TabIndex = 7;
            this.price.Text = "Price :";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(27, 132);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(130, 21);
            this.productName.TabIndex = 5;
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productDescription
            // 
            this.productDescription.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescription.Location = new System.Drawing.Point(28, 197);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(129, 40);
            this.productDescription.TabIndex = 11;
            // 
            // imageUC
            // 
            this.imageUC.Image = global::WindowsFormsApp1.Properties.Resources.noPicture;
            this.imageUC.Location = new System.Drawing.Point(24, 19);
            this.imageUC.Name = "imageUC";
            this.imageUC.Size = new System.Drawing.Size(126, 110);
            this.imageUC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageUC.TabIndex = 12;
            this.imageUC.TabStop = false;
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.imageUC);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productName);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(182, 253);
            ((System.ComponentModel.ISupportInitialize)(this.imageUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label price;
        public System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productDescription;
        public System.Windows.Forms.PictureBox imageUC;
    }
}
