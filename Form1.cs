using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayit_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet Ds = new DataSet();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //    DataTable Dt = new DataTable("Kişiler");

            //    DataColumn dcId = new DataColumn("ID");
            //    DataColumn dcAd = new DataColumn("AD");
            //    DataColumn dcSoyad = new DataColumn("SOYAD");
            //    DataColumn dcTelefonNo = new DataColumn("TELEFON NO");

            //    Dt.Columns.Add(dcId);
            //    Dt.Columns.Add(dcAd);
            //    Dt.Columns.Add(dcSoyad);
            //    Dt.Columns.Add(dcTelefonNo);

            //    Ds.Tables.Add(Dt);

            //    this.dataGridView1.DataSource = Dt;
            //Ds.Tables.Clear();
            //Ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);

            //if (Ds.Tables.Count > 0)
            //{
            //    this.dataGridView1.DataSource = Ds.Tables[0];
            //    this.KayitSayisiHesaplama();
            //    this.lblSonİslem.Text = "Veriler Yüklendi";
            //}
            this.VerileriYukle();
        

        }
        
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FrmYeniKayit frm = new FrmYeniKayit();
            DialogResult sonuc =  frm.ShowDialog();

            if (sonuc==System.Windows.Forms.DialogResult.OK)
            {
                Kisi Yenikisi = frm.YeniKisi;

                DataTable Dt = this.dataGridView1.DataSource as DataTable;

               DataRow Dr = Dt.NewRow();
                Dr[0] = Yenikisi.Id;
                Dr[1] = Yenikisi.Ad;
                Dr[2] = Yenikisi.Soyad;
                Dr[3] = Yenikisi.TelefonNo;

                Dt.Rows.Add(Dr);
               this.KayitSayisiHesaplama();
                this.lblSonİslem.Text = "Yeni Kayıt eklendi.";

            }
        }
            
        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow !=null)
            {
              

                FrmDuzenle frm = new FrmDuzenle();

                frm.GuncellenecekKisi = new Kisi();
                frm.GuncellenecekKisi.Ad = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.GuncellenecekKisi.Soyad = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.GuncellenecekKisi.TelefonNo = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DialogResult Sonuc = frm.ShowDialog();

                if (Sonuc==System.Windows.Forms.DialogResult.OK)
                {
                    DataRowView Drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow Dr = Drv.Row;
                    Dr[1] = frm.GuncellenecekKisi.Ad;
                    Dr[2] = frm.GuncellenecekKisi.Soyad;
                    Dr[3] = frm.GuncellenecekKisi.TelefonNo;
                    this.lblSonİslem.Text = "Kayıt düzenleme işlemi yapıldı.";

                }
            }
        }

        private void btnSilme_Click(object sender, EventArgs e) 
        {
            if (this.dataGridView1.CurrentRow !=null)
            {
                DialogResult sonuc = MessageBox.Show("Seçili Kaydi Silmek İstediğinizden Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow dr = drv.Row;
                    dr.Delete();
                    this.KayitSayisiHesaplama();
                    this.lblSonİslem.Text = "Kayıt silme işlemi yapıldı.";
                }
            }
          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ds.WriteXml(Application.StartupPath + "\\" + "data.xml", XmlWriteMode.WriteSchema);
            this.lblSonİslem.Text = "Veriler kaydedildi.";
        }

        private void mnuYenile_Click(object sender, EventArgs e)
        {
            this.VerileriYukle();
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            this.lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void mnuProgramBilgisi_Click(object sender, EventArgs e)
        {
            UygulamaHakkında frm = new UygulamaHakkında();
            frm.ShowDialog();
        }

        private void KayitSayisiHesaplama()
        {
            this.lblKayitSayisi.Text = "Kayıt Sayısı : " + this.dataGridView1.RowCount.ToString();
            

        }

        private void VerileriYukle()
        {
            Ds.Tables.Clear();
            Ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);

            if (Ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = Ds.Tables[0];
                this.KayitSayisiHesaplama();
                this.lblSonİslem.Text = "Veriler Yüklendi";
            }


        }

       
    }
} 
