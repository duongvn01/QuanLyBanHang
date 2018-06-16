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
    public class ChiTietPhieuBanHangDAO
    {
        private DBConnection conn;

        public ChiTietPhieuBanHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllChiTietPhieuBanHang()
        {
            return conn.executeGetTable("proGetBanHang_NhaCC_Kho");
        }
        public DataTable GetAllChiTietPhieuBanHangByMaPhieuBan(ChiTietPhieuBanHangO ctpbh)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieuBan";
            param.Value = ctpbh.MaPhieuBan;
            return conn.executeSelectQuery("proGetChiTietPhieuBanHang_HangHoa_DonVi_IfMaPhieu", param);
        }
        public bool ThemChiTietPhieuBanHang(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return conn.MyExecuteNonQuery("proThemChiTietPhieuBan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieuBan", ctpbh.MaChiTietPhieuBan),
                new SqlParameter("@MaPhieuBan", ctpbh.MaPhieuBan),
                new SqlParameter("@MaHangHoa", ctpbh.MaHangHoa),
                new SqlParameter("@SoLuong", ctpbh.SoLuong),
                new SqlParameter("@DonGia", ctpbh.DonGia),
                new SqlParameter("@ThanhTien", ctpbh.ThanhTien)
                );
        }
        public bool XoaChiTietPhieuBanHangByMaPhieuBan(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuBanHangIfMaPhieuBan",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuBan", ctpbh.MaPhieuBan));
        }
        public bool XoaChiTietPhieuBanHangByMaPhieuBanMaHangHoa(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuBanHangByMaPhieuBanMaHangHoa",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuBan", ctpbh.MaPhieuBan),
                 new SqlParameter("@MaHangHoa", ctpbh.MaHangHoa)
                 );
        }
        public bool XoaChiTietPhieuBanHangByMaChiTietPhieuBan(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuBanIfMaChiTietPhieuBan",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaChiTietPhieuBan", ctpbh.MaChiTietPhieuBan));
        }
        public bool CapNhatChiTietPhieuBanHang(ref string err, ChiTietPhieuBanHangO ctpbh)
        {
            return conn.MyExecuteNonQuery("proSuaChiTietPhieuBanHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieuBan", ctpbh.MaChiTietPhieuBan),
                new SqlParameter("@MaPhieuBan", ctpbh.MaPhieuBan),
                new SqlParameter("@MaHangHoa", ctpbh.MaHangHoa),
                new SqlParameter("@SoLuong", ctpbh.SoLuong),
                new SqlParameter("@DonGia", ctpbh.DonGia),
                new SqlParameter("@ThanhTien", ctpbh.ThanhTien)
                );
        }
    }
}
