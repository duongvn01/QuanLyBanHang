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
    public class HangHoaBUS
    {
        HangHoaDAO hangHoaDAO;
        HangHoaO HH;
        public HangHoaBUS()
        {
            hangHoaDAO = new HangHoaDAO();
            HH = new HangHoaO();
        }
        public DataTable getAllHangHoa()
        {
            return hangHoaDAO.GetAllHangHoa();        
        }
        public HangHoaO getOneHangHoa(HangHoaO hh)
        {
            DataTable dt = new DataTable();
            dt = hangHoaDAO.GetAllHangHoa();
            DataRow[] result = dt.Select("MaHangHoa= '" + hh.MaHangHoa + "'");
            DataRow row = result[0];
            HH.MaHangHoa = row["MaHangHoa"].ToString();
            HH.TenHangHoa = row["TenHangHoa"].ToString();
            HH.MaDonVi = row["MaDonVi"].ToString();
            HH.GiaMua = Convert.ToDouble(row["GiaMua"].ToString());
            HH.GiaBanSi = Convert.ToDouble(row["GiaBanSi"].ToString());
            HH.GiaBanLe = Convert.ToDouble(row["GiaBanLe"].ToString());
            return HH;
        }
        public bool ThemHangHoaBUS(ref string err, HangHoaO hh)
        {
            return hangHoaDAO.ThemHangHoa(ref err, hh);
        }
        public bool CapNhatHangHoaBUS(ref string err, HangHoaO hh)
        {
            return hangHoaDAO.CapNhatHangHoa(ref err, hh);
        }
        public bool XoaHangHoaBUS(ref string err, HangHoaO hh)
        {
            return hangHoaDAO.XoaHangHoa(ref err, hh);
        }
    }
}
