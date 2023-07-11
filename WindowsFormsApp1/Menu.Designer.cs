namespace WindowsFormsApp1
{
    partial class Menu
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
            this.pedidos = new System.Windows.Forms.Button();
            this.clientes = new System.Windows.Forms.Button();
            this.pratos = new System.Windows.Forms.Button();
            this.bebidas = new System.Windows.Forms.Button();
            this.entregas = new System.Windows.Forms.Button();
            this.funcionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pedidos
            // 
            this.pedidos.Location = new System.Drawing.Point(12, 52);
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(109, 55);
            this.pedidos.TabIndex = 0;
            this.pedidos.Text = "Pedidos";
            this.pedidos.UseVisualStyleBackColor = true;
            // 
            // clientes
            // 
            this.clientes.Location = new System.Drawing.Point(12, 141);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(109, 55);
            this.clientes.TabIndex = 1;
            this.clientes.Text = "Clientes";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // pratos
            // 
            this.pratos.Location = new System.Drawing.Point(12, 225);
            this.pratos.Name = "pratos";
            this.pratos.Size = new System.Drawing.Size(109, 55);
            this.pratos.TabIndex = 2;
            this.pratos.Text = "Pratos";
            this.pratos.UseVisualStyleBackColor = true;
            // 
            // bebidas
            // 
            this.bebidas.Location = new System.Drawing.Point(12, 319);
            this.bebidas.Name = "bebidas";
            this.bebidas.Size = new System.Drawing.Size(109, 55);
            this.bebidas.TabIndex = 3;
            this.bebidas.Text = "Bebidas";
            this.bebidas.UseVisualStyleBackColor = true;
            // 
            // entregas
            // 
            this.entregas.Location = new System.Drawing.Point(175, 52);
            this.entregas.Name = "entregas";
            this.entregas.Size = new System.Drawing.Size(109, 55);
            this.entregas.TabIndex = 4;
            this.entregas.Text = "Entregas";
            this.entregas.UseVisualStyleBackColor = true;
            // 
            // funcionarios
            // 
            this.funcionarios.Location = new System.Drawing.Point(175, 141);
            this.funcionarios.Name = "funcionarios";
            this.funcionarios.Size = new System.Drawing.Size(109, 55);
            this.funcionarios.TabIndex = 5;
            this.funcionarios.Text = "Funcionários";
            this.funcionarios.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.funcionarios);
            this.Controls.Add(this.entregas);
            this.Controls.Add(this.bebidas);
            this.Controls.Add(this.pratos);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.pedidos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pedidos;
        private System.Windows.Forms.Button clientes;
        private System.Windows.Forms.Button pratos;
        private System.Windows.Forms.Button bebidas;
        private System.Windows.Forms.Button entregas;
        private System.Windows.Forms.Button funcionarios;
    }
}