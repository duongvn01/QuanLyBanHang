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
    public class BanHangBUS
    {
        BanHangDAO banHangDAO;
        public BanHangBUS()
        {
            banHangDAO = new BanHangDAO();
        }
        public DataTable getAllBanHang()
        {
            return banHangDAO.GetAllBanHang();
        }
        public DataTable getAllBanHangByMaPhieuBanBUS(BanHangO bh)
        {
            return banHangDAO.GetAllBanHangByMaPhieuBan(bh);
        }
        public DataTable getAllBanHangByNgayNayNgayKiaBUS(DateTime ngayNay,DateTime ngayKia)
        {
            return banHangDAO.GetAllBanHangByNgayNayNgayKia(ngayNay, ngayKia);
        }
        public BanHangO getOneMuaHangByMaPhieu(BanHangO bh)
        {
            DataTable dt = new DataTable();
            BanHangO BH = new BanHangO();
            dt = banHangDAO.GetAllBanHangByMaPhieuBan(bh);
            if(dt!=null)
            {
                DataRow row = dt.Rows[0];
                BH.MaPhieuBan = row["MaPhieuBan"].ToString();
                BH.TenPhieu = row["TenPhieu"].ToString();
                BH.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);

                BH.MaKieuTT = row["MaThanhToan"].ToString();
                BH.MaHinhThucTT = row["MaHinhThuc"].ToString();
                BH.ThoiHanThanhToan = Convert.ToDateTime(row["ThoiHanThanhToan"]);
                
                BH.MaKhachHang = row["MaKhachHang"].ToString();
                BH.NgayGiaoHang =Convert.ToDateTime (row["NgayGiaoHang"]);

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
        public bool ThemBanHangBUS(ref string err, BanHangO bh)
        {
            return banHangDAO.ThemBanHang(ref err, bh);
        }
        public bool CapNhatBanHangBUS(ref string err, BanHangO bh)
        {
            return banHangDAO.CapNhatBanHang(ref err, bh);
        }
        public bool XoaBanHangBUS(ref string err, BanHangO bh)
        {
            return banHangDAO.XoaBanHang(ref err, bh);
        }
    }
}
