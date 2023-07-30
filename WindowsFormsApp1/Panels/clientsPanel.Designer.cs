namespace WindowsFormsApp1.Panels
{
    partial class clientsPanel
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
            this.clientPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(806, 721);
            this.clientPanel.TabIndex = 0;
            // 
            // clientsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(806, 721);
            this.Controls.Add(this.clientPanel);
            this.Name = "clientsPanel";
            this.Text = "clientsPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
    }
}