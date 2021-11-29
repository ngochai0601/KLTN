using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TraCuuDiem.Models;
using System.Data;

namespace TraCuuDiem.Controllers
{
    public class HomeController : Controller
    {
        quanlydiemEntities qlDiem = new quanlydiemEntities();
        public ActionResult Detect()
        {
            SINHVIEN sv = new SINHVIEN();
            ViewBag.MASV = "";
            return View(sv);
        }
        public static string ConvertImageToBase64String(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch { return null; }
        }

        private String EscapeData(String B64)
        {
            int B64_length = B64.Length;
            if (B64_length <= 32000)
            {
                return Uri.EscapeDataString(B64);
            }

            int idx = 0;
            StringBuilder builder = new StringBuilder();
            String substr = B64.Substring(idx, 32000);
            while (idx < B64_length)
            {
                builder.Append(Uri.EscapeDataString(substr));
                idx += 32000;

                if (idx < B64_length)
                {

                    substr = B64.Substring(idx, Math.Min(32000, B64_length - idx));
                }

            }
            return builder.ToString();
        }

        private String sendPOST(String url, String B64)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 5000;
                var postData = "image=" + EscapeData(B64);

                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (Exception ex)
            {
                return "Exception" + ex.ToString();
            }
        }
        [HttpPost]
        public ActionResult Detect(FormCollection f)
        {
            Image image = Image.FromFile(Server.MapPath(@"~\Content\images\" + f["file"].ToString()));
            String B64 = ConvertImageToBase64String(image);

            // Goi len server va tra ve ket qua
            String server_ip = "192.168.1.4";
            String server_path = "http://" + server_ip + ":8080/detect";
            String retStr = sendPOST(server_path, B64);
            ViewBag.MASV = retStr;
            SINHVIEN sv = LaySinhVien(retStr);
            DataTable dtb = LayThongTinHocVu(sv);
            ViewBag.BDT = dtb.Rows[0]["bacdaotao"].ToString();
            ViewBag.LHDT = dtb.Rows[0]["loaidaotao"].ToString();
            ViewBag.KH = dtb.Rows[0]["khoahoc"].ToString();
            ViewBag.NGANH = dtb.Rows[0]["nganh"].ToString();
            return View(sv);
        }
        public ActionResult Score(string masv)
        {
            List<XemDiem> lst = LayDiemTheoHK(masv);
            return View(lst);
        }
        [HttpPost]
        public string FileUpload(HttpPostedFileBase file)
        {
            if (file != null)
            {
                file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            }
            return "/Content/images/" + file.FileName;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public SINHVIEN LaySinhVien(string masv)
        {
            return qlDiem.SINHVIENs.SingleOrDefault(x => x.MASV == masv);
        }

        public DataTable LayThongTinHocVu(SINHVIEN sv)
        {
            NGANH nganh = qlDiem.NGANHs.SingleOrDefault(x => x.MANGANH == sv.MANGANH);
            BACDAOTAO bdt = qlDiem.BACDAOTAOs.SingleOrDefault(x => x.MABACDAOTAO == sv.MABACDAOTAO);
            LOAIHINHDAOTAO ldt = qlDiem.LOAIHINHDAOTAOs.SingleOrDefault(x => x.MALOAIHINHDAOTAO == sv.MALOAIHINHDAOTAO);
            NIENKHOA nk = qlDiem.NIENKHOAs.SingleOrDefault(x => x.MANIENKHOA == sv.MANIENKHOA);
            DataTable dt = new DataTable();
            dt.Columns.Add("bacdaotao");
            dt.Columns.Add("loaidaotao");
            dt.Columns.Add("khoahoc");
            dt.Columns.Add("nganh");
            dt.Rows.Add(bdt.TENBACDAOTAO, ldt.TENLOAIHINHDAOTAO, nk.NAMBATDAU, nganh.TENNGANH);

            return dt;
        }

        public List<HOCKY> LayHK(string masv)
        {
            List<HOCKY> hocky = new List<HOCKY>();
            List<DIEM> diems = qlDiem.DIEMs.Where(x => x.MASV == masv).ToList();
            foreach (DIEM d in diems)
            {
                hocky.Add(qlDiem.HOCKies.SingleOrDefault(x => x.MAHOCKY == d.MAHOCKY));
            }
            return hocky.Distinct().ToList();
        }

        public List<XemDiem> LayDiemTheoHK(string masv)
        {
            List<XemDiem> lst = new List<XemDiem>();
            foreach (HOCKY hk in qlDiem.HOCKies.ToList())
            {
                List<DIEM> diems = qlDiem.DIEMs.Where(x => x.MAHOCKY == hk.MAHOCKY && x.MASV == masv).ToList();
                if (diems.Count != 0)
                {
                    lst.Add(new XemDiem()
                    {
                        hk = hk.HK,
                        mamh = null,
                        tenmh = null,
                        lopdukien = null,
                        tinchi = null,
                        TL = null,
                        GK = null,
                        KT1 = null,
                        KT2 = null,
                        tongket = null,
                        diem4 = null,
                        diemchu = null,
                        xeploai = null
                    });

                    foreach (DIEM d in diems)
                    {
                        double? tongket = 0;
                        if (d.DIEMGK == null && d.DIEMTL != null)
                        {
                            tongket = (d.DIEMTL * 0.5) + (d.DIEMKT1 * 0.5);
                        }
                        else if (d.DIEMGK == null && d.DIEMTL == null)
                        {
                            tongket = d.DIEMKT1;
                        }
                        string diemchu = DiemChu(tongket);
                        string xeploai = XepLoai(diemchu);
                        double diem4 = Diem4(tongket);
                        MONHOC mh = qlDiem.MONHOCs.SingleOrDefault(x => x.MAMH == d.MAMH);
                        lst.Add(new XemDiem()
                        {
                            hk = null,
                            mamh = mh.MAMH,
                            tenmh = mh.TENMH,
                            tinchi = mh.SOTC.ToString(),
                            lopdukien = mh.MALOP,
                            TL = d.DIEMTL.ToString(),
                            GK = d.DIEMGK.ToString(),
                            KT1 = d.DIEMKT1.ToString(),
                            KT2 = d.DIEMKT2.ToString(),
                            tongket = tongket.ToString(),
                            diem4 = diem4.ToString(),
                            diemchu = diemchu,
                            xeploai = xeploai
                        });
                    }
                }
            }
            return lst;
        }

        public double Diem4(double? tongket)
        {
            if (tongket <= 3.9)
            {
                return 0;
            }
            else if (tongket >= 4 && tongket <= 5.4)
            {
                return 1.5;
            }
            else if (tongket >= 5.5 && tongket <= 6.4)
            {
                return 2;
            }
            else if (tongket >= 6.5 && tongket <= 6.9)
            {
                return 2.5;
            }
            else if (tongket >= 7 && tongket <= 7.9)
            {
                return 3;
            }
            else if (tongket >= 8 && tongket <= 8.4)
            {
                return 3.5;
            }
            return 4;
        }

        public string DiemChu(double? tongket)
        {
            if (tongket <= 3.9)
            {
                return "F";
            }
            else if (tongket >= 4.0 && tongket <= 5)
            {
                return "D";
            }
            else if (tongket >= 5.1 && tongket <= 5.5)
            {
                return "D+";
            }
            else if (tongket >= 5.6 && tongket <= 6.4)
            {
                return "C";
            }
            else if (tongket >= 6.5 && tongket <= 6.9)
            {
                return "C+";
            }
            else if (tongket >= 7 && tongket <= 7.9)
            {
                return "B";
            }
            else if (tongket >= 8 && tongket <= 8.4)
            {
                return "B+";
            }
            return "A";
        }

        public string XepLoai(string diemchu)
        {
            if (diemchu == "F")
            {
                return "Kém";
            }
            else if (diemchu == "D")
            {
                return "Trung bình yếu";
            }
            else if (diemchu == "D+" || diemchu == "C" || diemchu == "C+")
            {
                return "Trung bình";
            }
            else if (diemchu == "B" || diemchu == "B+")
            {
                return "Khá";
            }
            return "Giỏi";
        }
    }
}
