using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectFace
{
    public partial class ThongTinSinhVien : UserControl
    {
        SINHVIEN sv = Detect.sv;
        XuLy dt = new XuLy();
        public ThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            if (sv.MASV != null)
            {
                lbHoTen.Text = sv.HOTEN;
                lbGioiTinh.Text = sv.GTINH;
                lbMSSV.Text = sv.MASV;
                lbNgaySinh.Text = sv.NGSINH.Value.ToShortDateString();
                lbNoiSinh.Text = sv.NOISINH;
                lbLop.Text = sv.MALOP;
                picAnhSV.Image = Image.FromFile("anh/"+sv.HINH);
                DataTable data = dt.LayThongTinHocVu(sv);
                lbNganh.Text = data.Rows[0]["nganh"].ToString();
                lbLoaiDT.Text = data.Rows[0]["loaidaotao"].ToString();
                lbBacDT.Text = data.Rows[0]["bacdaotao"].ToString();
                lbKhoaHoc.Text = data.Rows[0]["khoahoc"].ToString();
                cbbHocKy.DataSource = dt.LayHK(sv.MASV);
                cbbHocKy.DisplayMember = "HK";
                cbbHocKy.ValueMember = "MAHOCKY";
            }
        }

        private void cbbHocKy_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridDiem.DataSource = dt.LayDiemTheoHK(int.Parse(cbbHocKy.SelectedValue.ToString()),sv);
            }
            catch { }
        }
    }
}
