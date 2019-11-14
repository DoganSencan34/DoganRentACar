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
    public partial class frmSozlesmeListesi : Form
    {
        public frmSozlesmeListesi()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        public void Goster()
        {
            dataGridView1.DataSource = db.Kiralamas.Where(x => x.AktifMi == true).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }
        private void frmSozlesmeListesi_Load(object sender, EventArgs e)
        {
            Goster();
        }
        Kiralama kiralamas;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                //List<Kiralama> kiralamas = new List<Kiralama>();
                kiralamas = new Kiralama();
                kiralamas = db.Kiralamas.Find(id);

                Arabalar arabalar = new Arabalar();
                arabalar = db.Arabalars.Find(kiralamas.ArabaID);

                Musteriler musteriler = new Musteriler();
                musteriler = db.Musterilers.Find(kiralamas.MusteriID);

                textBox1.Text = arabalar.Marka.ToString();
                textBox2.Text = musteriler.Adi.ToString();

                textBox3.Text = kiralamas.AlisTarihi.ToString();
                textBox4.Text = kiralamas.TeslimTarihi.ToString();
                textBox5.Text = kiralamas.KiralanmaSuresi.ToString();
                textBox6.Text = kiralamas.FaturaTutari.ToString();

                textBox7.Text = arabalar.Model.ToString();
            }
            catch (Exception)
            {

                return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiralamas.AktifMi = false;

            db.Entry(db.Kiralamas.Find(kiralamas.ID)).CurrentValues.SetValues(kiralamas);
            db.SaveChanges();
            MessageBox.Show("Pasif Yapıldı");
            Goster();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;

            textBox7.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sözleşme Silinsin Mi?", "Kullanıcı Sil", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                db.Kiralamas.Remove(kiralamas);
                db.SaveChanges();
                Goster();

            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
