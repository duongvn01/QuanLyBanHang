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
    public class ChiTietPhieuTraHangBUS
    {
        ChiTietPhieuTraHangDAO chiTietPhieuTraHangDAO;
        public ChiTietPhieuTraHangBUS()
        {
            chiTietPhieuTraHangDAO = new ChiTietPhieuTraHangDAO();
        }
        public DataTable getAllChiTietPhieuTraHang()
        {
            return chiTietPhieuTraHangDAO.GetAllChiTietPhieuTraHang();     
        }
        public DataTable GetAllChiTietPhieuTraHangByMaPhieuTraBUS(ChiTietTraHangO ctth)
        {
            return chiTietPhieuTraHangDAO.GetAllChiTietPhieuTraHangByMaPhieuTra(ctth);
        }
        public bool ThemChiTietPhieuTraHangBUS(ref string err, ChiTietTraHangO ctth)
        {
            return chiTietPhieuTraHangDAO.ThemChiTietPhieuTraHang(ref err, ctth);
        }
        public bool CapNhatChiTietPhieuTraHangBUS(ref string err, ChiTietTraHangO ctth)
        {
            return chiTietPhieuTraHangDAO.CapNhatChiTietPhieuTraHangByMaPhieuTraMaHangHoa(ref err, ctth);
        }
        public bool CapNhatChiTietPhieuTraHangByMaPhieuTraMaHangHoaBUS(ref string err, ChiTietTraHangO ctth)
        {
            return chiTietPhieuTraHangDAO.CapNhatChiTietPhieuTraHangByMaPhieuTraMaHangHoa(ref err, ctth);
        }
        public bool XoaChiTietPhieuTraHangByMaPhieuTraBUS(ref string err, ChiTietTraHangO ctth)
        {
            return chiTietPhieuTraHangDAO.XoaChiTietPhieuTraHangByMaPhieuTra(ref err, ctth);
        }
        public bool XoaChiTietPhieuTraHangByMaPhieuTraMaHangHoaBUS(ref string err, ChiTietTraHangO ctth)
        {
            return chiTietPhieuTraHangDAO.XoaChiTietPhieuTraHangByMaPhieuTraMaHangHoa(ref err, ctth);
        }
    }
}
