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
    public class MuaHangDAO
    {
        private DBConnection conn;

        public MuaHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllMuaHang()
        {
            return conn.executeGetTable("proGetHangHoa_Kho_NhomHang_DonVi_NhaCC");
        }
        public DataTable GetAllMuaHangByMaNhaCungCap(MuaHangO mh)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaNhaCungCap";
            param.Value = mh.MaNhaCungCap;
            return conn.executeSelectQuery("proGetMuaHang_NhaCC_Kho_IfMaNhaCungCap", param);
        }
        public DataTable GetAllMuaHangByNgayNayNgayKia(DateTime ngayNay,DateTime ngayKia)
        {
            SqlParameter[] parameters = { new SqlParameter("@NgayNay", ngayNay),
                                          new SqlParameter("@NgayKia", ngayKia)};
 
            return conn.executeSelectQueryParamArray("proGetMuaHang_NhaCC_Kho_IfNgayNay_NgayKia",
                parameters
                );
        }
        public bool ThemMuaHang(ref string err, MuaHangO mh)
        {
            return conn.MyExecuteNonQuery("proThemMuaHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieu", mh.MaPhieu),
                new SqlParameter("@TenPhieu", mh.TenPhieu),
                new SqlParameter("@NgayLapPhieu", mh.NgayLapPhieu),
                new SqlParameter("@SoHoaDonVAT", mh.SoHoaDonVAT),
                new SqlParameter("@SoPhieuVietTay", mh.SoPhieuVietTay),
                new SqlParameter("@MaThanhToan", mh.MaThanhToan),
                new SqlParameter("@MaHinhThuc", mh.MaHinhThuc),
                new SqlParameter("@MaNhaCungCap", mh.MaNhaCungCap),
                new SqlParameter("@ThoiHanThanhToan", mh.ThoiHanThanhToan),
                new SqlParameter("@GhiChu", mh.GhiChu),

                new SqlParameter("@MaNhanVien", mh.MaNhanVien),
                new SqlParameter("@MaKho", mh.MaKho),
                new SqlParameter("@TongTien", mh.TongTien),
                new SqlParameter("@PTramCK", mh.PTramCK),
                new SqlParameter("@Thue", mh.Thue),
                new SqlParameter("@TuongDuongTien", mh.TuongDuongTien),
                new SqlParameter("@TienThanhToan", mh.TienThanhToan)
                );
        }
        public bool XoaMuaHang(ref string err, MuaHangO mh)
        {
            return conn.MyExecuteNonQuery("proXoaMuaHang",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieu", mh.MaPhieu));
        }
        public bool CapNhatMuaHang(ref string err, MuaHangO mh)
        {
            return conn.MyExecuteNonQuery("proSuaMuaHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieu", mh.MaPhieu),
                new SqlParameter("@TenPhieu", mh.TenPhieu),
                new SqlParameter("@NgayLapPhieu", mh.NgayLapPhieu.Date),
                new SqlParameter("@SoHoaDonVAT", mh.SoHoaDonVAT),
                new SqlParameter("@SoPhieuVietTay", mh.SoPhieuVietTay),
                new SqlParameter("@MaThanhToan", mh.MaThanhToan),
                new SqlParameter("@MaHinhThuc", mh.MaHinhThuc),
                new SqlParameter("@MaNhaCungCap", mh.MaNhaCungCap),
                new SqlParameter("@ThoiHanThanhToan", mh.ThoiHanThanhToan.Date),
                new SqlParameter("@GhiChu", mh.GhiChu),

                new SqlParameter("@MaNhanVien", mh.MaNhanVien),
                new SqlParameter("@MaKho", mh.MaKho),
                new SqlParameter("@TongTien", mh.TongTien),
                new SqlParameter("@PTramCK", mh.PTramCK),
                new SqlParameter("@Thue", mh.Thue),
                new SqlParameter("@TuongDuongTien", mh.TuongDuongTien),
                new SqlParameter("@TienThanhToan", mh.TienThanhToan)
                );
        }

        public bool XoaMuaHang(ref string err, HangHoaO mh)
        {
            throw new NotImplementedException();
        }
    }
}
