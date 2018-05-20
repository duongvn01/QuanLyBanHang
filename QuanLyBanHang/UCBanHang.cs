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
    public partial class UCBanHang : UserControl
    {
        string ma = "";
        int themOrSua = 1;
        double tongTien;
        BanHangO BH;

        KhachHangO KH;
        HangHoaO HH;
        DonViO DV;
        ChiTietPhieuBanHangO CTPBH;
        TonKhoO TK;

        BanHangBUS banHangBUS;
        KhachHangBUS khachHangBUS;
        NhanVienBUS nhanVienBUS;
        KhoBUS khoBUS;
        HangHoaBUS hangHoaBUS;
        DonViBUS donViBUS;
        TonKhoBUS tonKhoBUS;

        KieuThanhToanBUS kieuThanhToanBUS;
        HinhThucThanhToanBUS hinhThucThanhToanBUS;

        ChiTietPhieuBanHangBUS chiTietPhieuBanHangBUS;

        DataTable dt;
        public UCBanHang()
        {
            InitializeComponent();
            initObjectBUS();
            initDataTable();
            themOrSua = 1;
            tongTien = 0;
        }
        public UCBanHang(int themOrSua)
        {
            InitializeComponent();
            initObjectBUS();
            initDataTable();
            this.themOrSua = themOrSua;
            tongTien = 0;

        }
        public void setThemOrSuaBang1()
        {
            this.themOrSua = 1;
        }
        public void textBoxChange(string input) //change the display of the textBox
        {
            ma = input;
            txtMaPhieuBan.Text = input;
        }
        void initObjectBUS()
        {

            BH = new BanHangO();
            KH = new KhachHangO();
            HH = new HangHoaO();
            DV = new DonViO();
            CTPBH = new ChiTietPhieuBanHangO();
            TK = new TonKhoO();
            banHangBUS = new BanHangBUS();

            khachHangBUS = new KhachHangBUS();
            nhanVienBUS = new NhanVienBUS();
            khoBUS = new KhoBUS();
            hangHoaBUS = new HangHoaBUS();
            donViBUS = new DonViBUS();
            tonKhoBUS = new TonKhoBUS();
            chiTietPhieuBanHangBUS = new ChiTietPhieuBanHangBUS();

            kieuThanhToanBUS = new KieuThanhToanBUS();
            hinhThucThanhToanBUS = new HinhThucThanhToanBUS();
        }
        void loadLookUpEdit()
        {
            //load lookupedit Khach Hang
            lueKhachHang.Properties.DataSource = khachHangBUS.getAllKhachHang();
            lueKhachHang.Properties.DisplayMember = "MaKhachHang";
            lueKhachHang.Properties.ValueMember = "MaKhachHang";


            //NhanVien
            lueNhanVien.Properties.DataSource = nhanVienBUS.getAllNhanVien();
            lueNhanVien.Properties.DisplayMember = "TenNhanVien";
            lueNhanVien.Properties.ValueMember = "MaNhanVien";

            //  kho
            lueKho.Properties.DataSource = khoBUS.getAllKhoBUS();
            lueKho.Properties.DisplayMember = "TenKho";
            lueKho.Properties.ValueMember = "MaKho";

            //Hang Hoa
            lueHangHoa.Properties.DataSource = hangHoaBUS.getAllHangHoa();
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.ValueMember = "MaHangHoa";


            //Kieu thanh toan
            lueKieuThanhToan.Properties.DataSource = kieuThanhToanBUS.getAllKieuThanhToan();
            lueKieuThanhToan.Properties.DisplayMember = "TenKieuThanhToan";
            lueKieuThanhToan.Properties.ValueMember = "MaKieuThanhToan";

            //Hinh Thuc Thanh Toan
            lueHinhThucThanhToan.Properties.DataSource = hinhThucThanhToanBUS.getAllHinhThucThanhToan();
            lueHinhThucThanhToan.Properties.DisplayMember = "TenHinhThuc";
            lueHinhThucThanhToan.Properties.ValueMember = "MaHinhThuc";
        }
        void initDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("MaHangHoa", typeof(string));
            dt.Columns.Add("TenHangHoa", typeof(string));
            dt.Columns.Add("MaDonVi", typeof(string));
            dt.Columns.Add("TenDonVi", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double));
        }
        void LayBanHangByMaPhieuBan(BanHangO bh)
        {
            BH = banHangBUS.getOneBanHangByMaPhieuBan(bh);
            //dua du lieu len textbox,lookupedit
            txtMaPhieuBan.Text = BH.MaPhieuBan;
            txtTenPhieu.Text = BH.TenPhieu;
            deNgayLapPhieu.EditValue = BH.NgayLapPhieu;
            lueKieuThanhToan.EditValue = BH.MaKieuTT;

            lueKhachHang.EditValue = KH.MaKhachHang;
            deThoiHanThanhToan.EditValue = BH.ThoiHanThanhToan;
            lueHinhThucThanhToan.EditValue = BH.MaHinhThucTT;

            lueNhanVien.EditValue = BH.MaNhanVien;
            lueKho.EditValue = BH.MaKho;
            txtGhiChu.Text = BH.GhiChu;

            txtTongTien.Text = BH.TongTien.ToString();
            txtPhanTramChuyenKhoan.Text = BH.PTramCK.ToString();
            txtPhanTramThue.Text = BH.Thue.ToString();
            txtTuongDuongTien.Text = BH.TuongDuongTien.ToString();
            txtTienThanhToan.Text = BH.TienThanhToan.ToString();
        }
        void LayChiTietPhieuBanHangByMaPhieu(BanHangO bh)
        {
            CTPBH.MaPhieuBan = bh.MaPhieuBan;
            gridControlBanHang.DataSource = chiTietPhieuBanHangBUS.GetAllChiTietPhieuBanHangByMaPhieuBanBUS(CTPBH);
        }

        private void UCBanHang_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();

            if (ma != "")
            {
                //MH.MaPhieu=maPhieuTruyen;
                BH.MaPhieuBan = ma;
                txtMaPhieuBan.Text = ma;
                LayBanHangByMaPhieuBan(BH);
                LayChiTietPhieuBanHangByMaPhieu(BH);
            }
        }

        private void lueKhachHang_EditValueChanged(object sender, EventArgs e)
        {

            KH.MaKhachHang = lueKhachHang.EditValue.ToString();
            KH = khachHangBUS.getOneKhachHang(KH);
            txtTenKhachHang.Text = KH.TenKhachHang;
            txtDiaChi.Text = KH.DiaChi;
            txtSoDienThoai.Text = KH.SoDienThoai;
        }

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (HH.GiaMua * (Convert.ToDouble(txtSoLuong.Text))).ToString();
        }

        private void txtDonGia_EditValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (HH.GiaMua * (Convert.ToDouble(txtSoLuong.Text))).ToString();
        }

        private void lueHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            HH.MaHangHoa = lueHangHoa.EditValue.ToString();
            HH = hangHoaBUS.getOneHangHoa(HH);
            DV.MaDonVi = HH.MaDonVi;
            DV = donViBUS.getOneDonVi(DV);//lay don vi tu ma don vi
            txtDonGia.Text = HH.GiaMua.ToString();
            txtThanhTien.Text = (HH.GiaMua * (Convert.ToDouble(txtSoLuong.Text))).ToString();
        }

        private void btnThemVaoGridview_Click(object sender, EventArgs e)
        {
            string maHangHoa = lueHangHoa.EditValue.ToString();
            if (dt != null)
            {
                if (KiemTraTrung(maHangHoa))
                {
                    bool f = ThemMaDaCoVaoDataTable(maHangHoa);
                }
                else
                {
                    bool f = ThemMoiVaoDatatable();
                }

            }

            gridControlBanHang.DataSource = dt;
            txtTongTien.Text = TinhTongTien().ToString();
        }
        double TinhTongTien()
        {
            double tong = 0;
            foreach (DataRow r in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {
                tong = tong + Convert.ToDouble(r[6]);
            }
            return tong;
        }

        private void btnRemoveKhoiGridview_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn không muốn mua mặt hàng này không?",
                "Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool f = RemoveKhoiDataTable(CTPBH.MaHangHoa);
            }
        }
        bool ThemMoiVaoDatatable()
        {
            try
            {
                DataRow row;
                row = dt.NewRow();
                row["MaHangHoa"] = HH.MaHangHoa;
                row["TenHangHoa"] = HH.TenHangHoa;
                row["MaDonVi"] = HH.MaDonVi;
                row["TenDonVi"] = DV.TenDonVi;
                row["SoLuong"] = txtSoLuong.Text;
                row["DonGia"] = txtDonGia.Text;
                row["ThanhTien"] = txtThanhTien.Text;
                dt.Rows.Add(row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool ThemMaDaCoVaoDataTable(string ma)
        {
            try
            {
                foreach (DataRow r in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
                {
                    if (ma == r[0].ToString())
                    {
                        int soluong = Convert.ToInt32(r[4]);
                        r[4] = Convert.ToInt32(txtSoLuong.Text) + soluong;

                        r[6] = Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(r[4]);
                        return true;
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        bool RemoveKhoiDataTable(string ma)
        {
            try
            {
                foreach (DataRow r in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
                {
                    if (ma == r[0].ToString())
                    {
                        dt.Rows.Remove(r);

                        return true;
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool KiemTraTrung(string ma)
        {
            if (dt != null)
            {
                DataRow r = dt.NewRow();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (ma == dt.Rows[i][0].ToString())
                    {
                        return true;
                    }
                }

            }
            return false;


        }

        private void gridViewBanHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            CTPBH.MaHangHoa = gridViewBanHang.GetFocusedRowCellValue(colMaHangHoa).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            //them mua hang            
            BH.MaPhieuBan = txtMaPhieuBan.Text;
            BH.TenPhieu = txtTenPhieu.Text;
            BH.NgayLapPhieu = Convert.ToDateTime(deNgayLapPhieu.Text);
          
            BH.MaKieuTT = lueKieuThanhToan.EditValue.ToString();
            BH.MaHinhThucTT = lueHinhThucThanhToan.EditValue.ToString();
            BH.MaKhachHang = lueKhachHang.EditValue.ToString();
            BH.ThoiHanThanhToan = Convert.ToDateTime(deThoiHanThanhToan.Text);
            BH.NgayGiaoHang = Convert.ToDateTime(deNgayGiaoHang.Text);
            BH.GhiChu = txtGhiChu.Text;
            BH.MaNhanVien = lueNhanVien.EditValue.ToString();
            BH.MaKho = lueKho.EditValue.ToString();
            BH.TongTien = Convert.ToDouble(txtTongTien.Text);
            BH.PTramCK = Convert.ToInt32(txtPhanTramChuyenKhoan.Text);
            BH.Thue = Convert.ToInt32(txtPhanTramThue.Text);
            BH.TuongDuongTien = Convert.ToDouble(txtTuongDuongTien.Text);
            BH.TienThanhToan = Convert.ToDouble(txtTienThanhToan.Text);

            {

                try
                {
                    bool f = banHangBUS.ThemBanHangBUS(ref err, BH);
                    int demTonKho = 0, demChiTietPMH = 0;
                    if (f == true)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            TK.MaHangHoa = r[0].ToString();
                            TK.MaKho = lueKho.EditValue.ToString();
                            TK.SoLuong = Convert.ToInt32(r[4]);
                            bool f1 = tonKhoBUS.XuatTonKhoBUS(ref err, TK);

                            CTPBH.MaChiTietPhieuBan = "1";
                            CTPBH.MaPhieuBan = txtMaPhieuBan.Text;
                            CTPBH.MaHangHoa = r[0].ToString();
                            CTPBH.SoLuong = Convert.ToInt32(r[4]);
                            CTPBH.DonGia = Convert.ToInt32(r[5]);
                            CTPBH.ThanhTien = Convert.ToInt32(r[6]);
                            bool f2 = chiTietPhieuBanHangBUS.ThemChiTietPhieuBanHangBUS(ref err, CTPBH);
                            if (f1 == true)
                            {
                                demTonKho++;
                            }
                            if (f2 == true)
                            {
                                demChiTietPMH++;
                            }
                        }
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc, Loi: " + err);
                    }
                    if (demTonKho == dt.Rows.Count)
                    {
                        MessageBox.Show("Them thanh cong Ton kho: " + demTonKho);
                    }
                    if (demChiTietPMH == dt.Rows.Count)
                    {
                        MessageBox.Show("Them thanh cong Chi tiet phieu mua hang: " + demChiTietPMH);
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc, so luong them: " + demChiTietPMH);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi: " + err);
                }

            }
        }

        private void txtPhanTramThue_EditValueChanged(object sender, EventArgs e)
        {
            int thue = Convert.ToInt32(txtPhanTramThue.Text);
            tongTien = Convert.ToDouble(txtTongTien.Text);
            double tienThueTuongDuong = (tongTien / 100) * thue;
            txtTuongDuongTien.Text = tienThueTuongDuong.ToString();

            double tienChuyenKhoan = Convert.ToDouble(txtPhanTramChuyenKhoan.Text) * tongTien / 100;
            txtTienThanhToan.Text = (tongTien - tienChuyenKhoan + tienThueTuongDuong).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormHangHoa hh = new FormHangHoa();
            hh.Show();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.Show();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            FormKhoHang kh = new FormKhoHang();
            kh.Show();
        }

        private void txtMaPhieuBan_EditValueChanged(object sender, EventArgs e)
        {
            if (ma != "")
            {
                BH.MaPhieuBan = ma;
                txtMaPhieuBan.Text = ma;
                LayBanHangByMaPhieuBan(BH);
                LayChiTietPhieuBanHangByMaPhieu(BH);
            }
        }
    }
}
