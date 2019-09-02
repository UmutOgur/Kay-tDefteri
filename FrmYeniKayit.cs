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
    public partial class FrmYeniKayit : Form
    {
        public Kisi YeniKisi { get; set;  }

        public FrmYeniKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.YeniKisi = new Kisi();
            this.YeniKisi.Id = new Guid();
           this.YeniKisi.Ad =this.txtAd.Text;
            this.YeniKisi.Soyad = this.txtsoyad.Text;
            this.YeniKisi.TelefonNo = this.txtTelNo.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;
            if (txt !=null)
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
