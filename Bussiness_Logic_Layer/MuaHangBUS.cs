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
