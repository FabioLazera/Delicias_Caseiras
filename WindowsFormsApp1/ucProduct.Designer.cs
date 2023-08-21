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
            this.productName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productPrice = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(17, 14);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(130, 21);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(18, 90);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(92, 18);
            this.description.TabIndex = 1;
            this.description.Text = "Description :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(18, 53);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(50, 18);
            this.price.TabIndex = 2;
            this.price.Text = "Price :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productPrice);
            this.panel1.Controls.Add(this.productDescription);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 200);
            this.panel1.TabIndex = 0;
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Bookman Old Style", 7.8F);
            this.productPrice.Location = new System.Drawing.Point(63, 55);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(47, 18);
            this.productPrice.TabIndex = 4;
            this.productPrice.Text = "label1";
            // 
            // productDescription
            // 
            this.productDescription.BackColor = System.Drawing.SystemColors.Control;
            this.productDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDescription.Font = new System.Drawing.Font("Bookman Old Style", 7.8F);
            this.productDescription.Location = new System.Drawing.Point(21, 113);
            this.productDescription.Multiline = true;
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            this.productDescription.Size = new System.Drawing.Size(126, 84);
            this.productDescription.TabIndex = 3;
            this.productDescription.Text = "Teste para verificar se o tamanho é suficiente";
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(170, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label productName;
        public System.Windows.Forms.Label productPrice;
        public System.Windows.Forms.TextBox productDescription;
    }
}
