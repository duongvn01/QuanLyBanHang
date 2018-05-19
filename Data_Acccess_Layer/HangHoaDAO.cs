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
    public class HangHoaDAO
    {
        private DBConnection conn;
        
        public HangHoaDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllHangHoa()
        {
            return conn.executeGetTable("proGetAllHangHoa_NhomHang_DonVi_Kho_NhaCungCap");
        }

        public bool ThemHangHoa(ref string err, HangHoaO hh)
        {
            return conn.MyExecuteNonQuery("proThemHangHoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", hh.MaHangHoa),
                new SqlParameter("@TenHangHoa", hh.TenHangHoa),
                new SqlParameter("@MaKho", hh.MaKho),
                new SqlParameter("@MaNhomHang", hh.MaNhomHang),
                
                new SqlParameter("@MaVachNSX", hh.MaVachNSX),
                new SqlParameter("@MaDonVi", hh.MaDonVi),
                new SqlParameter("@XuatXu", hh.XuatXu),
                new SqlParameter("@Thue", hh.Thue),
                new SqlParameter("@TonKhoToiThieu", hh.TonKhoToiThieu),
                new SqlParameter("@TonHienTai", hh.TonHienTai),
                new SqlParameter("@MaNhaCungCap", hh.MaNhaCungCap),
                new SqlParameter("@GiaMua", hh.GiaMua),
                new SqlParameter("@GiaBanSi", hh.GiaBanSi),
                new SqlParameter("@GiaBanLe", hh.GiaBanLe),
                new SqlParameter("@HangHoaOrDichVu", hh.HangHoaOrDichVu),
                new SqlParameter("@ConQuanLy", hh.ConQuanLy)
                );
        }
        public bool XoaHangHoa(ref string err, HangHoaO hh)
        {
            return conn.MyExecuteNonQuery("proXoaHangHoa",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaHangHoa", hh.MaHangHoa));
        }
        public bool CapNhatHangHoa(ref string err, HangHoaO hh)
        {
            return conn.MyExecuteNonQuery("proSuaHangHoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHangHoa", hh.MaHangHoa),
                new SqlParameter("@TenHangHoa", hh.TenHangHoa),
                new SqlParameter("@MaKho", hh.MaKho),
                new SqlParameter("@MaNhomHang", hh.MaNhomHang),

                new SqlParameter("@MaVachNSX", hh.MaVachNSX),
                new SqlParameter("@MaDonVi", hh.MaDonVi),
                new SqlParameter("@XuatXu", hh.XuatXu),
                new SqlParameter("@Thue", hh.Thue),
                new SqlParameter("@TonKhoToiThieu", hh.TonKhoToiThieu),
                new SqlParameter("@TonHienTai", hh.TonHienTai),
                new SqlParameter("@MaNhaCungCap", hh.MaNhaCungCap),
                new SqlParameter("@GiaMua", hh.GiaMua),
                new SqlParameter("@GiaBanSi", hh.GiaBanSi),
                new SqlParameter("@GiaBanLe", hh.GiaBanLe),
                new SqlParameter("@HangHoaOrDichVu", hh.HangHoaOrDichVu),
                new SqlParameter("@ConQuanLy", hh.ConQuanLy)     
                );
        }
    }
}
