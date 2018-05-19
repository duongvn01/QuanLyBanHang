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
    public class ChiTietPhieuMuaHangBUS
    {
        ChiTietPhieuMuaHangDAO chiTietPhieuMuaHangDAO;
        public ChiTietPhieuMuaHangBUS()
        {
            chiTietPhieuMuaHangDAO = new ChiTietPhieuMuaHangDAO();
        }
        public DataTable getAllChiTietPhieuMuaHang()
        {
            return chiTietPhieuMuaHangDAO.GetAllChiTietPhieuMuaHang();     
        }
        public DataTable GetAllChiTietPhieuMuaHangByMaPhieuBUS(ChiTietPhieuMuaHangO ctpmh)
        {
            return chiTietPhieuMuaHangDAO.GetAllChiTietPhieuMuaHangByMaPhieu(ctpmh);
        }
        public bool ThemChiTietPhieuMuaHangBUS(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return chiTietPhieuMuaHangDAO.ThemChiTietPhieuMuaHang(ref err, ctpmh);
        }
        public bool CapNhatChiTietPhieuMuaHangBUS(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return chiTietPhieuMuaHangDAO.CapNhatChiTietPhieuMuaHang(ref err, ctpmh);
        }
        public bool XoaChiTietPhieuMuaHangByMaChiTietPhieuBUS(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return chiTietPhieuMuaHangDAO.XoaChiTietPhieuMuaHangByMaChiTietPhieu(ref err, ctpmh);
        }
        public bool XoaChiTietPhieuMuaHangByMaPhieuBUS(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return chiTietPhieuMuaHangDAO.XoaChiTietPhieuMuaHangByMaPhieu(ref err, ctpmh);
        }
    }
}
