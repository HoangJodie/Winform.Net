﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTRUNGTAMHOCTHEM
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=DESKTOP-NJU1DKG\SQLEXPRESS;Initial Catalog=QLLopHocDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            string sql = "Select COUNT(*) from Admin_Accounts where Username = '" + txt_Taikhoan.Text + "' and  Password = '" + txt_Matkhau.Text + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_Main frmMain = new frm_Main();
                frmMain.Show();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại");
                if (dem == 3) Application.Exit();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?\t", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chk_Hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Hienthi.Checked)
            {
                txt_Matkhau.PasswordChar = '\0';
            }
            else
            {
                txt_Matkhau.PasswordChar = '*';
            }
        }
    }
}