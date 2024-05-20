using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTRUNGTAMHOCTHEM
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_HocVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLHocVien"] == null)
            {
                frm_QLHocVien formhv = new frm_QLHocVien();
                formhv.MdiParent = this;
                formhv.TopMost = true;
                formhv.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_QLHocVien"].Activate();
        }

        private void btn_GiaoVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLGiaoVien"] == null)
            {
                frm_QLGiaoVien formgv = new frm_QLGiaoVien();
                formgv.MdiParent = this;
                formgv.TopMost = true;
                formgv.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_QLGiaoVien"].Activate();
        }

        private void btn_LopHoc_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLLop"] == null)
            {
                frm_QLLop forml = new frm_QLLop();
                forml.MdiParent = this;
                forml.TopMost = true;
                forml.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_QLLop"].Activate();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DangKyLop"] == null)
            {
                frm_DangKyLop formdk = new frm_DangKyLop();
                formdk.MdiParent = this;
                formdk.TopMost = true;
                formdk.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_DangKyLop"].Activate();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThanhToan"] == null)
            {
                frm_ThanhToan formtt = new frm_ThanhToan();
                formtt.MdiParent = this;
                formtt.TopMost = true;
                formtt.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_ThanhToan"].Activate();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongKe"] == null)
            {
                frm_ThongKe formtk = new frm_ThongKe();
                formtk.MdiParent = this;
                formtk.TopMost = true;
                formtk.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_ThongKe"].Activate();
        }


        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TrangChu"] == null)
            {
                frm_TrangChu formtc = new frm_TrangChu();
                formtc.MdiParent = this;
                formtc.TopMost = true;
                formtc.Show();
                pictureBox1.Hide();
            }
            else Application.OpenForms["frm_TrangChu"].Activate();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đăng xuất không?\t", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
