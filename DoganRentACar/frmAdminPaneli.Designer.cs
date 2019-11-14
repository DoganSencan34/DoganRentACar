namespace DoganRentACar
{
    partial class frmAdminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOĞAN RENT A CAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.araçİşlemleriToolStripMenuItem,
            this.sözleşmelerToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.müşteriİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriİşlemleriToolStripMenuItem.Image")));
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem,
            this.araçListesiToolStripMenuItem});
            this.araçİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.araçİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçİşlemleriToolStripMenuItem.Image")));
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // araçEkleToolStripMenuItem
            // 
            this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
            this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.araçEkleToolStripMenuItem.Text = "Araç Ekle";
            this.araçEkleToolStripMenuItem.Click += new System.EventHandler(this.araçEkleToolStripMenuItem_Click);
            // 
            // araçListesiToolStripMenuItem
            // 
            this.araçListesiToolStripMenuItem.Name = "araçListesiToolStripMenuItem";
            this.araçListesiToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.araçListesiToolStripMenuItem.Text = "Araç Listesi";
            this.araçListesiToolStripMenuItem.Click += new System.EventHandler(this.araçListesiToolStripMenuItem_Click);
            // 
            // sözleşmelerToolStripMenuItem
            // 
            this.sözleşmelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sözleşmeListesiToolStripMenuItem});
            this.sözleşmelerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.sözleşmelerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sözleşmelerToolStripMenuItem.Image")));
            this.sözleşmelerToolStripMenuItem.Name = "sözleşmelerToolStripMenuItem";
            this.sözleşmelerToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.sözleşmelerToolStripMenuItem.Text = "Sözleşmeler";
            // 
            // sözleşmeListesiToolStripMenuItem
            // 
            this.sözleşmeListesiToolStripMenuItem.Name = "sözleşmeListesiToolStripMenuItem";
            this.sözleşmeListesiToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.sözleşmeListesiToolStripMenuItem.Text = "Sözleşme Listesi";
            this.sözleşmeListesiToolStripMenuItem.Click += new System.EventHandler(this.sözleşmeListesiToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // frmAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 290);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeListesiToolStripMenuItem;
    }
}