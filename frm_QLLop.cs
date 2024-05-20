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
            string sql = "SELECT cl.Class_ID, cl.Class_Name, cl.Teacher_ID, cl.Start_Date, cl.Class_Amount,           sch.Slot, rm.Room_Number      FROM Classes cl\r\n        INNER JOIN Schedules sch ON cl.Class_ID = sch.Class_ID        INNER JOIN Rooms rm ON sch.Room_ID = rm.Room_ID";
            dataGridView_QLLop.DataSource = lopchung.LoadDL(sql);
        }

        private int GetNextScheduleID()
        {
            string sql = "SELECT MAX(Schedules_ID) FROM Schedules";
            object result = lopchung.LayGT(sql);  
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToInt32(result) + 1;
            }
            return 1;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlClasses = "INSERT INTO Classes (Class_ID, Class_Name, Teacher_ID, Class_Amount, Start_Date) VALUES ('" +
                    txt_MSLop.Text + "', N'" + txt_TenLop.Text + "', '" + cb_GVPhuTrach.SelectedValue + "', '" +
                    txt_SLHocVien.Text + "', '" + date_NgayBatDau.Value.ToString("yyyy-MM-dd") + "')";

                int kqClasses = lopchung.ThemXoaSua(sqlClasses);

                int newScheduleID = GetNextScheduleID();
                int slot = int.Parse(cb_Suat.Text);

                string sqlSchedules = "INSERT INTO Schedules (Schedules_ID, Class_ID, Room_ID, Slot, Class_Date) VALUES ('" +
                    newScheduleID + "', '" + txt_MSLop.Text + "', '" + cb_Phong.SelectedValue + "', '" + slot + "', '" +
                    date_NgayBatDau.Value.ToString("yyyy-MM-dd") + "')";

                int kqSchedules = lopchung.ThemXoaSua(sqlSchedules);

                if (kqClasses >= 1 && kqSchedules >= 1)
                {
                    MessageBox.Show("Thêm lớp học và lịch học thành công");
                }
                else
                {
                    MessageBox.Show("Thêm lớp học hoặc lịch học thất bại");
                }

                LoadLH();
            }
            catch (Exception ex)
            {
                lopchung.conn.Close();
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void LoadRooms()
        {
            string sql = "SELECT Room_ID, Room_Number FROM Rooms";
            try
            {
                DataTable dt = lopchung.LoadDL(sql); 

                cb_Phong.DataSource = dt;          
                cb_Phong.DisplayMember = "Room_Number"; 
                cb_Phong.ValueMember = "Room_ID";   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message);
            }
        }

        private void frm_QLLop_Load(object sender, EventArgs e)
        {
            LoadLH();
            string sql = "Select * from Teachers";
            cb_GVPhuTrach.DataSource = lopchung.LoadDL(sql);
            cb_GVPhuTrach.DisplayMember = "Teacher_Name";
            cb_GVPhuTrach.ValueMember = "Teacher_ID";
            LoadRooms();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Update Classes table
                string sqlClasses = "UPDATE Classes SET Class_Name = N'" + txt_TenLop.Text +
                                    "', Teacher_ID = '" + cb_GVPhuTrach.SelectedValue +
                                    "', Class_Amount = " + Convert.ToInt32(txt_SLHocVien.Text) +
                                    ", Start_Date = '" + date_NgayBatDau.Value.ToString("yyyy-MM-dd") +
                                    "' WHERE Class_ID = '" + txt_MSLop.Text + "'";

                int kqClasses = lopchung.ThemXoaSua(sqlClasses);

                // Update Schedules table
                string sqlSchedules = "UPDATE Schedules SET Room_ID = '" + cb_Phong.SelectedValue +
                                      "', Slot = " + int.Parse(cb_Suat.Text) +
                                      ", Class_Date = '" + date_NgayBatDau.Value.ToString("yyyy-MM-dd") +
                                      "' WHERE Class_ID = '" + txt_MSLop.Text + "'";

                int kqSchedules = lopchung.ThemXoaSua(sqlSchedules);

                if (kqClasses >= 1 && kqSchedules >= 1)
                    MessageBox.Show("Cập nhật lớp học và lịch học thành công");
                else
                    MessageBox.Show("Cập nhật lớp học hoặc lịch học thất bại");

                LoadLH();
            }
            catch (Exception ex)
            {
                lopchung.conn.Close();
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete from Schedules table first due to foreign key constraints
                string sqlSchedules = "DELETE FROM Schedules WHERE Class_ID = '" + txt_MSLop.Text + "'";
                int kqSchedules = lopchung.ThemXoaSua(sqlSchedules);

                // Then delete from Classes table
                string sqlClasses = "DELETE FROM Classes WHERE Class_ID = '" + txt_MSLop.Text + "'";
                int kqClasses = lopchung.ThemXoaSua(sqlClasses);

                if (kqClasses >= 1 && kqSchedules >= 1)
                    MessageBox.Show("Xóa lớp học và lịch học thành công");
                else
                    MessageBox.Show("Xóa lớp học hoặc lịch học thất bại");

                LoadLH();
            }
            catch (Exception ex)
            {
                lopchung.conn.Close();
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void dataGridView_QLLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView_QLLop.Rows[e.RowIndex];

                txt_MSLop.Text = row.Cells["Class_ID"].Value.ToString();
                txt_TenLop.Text = row.Cells["Class_Name"].Value.ToString();
                cb_GVPhuTrach.SelectedValue = row.Cells["Teacher_ID"].Value.ToString();
                txt_SLHocVien.Text = row.Cells["Class_Amount"].Value.ToString();
                date_NgayBatDau.Value = Convert.ToDateTime(row.Cells["Start_Date"].Value);

                var slot_value = row.Cells["Slot"].Value;
                cb_Suat.Text = slot_value.ToString();
                cb_Phong.SelectedValue = row.Cells["Room_Number"].Value.ToString(); 
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tenLop = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp cần tìm.");
                return;
            }

            string sql = "SELECT Class_ID, Class_Name, Teacher_ID, Class_Amount, Start_Date FROM Classes WHERE Class_Name LIKE '%" + tenLop + "%'";

            try
            {
                LOPDUNGCHUNG db = new LOPDUNGCHUNG();
                DataTable dt = db.LoadDL(sql);
                if (dt.Rows.Count > 0)
                {
                    dataGridView_QLLop.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Lớp không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        
    }
}
