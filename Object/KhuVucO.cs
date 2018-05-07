using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class KhuVucO
    {
        public KhuVucO()
        {

        }
        private String maKhuVuc;
        private String tenKhuVuc;
        private String ghiChu;
        private bool conQuanLy;
        public String MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }
        

        public String TenKhuVuc
        {
            get { return tenKhuVuc; }
            set { tenKhuVuc = value; }
        }
        
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        

        public bool ConQuanLy
        {
            get { return conQuanLy; }
            set { conQuanLy = value; }
        }
        
    }
}
