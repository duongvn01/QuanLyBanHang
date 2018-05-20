using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Acccess_Layer;
using Object;

namespace Bussiness_Logic_Layer
{
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO;
        KhachHangO KH;
        public KhachHangBUS()
        {
            khachHangDAO = new KhachHangDAO();
            KH = new KhachHangO();
        }
        public DataTable getAllKhachHang()
        {
            return khachHangDAO.GetAllKhachHang();
          
        }
        public KhachHangO getOneKhachHang(KhachHangO kh)
        {
            DataTable dt = new DataTable();
            dt = khachHangDAO.GetAllKhachHang();
            DataRow[] result = dt.Select("MaKhachHang= '" + kh.MaKhachHang + "'");
            DataRow row = result[0];
            KH.MaKhachHang = row["MaKhachHang"].ToString();
            KH.TenKhachHang = row["TenKhachHang"].ToString();
            KH.SoDienThoai = row["SoDienThoai"].ToString();
            KH.DiaChi = row["DiaChi"].ToString();

            return KH;
        }
        public bool ThemKhachHangBUS(ref string err,KhachHangO kh)
        {
            return khachHangDAO.ThemKhachHang(ref err, kh);
        }
        public bool CapNhatKhachHangBUS(ref string err, KhachHangO kh)
        {
            return khachHangDAO.CapNhatKhachHang(ref err, kh);
        }
        public bool XoaKhachHangBUS(ref string err, KhachHangO kh)
        {
            return khachHangDAO.XoaKhachHang(ref err, kh);
        }
    }
}
