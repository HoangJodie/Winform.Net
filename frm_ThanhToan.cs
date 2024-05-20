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
    public partial class frm_ThanhToan : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_ThanhToan()
        {
            InitializeComponent();
        }
        public void LoadDL()
        {
            string sql = "Select * from Payments";
            dataGridView_QLThanhToan.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Payments values ('" + txt_MaThanhToan.Text + "','" + txt_MSSV.Text + "', '" + cb_MSLop.SelectedValue + "',Convert(Datetime, '" + date_NgayThanhToan.Value + "', 103), N'" + txt_SoTien.Text + "', '"+cb_Status.SelectedValue+"')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm thanh toán thành công");
            else MessageBox.Show("Thêm thanh toán thất bại");
            LoadDL();
        }

        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LoadDL();
            string sql = "Select * from Classes";
            cb_MSLop.DataSource = lopchung.LoadDL(sql);
            cb_MSLop.DisplayMember = "Class_ID";
            cb_MSLop.ValueMember = "Class_ID";
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update Payments set Student_ID = N'" + txt_MSSV.Text + "', Class_ID = '" + cb_MSLop.SelectedValue + "',Payment_Date = Convert(Datetime, '" + date_NgayThanhToan.Value + "', 103),Amount = '" + txt_SoTien.Text + "', Status='"+cb_Status.SelectedValue+"'  where Payment_ID = '" + txt_MaThanhToan.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật thanh toán thành công");
            else MessageBox.Show("Cập nhật thanh toán thất bại");
            LoadDL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Delete Payments where Payment_ID = N'" + txt_MaThanhToan.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá thanh toán thành công");
            else MessageBox.Show("Xoá thanh toán thất bại");
            LoadDL();
        }

        private void dataGridView_QLThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaThanhToan.Text = dataGridView_QLThanhToan.CurrentRow.Cells["Payment_ID"].Value.ToString();
            txt_MSSV.Text = dataGridView_QLThanhToan.CurrentRow.Cells["Student_ID"].Value.ToString();
            cb_MSLop.SelectedValue = dataGridView_QLThanhToan.CurrentRow.Cells["Class_ID"].Value.ToString();
            date_NgayThanhToan.Value = Convert.ToDateTime(dataGridView_QLThanhToan.Rows[e.RowIndex].Cells["Payment_Date"].Value);
            txt_SoTien.Text = dataGridView_QLThanhToan.CurrentRow.Cells["Amount"].Value.ToString();
            cb_Status.SelectedValue = dataGridView_QLThanhToan.CurrentRow.Cells["Status"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string paymentID = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(paymentID))
            {
                MessageBox.Show("Vui lòng nhập mã thanh toán cần tìm.");
                return;
            }

            string sql = "SELECT Payment_ID, Student_ID, Class_ID, Payment_Date, Amount, Status FROM Payments WHERE Payment_ID LIKE @PaymentID";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D2Q783K;Initial Catalog=QLLopHocDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PaymentID", "%" + paymentID + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView_QLThanhToan.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Mã thanh toán không tồn tại.");
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
