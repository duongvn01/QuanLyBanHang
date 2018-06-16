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
    public class TraHangDAO
    {
        private DBConnection conn;

        public TraHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllTraHang()
        {
            return conn.executeGetTable("proGetTraHang_KhachHang_Kho");
        }
        public DataTable GetAllTraHangByMaPhieuTra(TraHangO bh)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieuTra";
            param.Value = bh.MaPhieuTra;
            return conn.executeSelectQuery("proGetTraHang_KhachHang_Kho_IfMaPhieuTra", param);
        }
        public DataTable GetAllTraHangByNgayNayNgayKia(DateTime ngayNay,DateTime ngayKia)
        {
            SqlParameter[] parameters = { new SqlParameter("@NgayNay", ngayNay),
                                          new SqlParameter("@NgayKia", ngayKia)};

            return conn.executeSelectQueryParamArray("proGetTraHang_KhachHang_Kho_IfNgayNay_NgayKia",
                parameters
                );
        }
        public bool ThemTraHang(ref string err, TraHangO bh)
        {
            return conn.MyExecuteNonQuery("proThemTraHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuTra", bh.MaPhieuTra),
                new SqlParameter("@NgayLapPhieu", bh.NgayLapPhieu),
                new SqlParameter("@GhiChu", bh.GhiChu),
                new SqlParameter("@MaKhachHang", bh.MaKhachHang),
                new SqlParameter("@MaNhanVien", bh.MaNhanVien),
                new SqlParameter("@MaKho", bh.MaKho),
                
                new SqlParameter("@TongTien", bh.TongTien),
                new SqlParameter("@PTramCK", bh.PTramCK),
                new SqlParameter("@Thue", bh.Thue),
                new SqlParameter("@TuongDuongTien", bh.TuongDuongTien),
                new SqlParameter("@TienThanhToan", bh.TienThanhToan)
                );
        }
        public bool XoaTraHang(ref string err, TraHangO bh)
        {
            return conn.MyExecuteNonQuery("proXoaTraHang",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuTra", bh.MaPhieuTra));
        }
        public bool CapNhatTraHang(ref string err, TraHangO bh)
        {
            return conn.MyExecuteNonQuery("proSuaTraHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuTra", bh.MaPhieuTra),
                new SqlParameter("@NgayLapPhieu", bh.NgayLapPhieu),
                new SqlParameter("@GhiChu", bh.GhiChu),
                new SqlParameter("@MaKhachHang", bh.MaKhachHang),
                new SqlParameter("@MaNhanVien", bh.MaNhanVien),
                new SqlParameter("@MaKho", bh.MaKho),

                new SqlParameter("@TongTien", bh.TongTien),
                new SqlParameter("@PTramCK", bh.PTramCK),
                new SqlParameter("@Thue", bh.Thue),
                new SqlParameter("@TuongDuongTien", bh.TuongDuongTien),
                new SqlParameter("@TienThanhToan", bh.TienThanhToan)
                );
        }
    }
}
