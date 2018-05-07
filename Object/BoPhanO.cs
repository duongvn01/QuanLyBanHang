using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class BoPhanO
    {
        public BoPhanO()
        {

        }
        String maBoPhan;

        public String MaBoPhan
        {
            get { return maBoPhan; }
            set { maBoPhan = value; }
        }
        String tenBoPhan;

        public String TenBoPhan
        {
            get { return tenBoPhan; }
            set { tenBoPhan = value; }
        }
        String ghiChu;

        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        bool conQuanLy;

        public bool ConQuanLy
        {
            get { return conQuanLy; }
            set { conQuanLy = value; }
        }
    }
}
