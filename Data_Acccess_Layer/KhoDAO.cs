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
    public class KhoDAO
    {
        private DBConnection conn;
        
        public KhoDAO()
        {
            conn = new DBConnection();
        }
        public DataTable getAllKho()
        {
            return conn.executeGetTable("proGetKhoNhanVien");
        }
       
        public bool ThemKho(ref string err,KhoO k)// string MaKhuVuc, string TenKhuVuc, string GhiChu,int ConQuanLy)
        {
            return conn.MyExecuteNonQuery("proThemKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKho", k.MaKho),
                new SqlParameter("@TenKho", k.TenKho),
                new SqlParameter("@MaNguoiQuanLy", k.MaNguoiQuanLy),
                new SqlParameter("@KyHieu", k.KyHieu),
                new SqlParameter("@NguoiLienHe", k.NguoiLienHe),
                new SqlParameter("@DiaChi", k.DiaChi),
                new SqlParameter("@Fax", k.Fax),
                new SqlParameter("@SoDienThoai", k.SoDienThoai),
                new SqlParameter("@Email", k.Email),
                new SqlParameter("@DienGiai", k.DienGiai),
                new SqlParameter("@ConQuanLy", k.ConQuanLy)
                );
        }
        public bool XoaKho(ref string err,KhoO k)// string MaKhuVuc)
        {
            return conn.MyExecuteNonQuery("proXoaKho",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKho", k.MaKho));
        }
        public bool CapNhatKho(ref string err,KhoO k)// string MaKhuVuc, string TenKhuVuc, string GhiChu, int ConQuanLy)
        {
            return conn.MyExecuteNonQuery("proSuaKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKho", k.MaKho),
                new SqlParameter("@TenKho", k.TenKho),
                new SqlParameter("@MaNguoiQuanLy", k.MaNguoiQuanLy),
                new SqlParameter("@KyHieu", k.KyHieu),
                new SqlParameter("@NguoiLienHe", k.NguoiLienHe),
                new SqlParameter("@DiaChi", k.DiaChi),
                new SqlParameter("@Fax", k.Fax),
                new SqlParameter("@SoDienThoai", k.SoDienThoai),
                new SqlParameter("@Email", k.Email),
                new SqlParameter("@DienGiai", k.DienGiai),
                new SqlParameter("@ConQuanLy", k.ConQuanLy)
                );
        }
        
        
    }
}
