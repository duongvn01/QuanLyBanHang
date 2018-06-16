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
    public class ChuyenKhoBUS
    {
        ChuyenKhoDAO chuyenKhoDAO;
        public ChuyenKhoBUS()
        {
            chuyenKhoDAO = new ChuyenKhoDAO();
        }
        public DataTable getAllChuyenKho()
        {
            return chuyenKhoDAO.GetAllChuyenKho();
        }

        public DataTable getAllChuyenKhoByNgayNayNgayKiaBUS(DateTime ngayNay, DateTime ngayKia)
        {
            return chuyenKhoDAO.GetAllChuyenKhoByNgayNayNgayKia(ngayNay, ngayKia);
        }
        public ChuyenKhoO getOneChuyenKhoByMaPhieuChuyen(ChuyenKhoO ck)
        {
            DataTable dt = new DataTable();
            dt = chuyenKhoDAO.GetAllChuyenKhoByMaPhieuChuyen(ck);
            if (dt != null)
            {
                //DataRow[] result = dt.Select("MaHangHoa= '" + hh.MaHangHoa + "'");
                DataRow row = dt.Rows[0];
                ck.MaPhieuChuyen = row["MaPhieuChuyen"].ToString();
                ck.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);
                ck.GhiChu = row["GhiChu"].ToString();
                ck.MaKhoChuyen = row["MaKhoChuyen"].ToString();
                ck.MaKhoNhan = row["MaKhoNhan"].ToString();
                ck.MaNguoiChuyen = row["MaNguoiChuyen"].ToString();
                ck.MaNguoiNhan = row["MaNguoiNhan"].ToString();
            }
            return ck;
        }
        public bool ThemChuyenKhoBUS(ref string err, ChuyenKhoO ck)
        {
            return chuyenKhoDAO.ThemChuyenKho(ref err, ck);
        }
        public bool CapNhatChuyenKhoBUS(ref string err, ChuyenKhoO ck)
        {
            return chuyenKhoDAO.CapNhatChuyenKho(ref err, ck);
        }
        public bool XoaChuyenKhoBUS(ref string err, ChuyenKhoO ck)
        {
            return chuyenKhoDAO.XoaChuyenKho(ref err, ck);
        }
    }
}
