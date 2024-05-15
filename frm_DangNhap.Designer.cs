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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.chk_Hienthi = new System.Windows.Forms.CheckBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(176, 60);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(192, 22);
            this.txt_TenDangNhap.TabIndex = 4;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(176, 94);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(192, 22);
            this.txt_MatKhau.TabIndex = 5;
            // 
            // chk_Hienthi
            // 
            this.chk_Hienthi.AutoSize = true;
            this.chk_Hienthi.Location = new System.Drawing.Point(385, 96);
            this.chk_Hienthi.Name = "chk_Hienthi";
            this.chk_Hienthi.Size = new System.Drawing.Size(79, 20);
            this.chk_Hienthi.TabIndex = 6;
            this.chk_Hienthi.Text = "Hiển Thị";
            this.chk_Hienthi.UseVisualStyleBackColor = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(213, 132);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(106, 36);
            this.btn_DangNhap.TabIndex = 7;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 237);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.chk_Hienthi);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.CheckBox chk_Hienthi;
        private System.Windows.Forms.Button btn_DangNhap;
    }
}