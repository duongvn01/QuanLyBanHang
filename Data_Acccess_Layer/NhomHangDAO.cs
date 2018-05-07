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
    public class NhomHangDAO
    {
        private DBConnection conn;

        public NhomHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllNhomHang()
        {
            string query = string.Format("select * from NhomHang");
           
            return conn.executeSelectQueryNoParam(query);
        }

        public bool ThemNhomHang(ref string err, NhomHangO nh)
        {
            return conn.MyExecuteNonQuery("proThemNhomHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhomHang", nh.MaNhomHang),
                new SqlParameter("@TenNhomHang", nh.TenNhomHang),
                new SqlParameter("@GhiChu", nh.GhiChu),
                new SqlParameter("@ConQuanLy", nh.ConQuanLy)
                );
        }
        public bool XoaNhomHang(ref string err, NhomHangO nh)
        {
            return conn.MyExecuteNonQuery("proXoaNhomHang",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaNhomHang", nh.MaNhomHang));
        }
        public bool CapNhatNhomHang(ref string err, NhomHangO nh)
        {
            return conn.MyExecuteNonQuery("proSuaNhomHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhomHang", nh.MaNhomHang),
                new SqlParameter("@TenNhomHang", nh.TenNhomHang),
                new SqlParameter("@GhiChu", nh.GhiChu),
                new SqlParameter("@ConQuanLy", nh.ConQuanLy)
                );
        }
    }
}
