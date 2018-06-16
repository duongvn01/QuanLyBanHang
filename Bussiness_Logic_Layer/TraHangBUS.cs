using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Acccess_Layer;
using Object;

namespace Bussiness_Logic_Layer
{
    public class TraHangBUS
    {
        TraHangDAO traHangDAO;
        public TraHangBUS()
        {
            traHangDAO = new TraHangDAO();
        }
        public DataTable getAllTraHang()
        {
            return traHangDAO.GetAllTraHang();
        }
        public DataTable getAllTraHangByMaPhieuTraBUS(TraHangO bh)
        {
            return traHangDAO.GetAllTraHangByMaPhieuTra(bh);
        }
        public DataTable getAllTraHangByNgayNayNgayKiaBUS(DateTime ngayNay,DateTime ngayKia)
        {
            return traHangDAO.GetAllTraHangByNgayNayNgayKia(ngayNay, ngayKia);
        }
        public TraHangO getOneTraHangByMaPhieuTra(TraHangO bh)
        {
            DataTable dt = new DataTable();
            TraHangO BH = new TraHangO();
            dt = traHangDAO.GetAllTraHangByMaPhieuTra(bh);
            if(dt!=null)
            {
                DataRow row = dt.Rows[0];
                BH.MaPhieuTra = row["MaPhieuTra"].ToString();              
                BH.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);
                BH.MaKhachHang = row["MaKhachHang"].ToString();

                BH.MaNhanVien = row["MaNhanVien"].ToString();
                BH.MaKho = row["MaKho"].ToString();
                BH.GhiChu = row["GhiChu"].ToString();

                BH.TongTien = Convert.ToDouble(row["TongTien"]);
                BH.PTramCK = Convert.ToInt32(row["PTramCK"]);
                BH.Thue = Convert.ToInt32(row["Thue"]);
                BH.TuongDuongTien = Convert.ToDouble(row["TuongDuongTien"]);
                BH.TienThanhToan = Convert.ToDouble(row["TienThanhToan"]);
              
            }     
            return BH;
        }
        public bool ThemTraHangBUS(ref string err, TraHangO bh)
        {
            return traHangDAO.ThemTraHang(ref err, bh);
        }
        public bool CapNhatTraHangBUS(ref string err, TraHangO bh)
        {
            return traHangDAO.CapNhatTraHang(ref err, bh);
        }
        public bool XoaTraHangBUS(ref string err, TraHangO bh)
        {
            return traHangDAO.XoaTraHang(ref err, bh);
        }
    }
}
