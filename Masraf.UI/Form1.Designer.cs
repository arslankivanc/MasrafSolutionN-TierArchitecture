namespace Masraf.UI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem,
            this.muhasebeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yetkiliGirisİçinTıklayınızToolStripMenuItem
            // 
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem.Name = "yetkiliGirisİçinTıklayınızToolStripMenuItem";
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem.Text = "Yetkili Giriş";
            this.yetkiliGirisİçinTıklayınızToolStripMenuItem.Click += new System.EventHandler(this.yetkiliGirisİçinTıklayınızToolStripMenuItem_Click);
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.muhasebeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.muhasebeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.muhasebeToolStripMenuItem.Text = "Muhasebe";
            this.muhasebeToolStripMenuItem.Click += new System.EventHandler(this.muhasebeToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.çıkışToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 448);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yetkiliGirisİçinTıklayınızToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
    }
}

