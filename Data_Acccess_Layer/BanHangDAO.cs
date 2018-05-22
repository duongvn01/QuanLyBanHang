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
    public class BanHangDAO
    {
        private DBConnection conn;

        public BanHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllBanHang()
        {
            return conn.executeGetTable("proGetBanHang_KhachHang_Kho");
        }
        /*
        public DataTable GetAllBanHangByMaKhachHang(BanHangO bh)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaKhachHang";
            param.Value = bh.MaKhachHang;
            return conn.executeSelectQuery("proGetBanHang_NhaCC_Kho_IfMaKH", param);/////
        }
        */
        public DataTable GetAllBanHangByMaPhieuBan(BanHangO bh)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieuBan";
            param.Value = bh.MaPhieuBan;
            return conn.executeSelectQuery("proGetBanHang_KhachHang_Kho_IfMaPhieuBan", param);
        }
        public DataTable GetAllBanHangByNgayNayNgayKia(DateTime ngayNay,DateTime ngayKia)
        {
            SqlParameter[] parameters = { new SqlParameter("@NgayNay", ngayNay),
                                          new SqlParameter("@NgayKia", ngayKia)};
 
            return conn.executeSelectQueryParamArray("proGetMuaHang_NhaCC_Kho_IfNgayNay_NgayKia",/////
                parameters
                );
        }
        public bool ThemBanHang(ref string err, BanHangO bh)
        {
            return conn.MyExecuteNonQuery("proThemBanHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuBan", bh.MaPhieuBan),
                new SqlParameter("@TenPhieu", bh.TenPhieu),
                new SqlParameter("@NgayLapPhieu", bh.NgayLapPhieu),
                new SqlParameter("@MaKieuThanhToan", bh.MaKieuTT),
                new SqlParameter("@MaHinhThuc", bh.MaHinhThucTT),
                new SqlParameter("@ThoiHanThanhToan", bh.ThoiHanThanhToan),

                new SqlParameter("@MaKhachHang", bh.MaKhachHang),
                new SqlParameter("@NgayGiaoHang", bh.NgayGiaoHang),

                new SqlParameter("@MaNhanVien", bh.MaNhanVien),
                new SqlParameter("@MaKho", bh.MaKho),
                new SqlParameter("@GhiChu", bh.GhiChu),

                new SqlParameter("@TongTien", bh.TongTien),
                new SqlParameter("@PTramCK", bh.PTramCK),
                new SqlParameter("@Thue", bh.Thue),
                new SqlParameter("@TuongDuongTien", bh.TuongDuongTien),
                new SqlParameter("@TienThanhToan", bh.TienThanhToan)
                );
        }
        public bool XoaBanHang(ref string err, BanHangO bh)
        {
            return conn.MyExecuteNonQuery("proXoaBanHang",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuBan", bh.MaPhieuBan));
        }
        public bool CapNhatBanHang(ref string err, BanHangO bh)
        {
            return conn.MyExecuteNonQuery("proSuaBanHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuBan", bh.MaPhieuBan),
                new SqlParameter("@TenPhieu", bh.TenPhieu),
                new SqlParameter("@NgayLapPhieu", bh.NgayLapPhieu),
                new SqlParameter("@MaKieuThanhToan", bh.MaKieuTT),
                new SqlParameter("@MaHinhThuc", bh.MaHinhThucTT),
                new SqlParameter("@ThoiHanThanhToan", bh.ThoiHanThanhToan),

                new SqlParameter("@MaKhachHang", bh.MaKhachHang),
                new SqlParameter("@NgayGiaoHang", bh.NgayGiaoHang),

                new SqlParameter("@MaNhanVien", bh.MaNhanVien),
                new SqlParameter("@MaKho", bh.MaKho),
                new SqlParameter("@GhiChu", bh.GhiChu),

                new SqlParameter("@TongTien", bh.TongTien),
                new SqlParameter("@PTramCK", bh.PTramCK),
                new SqlParameter("@Thue", bh.Thue),
                new SqlParameter("@TuongDuongTien", bh.TuongDuongTien),
                new SqlParameter("@TienThanhToan", bh.TienThanhToan)
                );
        }
    }
}
