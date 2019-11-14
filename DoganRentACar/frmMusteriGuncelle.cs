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
    public partial class frmMusteriGuncelle : Form
    {
        public frmMusteriGuncelle()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        public int id;
        private void frmMusteriGuncelle_Load(object sender, EventArgs e)
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
        Musteriler musteriler;
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
                frmMusteriListesi frmMusteriListesi = new frmMusteriListesi();
                frmMusteriListesi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kullanıcı Silinsin Mi?", "Kullanıcı Sil", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                db.Musterilers.Remove(musteriler);
                db.SaveChanges();
                frmMusteriListesi frmMusteriListesi = new frmMusteriListesi();
                frmMusteriListesi.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            
        }
    }
}
