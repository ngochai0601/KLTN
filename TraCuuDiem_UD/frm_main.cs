using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DetectFace
{
    public partial class frm_Main : Form
    {
        public static Panel pn_main = new Panel();
        public frm_Main()
        {
            pn_main.Size = new Size( 1173, 534);
            pn_main.Location = new Point(0, 32);
            this.Controls.Add(pn_main);
            InitializeComponent();
        }
        
        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (pn_main.Controls.Count > 0)
            {
                pn_main.Controls.RemoveAt(0);
            }
            Detect user = new Detect();
            pn_main.Controls.Add(user);
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Detect.device != null && Detect.device.IsRunning)
            //    Detect.device.Stop();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (Detect.sv!=null)
            {
                //if (Detect.device != null && Detect.device.IsRunning)
                //    Detect.device.Stop();
                if (pn_main.Controls.Count > 0)
                {
                    pn_main.Controls.RemoveAt(0);
                }
                ThongTinSinhVien user = new ThongTinSinhVien();
                pn_main.Controls.Add(user);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhận dạng!", "Thông báo");
            }
        }
    }
}
