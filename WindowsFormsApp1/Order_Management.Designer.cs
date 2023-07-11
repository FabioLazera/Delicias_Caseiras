namespace WindowsFormsApp1
{
    partial class Order_Management
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pratos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.change_status,
            this.pratos,
            this.bebidas,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // status
            // 
            this.status.HeaderText = "Estado Pedido";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // change_status
            // 
            this.change_status.HeaderText = "Alterar Estado";
            this.change_status.MinimumWidth = 6;
            this.change_status.Name = "change_status";
            this.change_status.Width = 125;
            // 
            // pratos
            // 
            this.pratos.HeaderText = "Pratos";
            this.pratos.MinimumWidth = 6;
            this.pratos.Name = "pratos";
            this.pratos.ReadOnly = true;
            this.pratos.Width = 125;
            // 
            // bebidas
            // 
            this.bebidas.HeaderText = "Bebidas";
            this.bebidas.MinimumWidth = 6;
            this.bebidas.Name = "bebidas";
            this.bebidas.ReadOnly = true;
            this.bebidas.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Preço";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 125;
            // 
            // Order_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order_Management";
            this.Text = "Gestão de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewComboBoxColumn change_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}