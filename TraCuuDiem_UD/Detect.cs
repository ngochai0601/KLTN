using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;

namespace DetectFace
{
    public partial class Detect : UserControl
    {
        public static Loading load = new Loading();
        XuLy dt = new XuLy();
        public static SINHVIEN sv = null;
        public static Image hinh = null;
        public Detect()
        {
            InitializeComponent();
        }

        //Bitmap bitmap = null;
        ////Danh sách các phần mềm quay
        //FilterInfoCollection filter;
        ////video
        //public static IVideoSource device;
        //private void Detect_Load(object sender, EventArgs e)
        //{
        //    filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //    foreach (FilterInfo f in filter)
        //        cbbDevice.Items.Add(f.Name);
        //    cbbDevice.SelectedIndex = 0;
        //}

        //private void btnCam_Click(object sender, EventArgs e)
        //{
        //    if (device != null && device.IsRunning)
        //    {
        //        device.Stop();
        //    }

        //    device = new VideoCaptureDevice(filter[cbbDevice.SelectedIndex].MonikerString);
        //    device.NewFrame += new NewFrameEventHandler(device_NewFrame);
        //    device.Start();
        //}

        //private void device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    bitmap = (Bitmap)eventArgs.Frame.Clone();//tạo bitmap bằng các frame quay được
        //    Cam_Face.Image = bitmap;
        //}

        //private void btnCap_Click(object sender, EventArgs e)
        //{
        //    Face.Image = bitmap;
        //}

        

        private void btnDetect_Click(object sender, EventArgs e)
        {
            load = new Loading();
            load.Show();
            string masv = dt.Detect(hinh);
            sv = dt.LaySinhVien(masv);
            while (sv != null && pn_ThongTin.Visible == false)
            {
                try
                {
                    loadSinhVien();
                    CheckSinhVien();
                }
                catch
                {
                    
                    loadSinhVien();
                    CheckSinhVien();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sv = null;
                CheckSinhVien();
                string fileName;
                fileName = dlg.FileName;
                Face.Image = Image.FromFile(fileName);
                hinh = Face.Image;
            }
        }

        public void CheckSinhVien()
        {
            if (sv == null)
            {
                pn_ThongTin.Visible = false;
            }
            else
                pn_ThongTin.Visible = true;
        }

        private void Detect_Load(object sender, EventArgs e)
        {
            sv = null;
            Face.Image = Image.FromFile("anh/img_avatar2.png");
            CheckSinhVien();
        }

        public void loadSinhVien()
        {
            try
            {
                if (sv.MASV != null)
                {
                    lbHoTen.Text = sv.HOTEN;
                    lbGioiTinh.Text = sv.GTINH;
                    lbMSSV.Text = sv.MASV;
                    lbNgaySinh.Text = sv.NGSINH.Value.ToShortDateString();
                    lbNoiSinh.Text = sv.NOISINH;
                    lbLop.Text = sv.MALOP;
                    picAnhSV.Image = Image.FromFile("anh/" + sv.HINH);
                    DataTable data = dt.LayThongTinHocVu(sv);
                    lbNganh.Text = data.Rows[0]["nganh"].ToString();
                    lbLoaiDT.Text = data.Rows[0]["loaidaotao"].ToString();
                    lbBacDT.Text = data.Rows[0]["bacdaotao"].ToString();
                    lbKhoaHoc.Text = data.Rows[0]["khoahoc"].ToString();
                }
            }
            catch { }
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (Detect.sv != null)
            {
                //if (Detect.device != null && Detect.device.IsRunning)
                //    Detect.device.Stop();
                if (frm_Main.pn_main.Controls.Count > 0)
                {
                    frm_Main.pn_main.Controls.RemoveAt(0);
                }
                ThongTinSinhVien user = new ThongTinSinhVien();
                frm_Main.pn_main.Controls.Add(user);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhận dạng!", "Thông báo");
            }
        }
    }
}
