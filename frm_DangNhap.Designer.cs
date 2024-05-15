namespace QLTRUNGTAMHOCTHEM
{
    partial class frm_DangNhap
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.chk_Hienthi = new System.Windows.Forms.CheckBox();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.txt_Taikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(313, 179);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 31);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangnhap.Location = new System.Drawing.Point(129, 179);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(119, 31);
            this.btn_Dangnhap.TabIndex = 14;
            this.btn_Dangnhap.Text = "Đăng nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = true;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // chk_Hienthi
            // 
            this.chk_Hienthi.AutoSize = true;
            this.chk_Hienthi.Location = new System.Drawing.Point(414, 121);
            this.chk_Hienthi.Name = "chk_Hienthi";
            this.chk_Hienthi.Size = new System.Drawing.Size(79, 20);
            this.chk_Hienthi.TabIndex = 13;
            this.chk_Hienthi.Text = "Hiển Thị";
            this.chk_Hienthi.UseVisualStyleBackColor = true;
            this.chk_Hienthi.CheckedChanged += new System.EventHandler(this.chk_Hienthi_CheckedChanged);
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(167, 122);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.PasswordChar = '*';
            this.txt_Matkhau.Size = new System.Drawing.Size(229, 22);
            this.txt_Matkhau.TabIndex = 12;
            // 
            // txt_Taikhoan
            // 
            this.txt_Taikhoan.Location = new System.Drawing.Point(167, 81);
            this.txt_Taikhoan.Name = "txt_Taikhoan";
            this.txt_Taikhoan.Size = new System.Drawing.Size(229, 22);
            this.txt_Taikhoan.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tài Khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ĐĂNG NHẬP";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 287);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.chk_Hienthi);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.txt_Taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.CheckBox chk_Hienthi;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.TextBox txt_Taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}