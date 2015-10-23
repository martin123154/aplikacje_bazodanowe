namespace Zadanie_10
{
    partial class Start
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
            this.tabeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wystepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabeleToolStripMenuItem
            // 
            this.tabeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientToolStripMenuItem,
            this.zakupToolStripMenuItem,
            this.biletToolStripMenuItem,
            this.premieraToolStripMenuItem,
            this.wystepToolStripMenuItem,
            this.aktorToolStripMenuItem});
            this.tabeleToolStripMenuItem.Name = "tabeleToolStripMenuItem";
            this.tabeleToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tabeleToolStripMenuItem.Text = "tabele";
            // 
            // klientToolStripMenuItem
            // 
            this.klientToolStripMenuItem.Name = "klientToolStripMenuItem";
            this.klientToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.klientToolStripMenuItem.Text = "Klient";
            this.klientToolStripMenuItem.Click += new System.EventHandler(this.klientToolStripMenuItem_Click);
            // 
            // zakupToolStripMenuItem
            // 
            this.zakupToolStripMenuItem.Name = "zakupToolStripMenuItem";
            this.zakupToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.zakupToolStripMenuItem.Text = "Zakup";
            this.zakupToolStripMenuItem.Click += new System.EventHandler(this.zakupToolStripMenuItem_Click);
            // 
            // biletToolStripMenuItem
            // 
            this.biletToolStripMenuItem.Name = "biletToolStripMenuItem";
            this.biletToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.biletToolStripMenuItem.Text = "Bilet";
            this.biletToolStripMenuItem.Click += new System.EventHandler(this.biletToolStripMenuItem_Click);
            // 
            // premieraToolStripMenuItem
            // 
            this.premieraToolStripMenuItem.Name = "premieraToolStripMenuItem";
            this.premieraToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.premieraToolStripMenuItem.Text = "Premiera";
            this.premieraToolStripMenuItem.Click += new System.EventHandler(this.premieraToolStripMenuItem_Click);
            // 
            // wystepToolStripMenuItem
            // 
            this.wystepToolStripMenuItem.Name = "wystepToolStripMenuItem";
            this.wystepToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.wystepToolStripMenuItem.Text = "Wystep";
            this.wystepToolStripMenuItem.Click += new System.EventHandler(this.wystepToolStripMenuItem_Click);
            // 
            // aktorToolStripMenuItem
            // 
            this.aktorToolStripMenuItem.Name = "aktorToolStripMenuItem";
            this.aktorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aktorToolStripMenuItem.Text = "Aktor";
            this.aktorToolStripMenuItem.Click += new System.EventHandler(this.aktorToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 298);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Start";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premieraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wystepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktorToolStripMenuItem;
    }
}

