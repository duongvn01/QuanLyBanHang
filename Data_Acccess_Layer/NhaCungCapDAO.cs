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
    public class NhaCungCapDAO
    {
        private DBConnection conn;
        
        public NhaCungCapDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllNhaCungCap()
        {
            string query = string.Format("select * from NhaCungCap");
           
            return conn.executeSelectQueryNoParam(query);
        }


        public bool ThemNhaCungCap(ref string err, NhaCungCapO ncc)
        {
            return conn.MyExecuteNonQuery("proThemNhaCungCap",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhaCungCap", ncc.MaNhaCungCap),
                new SqlParameter("@TenNhaCungCap", ncc.TenNhaCungCap),
                new SqlParameter("@MaKhuVuc", ncc.MaKhuVuc),
                new SqlParameter("@DiaChi", ncc.DiaChi),
                new SqlParameter("@MaSoThue", ncc.MaSoThue),
                new SqlParameter("@Fax", ncc.Fax),
                new SqlParameter("@SoDienThoai", ncc.SoDienThoai),
                new SqlParameter("@SoDiDong", ncc.SoDiDong),
                new SqlParameter("@Email", ncc.Email),
                new SqlParameter("@Website", ncc.Website),
                new SqlParameter("@TaiKhoan", ncc.TaiKhoan),
                new SqlParameter("@NganHang", ncc.NganHang),
                new SqlParameter("@GioiHanNo", ncc.GioiHanNo),
                new SqlParameter("@NoHienTai", ncc.NoHienTai),
                new SqlParameter("@ChietKhau", ncc.ChietKhau),
                new SqlParameter("@NguoiLienHe", ncc.NguoiLienHe),
                new SqlParameter("@ChucVu", ncc.ChucVu),
                new SqlParameter("@ThongTinKhac", ncc.ThongTinKhac),
                new SqlParameter("@ConQuanLy", ncc.ConQuanLy)
                );
        }
        public bool XoaNhaCungCap(ref string err, KhachHangO kh)
        {
            return conn.MyExecuteNonQuery("proXoaNhaCungCap",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKhachHang", kh.MaKhachHang));
        }
        public bool CapNhatNhaCungCap(ref string err, NhaCungCapO ncc)
        {
            return conn.MyExecuteNonQuery("proSuaNhaCungCap",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhaCungCap", ncc.MaNhaCungCap),
                new SqlParameter("@TenNhaCungCap", ncc.TenNhaCungCap),
                new SqlParameter("@MaKhuVuc", ncc.MaKhuVuc),
                new SqlParameter("@DiaChi", ncc.DiaChi),
                new SqlParameter("@MaSoThue", ncc.MaSoThue),
                new SqlParameter("@Fax", ncc.Fax),
                new SqlParameter("@SoDienThoai", ncc.SoDienThoai),
                new SqlParameter("@SoDiDong", ncc.SoDiDong),
                new SqlParameter("@Email", ncc.Email),
                new SqlParameter("@Website", ncc.Website),
                new SqlParameter("@TaiKhoan", ncc.TaiKhoan),
                new SqlParameter("@NganHang", ncc.NganHang),
                new SqlParameter("@GioiHanNo", ncc.GioiHanNo),
                new SqlParameter("@NoHienTai", ncc.NoHienTai),
                new SqlParameter("@ChietKhau", ncc.ChietKhau),
                new SqlParameter("@NguoiLienHe", ncc.NguoiLienHe),
                new SqlParameter("@ChucVu", ncc.ChucVu),
                new SqlParameter("@ThongTinKhac", ncc.ThongTinKhac),
                new SqlParameter("@ConQuanLy", ncc.ConQuanLy)
                );
        }

        public bool XoaNhaCungCap(ref string err, NhaCungCapO ncc)
        {
            return conn.MyExecuteNonQuery("proXoaNhaCungCap",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNhaCungCap", ncc.MaNhaCungCap));
        }
    }
}
