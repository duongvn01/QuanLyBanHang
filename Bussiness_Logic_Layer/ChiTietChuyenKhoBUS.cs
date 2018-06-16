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
    public class ChiTietChuyenKhoBUS
    {
        ChiTietChuyenKhoDAO chiTietChuyenKhoDAO;

        public ChiTietChuyenKhoBUS()
        {
            chiTietChuyenKhoDAO = new ChiTietChuyenKhoDAO();
        }
        public DataTable getAllChiTietChuyenKho()
        {

            return chiTietChuyenKhoDAO.GetAllChiTietChuyenKho();
        }
        public DataTable GetAllChiTietChuyenKhoByMaPhieuChuyenBUS(ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.GetAllChiTietChuyenKhoByMaPhieuChuyen(ctpck);
        }
        public bool ThemChiTietChuyenKhoBUS(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.ThemChiTietChuyenKho(ref err, ctpck);
        }
        public bool CapNhatChiTietChuyenKhoBUS(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.CapNhatChiTietChuyenKho(ref err, ctpck);
        }
        public bool CapNhatChiTietChuyenKhoByMaPhieuChuyenMaHangHoaBUS(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.CapNhatChiTietChuyenKhoByMaPhieuChuyenMaHangHoa(ref err, ctpck);
        }
        public bool XoaChiTietChuyenKhoByMaChiTietPhieuBUS(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.XoaChiTietChuyenKhoByMaChiTietPhieuChuyen(ref err, ctpck);
        }
        public bool XoaChiTietChuyenKhoByMaPhieuChuyenBUS(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.XoaChiTietChuyenKhoByMaPhieuChuyen(ref err,ctpck);
        }
        public bool XoaChiTietChuyenKhoByMaPhieuChuyenMaHangHoaBUS(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return chiTietChuyenKhoDAO.XoaChiTietChuyenKhoByMaPhieuChuyenMaHangHoa(ref err, ctpck);
        }
    }
}
