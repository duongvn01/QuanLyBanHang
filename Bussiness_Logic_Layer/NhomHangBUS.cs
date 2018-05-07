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
    public class NhomHangBUS
    {
       
        NhomHangDAO nhomHangDAO;
        public NhomHangBUS()
        {
            nhomHangDAO = new NhomHangDAO();
        }
        public DataTable getAllNhomHang()
        {
            return nhomHangDAO.GetAllNhomHang();       
        }
        public bool ThemNhomHangBUS(ref string err, NhomHangO nh)
        {
            return nhomHangDAO.ThemNhomHang(ref err, nh);
        }
        public bool CapNhatNhomHangBUS(ref string err,NhomHangO nh)
        {
            return nhomHangDAO.CapNhatNhomHang(ref err, nh);
        }
        public bool XoaNhomHangBUS(ref string err,NhomHangO nh)
        {
            return nhomHangDAO.XoaNhomHang(ref err, nh);
        }
    }
}
