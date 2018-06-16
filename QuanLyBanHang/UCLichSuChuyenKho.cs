using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bussiness_Logic_Layer;
using Object;


namespace QuanLyBanHang
{
    public partial class UCLichSuChuyenKho : UserControl
    {
        UCChuyenKho ucck;
        ChuyenKhoO CK;
        ChiTietChuyenKhoO CTCK;
        TonKhoO TK;

        ChuyenKhoBUS chuyenKhoBUS;
        ChiTietChuyenKhoBUS chiTietChuyenKhoBUS;
        TonKhoBUS tonKhoBUS;
        public UCLichSuChuyenKho()
        {
            InitializeComponent();
            ucck = new UCChuyenKho();
            CK = new ChuyenKhoO();
            CTCK = new ChiTietChuyenKhoO();
            TK = new TonKhoO();

            chuyenKhoBUS = new ChuyenKhoBUS();
            chiTietChuyenKhoBUS = new ChiTietChuyenKhoBUS();
            tonKhoBUS = new TonKhoBUS();
        }
        void loadData()
        {
            gridControlLichSuChuyenKho.DataSource = chuyenKhoBUS.getAllChuyenKho();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDatDau = Convert.ToDateTime(deNgayBatDau.Text);
            DateTime ngayKetThuc = Convert.ToDateTime(deNgayKetThuc.Text);
            gridControlLichSuChuyenKho.DataSource =chuyenKhoBUS.getAllChuyenKhoByNgayNayNgayKiaBUS(ngayDatDau, ngayKetThuc);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ucck.TruyenChuyenKho_MaPhieuChuyen(CK);
            ucck.SetThemOrSua(0);
            Control ctrPanel1 = btnSua.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(ucck);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?",
                "Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string err = "";
                try
                {
                    bool f = chuyenKhoBUS.XoaChuyenKhoBUS(ref err, CK);
                    bool f1 = false;
                    if (f == true)
                    {
                        DataTable dtChiTietCK = new DataTable();
                        dtChiTietCK = chiTietChuyenKhoBUS.GetAllChiTietChuyenKhoByMaPhieuChuyenBUS(CTCK);
                        f1 = chiTietChuyenKhoBUS.XoaChiTietChuyenKhoByMaPhieuChuyenBUS(ref err, CTCK);
                        MessageBox.Show("Xoa thanh cong chuyen kho");
                        if (f1 == true)
                        {
                            foreach (DataRow r in dtChiTietCK.Rows)
                            {
                                TK.MaHangHoa = r[2].ToString();
                                TK.MaKho = CK.MaKhoChuyen;
                                TK.SoLuong = Convert.ToInt32(r[3]);
                                bool f2 = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);
                                if (f2 == true)
                                {
                                    MessageBox.Show("Cong thanh cong kho:" + TK.MaKho + ",MaHangHoa:" + TK.MaHangHoa + ", So luong:" + TK.SoLuong);
                                }
                                TK.MaKho = CK.MaKhoNhan;
                                bool f3 = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                                if (f3 == true)
                                {
                                    MessageBox.Show("Tru thanh cong kho:" + TK.MaKho + ",MaHangHoa:" + TK.MaHangHoa + ", So luong:" + TK.SoLuong);
                                }
                            }

                            MessageBox.Show("Xoa thanh cong chitietmuahang, ma phieu:" + CTCK.MaPhieuChuyen);
                        }
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc chuyenkho. Loi: " + err);
                    }                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong Xoa duoc. Loi: " + err);
                }
            }           
        }

        private void UCLichSuChuyenKho_Load(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
