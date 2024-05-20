namespace QLTRUNGTAMHOCTHEM
{
    partial class frm_DangKyLop
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
            this.cb_TenLop = new System.Windows.Forms.ComboBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.txt_maDK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_QLDKLop = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLDKLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Lớp";
            // 
            // cb_TenLop
            // 
            this.cb_TenLop.FormattingEnabled = true;
            this.cb_TenLop.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_TenLop.Location = new System.Drawing.Point(158, 156);
            this.cb_TenLop.Name = "cb_TenLop";
            this.cb_TenLop.Size = new System.Drawing.Size(206, 24);
            this.cb_TenLop.TabIndex = 17;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(158, 82);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(206, 22);
            this.txt_MSSV.TabIndex = 16;
            // 
            // txt_maDK
            // 
            this.txt_maDK.Location = new System.Drawing.Point(158, 48);
            this.txt_maDK.Name = "txt_maDK";
            this.txt_maDK.Size = new System.Drawing.Size(206, 22);
            this.txt_maDK.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "MS Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Đăng Ký";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(158, 119);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(206, 22);
            this.txt_HoTen.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ Tên";
            // 
            // dataGridView_QLDKLop
            // 
            this.dataGridView_QLDKLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLDKLop.Location = new System.Drawing.Point(64, 284);
            this.dataGridView_QLDKLop.Name = "dataGridView_QLDKLop";
            this.dataGridView_QLDKLop.RowHeadersWidth = 51;
            this.dataGridView_QLDKLop.RowTemplate.Height = 24;
            this.dataGridView_QLDKLop.Size = new System.Drawing.Size(669, 215);
            this.dataGridView_QLDKLop.TabIndex = 53;
            this.dataGridView_QLDKLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QLDKLop_CellClick);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(464, 233);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(174, 22);
            this.txt_TimKiem.TabIndex = 52;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(644, 230);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 27);
            this.btn_search.TabIndex = 51;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(156, 230);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 27);
            this.btn_Sua.TabIndex = 50;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 49;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(64, 230);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 27);
            this.btn_Them.TabIndex = 48;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(397, 80);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 54;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "MS Lớp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_DangKyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.dataGridView_QLDKLop);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_TenLop);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.txt_maDK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(113, 45);
            this.Name = "frm_DangKyLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_DangKyLop";
            this.Load += new System.EventHandler(this.frm_DangKyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLDKLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TenLop;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.TextBox txt_maDK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_QLDKLop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}