using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;
using Microsoft.VisualBasic;


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
            string sql = "insert into Teachers values ('" + txt_MSGV.Text + "', N'" + txt_Hoten.Text + "', '" + txt_SDT.Text + "', '" + txt_Email.Text + "', N'" + txt_DiaChi.Text + "', N'"+txt_Certi.Text+"', '" + cb_GioiTinh.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm giáo viên thành công");
            else MessageBox.Show("Thêm giáo viên thất bại");
            LoadGV();
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "update Teachers set  Teacher_Name=N'" + txt_Hoten.Text + "', Phone_Number='" + txt_SDT.Text + "',Email='" + txt_Email.Text + "',Address=N'" + txt_DiaChi.Text + "', Certificate=N'"+txt_Certi.Text+"',Gender='" + cb_GioiTinh.SelectedValue + "' where Teacher_ID='" + txt_MSGV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa giáo viên thành công");
            else MessageBox.Show("Sửa giáo viên thất bại");
            LoadGV();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete Teachers where  Teacher_ID='" + txt_MSGV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa giáo viên thành công");
            else MessageBox.Show("Xóa giáo viên thất bại");
            LoadGV();
        }

        private void dataGridView_QLGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSGV.Text = dataGridView_QLGiaoVien.CurrentRow.Cells["Teacher_ID"].Value.ToString();
            txt_Hoten.Text = dataGridView_QLGiaoVien.CurrentRow.Cells["Teacher_Name"].Value.ToString();
            txt_SDT.Text = dataGridView_QLGiaoVien.CurrentRow.Cells["Phone_Number"].Value.ToString();
            txt_Email.Text = dataGridView_QLGiaoVien.CurrentRow.Cells["Email"].Value.ToString();
            txt_DiaChi.Text = dataGridView_QLGiaoVien.CurrentRow.Cells["Address"].Value.ToString();
            txt_Certi.Text = dataGridView_QLGiaoVien.CurrentRow.Cells["Certificate"].Value.ToString();
            cb_GioiTinh.SelectedValue = dataGridView_QLGiaoVien.CurrentRow.Cells["Gender"].Value.ToString();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            string tenGiangVien = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenGiangVien))
            {
                MessageBox.Show("Vui lòng nhập tên giảng viên cần tìm.");
                return;
            }

            string sql = "SELECT Teacher_ID, Teacher_Name, Phone_Number, Email, Address, Certificate, Gender FROM Teachers WHERE Teacher_Name LIKE @tenGiangVien";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D2Q783K;Initial Catalog=QLLopHocDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenGiangVien", "%" + tenGiangVien + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_QLGiaoVien.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Giảng viên không tồn tại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
