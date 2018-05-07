using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;

namespace Data_Acccess_Layer
{
    public class DonViDAO
    {
        private DBConnection conn;

        public DonViDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllDonVi()
        {
            string query = string.Format("select * from DonVi");
           
            return conn.executeSelectQueryNoParam(query);
        }
       
        public bool ThemDonVi(ref string err,DonViO dv)
        {
            return conn.MyExecuteNonQuery("proThemDonVi",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDonVi", dv.MaDonVi),
                new SqlParameter("@TenDonVi", dv.TenDonVi),
                new SqlParameter("@GhiChu", dv.GhiChu),
                new SqlParameter("@ConQuanLy", dv.ConQuanLy)
                );
        }
        public bool XoaDonVi(ref string err, DonViO dv)
        {
            return conn.MyExecuteNonQuery("proXoaDonVi",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaDonVi", dv.MaDonVi));
        }
        public bool CapNhatDonVi(ref string err,DonViO dv)
        {
            return conn.MyExecuteNonQuery("proSuaDonVi",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaDonVi", dv.MaDonVi),
                new SqlParameter("@TenDonVi", dv.TenDonVi),
                new SqlParameter("@GhiChu", dv.GhiChu),
                new SqlParameter("@ConQuanLy", dv.ConQuanLy)
                );
        }
    }
}
