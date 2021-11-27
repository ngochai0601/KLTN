namespace DetectFace
{
    partial class ThongTinSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gr_TTCN = new System.Windows.Forms.GroupBox();
            this.gridDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.gr_TTHV = new System.Windows.Forms.GroupBox();
            this.lbKhoaHoc = new System.Windows.Forms.Label();
            this.lbNganh = new System.Windows.Forms.Label();
            this.lbLoaiDT = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbBacDT = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAnhSV = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gr_TTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiem)).BeginInit();
            this.gr_TTHV.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gr_TTCN);
            this.panel1.Controls.Add(this.gr_TTHV);
            this.panel1.Location = new System.Drawing.Point(237, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 431);
            this.panel1.TabIndex = 1;
            // 
            // gr_TTCN
            // 
            this.gr_TTCN.Controls.Add(this.gridDiem);
            this.gr_TTCN.Controls.Add(this.cbbHocKy);
            this.gr_TTCN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_TTCN.Location = new System.Drawing.Point(4, 147);
            this.gr_TTCN.Name = "gr_TTCN";
            this.gr_TTCN.Size = new System.Drawing.Size(772, 283);
            this.gr_TTCN.TabIndex = 1;
            this.gr_TTCN.TabStop = false;
            this.gr_TTCN.Text = "Kết quả học tập";
            // 
            // gridDiem
            // 
            this.gridDiem.AllowUserToAddRows = false;
            this.gridDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.gridDiem.Location = new System.Drawing.Point(7, 60);
            this.gridDiem.Name = "gridDiem";
            this.gridDiem.RowTemplate.Height = 24;
            this.gridDiem.Size = new System.Drawing.Size(765, 216);
            this.gridDiem.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mamh";
            this.Column1.HeaderText = "Mã môn học";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenmh";
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tinchi";
            this.Column3.HeaderText = "Số tín chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "lopdukien";
            this.Column4.HeaderText = "Lớp dự kiến";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TL";
            this.Column5.HeaderText = "TL/BTL";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GK";
            this.Column6.HeaderText = "Giữa kỳ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "KT1";
            this.Column7.HeaderText = "KT1";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "KT2";
            this.Column8.HeaderText = "KT2";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tongket";
            this.Column9.HeaderText = "Điểm tổng kết";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "diem4";
            this.Column10.HeaderText = "Thang điểm 4";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "diemchu";
            this.Column11.HeaderText = "Điểm chữ";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "xeploai";
            this.Column12.HeaderText = "Xếp loại";
            this.Column12.Name = "Column12";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Location = new System.Drawing.Point(7, 27);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(251, 27);
            this.cbbHocKy.TabIndex = 0;
            this.cbbHocKy.SelectedValueChanged += new System.EventHandler(this.cbbHocKy_SelectedValueChanged);
            // 
            // gr_TTHV
            // 
            this.gr_TTHV.Controls.Add(this.lbKhoaHoc);
            this.gr_TTHV.Controls.Add(this.lbNganh);
            this.gr_TTHV.Controls.Add(this.lbLoaiDT);
            this.gr_TTHV.Controls.Add(this.label13);
            this.gr_TTHV.Controls.Add(this.label16);
            this.gr_TTHV.Controls.Add(this.lbBacDT);
            this.gr_TTHV.Controls.Add(this.lbLop);
            this.gr_TTHV.Controls.Add(this.label7);
            this.gr_TTHV.Controls.Add(this.label4);
            this.gr_TTHV.Controls.Add(this.label5);
            this.gr_TTHV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_TTHV.Location = new System.Drawing.Point(4, 4);
            this.gr_TTHV.Name = "gr_TTHV";
            this.gr_TTHV.Size = new System.Drawing.Size(772, 137);
            this.gr_TTHV.TabIndex = 0;
            this.gr_TTHV.TabStop = false;
            this.gr_TTHV.Text = "Thông tin";
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.AutoSize = true;
            this.lbKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoaHoc.Location = new System.Drawing.Point(93, 68);
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Size = new System.Drawing.Size(64, 19);
            this.lbKhoaHoc.TabIndex = 27;
            this.lbKhoaHoc.Text = "label20";
            // 
            // lbNganh
            // 
            this.lbNganh.AutoSize = true;
            this.lbNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganh.Location = new System.Drawing.Point(382, 68);
            this.lbNganh.Name = "lbNganh";
            this.lbNganh.Size = new System.Drawing.Size(64, 19);
            this.lbNganh.TabIndex = 26;
            this.lbNganh.Text = "label21";
            // 
            // lbLoaiDT
            // 
            this.lbLoaiDT.AutoSize = true;
            this.lbLoaiDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDT.Location = new System.Drawing.Point(457, 32);
            this.lbLoaiDT.Name = "lbLoaiDT";
            this.lbLoaiDT.Size = new System.Drawing.Size(64, 19);
            this.lbLoaiDT.TabIndex = 25;
            this.lbLoaiDT.Text = "label16";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Khóa học:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(332, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 19);
            this.label16.TabIndex = 21;
            this.label16.Text = "Ngành:";
            // 
            // lbBacDT
            // 
            this.lbBacDT.AutoSize = true;
            this.lbBacDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacDT.Location = new System.Drawing.Point(108, 104);
            this.lbBacDT.Name = "lbBacDT";
            this.lbBacDT.Size = new System.Drawing.Size(64, 19);
            this.lbBacDT.TabIndex = 18;
            this.lbBacDT.Text = "label16";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(84, 32);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(64, 19);
            this.lbLop.TabIndex = 17;
            this.lbLop.Text = "label17";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loại hình đào tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bậc đào tạo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp học:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picAnhSV);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbGioiTinh);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbMSSV);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbNoiSinh);
            this.panel2.Controls.Add(this.lbHoTen);
            this.panel2.Controls.Add(this.lbNgaySinh);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 431);
            this.panel2.TabIndex = 2;
            // 
            // picAnhSV
            // 
            this.picAnhSV.Location = new System.Drawing.Point(30, 3);
            this.picAnhSV.Name = "picAnhSV";
            this.picAnhSV.Size = new System.Drawing.Size(176, 208);
            this.picAnhSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhSV.TabIndex = 0;
            this.picAnhSV.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "MSSV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nơi sinh:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(83, 311);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(64, 19);
            this.lbGioiTinh.TabIndex = 24;
            this.lbGioiTinh.Text = "label17";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Họ tên:";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(66, 229);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(64, 19);
            this.lbMSSV.TabIndex = 23;
            this.lbMSSV.Text = "label18";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giới tính:";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiSinh.Location = new System.Drawing.Point(81, 393);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(64, 19);
            this.lbNoiSinh.TabIndex = 16;
            this.lbNoiSinh.Text = "label18";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(69, 270);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(64, 19);
            this.lbHoTen.TabIndex = 19;
            this.lbHoTen.Text = "label21";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(90, 352);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(64, 19);
            this.lbNgaySinh.TabIndex = 20;
            this.lbNgaySinh.Text = "label20";
            // 
            // ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinSinhVien";
            this.Size = new System.Drawing.Size(1019, 440);
            this.Load += new System.EventHandler(this.ThongTinSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.gr_TTCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiem)).EndInit();
            this.gr_TTHV.ResumeLayout(false);
            this.gr_TTHV.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnhSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gr_TTCN;
        private System.Windows.Forms.GroupBox gr_TTHV;
        private System.Windows.Forms.Label lbKhoaHoc;
        private System.Windows.Forms.Label lbNganh;
        private System.Windows.Forms.Label lbLoaiDT;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbBacDT;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridDiem;
        private System.Windows.Forms.ComboBox cbbHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}
