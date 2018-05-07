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
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO;
        public KhachHangBUS()
        {
            khachHangDAO = new KhachHangDAO();
        }
        public DataTable getAllKhachHang()
        {
            return khachHangDAO.GetAllKhachHang();
          
        }
        public bool ThemKhachHangBUS(ref string err,KhachHangO kh)
        {
            return khachHangDAO.ThemKhachHang(ref err, kh);
        }
        public bool CapNhatKhachHangBUS(ref string err, KhachHangO kh)
        {
            return khachHangDAO.CapNhatKhachHang(ref err, kh);
        }
        public bool XoaKhachHangBUS(ref string err, KhachHangO kh)
        {
            return khachHangDAO.XoaKhachHang(ref err, kh);
        }
    }
}
