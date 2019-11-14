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
    public partial class AdminAracListesi : Form
    {
        public AdminAracListesi()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void AdminAracListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Arabalars.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AracGuncelle aracGuncelle = new AracGuncelle();

            aracGuncelle.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            this.Hide();
            aracGuncelle.Show();
        }
    }
}
