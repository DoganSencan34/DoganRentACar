using DoganRentACar.ORM.Context;
using DoganRentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoganRentACar
{
    public partial class frmAracEkle : Form
    {
        public frmAracEkle()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void button2_Click(object sender, EventArgs e)
        {
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Arabalars.Where(x=>x.Plaka==txt_Plaka.Text.Trim().Replace(" ", string.Empty)).ToList();
            if (arabalars.Count>0)
            {
                MessageBox.Show("Bu plakaya ait araba vardır.");
                return;
            }

            dosyaAdi = Path.GetFileName(dosyaYolu); //Dosya adını alma
            string kaynak = dosyaYolu;
            string hedef = Application.StartupPath + @"\Resimler\";
            string yeniad = txt_Plaka.Text.Trim().Replace(" ", string.Empty) + ".jpg";


            Arabalar arabalar = new Arabalar();
            arabalar.Plaka = txt_Plaka.Text;
            arabalar.Marka = txt_Marka.Text;
            arabalar.Model = txt_model.Text;
            arabalar.AracTipi = cmb_tip.Text;
            arabalar.Vites = cmb_vites.Text;
            arabalar.YakitTipi = cmb_yakit.Text;
            arabalar.Fiyat = Convert.ToDouble(txt_fiyat.Text);
            arabalar.AktifMi = true;
            arabalar.Resim = yeniad;

            db.Arabalars.Add(arabalar);
            db.SaveChanges();

            File.Copy(kaynak, hedef + yeniad);

            MessageBox.Show("Eklendi");
            this.Hide();

        }

        private void frmAracEkle_Load(object sender, EventArgs e)
        {

        }
        string dosyaYolu;
        string dosyaAdi;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png ;*.jpeg;*.gif|  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            dosyaYolu = dosya.FileName;
            textBox4.Text = dosyaYolu;
            pictureBox1.ImageLocation = dosyaYolu;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
