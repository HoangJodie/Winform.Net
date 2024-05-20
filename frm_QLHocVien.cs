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
    public partial class frm_QLHocVien : Form
    {
       LOPDUNGCHUNG dungchung = new LOPDUNGCHUNG();
        public frm_QLHocVien()
        {
            InitializeComponent();
            LoadHocVien();
        }

        public void LoadHocVien()
        {
            string sql = "SELECT Student_ID, Student_Name, FORMAT(Date_Of_Birth, 'dd/MM/yyyy') AS Date_Of_Birth, Gender, Phone_Number, Email, Address FROM Students";
            dataGridView_QLHocVien.DataSource = dungchung.LoadDL(sql);
        }
        public void HienThiSoLuongSinhVien()
        {
            string sql = "SELECT COUNT(*) FROM Students";
            int soLuong = (int)dungchung.LayGT(sql);
            txt_SoSV.Text = soLuong.ToString();
        }

        public void TimKiemHocVien()
        {
            string tenHocVien = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenHocVien))
            {
                MessageBox.Show("Vui lòng nhập tên học viên cần tìm.");
                return;
            }

            string sql = "SELECT Student_ID, Student_Name, FORMAT(Date_Of_Birth, 'dd/MM/yyyy') AS Date_Of_Birth, Gender, Phone_Number, Email, Address FROM Students WHERE Student_Name LIKE N'%" + tenHocVien + "%'";
            DataTable dt = dungchung.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                dataGridView_QLHocVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Học viên không tồn tại.");
            }
        }

        public void ClearForm()
        {
            txt_MSSV.Clear();
            txt_Hoten.Clear();
            dateTimePicker1.Value = DateTime.Now; 
            cb_GioiTinh.SelectedIndex = -1;
            txt_SDT.Clear();
            txt_Email.Clear();
            txt_DiaChi.Clear();
            txt_TimKiem.Clear();
            LoadHocVien();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Students values (N'" + txt_MSSV.Text + "',N'" + txt_Hoten.Text + "',N'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',N'" + cb_GioiTinh.Text + "','" + txt_SDT.Text + "','" + txt_Email.Text + "',N'" + txt_DiaChi.Text + "')";
            int kq = dungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm học viên thành công");
            else MessageBox.Show("Thêm học viên thất bại");
            LoadHocVien();
            HienThiSoLuongSinhVien();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Students SET Student_Name = N'" + txt_Hoten.Text + "', Date_Of_Birth = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                         "', Gender = N'" + cb_GioiTinh.Text + "', Phone_Number = '" + txt_SDT.Text + "', Email = '" + txt_Email.Text + "', Address = N'" + txt_DiaChi.Text +
                         "' WHERE Student_ID = N'" + txt_MSSV.Text + "'";
            int kq = dungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật Học Viên thành công");
            else MessageBox.Show("Cập nhật Học Viên thất bại");
            LoadHocVien();
            HienThiSoLuongSinhVien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete Students where Student_ID = N'" + txt_MSSV.Text + "'";
            int kq = dungchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá học viên thành công");
            else MessageBox.Show("Xoá học viên thất bại");
            LoadHocVien();
            HienThiSoLuongSinhVien();
        }

        private void dataGridView_QLHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_QLHocVien.Rows[e.RowIndex];
                txt_MSSV.Text = row.Cells["Student_ID"].Value.ToString();
                txt_Hoten.Text = row.Cells["Student_Name"].Value.ToString();

                string dateOfBirthString = row.Cells["Date_Of_Birth"].Value.ToString();
                DateTime dateOfBirth;
                bool isValidDate = DateTime.TryParseExact(
                    dateOfBirthString,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out dateOfBirth
                );

                if (isValidDate)
                {
                    dateTimePicker1.Value = dateOfBirth;
                }
                else
                {
                    MessageBox.Show("Định dạng ngày tháng không hợp lệ: " + dateOfBirthString);
                }

                cb_GioiTinh.Text = row.Cells["Gender"].Value.ToString();
                txt_SDT.Text = row.Cells["Phone_Number"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_DiaChi.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            HienThiSoLuongSinhVien();

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            TimKiemHocVien();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
