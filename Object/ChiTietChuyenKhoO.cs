using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class ChiTietChuyenKhoO
    {
        String maChiTietPhieuChuyen;

        public String MaChiTietPhieuChuyen
        {
            get { return maChiTietPhieuChuyen; }
            set { maChiTietPhieuChuyen = value; }
        }
        String maPhieuChuyen;

        public String MaPhieuChuyen
        {
            get { return maPhieuChuyen; }
            set { maPhieuChuyen = value; }
        }
        String maHangHoa;

        public String MaHangHoa
        {
            get { return maHangHoa; }
            set { maHangHoa = value; }
        }
        int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        double thanhTien;

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
