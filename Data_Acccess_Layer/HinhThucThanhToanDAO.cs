using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Acccess_Layer
{
    public class HinhThucThanhToanDAO
    {
        private DBConnection conn;

        public HinhThucThanhToanDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllHinhThucThanhToan()
        {
            string query = string.Format("select * from HinhThucThanhToan");
           
            return conn.executeSelectQueryNoParam(query);
        }
    }
}
