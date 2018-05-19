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
    public class KhachHangDAO
    {
        private DBConnection conn;
        
        public KhachHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllKhachHang()
        {
            string query = string.Format("select * from KhachHang");
           
            return conn.executeSelectQueryNoParam(query);
        }

        public bool ThemKhachHang(ref string err,KhachHangO kh)/*, int SiOrLe, string MaKhachHang, string MaKhuVuc,
            string TenKhachHang, string DiaChi, string MaSoThue, string Fax, string SoDienThoai, string SoDiDong,
            string Email, string Website, string TaiKhoan, string NganHang, double GioiHanNo, double NoHienTai, float ChietKhau,
            string NguoiLienHe, string ThongTinKhac)*/
        {
            return conn.MyExecuteNonQuery("proThemKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@SiOrLe", kh.SiOrLe),
                new SqlParameter("@MaKhachHang", kh.MaKhachHang),
                new SqlParameter("@MaKhuVuc", kh.MaKhuVuc),
                new SqlParameter("@TenKhachHang", kh.TenKhachHang),
                new SqlParameter("@DiaChi", kh.DiaChi),
                new SqlParameter("@MaSoThue", kh.MaSoThue),
                new SqlParameter("@Fax", kh.Fax),
                new SqlParameter("@SoDienThoai", kh.SoDienThoai),
                new SqlParameter("@SoDiDong", kh.SoDiDong),
                new SqlParameter("@Email", kh.Email),
                new SqlParameter("@Website", kh.Website),
                new SqlParameter("@TaiKhoan", kh.TaiKhoan),
                new SqlParameter("@NganHang", kh.NganHang),
                new SqlParameter("@GioiHanNo", kh.GioiHanNo),
                new SqlParameter("@NoHienTai", kh.NoHienTai),
                new SqlParameter("@ChietKhau", kh.ChietKhau),
                new SqlParameter("@NguoiLienHe", kh.NguoiLienHe),
                new SqlParameter("@ThongTinKhac", kh.ThongTinKhac),
                new SqlParameter("@ConQuanLy", kh.ConQuanLy)
                );
        }
        public bool XoaKhachHang(ref string err, KhachHangO kh)
        {
            return conn.MyExecuteNonQuery("proXoaKhachHang",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKhachHang", kh.MaKhachHang));
        }
        public bool CapNhatKhachHang(ref string err,KhachHangO kh)/* int SiOrLe, string MaKhachHang, string MaKhuVuc,
            string TenKhachHang, string DiaChi, string MaSoThue, string Fax, string SoDienThoai, string SoDiDong,
            string Email, string Website, string TaiKhoan, string NganHang, double GioiHanNo, double NoHienTai, float ChietKhau,
            string NguoiLienHe, string ThongTinKhac)*/
        {
            return conn.MyExecuteNonQuery("proSuaKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@SiOrLe", kh.SiOrLe),
                new SqlParameter("@MaKhachHang", kh.MaKhachHang),
                new SqlParameter("@MaKhuVuc", kh.MaKhuVuc),
                new SqlParameter("@TenKhachHang", kh.TenKhachHang),
                new SqlParameter("@DiaChi", kh.DiaChi),
                new SqlParameter("@MaSoThue", kh.MaSoThue),
                new SqlParameter("@Fax", kh.Fax),
                new SqlParameter("@SoDienThoai", kh.SoDienThoai),
                new SqlParameter("@SoDiDong", kh.SoDiDong),
                new SqlParameter("@Email", kh.Email),
                new SqlParameter("@Website", kh.Website),
                new SqlParameter("@TaiKhoan", kh.TaiKhoan),
                new SqlParameter("@NganHang", kh.NganHang),
                new SqlParameter("@GioiHanNo", kh.GioiHanNo),
                new SqlParameter("@NoHienTai", kh.NoHienTai),
                new SqlParameter("@ChietKhau", kh.ChietKhau),
                new SqlParameter("@NguoiLienHe", kh.NguoiLienHe),
                new SqlParameter("@ThongTinKhac", kh.ThongTinKhac),
                new SqlParameter("@ConQuanLy", kh.ConQuanLy)
                );
        }
    }
}
