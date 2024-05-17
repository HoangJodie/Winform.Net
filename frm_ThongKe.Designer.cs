namespace QLTRUNGTAMHOCTHEM
{
    partial class frm_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_numberStudents = new System.Windows.Forms.Label();
            this.lb_numberTeachers = new System.Windows.Forms.Label();
            this.lb_tongSoLopHoc = new System.Windows.Forms.Label();
            this.lb_tongDoanhThu = new System.Windows.Forms.Label();
            this.lb_daThanhToan = new System.Windows.Forms.Label();
            this.lb_noHocPhi = new System.Windows.Forms.Label();
            this.data_danhSachTongHop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_danhSachTongHop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê";
            // 
            // lb_numberStudents
            // 
            this.lb_numberStudents.AutoSize = true;
            this.lb_numberStudents.Location = new System.Drawing.Point(41, 69);
            this.lb_numberStudents.Name = "lb_numberStudents";
            this.lb_numberStudents.Size = new System.Drawing.Size(119, 16);
            this.lb_numberStudents.TabIndex = 1;
            this.lb_numberStudents.Text = "Số lượng học viên: ";
            this.lb_numberStudents.Click += new System.EventHandler(this.lb_numberStudents_Click);
            // 
            // lb_numberTeachers
            // 
            this.lb_numberTeachers.AutoSize = true;
            this.lb_numberTeachers.Location = new System.Drawing.Point(44, 127);
            this.lb_numberTeachers.Name = "lb_numberTeachers";
            this.lb_numberTeachers.Size = new System.Drawing.Size(131, 16);
            this.lb_numberTeachers.TabIndex = 2;
            this.lb_numberTeachers.Text = "Số lượng giảng viên: ";
            // 
            // lb_tongSoLopHoc
            // 
            this.lb_tongSoLopHoc.AutoSize = true;
            this.lb_tongSoLopHoc.Location = new System.Drawing.Point(44, 187);
            this.lb_tongSoLopHoc.Name = "lb_tongSoLopHoc";
            this.lb_tongSoLopHoc.Size = new System.Drawing.Size(210, 16);
            this.lb_tongSoLopHoc.TabIndex = 3;
            this.lb_tongSoLopHoc.Text = "Số lượng lớp học đang hoạt động: ";
            // 
            // lb_tongDoanhThu
            // 
            this.lb_tongDoanhThu.AutoSize = true;
            this.lb_tongDoanhThu.Location = new System.Drawing.Point(362, 69);
            this.lb_tongDoanhThu.Name = "lb_tongDoanhThu";
            this.lb_tongDoanhThu.Size = new System.Drawing.Size(200, 16);
            this.lb_tongDoanhThu.TabIndex = 4;
            this.lb_tongDoanhThu.Text = "Tổng doanh thu trong tháng này: ";
            // 
            // lb_daThanhToan
            // 
            this.lb_daThanhToan.AutoSize = true;
            this.lb_daThanhToan.Location = new System.Drawing.Point(365, 127);
            this.lb_daThanhToan.Name = "lb_daThanhToan";
            this.lb_daThanhToan.Size = new System.Drawing.Size(245, 16);
            this.lb_daThanhToan.TabIndex = 5;
            this.lb_daThanhToan.Text = "Tổng số học viên đã thanh toán học phí: ";
            // 
            // lb_noHocPhi
            // 
            this.lb_noHocPhi.AutoSize = true;
            this.lb_noHocPhi.Location = new System.Drawing.Point(368, 186);
            this.lb_noHocPhi.Name = "lb_noHocPhi";
            this.lb_noHocPhi.Size = new System.Drawing.Size(205, 16);
            this.lb_noHocPhi.TabIndex = 6;
            this.lb_noHocPhi.Text = "Tổng số học viên còn nợ học phí: ";
            // 
            // data_danhSachTongHop
            // 
            this.data_danhSachTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_danhSachTongHop.Location = new System.Drawing.Point(44, 235);
            this.data_danhSachTongHop.Name = "data_danhSachTongHop";
            this.data_danhSachTongHop.RowHeadersWidth = 51;
            this.data_danhSachTongHop.RowTemplate.Height = 24;
            this.data_danhSachTongHop.Size = new System.Drawing.Size(746, 252);
            this.data_danhSachTongHop.TabIndex = 7;
            this.data_danhSachTongHop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 512);
            this.Controls.Add(this.data_danhSachTongHop);
            this.Controls.Add(this.lb_noHocPhi);
            this.Controls.Add(this.lb_daThanhToan);
            this.Controls.Add(this.lb_tongDoanhThu);
            this.Controls.Add(this.lb_tongSoLopHoc);
            this.Controls.Add(this.lb_numberTeachers);
            this.Controls.Add(this.lb_numberStudents);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(113, 45);
            this.Name = "frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.data_danhSachTongHop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_numberStudents;
        private System.Windows.Forms.Label lb_numberTeachers;
        private System.Windows.Forms.Label lb_tongSoLopHoc;
        private System.Windows.Forms.Label lb_tongDoanhThu;
        private System.Windows.Forms.Label lb_daThanhToan;
        private System.Windows.Forms.Label lb_noHocPhi;
        private System.Windows.Forms.DataGridView data_danhSachTongHop;
    }
}