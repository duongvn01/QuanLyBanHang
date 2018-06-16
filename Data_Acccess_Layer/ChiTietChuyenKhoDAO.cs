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
    public class ChiTietChuyenKhoDAO
    {
        private DBConnection conn;

        public ChiTietChuyenKhoDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllChiTietChuyenKho()
        {
            return conn.executeGetTable("proGetChuyenHang_NhaCC_Kho");
        }
        public DataTable GetAllChiTietChuyenKhoByMaPhieuChuyen(ChiTietChuyenKhoO ctpck)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieuChuyen";
            param.Value = ctpck.MaPhieuChuyen;
            return conn.executeSelectQuery("proGetChiTietChuyenKho_HangHoa_DonVi_IfMaPhieuChuyen", param);
        }
        public bool ThemChiTietChuyenKho(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return conn.MyExecuteNonQuery("proThemChiTietPhieuChuyen",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieuChuyen", ctpck.MaChiTietPhieuChuyen),
                new SqlParameter("@MaPhieuChuyen", ctpck.MaPhieuChuyen),
                new SqlParameter("@MaHangHoa", ctpck.MaHangHoa),
                new SqlParameter("@SoLuong", ctpck.SoLuong),
                new SqlParameter("@DonGia", ctpck.DonGia),
                new SqlParameter("@ThanhTien", ctpck.ThanhTien)
                );
        }
        public bool XoaChiTietChuyenKhoByMaPhieuChuyen(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietChuyenKhoIfMaPhieuChuyenMaHangHoa",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuChuyen", ctpck.MaPhieuChuyen));
        }
        public bool XoaChiTietChuyenKhoByMaPhieuChuyenMaHangHoa(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuMuaHangByMaPhieuMaHangHoa",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuChuyen", ctpck.MaPhieuChuyen),
                 new SqlParameter("@MaHangHoa", ctpck.MaHangHoa)
                 );
        }
        public bool XoaChiTietChuyenKhoByMaChiTietPhieuChuyen(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuChuyenIfMaChiTietPhieuChuyen",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaChiTietPhieuChuyen", ctpck.MaChiTietPhieuChuyen));
        }
        public bool CapNhatChiTietChuyenKho(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return conn.MyExecuteNonQuery("proSuaChiTietChuyenKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieuChuyen", ctpck.MaChiTietPhieuChuyen),
                new SqlParameter("@MaPhieuChuyen", ctpck.MaPhieuChuyen),
                new SqlParameter("@MaHangHoa", ctpck.MaHangHoa),
                new SqlParameter("@SoLuong", ctpck.SoLuong),
                new SqlParameter("@DonGia", ctpck.DonGia),
                new SqlParameter("@ThanhTien", ctpck.ThanhTien)
                );
        }
        public bool CapNhatChiTietChuyenKhoByMaPhieuChuyenMaHangHoa(ref string err, ChiTietChuyenKhoO ctpck)
        {
            return conn.MyExecuteNonQuery("proSuaChiTietPhieuMuaHangByMaPhieu_MaHangHoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuChuyen", ctpck.MaPhieuChuyen),
                new SqlParameter("@MaHangHoa", ctpck.MaHangHoa)
                );
        }
    }
}
