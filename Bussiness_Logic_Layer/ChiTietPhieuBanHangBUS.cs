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
    public class ChiTietPhieuBanHangBUS
    {
        ChiTietPhieuBanHangDAO chiTietPhieuBanHangDAO;
        
        public ChiTietPhieuBanHangBUS()
        {
            chiTietPhieuBanHangDAO = new ChiTietPhieuBanHangDAO();
        }
        public DataTable getAllChiTietPhieuBanHang()
        {

            return chiTietPhieuBanHangDAO.GetAllChiTietPhieuBanHang();
        }
        public DataTable GetAllChiTietPhieuBanHangByMaPhieuBanBUS(ChiTietPhieuBanHangO ctpbh)
        {
            return chiTietPhieuBanHangDAO.GetAllChiTietPhieuBanHangByMaPhieuBan(ctpbh);
        }
        public bool ThemChiTietPhieuBanHangBUS(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return chiTietPhieuBanHangDAO.ThemChiTietPhieuBanHang(ref err, ctpbh);
        }
        public bool CapNhatChiTietPhieuBanHangBUS(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return chiTietPhieuBanHangDAO.CapNhatChiTietPhieuBanHang(ref err, ctpbh);
        }
        public bool XoaChiTietPhieuBanHangByMaChiTietPhieuBUS(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return chiTietPhieuBanHangDAO.XoaChiTietPhieuBanHangByMaChiTietPhieuBan(ref err, ctpbh);
        }
        public bool XoaChiTietPhieuBanHangByMaPhieuBanBUS(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return chiTietPhieuBanHangDAO.XoaChiTietPhieuBanHangByMaPhieuBan(ref err,ctpbh);
        }
        public bool XoaChiTietPhieuBanHangByMaPhieuBanMaHangHoaBUS(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return chiTietPhieuBanHangDAO.XoaChiTietPhieuBanHangByMaPhieuBanMaHangHoa(ref err, ctpbh);
        }
    }
}
