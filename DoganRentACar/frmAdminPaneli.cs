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
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracEkle frmAracEkle = new frmAracEkle();
            frmAracEkle.Show();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriListesi frmMusteriListesi = new frmMusteriListesi();
            frmMusteriListesi.Show();
        }

        private void araçListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAracListesi adminAracListesi = new AdminAracListesi();
            adminAracListesi.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sözleşmeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSozlesmeListesi frmSozlesmeListesi = new frmSozlesmeListesi();
            frmSozlesmeListesi.Show();
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
