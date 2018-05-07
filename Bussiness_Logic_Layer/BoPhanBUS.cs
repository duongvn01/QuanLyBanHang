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
    public class BoPhanBUS
    {
        BoPhanDAO boPhanDAO;
        public BoPhanBUS()
        {
            boPhanDAO = new BoPhanDAO();
        }
        public DataTable getAllBoPhan()
        {
            return boPhanDAO.GetAllBoPhan();
          
        }
        public bool ThemBoPhanBUS(ref string err, BoPhanO bp)
        {
            return boPhanDAO.ThemBoPhan(ref err, bp);
        }
        public bool CapNhatBoPhanBUS(ref string err, BoPhanO bp)
        {
            return boPhanDAO.CapNhatBoPhan(ref err, bp);
        }
        public bool XoaBoPhanBUS(ref string err, BoPhanO bp)
        {
            return boPhanDAO.XoaBoPhan(ref err, bp);
        }
    }
}
