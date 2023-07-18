namespace WindowsFormsApp1
{
    partial class TableModel
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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.PictureBox();
            this.TableHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.TableHeader);
            this.ControlPanel.Controls.Add(this.pictureBox2);
            this.ControlPanel.Controls.Add(this.AddButton);
            this.ControlPanel.Controls.Add(this.SearchLabel);
            this.ControlPanel.Controls.Add(this.TextSearch);
            this.ControlPanel.Location = new System.Drawing.Point(239, 87);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1027, 750);
            this.ControlPanel.TabIndex = 5;
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(722, 124);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(231, 22);
            this.TextSearch.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(821, 100);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(62, 20);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(777, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Image = global::WindowsFormsApp1.Properties.Resources.plus;
            this.AddButton.Location = new System.Drawing.Point(67, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 69);
            this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddButton.TabIndex = 2;
            this.AddButton.TabStop = false;
            // 
            // TableHeader
            // 
            this.TableHeader.AutoSize = true;
            this.TableHeader.BackColor = System.Drawing.Color.Transparent;
            this.TableHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableHeader.Location = new System.Drawing.Point(58, 40);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.Size = new System.Drawing.Size(93, 29);
            this.TableHeader.TabIndex = 4;
            this.TableHeader.Text = "Header";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(38, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(936, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "_______________________________________________________________________";
            // 
            // TableModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 925);
            this.Controls.Add(this.ControlPanel);
            this.Name = "TableModel";
            this.Text = "TableModel";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox AddButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TableHeader;
    }
}