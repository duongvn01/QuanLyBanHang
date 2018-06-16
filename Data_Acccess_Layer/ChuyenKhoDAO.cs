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
    public class ChuyenKhoDAO
    {
        private DBConnection conn;

        public ChuyenKhoDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllChuyenKho()
        {
            return conn.executeGetTable("proGetChuyenKho_Kho_NhanVien");
        }
        public DataTable GetAllChuyenKhoByMaPhieuChuyen(ChuyenKhoO ck)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieuChuyen";
            param.Value = ck.MaPhieuChuyen;
            return conn.executeSelectQuery("proGetChuyenKho_Kho_NhanVien_IfMaPhieuChuyen", param);
        }
        public DataTable GetAllChuyenKhoByNgayNayNgayKia(DateTime ngayNay,DateTime ngayKia)
        {
            SqlParameter[] parameters = { new SqlParameter("@NgayNay", ngayNay),
                                          new SqlParameter("@NgayKia", ngayKia)};

            return conn.executeSelectQueryParamArray("proGetChuyenKho_Kho_NhanVien_IfNgayNay_NgayKia",
                parameters
                );
        }
        public bool ThemChuyenKho(ref string err, ChuyenKhoO ck)
        {
            return conn.MyExecuteNonQuery("proThemChuyenKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuChuyen", ck.MaPhieuChuyen),
                new SqlParameter("@NgayLapPhieu", ck.NgayLapPhieu),
                new SqlParameter("@GhiChu", ck.GhiChu),
                new SqlParameter("@MaKhoChuyen", ck.MaKhoChuyen),
                new SqlParameter("@MaKhoNhan", ck.MaKhoNhan),
                new SqlParameter("@MaNguoiChuyen", ck.MaNguoiChuyen),
                new SqlParameter("@MaNguoiNhan", ck.MaNguoiNhan)
                );
        }
        public bool XoaChuyenKho(ref string err, ChuyenKhoO ck)
        {
            return conn.MyExecuteNonQuery("proXoaChuyenKho",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuChuyen", ck.MaPhieuChuyen));
        }
        public bool CapNhatChuyenKho(ref string err, ChuyenKhoO ck)
        {
            return conn.MyExecuteNonQuery("proSuaChuyenKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuChuyen", ck.MaPhieuChuyen),
                new SqlParameter("@NgayLapPhieu", ck.NgayLapPhieu),
                new SqlParameter("@GhiChu", ck.GhiChu),
                new SqlParameter("@MaKhoChuyen", ck.MaKhoChuyen),
                new SqlParameter("@MaKhoNhan", ck.MaKhoNhan),
                new SqlParameter("@MaNguoiChuyen", ck.MaNguoiChuyen),
                new SqlParameter("@MaNguoiNhan", ck.MaNguoiNhan)
                );
        }
    }
}
