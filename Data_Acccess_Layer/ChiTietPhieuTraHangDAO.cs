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
    public class ChiTietPhieuTraHangDAO
    {
        private DBConnection conn;

        public ChiTietPhieuTraHangDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllChiTietPhieuTraHang()
        {
            return conn.executeGetTable("proGetChiTietTraHang_HangHoa_DonVi");//
        }
        public DataTable GetAllChiTietPhieuTraHangByMaPhieuTra(ChiTietTraHangO ctth)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@MaPhieuTra";
            param.Value = ctth.MaPhieuTra;
            return conn.executeSelectQuery("proGetChiTietTraHang_HangHoa_DonVi_IfMaPhieuTra", param);//
        }
        public bool ThemChiTietPhieuTraHang(ref string err, ChiTietTraHangO ctth)
        {
            return conn.MyExecuteNonQuery("proThemChiTietPhieuTra",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieuTra", ctth.MaChiTietPhieuTra),
                new SqlParameter("@MaPhieuTra", ctth.MaPhieuTra),
                new SqlParameter("@MaHangHoa", ctth.MaHangHoa),
                new SqlParameter("@SoLuong", ctth.SoLuong),
                new SqlParameter("@DonGia", ctth.DonGia),
                new SqlParameter("@ThanhTien", ctth.ThanhTien)
                );
        }
        public bool XoaChiTietPhieuTraHangByMaPhieuTra(ref string err, ChiTietTraHangO ctth)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuTraHangIfMaPhieuTra",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuTra", ctth.MaPhieuTra));
        }
        public bool XoaChiTietPhieuTraHangByMaPhieuTraMaHangHoa(ref string err, ChiTietTraHangO ctth)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuTraHangByMaPhieuTraMaHangHoa",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaPhieuTra", ctth.MaPhieuTra),
                 new SqlParameter("@MaHangHoa", ctth.MaHangHoa)
                 );
        }
        public bool XoaChiTietPhieuTraHangByMaChiTietPhieuTra(ref string err, ChiTietTraHangO ctth)
        {
            return conn.MyExecuteNonQuery("proXoaChiTietPhieuTraIfMaChiTietPhieuTra",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaChiTietPhieuTra", ctth.MaChiTietPhieuTra));
        }
        public bool CapNhatChiTietPhieuTraHang(ref string err, ChiTietTraHangO ctth)
        {
            return conn.MyExecuteNonQuery("proSuaChiTietPhieuTraHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaChiTietPhieuTra", ctth.MaChiTietPhieuTra),
                new SqlParameter("@MaPhieuTra", ctth.MaPhieuTra),
                new SqlParameter("@MaHangHoa", ctth.MaHangHoa),
                new SqlParameter("@SoLuong", ctth.SoLuong),
                new SqlParameter("@DonGia", ctth.DonGia),
                new SqlParameter("@ThanhTien", ctth.ThanhTien)
                );
        }
        public bool CapNhatChiTietPhieuTraHangByMaPhieuTraMaHangHoa(ref string err, ChiTietTraHangO ctth)
        {
            return conn.MyExecuteNonQuery("proSuaChiTietTraHangByMaPhieuTra_MaHangHoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaPhieuTra", ctth.MaPhieuTra),
                new SqlParameter("@MaHangHoa", ctth.MaHangHoa),
                new SqlParameter("@SoLuong", ctth.SoLuong),
                new SqlParameter("@DonGia", ctth.DonGia),
                new SqlParameter("@ThanhTien", ctth.ThanhTien)
                );
        }
    }
}
