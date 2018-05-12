using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Acccess_Layer;

namespace Bussiness_Logic_Layer
{
    public class HinhThucThanhToanBUS
    {
        DonViDAO donViDAO;
        HinhThucThanhToanDAO hinhThucThanhToanDAO;
        public HinhThucThanhToanBUS()
        {
            hinhThucThanhToanDAO = new HinhThucThanhToanDAO();
        }
        public DataTable getAllHinhThucThanhToan()
        {
            return hinhThucThanhToanDAO.GetAllHinhThucThanhToan();
        }
    }
}
