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
        DonViO DV;
        public DonViBUS(){
            donViDAO = new DonViDAO();
            DV = new DonViO();
        }
        public DataTable getAllDonVi()
        {
            return donViDAO.GetAllDonVi();
          
        }
        public DonViO getOneDonVi(DonViO dv)
        {
            DataTable dt = new DataTable();
            dt = donViDAO.GetAllDonVi();
            DataRow[] result = dt.Select("MaDonVi= '" + dv.MaDonVi + "'");
            DataRow row = result[0];
            DV.MaDonVi = row["MaDonVi"].ToString();
            DV.TenDonVi = row["TenDonVi"].ToString();
            DV.GhiChu = row["GhiChu"].ToString();
            return DV;
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
