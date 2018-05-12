using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Acccess_Layer
{
    public class KieuThanhToanDAO
    {
        private DBConnection conn;

        public KieuThanhToanDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllKieuThanhToan()
        {
            string query = string.Format("select * from KieuThanhToan");
           
            return conn.executeSelectQueryNoParam(query);
        }

    }
}
