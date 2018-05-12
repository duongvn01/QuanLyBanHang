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
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO;
        NhaCungCapO NCC;
        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
            NCC = new NhaCungCapO();
        }
        public DataTable getAllNhaCungCap()
        {
            return nhaCungCapDAO.GetAllNhaCungCap();
          
        }
        public NhaCungCapO getOneNhaCungCap(NhaCungCapO ncc)
        {
            DataTable dt = new DataTable();
            dt = nhaCungCapDAO.GetAllNhaCungCap();
            DataRow[] result = dt.Select("MaNhaCungCap= '"+ncc.MaNhaCungCap+"'");
            DataRow row = result[0];
            NCC.MaNhaCungCap = row["MaNhaCungCap"].ToString();
            NCC.TenNhaCungCap = row["TenNhaCungCap"].ToString();
            NCC.SoDienThoai = row["SoDienThoai"].ToString();
            NCC.DiaChi = row["DiaChi"].ToString();
            return NCC;
        }
        public bool ThemNhaCungCapBUS(ref string err, NhaCungCapO ncc)
        {
            return nhaCungCapDAO.ThemNhaCungCap(ref err, ncc);
        }
        public bool CapNhatNhaCungCapBUS(ref string err, NhaCungCapO ncc)
        {
            return nhaCungCapDAO.CapNhatNhaCungCap(ref err, ncc);
        }
        public bool XoaNhaCungCapBUS(ref string err, NhaCungCapO ncc)
        {
            return nhaCungCapDAO.XoaNhaCungCap(ref err, ncc);
        }
    }
}
