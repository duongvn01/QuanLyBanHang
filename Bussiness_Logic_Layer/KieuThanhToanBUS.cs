using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Acccess_Layer;


namespace Bussiness_Logic_Layer
{
    public class KieuThanhToanBUS
    {
        KieuThanhToanDAO kieuThanhToanDAO;
        public KieuThanhToanBUS()
        {
            kieuThanhToanDAO = new KieuThanhToanDAO();
        }
        public DataTable getAllKieuThanhToan()
        {
            return kieuThanhToanDAO.GetAllKieuThanhToan();
        }
    }
}
