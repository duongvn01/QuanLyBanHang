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
            tongTien = 0;
        }
        public void SetThemOrSua(int a)
        {
            this.themOrSua = a;
        }
        public void TruyenBanHang_MaPhieuBan(BanHangO bh)
        {
            this.BH = bh;
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
            dt.Columns.Add("MaChiTietPhieuBan", typeof(string));
            dt.Columns.Add("MaPhieuBan", typeof(string));
            dt.Columns.Add("MaHangHoa", typeof(string));        
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double)); 
            dt.Columns.Add("MaDonVi", typeof(string));
            dt.Columns.Add("TenHangHoa", typeof(string));
            dt.Columns.Add("TenDonVi", typeof(string));
        }
        void LayBanHangByMaPhieuBan(BanHangO bh)
        {
            BH = banHangBUS.getOneBanHangByMaPhieuBan(bh);
            //dua du lieu len textbox,lookupedit
            txtMaPhieuBan.Text = BH.MaPhieuBan;
            txtTenPhieu.Text = BH.TenPhieu;
            deNgayLapPhieu.EditValue = BH.NgayLapPhieu;
            lueKieuThanhToan.EditValue = BH.MaKieuTT;

            lueKhachHang.EditValue = BH.MaKhachHang;
            deThoiHanThanhToan.EditValue = BH.ThoiHanThanhToan;
            lueHinhThucThanhToan.EditValue = BH.MaHinhThucTT;
            deNgayGiaoHang.EditValue = BH.NgayGiaoHang;

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
            dt = chiTietPhieuBanHangBUS.GetAllChiTietPhieuBanHangByMaPhieuBanBUS(CTPBH);
            gridControlBanHang.DataSource = dt;
            
        }
        private void UCBanHang_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
            if (themOrSua == 0)
            {
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
                tong = tong + Convert.ToDouble(r[4]);
            }
            return tong;
        }
        private void btnRemoveKhoiGridview_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn không muốn mua mặt hàng này?",
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
                row["MaChiTietPhieuBan"] = "1";
                row["MaPhieuBan"] = txtMaPhieuBan.Text;
                row["MaHangHoa"] = HH.MaHangHoa;        
                row["SoLuong"] = txtSoLuong.Text;
                row["DonGia"] = txtDonGia.Text;
                row["ThanhTien"] = txtThanhTien.Text;
                row["MaDonVi"] = HH.MaDonVi;
                row["TenHangHoa"] = HH.TenHangHoa;
                row["TenDonVi"] = DV.TenDonVi;
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
                    if (ma == r[2].ToString())
                    {
                        int soluong = Convert.ToInt32(r[3]);
                        r[3] = Convert.ToInt32(txtSoLuong.Text) + soluong;
                        r[4] = Convert.ToDouble(txtDonGia.Text);
                        r[5] = Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(r[3]);
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
                    if (ma == r[2].ToString())
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
                    if (ma == dt.Rows[i][2].ToString())
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
            BH.NgayLapPhieu = Convert.ToDateTime(deNgayLapPhieu.EditValue);

            BH.MaKieuTT = lueKieuThanhToan.EditValue.ToString();
            BH.MaHinhThucTT = lueHinhThucThanhToan.EditValue.ToString();
            BH.MaKhachHang = lueKhachHang.EditValue.ToString();
            BH.ThoiHanThanhToan = Convert.ToDateTime(deThoiHanThanhToan.EditValue);
            BH.NgayGiaoHang = Convert.ToDateTime(deNgayGiaoHang.EditValue);
            BH.GhiChu = txtGhiChu.Text;
            BH.MaNhanVien = lueNhanVien.EditValue.ToString();
            BH.MaKho = lueKho.EditValue.ToString();
            BH.TongTien = Convert.ToDouble(txtTongTien.Text);
            BH.PTramCK = Convert.ToInt32(txtPhanTramChuyenKhoan.Text);
            BH.Thue = Convert.ToInt32(txtPhanTramThue.Text);
            BH.TuongDuongTien = Convert.ToDouble(txtTuongDuongTien.Text);
            BH.TienThanhToan = Convert.ToDouble(txtTienThanhToan.Text);
            if (txtMaPhieuBan.Text == "" || txtTenPhieu.Text == "" || BH.NgayLapPhieu == Convert.ToDateTime("1/1/0001 12:00:00 AM")
                || BH.NgayGiaoHang==Convert.ToDateTime("1/1/0001 12:00:00 AM") || BH.ThoiHanThanhToan == Convert.ToDateTime("1/1/0001 12:00:00 AM")
                || BH.MaHinhThucTT == "" || BH.MaKieuTT == "" || BH.MaKhachHang == "" || BH.MaNhanVien == "" || BH.MaKho == "" || BH.TongTien == 0 || BH.TienThanhToan == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                if (themOrSua == 1)
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
                else
                {

                    try
                    {
                        bool f = banHangBUS.CapNhatBanHangBUS(ref err, BH);
                        if (f == true)
                        {
                            DataTable dtDBCu = chiTietPhieuBanHangBUS.GetAllChiTietPhieuBanHangByMaPhieuBanBUS(CTPBH);
                            DataTable dtDBMoi = dt;
                            // chay theo dtDBCu
                            SuaChiTietPhieuMuaHang_TonKho_dtDBCu(dtDBMoi, dtDBCu);
                            //ThemChiTietPhieuMuaHang_TonKho_dtDBCu(dtDBMoi,dtDBCu);
                            XoaChiTietPhieuMuaHang_TonKho_dtDBMoi(dtDBMoi, dtDBCu);
                        }

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi: " + err);
                    }
                }
            }
        }
        bool KiemTraMaHangHoaTonTaiTrongDB(DataTable dtcu, string ma)
        {
            foreach (DataRow rCu in dtcu.Rows)
            {
                if (ma == rCu[2].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        void SuaChiTietPhieuMuaHang_TonKho_dtDBCu(DataTable dtmoi, DataTable dtcu)
        {
            string err = "";
            foreach (DataRow rMoi in dtmoi.Rows)
            {
                if (KiemTraMaHangHoaTonTaiTrongDB(dtcu, rMoi[2].ToString()))
                {
                    foreach (DataRow rCu in dtcu.Rows)
                    {
                        if (rCu[2].Equals(rMoi[2]))
                        {
                            //cap nhat tonkho
                            TK.MaHangHoa = rCu[2].ToString();
                            TK.MaKho = lueKho.EditValue.ToString();
                            TK.SoLuong = Convert.ToInt32(rCu[3]);
                            int soLuongMoi = Convert.ToInt32(rMoi[3]);
                            if (soLuongMoi != TK.SoLuong)
                            {
                                if (soLuongMoi > TK.SoLuong)
                                {
                                    TK.SoLuong = soLuongMoi - TK.SoLuong;
                                    bool f = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                                    
                                    if (f == true)
                                    {
                                        MessageBox.Show("Cong thanh cong");
                                    }
                                }
                                else
                                {
                                    TK.SoLuong = TK.SoLuong - soLuongMoi;
                                    bool f = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);
                                    if (f == true)
                                    {
                                        MessageBox.Show("Tru thanh cong");
                                    }
                                }
                            }


                            // cap nhat chi tiet phieu ban
                            CTPBH.MaChiTietPhieuBan = "1";
                            CTPBH.MaPhieuBan = txtMaPhieuBan.Text;
                            CTPBH.MaHangHoa = rMoi[2].ToString();
                            CTPBH.SoLuong = Convert.ToInt32(rMoi[3]);
                            CTPBH.DonGia = Convert.ToInt32(rMoi[4]);
                            CTPBH.ThanhTien = Convert.ToInt32(rMoi[5]);
                            bool f1 = chiTietPhieuBanHangBUS.CapNhatChiTietPhieuBanHangBUS(ref err, CTPBH);
                        }
                    }

                }
                else
                {
                    //xuat ton kho
                    TK.MaHangHoa = rMoi[2].ToString();
                    TK.MaKho = lueKho.EditValue.ToString();
                    TK.SoLuong = Convert.ToInt32(rMoi[3]);
                    //bool f = tonKhoBUS.ThemTonKhoBUS(ref err, TK);
                    bool f = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                    if (f == true)
                    {
                        MessageBox.Show("Tru thanh cong ton kho, MaHangHoa: " +
                            TK.MaHangHoa + " makho:" + TK.MaKho + "So luong " + TK.SoLuong);
                    }

                    // them chi tiet phieu ban
                    CTPBH.MaChiTietPhieuBan = "1";
                    CTPBH.MaPhieuBan = txtMaPhieuBan.Text;
                    CTPBH.MaHangHoa = rMoi[2].ToString();
                    CTPBH.SoLuong = Convert.ToInt32(rMoi[3]);
                    CTPBH.DonGia = Convert.ToInt32(rMoi[4]);
                    CTPBH.ThanhTien = Convert.ToInt32(rMoi[5]);
                    bool f1 = chiTietPhieuBanHangBUS.ThemChiTietPhieuBanHangBUS(ref err, CTPBH);
                }
            }
        }
        void XoaChiTietPhieuMuaHang_TonKho_dtDBMoi(DataTable dtmoi, DataTable dtcu)
        {
            string err = "";
            foreach (DataRow rCu in dtcu.Rows)
            {
                if (KiemTraMaHangHoaTonTaiTrongDB(dtmoi, rCu[2].ToString()) == false)//ko ton tai trong dbmoi
                {
                    //cap nhat tonkho
                    TK.MaHangHoa = rCu[2].ToString();
                    TK.MaKho = lueKho.EditValue.ToString();
                    TK.SoLuong = Convert.ToInt32(rCu[3]);
                    bool f = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);
                    if (f == true)
                    {
                        MessageBox.Show("Them ton kho thanh cong, Ma Hang Hoa:" + TK.MaHangHoa + ", Kho:" + TK.MaKho
                            + ", so luong:" + TK.SoLuong);
                    }
                    // xoa chi tiet phieu
                    CTPBH.MaChiTietPhieuBan = "1";
                    CTPBH.MaPhieuBan = txtMaPhieuBan.Text;
                    CTPBH.MaHangHoa = rCu[2].ToString();
                    CTPBH.SoLuong = Convert.ToInt32(rCu[3]);
                    CTPBH.DonGia = Convert.ToInt32(rCu[4]);
                    CTPBH.ThanhTien = Convert.ToInt32(rCu[5]);
                    bool f1 = chiTietPhieuBanHangBUS.XoaChiTietPhieuBanHangByMaPhieuBanMaHangHoaBUS(ref err, CTPBH);
                    if (f1 == true)
                    {
                        MessageBox.Show("xoa thanh cong chi tietphieumuahang, MaPhieuBan: " + CTPBH.MaPhieuBan + ", MahangHoa:" + CTPBH.MaHangHoa);
                    }
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
            /*
            LayBanHangByMaPhieuBan(BH);
            LayChiTietPhieuBanHangByMaPhieu(BH);
            */
        }
        private void btnLichSu_Click(object sender, EventArgs e)
        {
            UCLichSuBanHang uclsbh = new UCLichSuBanHang();
            Control ctrPanel1 = btnLichSu.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(uclsbh);
        }
    }
}
