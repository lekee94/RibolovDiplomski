namespace Klijent
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.takmicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTakmicaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledTakmicaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takmicenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTakmicenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragatakmicenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takmicarToolStripMenuItem,
            this.takmicenjeToolStripMenuItem,
            this.krajRadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // takmicarToolStripMenuItem
            // 
            this.takmicarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosTakmicaraToolStripMenuItem,
            this.pregledTakmicaraToolStripMenuItem});
            this.takmicarToolStripMenuItem.Name = "takmicarToolStripMenuItem";
            this.takmicarToolStripMenuItem.Size = new System.Drawing.Size(96, 30);
            this.takmicarToolStripMenuItem.Text = "Takmičar";
            // 
            // unosTakmicaraToolStripMenuItem
            // 
            this.unosTakmicaraToolStripMenuItem.Name = "unosTakmicaraToolStripMenuItem";
            this.unosTakmicaraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.unosTakmicaraToolStripMenuItem.Text = "Unos takmičara";
            this.unosTakmicaraToolStripMenuItem.Click += new System.EventHandler(this.unosTakmicaraToolStripMenuItem_Click);
            // 
            // pregledTakmicaraToolStripMenuItem
            // 
            this.pregledTakmicaraToolStripMenuItem.Name = "pregledTakmicaraToolStripMenuItem";
            this.pregledTakmicaraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pregledTakmicaraToolStripMenuItem.Text = "Pregled takmičara";
            this.pregledTakmicaraToolStripMenuItem.Click += new System.EventHandler(this.pregledTakmicaraToolStripMenuItem_Click);
            // 
            // takmicenjeToolStripMenuItem
            // 
            this.takmicenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosTakmicenjaToolStripMenuItem,
            this.pretragatakmicenjaToolStripMenuItem});
            this.takmicenjeToolStripMenuItem.Name = "takmicenjeToolStripMenuItem";
            this.takmicenjeToolStripMenuItem.Size = new System.Drawing.Size(113, 30);
            this.takmicenjeToolStripMenuItem.Text = "Takmičenje";
            // 
            // unosTakmicenjaToolStripMenuItem
            // 
            this.unosTakmicenjaToolStripMenuItem.Name = "unosTakmicenjaToolStripMenuItem";
            this.unosTakmicenjaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.unosTakmicenjaToolStripMenuItem.Text = "Unos takmičenja";
            this.unosTakmicenjaToolStripMenuItem.Click += new System.EventHandler(this.unosTakmicenjaToolStripMenuItem_Click);
            // 
            // pretragatakmicenjaToolStripMenuItem
            // 
            this.pretragatakmicenjaToolStripMenuItem.Name = "pretragatakmicenjaToolStripMenuItem";
            this.pretragatakmicenjaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pretragatakmicenjaToolStripMenuItem.Text = "Pretraga takmičenja";
            this.pretragatakmicenjaToolStripMenuItem.Click += new System.EventHandler(this.pretragatakmicenjaToolStripMenuItem_Click);
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(97, 30);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            this.krajRadaToolStripMenuItem.Click += new System.EventHandler(this.krajRadaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaForma_FormClosed);
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takmicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takmicenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajRadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTakmicaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledTakmicaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTakmicenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragatakmicenjaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}