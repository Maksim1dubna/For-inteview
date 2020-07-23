namespace unidubna
{
    partial class MainPage
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpPanel = new System.Windows.Forms.Label();
            this.FIOcombobox = new System.Windows.Forms.ComboBox();
            this.FIOtextbox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MainPanel.Controls.Add(this.FIOtextbox);
            this.MainPanel.Controls.Add(this.FIOcombobox);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.UpPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // UpPanel
            // 
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpPanel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(800, 100);
            this.UpPanel.TabIndex = 0;
            this.UpPanel.Text = "Страница";
            this.UpPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIOcombobox
            // 
            this.FIOcombobox.AccessibleDescription = "";
            this.FIOcombobox.AccessibleName = "";
            this.FIOcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOcombobox.Items.AddRange(new object[] {
            "ФИО участников"});
            this.FIOcombobox.Location = new System.Drawing.Point(7, 106);
            this.FIOcombobox.Name = "FIOcombobox";
            this.FIOcombobox.Size = new System.Drawing.Size(339, 32);
            this.FIOcombobox.TabIndex = 1;
            // 
            // FIOtextbox
            // 
            this.FIOtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOtextbox.Location = new System.Drawing.Point(7, 158);
            this.FIOtextbox.Name = "FIOtextbox";
            this.FIOtextbox.Size = new System.Drawing.Size(339, 47);
            this.FIOtextbox.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UpPanel;
        private System.Windows.Forms.TextBox FIOtextbox;
        private System.Windows.Forms.ComboBox FIOcombobox;
    }
}