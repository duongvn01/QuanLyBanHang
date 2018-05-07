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
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO;
        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }
        public DataTable getAllNhaCungCap()
        {
            return nhaCungCapDAO.GetAllNhaCungCap();
          
        }
        public bool ThemNhaCungCapBUS(ref string err, NhaCungCapO ncc)
        {
            return nhaCungCapDAO.ThemNhaCungCap(ref err, ncc);
        }
        public bool CapNhatNhaCungCapBUS(ref string err, NhaCungCapO ncc)
        {
            return nhaCungCapDAO.CapNhatNhaCungCap(ref err, ncc);
        }
        public bool XoaNhaCungCapBUS(ref string err, NhaCungCapO ncc)
        {
            return nhaCungCapDAO.XoaNhaCungCap(ref err, ncc);
        }
    }
}
