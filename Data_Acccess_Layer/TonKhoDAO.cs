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
            return conn.executeSelectQuery("proGetTonKho_Kho_HangHoa_DonVi_NhomHang_IfMaKho",new SqlParameter("@MaKho", tk.MaKho),
                new SqlParameter("@SoLuong", tk.SoLuong)
                );
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
    }
}
