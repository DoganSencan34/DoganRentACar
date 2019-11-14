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
    public partial class frmAracListesi : Form
    {
        public string kid;
        public frmAracListesi()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();



        private void frmAracListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Arabalars.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AracDetayVeKirala aracDetayVeKirala = new AracDetayVeKirala();
            aracDetayVeKirala.kid = kid;
            aracDetayVeKirala.id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            aracDetayVeKirala.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
