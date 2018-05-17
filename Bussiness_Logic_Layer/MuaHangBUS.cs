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
    public class MuaHangBUS
    {
        MuaHangDAO muaHangDAO;
        public MuaHangBUS()
        {
            muaHangDAO = new MuaHangDAO();
        }
        public DataTable getAllMuaHang()
        {
            return muaHangDAO.GetAllMuaHang();
        }
        public DataTable getAllMuaHangByMaNhaCungCapBUS(MuaHangO mh)
        {
            return muaHangDAO.GetAllMuaHangByMaPhieu(mh);
        }
        public DataTable getAllMuaHangByNgayNayNgayKiaBUS(DateTime ngayNay,DateTime ngayKia)
        {
            return muaHangDAO.GetAllMuaHangByNgayNayNgayKia(ngayNay, ngayKia);
        }
        public MuaHangO getOneMuaHangByMaPhieu(MuaHangO mh)
        {
            DataTable dt = new DataTable();
            MuaHangO MH = new MuaHangO();
            dt = muaHangDAO.GetAllMuaHangByMaPhieu(mh);
            //DataRow[] result = dt.Select("MaHangHoa= '" + hh.MaHangHoa + "'");
            DataRow row = dt.Rows[0];
            MH.MaPhieu = row["MaPhieu"].ToString();
            MH.TenPhieu = row["TenPhieu"].ToString();
            MH.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);
            MH.SoHoaDonVAT = row["SoHoaDonVAT"].ToString();
            MH.SoPhieuVietTay = (row["SoPhieuVietTay"]).ToString();
            MH.MaThanhToan = row["MaThanhToan"].ToString();
            MH.MaHinhThuc = row["MaHinhThuc"].ToString();
            MH.MaNhaCungCap = row["MaNhaCungCap"].ToString();
            MH.ThoiHanThanhToan = Convert.ToDateTime(row["ThoiHanThanhToan"]);
            MH.GhiChu = row["GhiChu"].ToString();

            MH.MaNhanVien = row["MaNhanVien"].ToString();
            MH.MaKho = row["MaKho"].ToString();

            MH.TongTien = Convert.ToDouble(row["TongTien"]);
            MH.PTramCK = Convert.ToInt32(row["PTramCK"]);
            MH.Thue = Convert.ToInt32(row["Thue"]);
            MH.TuongDuongTien =  Convert.ToDouble(row["TuongDuongTien"]);
            MH.TienThanhToan = Convert.ToDouble(row["TienThanhToan"]);
              
            return MH;
        }
        public bool ThemHangHoaBUS(ref string err, MuaHangO mh)
        {
            return muaHangDAO.ThemMuaHang(ref err, mh);
        }
        public bool CapNhatHangHoaBUS(ref string err, MuaHangO mh)
        {
            return muaHangDAO.CapNhatMuaHang(ref err, mh);
        }
        public bool XoaHangHoaBUS(ref string err, HangHoaO mh)
        {
            return muaHangDAO.XoaMuaHang(ref err, mh);
        }
    }
}
