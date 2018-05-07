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
        public HangHoaBUS()
        {
            hangHoaDAO = new HangHoaDAO();
        }
        public DataTable getAllHangHoa()
        {
            return hangHoaDAO.GetAllHangHoa();
          
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
