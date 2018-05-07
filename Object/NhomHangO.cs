using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class NhomHangO
    {
        public NhomHangO()
        {

        }
        String maNhomHang;

        public String MaNhomHang
        {
            get { return maNhomHang; }
            set { maNhomHang = value; }
        }
        String tenNhomHang;

        public String TenNhomHang
        {
            get { return tenNhomHang; }
            set { tenNhomHang = value; }
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
