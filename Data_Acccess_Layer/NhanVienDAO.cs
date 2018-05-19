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
    public class NhanVienDAO
    {
        private DBConnection conn;
        
        public NhanVienDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllNhanVien()
        {
            string query = string.Format("select * from NhanVien");
           
            return conn.executeSelectQueryNoParam(query);
        }
        public bool ThemNhanVien(ref string err, NhanVienO nv)
        {

            return conn.MyExecuteNonQuery("proThemNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", nv.MaNhanVien),
                new SqlParameter("@TenNhanVien", nv.TenNhanVien),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@SoDienThoai", nv.SoDienThoai),
                new SqlParameter("@SoDiDong", nv.SoDiDong),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@MaBoPhan", nv.MaBoPhan),
                new SqlParameter("@MaNguoiQuanLy", nv.MaNguoiQuanLy),
                new SqlParameter("@ConQuanLy", nv.ConQuanLy)
                );
        }
        public bool XoaNhanVien(ref string err, NhanVienO nv)
        {
            return conn.MyExecuteNonQuery("proXoaNhanVien",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaNhanVien", nv.MaNhanVien));
        }
        public bool CapNhatNhanVien(ref string err, NhanVienO nv)
        {
            return conn.MyExecuteNonQuery("proSuaNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhanVien", nv.MaNhanVien),
                new SqlParameter("@TenNhanVien", nv.TenNhanVien),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@SoDienThoai", nv.SoDienThoai),
                new SqlParameter("@SoDiDong", nv.SoDiDong),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@MaBoPhan", nv.MaBoPhan),
                new SqlParameter("@MaNguoiQuanLy", nv.MaNguoiQuanLy),
                new SqlParameter("@ConQuanLy", nv.ConQuanLy)
                );
        }
    }
}
