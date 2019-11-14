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
    public partial class AracGuncelle : Form
    {
        public AracGuncelle()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        public int id;
        private void AracGuncelle_Load(object sender, EventArgs e)
        {


            arabalar = db.Arabalars.Find(id);
            txt_Plaka.Text = arabalar.Plaka.ToString();
            txt_Marka.Text = arabalar.Marka.ToString();
            txt_model.Text = arabalar.Model.ToString();
            cmb_tip.Text = arabalar.AracTipi.ToString();
            cmb_vites.Text = arabalar.Vites.ToString();
            cmb_yakit.Text = arabalar.YakitTipi.ToString();
            txt_fiyat.Text = arabalar.Fiyat.ToString();
            textBox4.Text = arabalar.Resim.ToString();
            pictureBox1.ImageLocation = Application.StartupPath + @"\resimler\" + arabalar.Resim;

        }
        Arabalar arabalar;
        string dosyaYolu;
        string dosyaAdi;
        private void button2_Click(object sender, EventArgs e)
        {

            if (arabalar.Plaka!=txt_Plaka.Text)
            {
                List<Arabalar> arabalars = new List<Arabalar>();
                arabalars = db.Arabalars.Where(x => x.Plaka == txt_Plaka.Text.Trim().Replace(" ", string.Empty)).ToList();
                if (arabalars.Count > 0)
                {
                    MessageBox.Show("Bu plakaya ait araba vardır.");
                    return;
                }
            }


            if (arabalar.Resim != textBox4.Text)
            {
                dosyaAdi = Path.GetFileName(dosyaYolu); //Dosya adını alma
                string kaynak = dosyaYolu;
                string hedef = Application.StartupPath + @"\Resimler\";
                string yeniad = txt_Plaka.Text.Trim().Replace(" ", string.Empty) + ".jpg";

                string path = hedef;
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] rgFiles = di.GetFiles();
                foreach (FileInfo fi in rgFiles)
                {
                    if (fi.Name == arabalar.Resim)
                    {
                        File.Delete(hedef + arabalar.Resim);
                    }
                }

                arabalar.Plaka = txt_Plaka.Text;
                arabalar.Marka = txt_Marka.Text;
                arabalar.Model = txt_model.Text;
                arabalar.AracTipi = cmb_tip.Text;
                arabalar.Vites = cmb_vites.Text;
                arabalar.YakitTipi = cmb_yakit.Text;
                arabalar.Fiyat = Convert.ToDouble(txt_fiyat.Text);
                arabalar.Resim = yeniad;
                arabalar.UpdateDate = DateTime.Now;

                db.Entry(db.Arabalars.Find(arabalar.ID)).CurrentValues.SetValues(arabalar);
                db.SaveChanges();

                File.Copy(kaynak, hedef + yeniad);

                MessageBox.Show("Guncellendi");

                AdminAracListesi adminAracListesi = new AdminAracListesi();
                adminAracListesi.Show();
                
                this.Hide();
            }
            else
            {
                arabalar.Plaka = txt_Plaka.Text;
                arabalar.Marka = txt_Marka.Text;
                arabalar.Model = txt_model.Text;
                arabalar.AracTipi = cmb_tip.Text;
                arabalar.Vites = cmb_vites.Text;
                arabalar.YakitTipi = cmb_yakit.Text;
                arabalar.Fiyat = Convert.ToDouble(txt_fiyat.Text);
                arabalar.Resim = textBox4.Text;
                arabalar.UpdateDate = DateTime.Now;

                db.Entry(db.Arabalars.Find(arabalar.ID)).CurrentValues.SetValues(arabalar);
                db.SaveChanges();
                MessageBox.Show("Guncellendi");

                AdminAracListesi adminAracListesi = new AdminAracListesi();
                adminAracListesi.Show();

                this.Hide();
            }
        }

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
            DialogResult result = MessageBox.Show("Kullanıcı Silinsin Mi?", "Kullanıcı Sil", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                db.Arabalars.Remove(arabalar);
                db.SaveChanges();

                AdminAracListesi adminAracListesi = new AdminAracListesi();
                adminAracListesi.Show();

                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
