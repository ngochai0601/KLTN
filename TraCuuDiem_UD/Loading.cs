using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DetectFace
{
    public partial class Loading : Form
    {
        XuLy dt = new XuLy();
        public Loading()
        {
            InitializeComponent();
        }

        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (Detect.sv!=null||x==15)
            {
                timer1.Stop();
                this.Close();
                //string masv = dt.Detect(Detect.hinh);
                //Detect.sv = dt.LaySinhVien(masv);
            }
        }
    }
}
