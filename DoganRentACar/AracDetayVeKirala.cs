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
    public partial class AracDetayVeKirala : Form
    {
        public AracDetayVeKirala()
        {
            InitializeComponent();
        }
        List<DateTime> list = new List<DateTime>();
        
        public void KontrolEt(int arabaid)
        {
            List<Kiralama> krl = new List<Kiralama>();
            krl = db.Kiralamas.Where(x => x.AktifMi==true && x.ArabaID ==arabaid).ToList();

            foreach (Kiralama item in krl)
            {
                DateTime start = new DateTime();
                start = item.AlisTarihi;
                DateTime end = new DateTime();
                end = item.TeslimTarihi;

                var dates = new List<DateTime>();
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);

                    list.Add(dt);
                }
            }
        }

        List<DateTime> secilentariharalıgı = new List<DateTime>();
        public bool GonderilenKontrol(DateTime AlisTarihi, DateTime TeslimTarihi)
        {
            
                DateTime start = new DateTime();
                start = AlisTarihi;
                DateTime end = new DateTime();
                end = TeslimTarihi;

                var dates = new List<DateTime>();
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);

                    secilentariharalıgı.Add(dt);
                }


            for (int i = 0; i < dates.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (dates[i].ToString()==list[j].ToString())
                    {
                        return false;
                    }
                }
            }

            return true;

        }



        ProjectContext db = new ProjectContext();
        public string kid;
        public int id;
        private void AracDetayVeKirala_Load(object sender, EventArgs e)
        {
            KontrolEt(id);
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Arabalars.Where(x => x.ID == id).ToList();

            foreach (Arabalar item in arabalars)
            {
                lbl_plk.Text = item.Plaka.ToString();
                lbl_marka.Text = item.Marka.ToString();
                lbl_model.Text =item.Model.ToString();
                lbl_aractipi.Text = item.AracTipi.ToString() ;
                lbl_vites.Text = item.Vites.ToString();
                lbl_yakittipi.Text = item.YakitTipi.ToString();
                lbl_fiyat.Text = item.Fiyat.ToString();
                pictureBox1.ImageLocation = Application.StartupPath + @"\resimler\" + item.Resim;
            }

            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }
        int gun;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);
            gun= GunFarki.Days;
            double hesapla= gun * Convert.ToDouble(lbl_fiyat.Text);
            lbl_tutaR.Text = hesapla.ToString();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a=GonderilenKontrol(dateTimePicker1.Value, dateTimePicker2.Value);
            if (a==false)
            {
                MessageBox.Show("İstediğiniz Tarihte Araba Dolu Olduğundan Veremiyoruz.");
            }
            else
            {
                Kiralama kiralama = new Kiralama
                {
                    ArabaID = id,
                    MusteriID = Convert.ToInt32(kid),
                    AlisTarihi = Convert.ToDateTime(dateTimePicker1.Value),
                    TeslimTarihi = Convert.ToDateTime(dateTimePicker2.Value),
                    KiralanmaSuresi = gun,
                    FaturaTutari = Convert.ToDouble(lbl_tutaR.Text),
                    AktifMi = true

                };
                db.Kiralamas.Add(kiralama);
                db.SaveChanges();

                MessageBox.Show("Araç Kiralandı.");
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
