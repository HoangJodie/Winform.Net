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

namespace QLTRUNGTAMHOCTHEM
{
    public partial class frm_QLLop : Form
    {
        LOPDUNGCHUNG lopchung=new LOPDUNGCHUNG();
        public frm_QLLop()
        {
            InitializeComponent();
        }
        public void LoadLH()
        {
            string sql = "Select * from Classes";
            dataGridView_QLLop.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "insert into Classes values ('" + txt_MSLop.Text + "', N'" + txt_TenLop.Text + "', '" + cb_GVPhuTrach.SelectedValue + "', '" + txt_SLHocVien.Text + "', Convert(Datetime, '" + date_NgayBatDau.Value + "', 103))";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm lớp học thành công");
            else MessageBox.Show("Thêm lớp học thất bại");
            LoadLH();
        }

        private void frm_QLLop_Load(object sender, EventArgs e)
        {
            LoadLH();
            string sql = "Select * from Teachers";
            cb_GVPhuTrach.DataSource = lopchung.LoadDL(sql);
            cb_GVPhuTrach.DisplayMember = "Teacher_Name";
            cb_GVPhuTrach.ValueMember = "Teacher_ID";
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "update Classes set Class_Name=N'" + txt_TenLop.Text + "',Teacher_ID = '" + cb_GVPhuTrach.SelectedValue+ "', Class_Amount = Convert(int, '"+txt_SLHocVien.Text+"'), Start_Date=Convert(Datetime, '" + date_NgayBatDau.Value + "', 103) Where Class_ID='" + txt_MSLop.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa lớp thành công");
            else MessageBox.Show("Sửa lớp thất bại");
            LoadLH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete Classes where  Class_ID='" + txt_MSLop.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xóa lớp thành công");
            else MessageBox.Show("Xóa lớp thất bại");
            LoadLH();
        }

        private void dataGridView_QLLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSLop.Text = dataGridView_QLLop.CurrentRow.Cells["Class_ID"].Value.ToString();
            txt_TenLop.Text = dataGridView_QLLop.CurrentRow.Cells["Class_Name"].Value.ToString();
            cb_GVPhuTrach.SelectedValue = dataGridView_QLLop.CurrentRow.Cells["Teacher_ID"].Value.ToString();
            txt_SLHocVien.Text = dataGridView_QLLop.CurrentRow.Cells["Class_Amount"].Value.ToString();
            date_NgayBatDau.Value = Convert.ToDateTime(dataGridView_QLLop.Rows[e.RowIndex].Cells["Start_Date"].Value);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tenLop = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp cần tìm.");
                return;
            }

            string sql = "SELECT Class_ID, Class_Name, Teacher_ID, Class_Amount, Start_Date FROM Classes WHERE Class_Name LIKE @tenLop";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D2Q783K;Initial Catalog=QLLopHocDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenLop", "%" + tenLop + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_QLLop.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Lớp không tồn tại.");
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
