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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string kid="";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAracListesi frmAracListesi = new frmAracListesi();
            frmAracListesi.kid = kid;
            frmAracListesi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKullaniciİslemleri frmKullaniciİslemleri = new frmKullaniciİslemleri();
            frmKullaniciİslemleri.id = Convert.ToInt32(kid);
            frmKullaniciİslemleri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
