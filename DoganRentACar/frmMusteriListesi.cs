using DoganRentACar.ORM.Context;
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
    public partial class frmMusteriListesi : Form
    {
        public frmMusteriListesi()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Musterilers.Where(x => x.AktifMi == true ).ToList();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
            int id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            frmMusteriGuncelle frmMusteriGuncelle = new frmMusteriGuncelle();
            frmMusteriGuncelle.id = id;
            frmMusteriGuncelle.Show();
            this.Hide();
            
        }
    }
}
