using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace QLTRUNGTAMHOCTHEM
{
    public partial class frm_QLGiaoVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_QLGiaoVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        public void LoadGV()
        {
            string sql = "Select * from Teachers";
            dataGridView_QLGiaoVien.DataSource = lopchung.LoadDL(sql);
        }

        private void frm_QLGiaoVien_Load(object sender, EventArgs e)
        {
            LoadGV();
        }
    }
}
