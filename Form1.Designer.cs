namespace Kayit_Defteri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKayitGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKayitSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProgramBilgisi = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKayitSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSonİslem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.btnKayitDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSilme = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapıştır = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuDuzen,
            this.mnuIslem,
            this.mnuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuKaydet,
            this.toolStripMenuItem6,
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(51, 20);
            this.mnuDosya.Text = "Dosya";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.Size = new System.Drawing.Size(152, 22);
            this.mnuKaydet.Text = "Kaydet";
            this.mnuKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(152, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // mnuDuzen
            // 
            this.mnuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKes,
            this.mnuKopyala,
            this.toolStripMenuItem2,
            this.mnuYapistir});
            this.mnuDuzen.Name = "mnuDuzen";
            this.mnuDuzen.Size = new System.Drawing.Size(52, 20);
            this.mnuDuzen.Text = "Düzen";
            // 
            // mnuKes
            // 
            this.mnuKes.Name = "mnuKes";
            this.mnuKes.Size = new System.Drawing.Size(152, 22);
            this.mnuKes.Text = "Kes";
            // 
            // mnuKopyala
            // 
            this.mnuKopyala.Name = "mnuKopyala";
            this.mnuKopyala.Size = new System.Drawing.Size(152, 22);
            this.mnuKopyala.Text = "Kopyala";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuYapistir
            // 
            this.mnuYapistir.Name = "mnuYapistir";
            this.mnuYapistir.Size = new System.Drawing.Size(152, 22);
            this.mnuYapistir.Text = "Yapıştır";
            // 
            // mnuIslem
            // 
            this.mnuIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeniKayit,
            this.mnuKayitGuncelle,
            this.toolStripMenuItem3,
            this.mnuKayitSil,
            this.toolStripMenuItem4,
            this.mnuYenile});
            this.mnuIslem.Name = "mnuIslem";
            this.mnuIslem.Size = new System.Drawing.Size(47, 20);
            this.mnuIslem.Text = "İşlem";
            // 
            // mnuYeniKayit
            // 
            this.mnuYeniKayit.Name = "mnuYeniKayit";
            this.mnuYeniKayit.Size = new System.Drawing.Size(152, 22);
            this.mnuYeniKayit.Text = "Yeni Kayıt";
            this.mnuYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // mnuKayitGuncelle
            // 
            this.mnuKayitGuncelle.Name = "mnuKayitGuncelle";
            this.mnuKayitGuncelle.Size = new System.Drawing.Size(152, 22);
            this.mnuKayitGuncelle.Text = "Kayıt Güncelle";
            this.mnuKayitGuncelle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuKayitSil
            // 
            this.mnuKayitSil.Name = "mnuKayitSil";
            this.mnuKayitSil.Size = new System.Drawing.Size(152, 22);
            this.mnuKayitSil.Text = "Kayıt Sil";
            this.mnuKayitSil.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuYenile
            // 
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.Size = new System.Drawing.Size(152, 22);
            this.mnuYenile.Text = "Yenile";
            this.mnuYenile.Click += new System.EventHandler(this.mnuYenile_Click);
            // 
            // mnuHakkinda
            // 
            this.mnuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYardim,
            this.toolStripMenuItem5,
            this.mnuProgramBilgisi});
            this.mnuHakkinda.Name = "mnuHakkinda";
            this.mnuHakkinda.Size = new System.Drawing.Size(69, 20);
            this.mnuHakkinda.Text = "Hakkında";
            // 
            // mnuYardim
            // 
            this.mnuYardim.Name = "mnuYardim";
            this.mnuYardim.Size = new System.Drawing.Size(154, 22);
            this.mnuYardim.Text = "Yardım";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuProgramBilgisi
            // 
            this.mnuProgramBilgisi.Name = "mnuProgramBilgisi";
            this.mnuProgramBilgisi.Size = new System.Drawing.Size(154, 22);
            this.mnuProgramBilgisi.Text = "Program Bilgisi";
            this.mnuProgramBilgisi.Click += new System.EventHandler(this.mnuProgramBilgisi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.lblKayitSayisi,
            this.lblSonİslem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(444, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaat
            // 
            this.lblSaat.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSaat.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSaat.ForeColor = System.Drawing.Color.Blue;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 19);
            this.lblSaat.Text = "Saat";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblKayitSayisi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(69, 19);
            this.lblKayitSayisi.Text = "Kayıt Sayısı";
            // 
            // lblSonİslem
            // 
            this.lblSonİslem.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSonİslem.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSonİslem.Name = "lblSonİslem";
            this.lblSonİslem.Size = new System.Drawing.Size(62, 19);
            this.lblSonİslem.Text = "Son İşlem";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKayit,
            this.btnKayitDuzenle,
            this.btnSilme,
            this.btnKaydet,
            this.btnKes,
            this.btnKopyala,
            this.btnYapıştır,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniKayit.Image = global::Kayit_Defteri.Properties.Resources.if_file_add_48761;
            this.btnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(23, 22);
            this.btnYeniKayit.Text = "&New";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayitDuzenle.Image = global::Kayit_Defteri.Properties.Resources.if_document_edit_48757;
            this.btnKayitDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(23, 22);
            this.btnKayitDuzenle.Text = "Edit";
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSilme.Image = global::Kayit_Defteri.Properties.Resources.if_file_delete_48762;
            this.btnSilme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(23, 22);
            this.btnSilme.Text = "Delete";
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(23, 22);
            this.btnKaydet.Text = "&Save";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(23, 22);
            this.btnKes.Text = "C&ut";
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(23, 22);
            this.btnKopyala.Text = "&Copy";
            // 
            // btnYapıştır
            // 
            this.btnYapıştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapıştır.Image = ((System.Drawing.Image)(resources.GetObject("btnYapıştır.Image")));
            this.btnYapıştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapıştır.Name = "btnYapıştır";
            this.btnYapıştır.Size = new System.Drawing.Size(23, 22);
            this.btnYapıştır.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuDuzen;
        private System.Windows.Forms.ToolStripMenuItem mnuKes;
        private System.Windows.Forms.ToolStripMenuItem mnuKopyala;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuYapistir;
        private System.Windows.Forms.ToolStripMenuItem mnuIslem;
        private System.Windows.Forms.ToolStripMenuItem mnuYeniKayit;
        private System.Windows.Forms.ToolStripMenuItem mnuKayitGuncelle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuKayitSil;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuYenile;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem mnuYardim;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuProgramBilgisi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblKayitSayisi;
        private System.Windows.Forms.ToolStripStatusLabel lblSonİslem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeniKayit;
        private System.Windows.Forms.ToolStripButton btnKayitDuzenle;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapıştır;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnSilme;
        private System.Windows.Forms.ToolStripMenuItem mnuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.Timer tmrSaat;
    }
}

