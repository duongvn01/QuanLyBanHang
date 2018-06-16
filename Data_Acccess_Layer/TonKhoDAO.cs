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
    public class TonKhoDAO
    {
        private DBConnection conn;

        public TonKhoDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllTonKho()
        {
            return conn.executeGetTable("proGetTonKho_Kho_HangHoa_DonVi_NhomHang");
        }
        public DataTable GetAllTonKhoByMaKho(TonKhoO tk)
        {
            SqlParameter param  = new SqlParameter();
            param.ParameterName = "@MaKho";
            param.Value         = tk.MaKho;
            return conn.executeSelectQuery("proGetTonKho_Kho_HangHoa_DonVi_NhomHang_IfMaKho",param);
        }
        public bool ThemTonKho(ref string err,TonKhoO tk)
        {
            return conn.MyExecuteNonQuery("proThemTonKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", tk.MaHangHoa),
                new SqlParameter("@MaKho", tk.MaKho),
                new SqlParameter("@SoLuong", tk.SoLuong)
                );
        }
        public bool XuatTonKho(ref string err, TonKhoO tk)
        {
            return conn.MyExecuteNonQuery("proXuatTonKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", tk.MaHangHoa),
                new SqlParameter("@MaKho", tk.MaKho),
                new SqlParameter("@SoLuong", tk.SoLuong)
                );
        }
        public bool XoaTonKho(ref string err, TonKhoO tk)
        {
            return conn.MyExecuteNonQuery("proXoaTonKho",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaHangHoa", tk.MaHangHoa));
        }
        public bool CapNhatTonKho(ref string err, TonKhoO tk)
        {
            return conn.MyExecuteNonQuery("proSuaTonKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", tk.MaHangHoa),
                new SqlParameter("@MaKho", tk.MaKho),
                new SqlParameter("@SoLuong", tk.SoLuong)
                );
        }
        public bool CongSoLuongTonKho(ref string err, TonKhoO tk)
        {
            return conn.MyExecuteNonQuery("proCongSoLuongTonKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", tk.MaHangHoa),
                new SqlParameter("@MaKho", tk.MaKho),
                new SqlParameter("@SoLuong", tk.SoLuong)
                );
        }
        public bool TruSoLuongTonKho(ref string err, TonKhoO tk)
        {
            return conn.MyExecuteNonQuery("proTruSoLuongTonKho",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", tk.MaHangHoa),
                new SqlParameter("@MaKho", tk.MaKho),
                new SqlParameter("@SoLuong", tk.SoLuong)
                );
        }
    }
}
