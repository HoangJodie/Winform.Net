namespace QLTRUNGTAMHOCTHEM
{
    partial class frm_ThanhToan
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
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_NgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.cb_MSLop = new System.Windows.Forms.ComboBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.txt_MaThanhToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_QLThanhToan = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán";
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Location = new System.Drawing.Point(211, 189);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(206, 22);
            this.txt_SoTien.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Số Tiền";
            // 
            // date_NgayThanhToan
            // 
            this.date_NgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayThanhToan.Location = new System.Drawing.Point(211, 151);
            this.date_NgayThanhToan.Name = "date_NgayThanhToan";
            this.date_NgayThanhToan.Size = new System.Drawing.Size(206, 22);
            this.date_NgayThanhToan.TabIndex = 41;
            // 
            // cb_MSLop
            // 
            this.cb_MSLop.FormattingEnabled = true;
            this.cb_MSLop.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_MSLop.Location = new System.Drawing.Point(211, 112);
            this.cb_MSLop.Name = "cb_MSLop";
            this.cb_MSLop.Size = new System.Drawing.Size(206, 24);
            this.cb_MSLop.TabIndex = 40;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(211, 75);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(206, 22);
            this.txt_MSSV.TabIndex = 39;
            // 
            // txt_MaThanhToan
            // 
            this.txt_MaThanhToan.Location = new System.Drawing.Point(211, 41);
            this.txt_MaThanhToan.Name = "txt_MaThanhToan";
            this.txt_MaThanhToan.Size = new System.Drawing.Size(206, 22);
            this.txt_MaThanhToan.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "MS Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ngày Thanh Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã Thanh Toán";
            // 
            // dataGridView_QLThanhToan
            // 
            this.dataGridView_QLThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLThanhToan.Location = new System.Drawing.Point(69, 260);
            this.dataGridView_QLThanhToan.Name = "dataGridView_QLThanhToan";
            this.dataGridView_QLThanhToan.RowHeadersWidth = 51;
            this.dataGridView_QLThanhToan.RowTemplate.Height = 24;
            this.dataGridView_QLThanhToan.Size = new System.Drawing.Size(669, 239);
            this.dataGridView_QLThanhToan.TabIndex = 49;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(468, 223);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(174, 22);
            this.txt_TimKiem.TabIndex = 48;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(648, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 27);
            this.button4.TabIndex = 47;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(160, 220);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 27);
            this.btn_Sua.TabIndex = 46;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 45;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(68, 220);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 27);
            this.btn_Them.TabIndex = 44;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 511);
            this.Controls.Add(this.dataGridView_QLThanhToan);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_SoTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_NgayThanhToan);
            this.Controls.Add(this.cb_MSLop);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.txt_MaThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(113, 45);
            this.Name = "frm_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_ThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_NgayThanhToan;
        private System.Windows.Forms.ComboBox cb_MSLop;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.TextBox txt_MaThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_QLThanhToan;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Them;
    }
}