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
    public class KhuVucDAO
    {
        private DBConnection conn;
        public KhuVucDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllKhuVuc()
        {
            string query = string.Format("select * from KhuVuc");
           
            return conn.executeSelectQueryNoParam(query);
        }
       
        public bool ThemKhuVuc(ref string err,KhuVucO kv)// string MaKhuVuc, string TenKhuVuc, string GhiChu,int ConQuanLy)
        {
            return conn.MyExecuteNonQuery("proThemKhuVuc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhuVuc",kv.MaKhuVuc),
                new SqlParameter("@TenKhuVuc",kv.TenKhuVuc),
                new SqlParameter("@GhiChu", kv.GhiChu),
                new SqlParameter("@ConQuanLy",kv.ConQuanLy)
                );
        }
        public bool XoaKhuVuc(ref string err,KhuVucO kv)// string MaKhuVuc)
        {
            return conn.MyExecuteNonQuery("proXoaKhuVuc",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKhuVuc", kv.MaKhuVuc));
        }
        public bool CapNhatKhuVuc(ref string err,KhuVucO kv)// string MaKhuVuc, string TenKhuVuc, string GhiChu, int ConQuanLy)
        {
            return conn.MyExecuteNonQuery("proSuaKhuVuc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhuVuc", kv.MaKhuVuc),
                new SqlParameter("@TenKhuVuc", kv.TenKhuVuc),
                new SqlParameter("@GhiChu", kv.GhiChu),
                new SqlParameter("@ConQuanLy", kv.ConQuanLy));
        }
        //proSuaKhuVuc-> commantext
    }
}
