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
    public class KhuVucBUS
    {
        KhuVucDAO khuVucDAO;
        public KhuVucBUS()
        {
            khuVucDAO = new KhuVucDAO();
        }
        public DataTable getAllKhuVuc()
        {
            return khuVucDAO.GetAllKhuVuc();
          
        }
        public bool ThemKhuVucBUS(ref string err,KhuVucO kv)
        {
            return khuVucDAO.ThemKhuVuc(ref err, kv);
        }
        public bool CapNhatKhuVucBUS(ref string err,KhuVucO kv)
        {
            return khuVucDAO.CapNhatKhuVuc(ref err, kv);
        }
        public bool XoaKhuVucBUS(ref string err,KhuVucO kv)
        {
            return khuVucDAO.XoaKhuVuc(ref err, kv);
        }

        public string SinhMaKhuVuc(ref string err,KhuVucO kv){
            
            return "";
        }
    }
}
