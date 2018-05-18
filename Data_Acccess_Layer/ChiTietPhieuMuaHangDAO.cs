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
    public class ChiTietPhieuMuaHangDAO
    {
        private DBConnection conn;

        public ChiTietPhieuMuaHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllChiTietPhieuMuaHang()
        {
            return conn.executeGetTable("proGetMuaHang_NhaCC_Kho");
        }
        public DataTable GetAllChiTietPhieuMuaHangByMaPhieu(ChiTietPhieuMuaHangO ctpmh)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieu";
            param.Value = ctpmh.MaPhieu;
            return conn.executeSelectQuery("proGetChiTietPhieuMuaHang_HangHoa_DonVi_IfMaPhieu", param);
        }

        public bool ThemChiTietPhieuMuaHang(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return conn.MyExecuteNonQuery("proThemChiTietPhieuMuaHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieu",ctpmh.MaChiTietPhieu),
                new SqlParameter("@MaPhieu", ctpmh.MaPhieu),
                new SqlParameter("@MaHangHoa",ctpmh.MaHangHoa),
                new SqlParameter("@SoLuong", ctpmh.SoLuong),
                new SqlParameter("@DonGia",ctpmh.DonGia),
                new SqlParameter("@ThanhTien", ctpmh.ThanhTien)
                );
        }
        public bool XoaChiTietPhieuMuaHangByMaPhieu(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuMuaHangIfMaPhieu",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieu", ctpmh.MaPhieu));
        }
        public bool XoaChiTietPhieuMuaHangByMaChiTietPhieu(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuMuaHangIfMaChiTietPhieu",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaChiTietPhieu", ctpmh.MaChiTietPhieu));
        }
        public bool CapNhatChiTietPhieuMuaHang(ref string err, ChiTietPhieuMuaHangO ctpmh)
        {
            return conn.MyExecuteNonQuery("proSuaChiTietPhieuMuaHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieu", ctpmh.MaChiTietPhieu),
                new SqlParameter("@MaPhieu", ctpmh.MaPhieu),
                new SqlParameter("@MaHangHoa", ctpmh.MaHangHoa),
                new SqlParameter("@SoLuong", ctpmh.SoLuong),
                new SqlParameter("@DonGia", ctpmh.DonGia),
                new SqlParameter("@ThanhTien", ctpmh.ThanhTien)
                );
        }
    }
}
