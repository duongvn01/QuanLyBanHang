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
    public class BoPhanDAO
    {
        private DBConnection conn;
        
        public BoPhanDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllBoPhan()
        {
            string query = string.Format("select * from BoPhan");
           
            return conn.executeSelectQueryNoParam(query);
        }


        public bool ThemBoPhan(ref string err, BoPhanO bp)
        {
            return conn.MyExecuteNonQuery("proThemBoPhan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBoPhan", bp.MaBoPhan),
                new SqlParameter("@TenBoPhan", bp.TenBoPhan),
                new SqlParameter("@GhiChu", bp.GhiChu),
                new SqlParameter("@ConQuanLy", bp.ConQuanLy)
                );
        }
        public bool XoaBoPhan(ref string err, BoPhanO bp)
        {
            return conn.MyExecuteNonQuery("proXoaBoPhan",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaBoPhan", bp.MaBoPhan));
        }
        public bool CapNhatBoPhan(ref string err, BoPhanO bp)
        {
            return conn.MyExecuteNonQuery("proSuaBoPhan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaBoPhan", bp.MaBoPhan),
                new SqlParameter("@TenBoPhan", bp.TenBoPhan),
                new SqlParameter("@GhiChu", bp.GhiChu),
                new SqlParameter("@ConQuanLy", bp.ConQuanLy)
                );
        }
    }
}
