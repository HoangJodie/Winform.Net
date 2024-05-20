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
    public partial class frm_ThongKe : Form
    {
        LOPDUNGCHUNG db = new LOPDUNGCHUNG();

        public frm_ThongKe()
        {
            InitializeComponent();
            HienThiTongSoHocVien();
            HienThiTongSoGiaoVien();
            HienThiTongSoLopHoc();
            HienThiTongDoanhThu();
            HienThiSoHocVienThanhToanVaNoHocPhi();
            LoadDataIntoDataGridView();
        }

        private void HienThiTongSoHocVien()
        {
            try
            {
                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                string sql = "SELECT COUNT(*) FROM Students";
                object tongHocVien = db.LayGT(sql);
                lb_numberStudents.Text = "Tổng số học viên: " + tongHocVien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void HienThiTongSoGiaoVien()
        {
            try
            {
                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                string sql = "SELECT COUNT(*) FROM Teachers";
                object tongGiaoVien = db.LayGT(sql);
                lb_numberTeachers.Text = "Tổng số giáo viên: " + tongGiaoVien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void HienThiTongSoLopHoc()
        {
            try
            {
                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                string sql = "SELECT COUNT(*) FROM Classes";
                object tongLopHoc = db.LayGT(sql);
                lb_tongSoLopHoc.Text = "Tổng số lớp học: " + tongLopHoc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void HienThiTongDoanhThu()
        {
            try
            {
                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                string sql = "SELECT SUM(Amount) FROM Payments WHERE MONTH(Payment_Date) = MONTH(GETDATE()) AND YEAR(Payment_Date) = YEAR(GETDATE())";
                object tongDoanhThu = db.LayGT(sql);
                if (tongDoanhThu != DBNull.Value)
                    lb_tongDoanhThu.Text = "Tổng doanh thu trong tháng này: " + tongDoanhThu.ToString();
                else
                    lb_tongDoanhThu.Text = "Tổng doanh thu trong tháng này: 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void HienThiSoHocVienThanhToanVaNoHocPhi()
        {
            try
            {
                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                string sqlDaThanhToan = "SELECT COUNT(*) FROM Payments WHERE Status = 'True'";
                string sqlNoHocPhi = "SELECT COUNT(*) FROM Payments WHERE Status = 'False'";

                object soHocVienDaThanhToan = db.LayGT(sqlDaThanhToan);
                object soHocVienNoHocPhi = db.LayGT(sqlNoHocPhi);

                lb_daThanhToan.Text = "Tổng số học viên đã thanh toán: " + soHocVienDaThanhToan.ToString();
                lb_noHocPhi.Text = "Tổng số học viên nợ học phí: " + soHocVienNoHocPhi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        public void LoadDataIntoDataGridView()
        {
            try
            {
                string sql = @"
        SELECT 
            c.Class_Name AS 'Tên Lớp', 
            t.Teacher_Name AS 'Tên Giảng Viên', 
            COUNT(sc.Student_ID) AS 'Tổng Số Học Viên', 
            c.Start_Date AS 'Ngày Bắt Đầu', 
            SUM(p.Amount) AS 'Tổng Doanh Thu'
        FROM 
            Classes c
        INNER JOIN 
            Teachers t ON c.Teacher_ID = t.Teacher_ID
        LEFT JOIN 
            Students_Classes sc ON c.Class_ID = sc.Class_ID
        LEFT JOIN 
            Payments p ON c.Class_ID = p.Class_ID AND p.Status = 'True'
        GROUP BY 
            c.Class_Name, t.Teacher_Name, c.Start_Date";

                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                DataTable dt = db.LoadDL(sql);
                data_danhSachTongHop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }


        private void lb_numberStudents_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
