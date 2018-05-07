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
    public class NhanVienBUS
    {
        NhanVienDAO nhanVienDAO;
        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }
        public DataTable getAllNhanVien()
        {
            return nhanVienDAO.GetAllNhanVien();
          
        }
        public bool ThemNhanVienBUS(ref string err, NhanVienO nv)
        {
            return nhanVienDAO.ThemNhanVien(ref err, nv);
        }
        public bool CapNhatNhanVienBUS(ref string err, NhanVienO nv)
        {
            return nhanVienDAO.CapNhatNhanVien(ref err, nv);
        }
        public bool XoaNhanVienBUS(ref string err, NhanVienO nv)
        {
            return nhanVienDAO.XoaNhanVien(ref err, nv);
        }
    }
}
