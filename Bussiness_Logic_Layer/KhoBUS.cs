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
    public class KhoBUS
    {
        KhoDAO khoDAO;
        KhoO K;
        public KhoBUS()
        {
            khoDAO = new KhoDAO();
            K = new KhoO();
        }
        public DataTable getAllKhoBUS()
        {
            return khoDAO.getAllKho();
          
        }
        public bool ThemKhoBUS(ref string err,KhoO k)
        {
            return khoDAO.ThemKho(ref err, k);
        }
        public bool CapNhatKhoBUS(ref string err,KhoO k)
        {
            return khoDAO.CapNhatKho(ref err, k);
        }
        public bool XoaKhoBUS(ref string err,KhoO k)
        {
            return khoDAO.XoaKho(ref err, k);
        }
    }
}
