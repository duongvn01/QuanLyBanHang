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
    public class DonViBUS
    {
        DonViDAO donViDAO;
        public DonViBUS(){
            donViDAO = new DonViDAO();
        }
        public DataTable getAllDonVi()
        {
            return donViDAO.GetAllDonVi();
          
        }
        public bool ThemDonViBUS(ref string err, DonViO dv)
        {
            return donViDAO.ThemDonVi(ref err, dv);
        }
        public bool CapNhatDonViBUS(ref string err, DonViO dv)
        {
            return donViDAO.CapNhatDonVi(ref err, dv);
        }
        public bool XoaDonViBUS(ref string err, DonViO dv)
        {
            return donViDAO.XoaDonVi(ref err, dv);
        }
    }
}
