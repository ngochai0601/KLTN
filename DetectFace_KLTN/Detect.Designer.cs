namespace DetectFace
{
    partial class Detect
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.Face = new System.Windows.Forms.PictureBox();
            this.pn_ThongTin = new System.Windows.Forms.Panel();
            this.btnXemDiem = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            this.pn_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 395);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 42);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load hình";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(173, 395);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(140, 42);
            this.btnDetect.TabIndex = 3;
            this.btnDetect.Text = "Nhận diện";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // Face
            // 
            this.Face.Location = new System.Drawing.Point(19, 60);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(294, 303);
            this.Face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Face.TabIndex = 4;
            this.Face.TabStop = false;
            // 
            // pn_ThongTin
            // 
            this.pn_ThongTin.Controls.Add(this.btnXemDiem);
            this.pn_ThongTin.Controls.Add(this.lbKhoaHoc);
            this.pn_ThongTin.Controls.Add(this.lbNganh);
            this.pn_ThongTin.Controls.Add(this.lbLoaiDT);
            this.pn_ThongTin.Controls.Add(this.label13);
            this.pn_ThongTin.Controls.Add(this.label16);
            this.pn_ThongTin.Controls.Add(this.lbBacDT);
            this.pn_ThongTin.Controls.Add(this.lbLop);
            this.pn_ThongTin.Controls.Add(this.label7);
            this.pn_ThongTin.Controls.Add(this.label4);
            this.pn_ThongTin.Controls.Add(this.label5);
            this.pn_ThongTin.Controls.Add(this.picAnhSV);
            this.pn_ThongTin.Controls.Add(this.label9);
            this.pn_ThongTin.Controls.Add(this.label6);
            this.pn_ThongTin.Controls.Add(this.lbGioiTinh);
            this.pn_ThongTin.Controls.Add(this.label15);
            this.pn_ThongTin.Controls.Add(this.lbMSSV);
            this.pn_ThongTin.Controls.Add(this.label14);
            this.pn_ThongTin.Controls.Add(this.label8);
            this.pn_ThongTin.Controls.Add(this.lbNoiSinh);
            this.pn_ThongTin.Controls.Add(this.lbHoTen);
            this.pn_ThongTin.Controls.Add(this.lbNgaySinh);
            this.pn_ThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_ThongTin.Location = new System.Drawing.Point(347, 60);
            this.pn_ThongTin.Name = "pn_ThongTin";
            this.pn_ThongTin.Size = new System.Drawing.Size(570, 392);
            this.pn_ThongTin.TabIndex = 5;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(228, 336);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(147, 41);
            this.btnXemDiem.TabIndex = 38;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // lbKhoaHoc
            // 
            this.lbKhoaHoc.AutoSize = true;
            this.lbKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoaHoc.Location = new System.Drawing.Point(377, 58);
            this.lbKhoaHoc.Name = "lbKhoaHoc";
            this.lbKhoaHoc.Size = new System.Drawing.Size(64, 19);
            this.lbKhoaHoc.TabIndex = 37;
            this.lbKhoaHoc.Text = "label20";
            // 
            // lbNganh
            // 
            this.lbNganh.AutoSize = true;
            this.lbNganh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganh.Location = new System.Drawing.Point(359, 184);
            this.lbNganh.Name = "lbNganh";
            this.lbNganh.Size = new System.Drawing.Size(64, 19);
            this.lbNganh.TabIndex = 36;
            this.lbNganh.Text = "label21";
            // 
            // lbLoaiDT
            // 
            this.lbLoaiDT.AutoSize = true;
            this.lbLoaiDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDT.Location = new System.Drawing.Point(434, 142);
            this.lbLoaiDT.Name = "lbLoaiDT";
            this.lbLoaiDT.Size = new System.Drawing.Size(64, 19);
            this.lbLoaiDT.TabIndex = 35;
            this.lbLoaiDT.Text = "label16";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(305, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Khóa học:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(309, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "Ngành:";
            // 
            // lbBacDT
            // 
            this.lbBacDT.AutoSize = true;
            this.lbBacDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacDT.Location = new System.Drawing.Point(392, 100);
            this.lbBacDT.Name = "lbBacDT";
            this.lbBacDT.Size = new System.Drawing.Size(64, 19);
            this.lbBacDT.TabIndex = 32;
            this.lbBacDT.Text = "label16";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(368, 16);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(64, 19);
            this.lbLop.TabIndex = 31;
            this.lbLop.Text = "label17";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Loại hình đào tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bậc đào tạo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lớp học:";
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
            this.label9.Location = new System.Drawing.Point(29, 226);
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
            this.lbGioiTinh.Location = new System.Drawing.Point(373, 226);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(64, 19);
            this.lbGioiTinh.TabIndex = 24;
            this.lbGioiTinh.Text = "label17";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Họ tên:";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(77, 225);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(64, 19);
            this.lbMSSV.TabIndex = 23;
            this.lbMSSV.Text = "label18";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(305, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 226);
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
            this.lbHoTen.Location = new System.Drawing.Point(79, 268);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(64, 19);
            this.lbHoTen.TabIndex = 19;
            this.lbHoTen.Text = "label21";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(379, 268);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(64, 19);
            this.lbNgaySinh.TabIndex = 20;
            this.lbNgaySinh.Text = "label20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhận diện sinh viên";
            // 
            // Detect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_ThongTin);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.btnLoad);
            this.Name = "Detect";
            this.Size = new System.Drawing.Size(920, 464);
            this.Load += new System.EventHandler(this.Detect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            this.pn_ThongTin.ResumeLayout(false);
            this.pn_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.PictureBox Face;
        private System.Windows.Forms.Panel pn_ThongTin;
        private System.Windows.Forms.PictureBox picAnhSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbKhoaHoc;
        private System.Windows.Forms.Label lbNganh;
        private System.Windows.Forms.Label lbLoaiDT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbBacDT;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
