using DoganRentACar.ORM.Context;
using DoganRentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoganRentACar
{
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Adi.Text) && !string.IsNullOrEmpty(txt_Soyadi.Text) && !string.IsNullOrEmpty(txt_EhliyetNo.Text) && !string.IsNullOrEmpty(txt_Telefon.Text) && !string.IsNullOrEmpty(txt_TC.Text) && !string.IsNullOrEmpty(txt_Sifre.Text) && !string.IsNullOrEmpty(txt_Mail.Text) && !string.IsNullOrEmpty(txt_Adres.Text))
            {
                Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!reg.IsMatch(txt_Mail.Text))
                {
                    MessageBox.Show("Geçersiz Mail Adresi");
                    return;
                }



                Musteriler musteriler = new Musteriler()
                {
                    Adi = txt_Adi.Text,
                    Soyadi = txt_Soyadi.Text,
                    EhliyetNo = txt_EhliyetNo.Text,
                    Telefon = txt_Telefon.Text,
                    TC = txt_TC.Text,
                    Sifre = txt_Sifre.Text,
                    Email = txt_Mail.Text,
                    Adres = txt_Adres.Text,
                    AktifMi = true,
                };
                db.Musterilers.Add(musteriler);
                db.SaveChanges();
                MessageBox.Show("Eklendi");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz..");
            }
        }

        private void frmKayitOl_Load(object sender, EventArgs e)
        {

        }
    }
}
