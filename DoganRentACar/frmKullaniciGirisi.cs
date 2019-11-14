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
    public partial class frmKullaniciGirisi : Form
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void button1_Click(object sender, EventArgs e)
        {
            string tc = "";
            string sifre = "";
            string id = "";
            List<Musteriler> mst = new List<Musteriler>();
            mst = db.Musterilers.Where(x => x.TC == txt_TC.Text).ToList();
            foreach (Musteriler musteri in mst)
            {
                tc = musteri.TC.ToString();
                sifre = musteri.Sifre.ToString();
                id = musteri.ID.ToString();
            }
            if (tc==txt_TC.Text)
            {
                if (sifre==txt_Sifre.Text)
                {
                    if (tc=="23453193112")
                    {
                        if (sifre=="1")
                        {
                            frmAdminPaneli frmAdminPaneli = new frmAdminPaneli();
                            frmAdminPaneli.Show();
                        }
                        else
                        {
                            MessageBox.Show("Şifre Yanlışş");
                        }
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        form1.kid = id;
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış.");
                }
            }
            else
            {
                MessageBox.Show("TC Numarası Bulunamadı.");
            }
        }

        private void frmKullaniciGirisi_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.Show();

        }
    }
}
