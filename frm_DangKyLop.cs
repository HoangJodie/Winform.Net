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
    public partial class frm_DangKyLop : Form
    {
        LOPDUNGCHUNG dungchung = new LOPDUNGCHUNG();
        public frm_DangKyLop()
        {
            InitializeComponent();
        }

        private void LoadDanhSachLop()
        {
            string sql = "SELECT Class_Name FROM Classes";  // 'Classes' là tên bảng, 'Class_Name' là cột chứa tên lớp
            DataTable dt = dungchung.LoadDL(sql);  // dungchung là thể hiện của lớp LOPDUNGCHUNG

            cb_TenLop.DataSource = dt;
            cb_TenLop.DisplayMember = "Class_Name";  // Thiết lập thuộc tính DisplayMember để chỉ định cột nào sẽ được hiển thị trong ComboBox
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string idHocVien = txt_MSSV.Text.Trim();
            if (string.IsNullOrEmpty(idHocVien))
            {
                MessageBox.Show("Vui lòng nhập mã số học viên cần tìm.");
                return;
            }

            // Correctly format the SQL for a LIKE query
            string sql = "SELECT Student_Name FROM Students WHERE Student_ID LIKE '%" + idHocVien + "%'";
            string tenSV = dungchung.LayDL(sql);
            txt_HoTen.Text = tenSV;  // tenSV will be "Not found" if no result is returned

            // Optionally, update data grid or other components
            // If tenSV returns "Not found", you might want to inform the user
            if (tenSV == "Not found")
            {
                MessageBox.Show("Học viên không tồn tại.");
            }
        }

        private void LoadDataIntoDataGridView()
        {
            string sql = @"
            SELECT sc.Student_Class_ID, s.Student_ID, s.Student_Name, c.Class_Name, c.Class_ID
            FROM Students s
            JOIN Students_Classes sc ON s.Student_ID = sc.Student_ID
            JOIN Classes c ON sc.Class_ID = c.Class_ID";

            DataTable dt = dungchung.LoadDL(sql);
            dataGridView_QLDKLop.DataSource = dt;

            dataGridView_QLDKLop.Columns["Student_Class_ID"].HeaderText = "Mã Đăng Ký";
            dataGridView_QLDKLop.Columns["Student_ID"].HeaderText = "ID Học Sinh";
            dataGridView_QLDKLop.Columns["Student_Name"].HeaderText = "Tên Học Sinh";
            dataGridView_QLDKLop.Columns["Class_ID"].HeaderText = "ID Lớp";
            dataGridView_QLDKLop.Columns["Class_Name"].HeaderText = "Tên Lớp";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txt_MSSV.Text.Trim();
                string regID = txt_maDK.Text.Trim();
                string classID = cb_TenLop.SelectedValue.ToString();
                string sqlInsertStudentClass = $"INSERT INTO Students_Classes (Student_Class_ID, Student_ID, Class_ID) VALUES ('{regID}','{studentID}', '{classID}')";
                try
                {
                    // Thực hiện các truy vấn

                    int result = dungchung.ThemXoaSua(sqlInsertStudentClass);

                    if (result > 0)
                        MessageBox.Show("Thêm mới dữ liệu thành công!");
                    else
                        MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                catch (Exception ex)
                {
                    dungchung.conn.Close();
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
            }catch(Exception ex)
            {
                dungchung.conn.Close();
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            LoadDanhSachLop();
        }

        private void LoadComboBoxClasses()
        {
            string sql = "Select * from Classes";
            cb_TenLop.DataSource = dungchung.LoadDL(sql);
            cb_TenLop.DisplayMember = "Class_ID";
            cb_TenLop.ValueMember = "Class_ID";
        }

        private void frm_DangKyLop_Load(object sender, EventArgs e)
        {
            LoadDanhSachLop();
            LoadDataIntoDataGridView();
            LoadComboBoxClasses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classID = cb_TenLop.SelectedValue.ToString();

            

            DataTable classes = cb_TenLop.DataSource as DataTable;
            DataRow[] rows = classes.Select("Class_ID = '" + classID + "'");
            if (rows.Length > 0)
            {
                textBox1.Text = rows[0]["Class_Name"].ToString();
            }
            else
            {
                textBox1.Text = "Tên lớp không tìm thấy!";
            }
        }

        private void dataGridView_QLDKLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem click có hợp lệ (trên hàng có dữ liệu)
    {
        DataGridViewRow row = dataGridView_QLDKLop.Rows[e.RowIndex];

        // Đưa dữ liệu vào các control
        txt_MSSV.Text = row.Cells["Student_ID"].Value.ToString();
        txt_maDK.Text = row.Cells["Student_Class_ID"].Value.ToString();
        txt_HoTen.Text = row.Cells["Student_Name"].Value.ToString();
        cb_TenLop.SelectedValue = row.Cells["Class_ID"].Value.ToString();
        textBox1.Text = row.Cells["Class_Name"].Value.ToString();
    }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txt_MSSV.Text.Trim();
                string studentClassID = txt_maDK.Text.Trim();
                string classID = cb_TenLop.SelectedValue.ToString();

                string sqlUpdate = $"UPDATE Students_Classes SET Student_ID = '{studentID}', Class_ID = '{classID}' WHERE Student_Class_ID = '{studentClassID}'";

                int result = dungchung.ThemXoaSua(sqlUpdate);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDataIntoDataGridView();  // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string studentClassID = txt_maDK.Text.Trim();

                string sqlDelete = $"DELETE FROM Students_Classes WHERE Student_Class_ID = '{studentClassID}'";

                int result = dungchung.ThemXoaSua(sqlDelete);

                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDataIntoDataGridView();  // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string studentName = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên cần tìm.");
                return;
            }

            string sql = @"
            SELECT sc.Student_Class_ID, s.Student_ID, s.Student_Name, c.Class_Name, c.Class_ID 
            FROM Students s
            JOIN Students_Classes sc ON s.Student_ID = sc.Student_ID
            JOIN Classes c ON sc.Class_ID = c.Class_ID
            WHERE s.Student_Name LIKE '%" + studentName + "%'";

            DataTable dt = dungchung.LoadDL(sql);
            dataGridView_QLDKLop.DataSource = dt;
        }
    }
}
