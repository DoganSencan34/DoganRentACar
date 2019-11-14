using DoganRentACar.ORM.Context;
using DoganRentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoganRentACar
{
    public partial class frmKullaniciİslemleri : Form
    {
        public frmKullaniciİslemleri()
        {
            InitializeComponent();
        }
        Musteriler musteriler;
        ProjectContext db = new ProjectContext();
        public int id;
        private void frmKullaniciİslemleri_Load(object sender, EventArgs e)
        {
            musteriler = db.Musterilers.Find(id);
            txt_Adi.Text = musteriler.Adi;
            txt_Soyadi.Text = musteriler.Soyadi;
            txt_EhliyetNo.Text = musteriler.EhliyetNo;
            txt_Telefon.Text = musteriler.Telefon;
            txt_TC.Text = musteriler.TC;
            txt_Sifre.Text = musteriler.Sifre;
            txt_Mail.Text = musteriler.Email;
            txt_Adres.Text = musteriler.Adres;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Adi.Text) && !string.IsNullOrEmpty(txt_Soyadi.Text) && !string.IsNullOrEmpty(txt_EhliyetNo.Text) && !string.IsNullOrEmpty(txt_Telefon.Text) && !string.IsNullOrEmpty(txt_TC.Text) && !string.IsNullOrEmpty(txt_Sifre.Text) && !string.IsNullOrEmpty(txt_Mail.Text) && !string.IsNullOrEmpty(txt_Adres.Text))
            {
                musteriler.Adi = txt_Adi.Text;
                musteriler.Soyadi = txt_Soyadi.Text;
                musteriler.EhliyetNo = txt_EhliyetNo.Text;
                musteriler.Telefon = txt_Telefon.Text;
                musteriler.TC = txt_TC.Text;
                musteriler.Sifre = txt_Sifre.Text;
                musteriler.Email = txt_Mail.Text;
                musteriler.Adres = txt_Adres.Text;
                musteriler.UpdateDate = DateTime.Now;

                db.Entry(db.Musterilers.Find(musteriler.ID)).CurrentValues.SetValues(musteriler);
                db.SaveChanges();
                MessageBox.Show("Guncellendi");
                Form1 form1 = new Form1();
                form1.kid = id.ToString();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.kid = id.ToString();
            form1.Show();
            this.Hide();
        }
    }
}
