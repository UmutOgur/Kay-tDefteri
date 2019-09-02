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
    public partial class FrmDuzenle : Form
    {
        public Kisi GuncellenecekKisi { get; set; }

        public FrmDuzenle()
        {
            InitializeComponent();
        }

     

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.GuncellenecekKisi.Ad = this.txtAd.Text;
            this.GuncellenecekKisi.Soyad = this.txtsoyad.Text;
            this.GuncellenecekKisi.TelefonNo = this.txtTelNo.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();

        }
        private void FrmDuzenle_Load(object sender, EventArgs e)
        {
            if (this.GuncellenecekKisi != null)
            {
                this.txtAd.Text = GuncellenecekKisi.Ad;
                this.txtsoyad.Text = GuncellenecekKisi.Soyad;
                this.txtTelNo.Text = GuncellenecekKisi.TelefonNo;

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

            TextBox txt = this.ActiveControl as TextBox;
            if (txt != null)
            {
                txt.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

            TextBox txt = this.ActiveControl as TextBox;
            if (txt != null)
            {
                txt.Copy();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

            TextBox txt = this.ActiveControl as TextBox;
            if (txt != null)
            {
                txt.Paste();
            }
        }
    }
}
