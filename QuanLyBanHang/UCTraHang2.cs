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
    public partial class UCTraHang2 : UserControl
    {
        int themOrSua = 1;
        double tongTien;
        TraHangO TH;

        KhachHangO KH;
        HangHoaO HH;
        DonViO DV;
        ChiTietTraHangO CTTH;
        TonKhoO TK;

        TraHangBUS traHangBUS;
        KhachHangBUS khachHangBUS;
        NhanVienBUS nhanVienBUS;
        KhoBUS khoBUS;
        HangHoaBUS hangHoaBUS;
        DonViBUS donViBUS;
        TonKhoBUS tonKhoBUS;

        KieuThanhToanBUS kieuThanhToanBUS;
        HinhThucThanhToanBUS hinhThucThanhToanBUS;

        ChiTietPhieuTraHangBUS chiTietPhieuTraHangBUS;

        DataTable dt;
        public UCTraHang2()
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
        public void TruyenTraHang_MaPhieuTra(TraHangO bh)
        {
            this.TH = bh;
        }
        void initObjectBUS()
        {

            TH = new TraHangO();
            KH = new KhachHangO();
            HH = new HangHoaO();
            DV = new DonViO();
            CTTH = new ChiTietTraHangO();
            TK = new TonKhoO();
            traHangBUS = new TraHangBUS();

            khachHangBUS = new KhachHangBUS();
            nhanVienBUS = new NhanVienBUS();
            khoBUS = new KhoBUS();
            hangHoaBUS = new HangHoaBUS();
            donViBUS = new DonViBUS();
            tonKhoBUS = new TonKhoBUS();
            chiTietPhieuTraHangBUS = new ChiTietPhieuTraHangBUS();

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

        }
        void initDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("MaChiTietPhieuTra", typeof(string));
            dt.Columns.Add("MaPhieuTra", typeof(string));
            dt.Columns.Add("MaHangHoa", typeof(string));        
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double)); 
            dt.Columns.Add("MaDonVi", typeof(string));
            dt.Columns.Add("TenHangHoa", typeof(string));
            dt.Columns.Add("TenDonVi", typeof(string));
        }
        void LayTraHangByMaPhieuTra(TraHangO bh)
        {
            TH = traHangBUS.getOneTraHangByMaPhieuTra(bh);
            //dua du lieu len textbox,lookupedit
            lueKhachHang.EditValue = TH.MaKhachHang;
            txtTenKhachHang.Text = KH.TenKhachHang;
            deNgayLapPhieu.EditValue = TH.NgayLapPhieu;
            txtGhiChu.Text = TH.GhiChu;

            txtMaPhieuTra.Text = TH.MaPhieuTra;
            txtDiaChi.Text = KH.DiaChi;
            txtSoDienThoai.Text = KH.SoDienThoai;

            lueNhanVien.EditValue = TH.MaNhanVien;
            lueKho.EditValue = TH.MaKho;
            
            txtTongTien.Text = TH.TongTien.ToString();
            txtPhanTramChuyenKhoan.Text = TH.PTramCK.ToString();
            txtPhanTramThue.Text = TH.Thue.ToString();
            txtTuongDuongTien.Text = TH.TuongDuongTien.ToString();
            txtTienThanhToan.Text = TH.TienThanhToan.ToString();
        }
        void LayChiTietPhieuTraHangByMaPhieuTra(TraHangO bh)
        {
            CTTH.MaPhieuTra = bh.MaPhieuTra;
            dt = chiTietPhieuTraHangBUS.GetAllChiTietPhieuTraHangByMaPhieuTraBUS(CTTH);
            gridControlTraHang.DataSource = dt;
            
        }

        private void UCTraHang2_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
            if (themOrSua == 0)
            {
                LayTraHangByMaPhieuTra(TH);
                LayChiTietPhieuTraHangByMaPhieuTra(TH);
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
            gridControlTraHang.DataSource = dt;
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
        bool ThemMoiVaoDatatable()
        {
            try
            {
                DataRow row;
                row = dt.NewRow();
                row["MaChiTietPhieuTra"] = "1";
                row["MaPhieuTra"] = txtMaPhieuTra.Text;
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

        private void btnRemoveKhoiGridview_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn không muốn mua mặt hàng này?",
                "Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool f = RemoveKhoiDataTable(CTTH.MaHangHoa);
            }
        }

        private void gridViewTraHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            CTTH.MaHangHoa = gridViewTraHang.GetFocusedRowCellValue(colMaHangHoa).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            //them tra hang
            TH.MaKhachHang = lueKhachHang.EditValue.ToString();
            TH.MaPhieuTra = txtMaPhieuTra.Text;
            TH.NgayLapPhieu = Convert.ToDateTime(deNgayLapPhieu.EditValue);
            TH.GhiChu = txtGhiChu.Text;


            TH.MaNhanVien = lueNhanVien.EditValue.ToString();
            TH.MaKho = lueKho.EditValue.ToString();

            TH.TongTien = Convert.ToDouble(txtTongTien.EditValue);
            TH.PTramCK = Convert.ToInt32(txtPhanTramChuyenKhoan.EditValue);
            TH.Thue = Convert.ToInt32(txtPhanTramThue.EditValue);
            TH.TuongDuongTien = Convert.ToDouble(txtTuongDuongTien.EditValue);
            TH.TienThanhToan = Convert.ToDouble(txtTienThanhToan.EditValue);
            if (txtMaPhieuTra.Text == "" || TH.NgayLapPhieu == Convert.ToDateTime("1/1/0001 12:00:00 AM")
                || TH.MaKhachHang == "" || TH.MaNhanVien == "" || TH.MaKho == "" || TH.TongTien == 0 || TH.TienThanhToan == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                if (themOrSua == 1)
                {

                    try
                    {
                        bool f = traHangBUS.ThemTraHangBUS(ref err, TH);
                        int demTonKho = 0, demChiTietPTH = 0;
                        if (f == true)
                        {
                            foreach (DataRow r in dt.Rows)
                            {
                                TK.MaHangHoa = r[2].ToString();
                                TK.MaKho = lueKho.EditValue.ToString();
                                TK.SoLuong = Convert.ToInt32(r[3]);
                                bool f1 = tonKhoBUS.ThemTonKhoBUS(ref err, TK);

                                CTTH.MaChiTietPhieuTra = "1";
                                CTTH.MaPhieuTra = txtMaPhieuTra.Text;
                                CTTH.MaHangHoa = r[2].ToString();
                                CTTH.SoLuong = Convert.ToInt32(r[3]);
                                CTTH.DonGia = Convert.ToInt32(r[4]);
                                CTTH.ThanhTien = Convert.ToInt32(r[5]);
                                bool f2 = chiTietPhieuTraHangBUS.ThemChiTietPhieuTraHangBUS(ref err, CTTH);
                                if (f1 == true)
                                {
                                    demTonKho++;
                                }
                                if (f2 == true)
                                {
                                    demChiTietPTH++;
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
                        if (demChiTietPTH == dt.Rows.Count)
                        {
                            MessageBox.Show("Them thanh cong Chi tiet phieu tra hang: " + demChiTietPTH);
                        }
                        else
                        {
                            MessageBox.Show("Khong them duoc, so luong them: " + demChiTietPTH);
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
                        bool f = traHangBUS.CapNhatTraHangBUS(ref err, TH);
                        if (f == true)
                        {
                            DataTable dtDBCu = chiTietPhieuTraHangBUS.GetAllChiTietPhieuTraHangByMaPhieuTraBUS(CTTH);
                            DataTable dtDBMoi = dt;
                            // chay theo dtDBCu
                            SuaChiTietPhieuTraHang_TonKho_dtDBCu(dtDBMoi, dtDBCu);
                            //ThemChiTietPhieuMuaHang_TonKho_dtDBCu(dtDBMoi,dtDBCu);
                            XoaChiTietPhieuTraHang_TonKho_dtDBMoi(dtDBMoi, dtDBCu);
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
        void SuaChiTietPhieuTraHang_TonKho_dtDBCu(DataTable dtmoi, DataTable dtcu)
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
                                    bool f = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);

                                    if (f == true)
                                    {
                                        MessageBox.Show("Cong thanh cong");
                                    }
                                }
                                else
                                {
                                    TK.SoLuong = TK.SoLuong - soLuongMoi;
                                    bool f = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                                    if (f == true)
                                    {
                                        MessageBox.Show("Tru thanh cong");
                                    }
                                }
                            }


                            // cap nhat chi tiet phieu ban
                            CTTH.MaChiTietPhieuTra = "1";
                            CTTH.MaPhieuTra = txtMaPhieuTra.Text;
                            CTTH.MaHangHoa = rMoi[2].ToString();
                            CTTH.SoLuong = Convert.ToInt32(rMoi[3]);
                            CTTH.DonGia = Convert.ToInt32(rMoi[4]);
                            CTTH.ThanhTien = Convert.ToInt32(rMoi[5]);
                            bool f1 = chiTietPhieuTraHangBUS.CapNhatChiTietPhieuTraHangByMaPhieuTraMaHangHoaBUS(ref err,CTTH);
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
                    CTTH.MaChiTietPhieuTra = "1";
                    CTTH.MaPhieuTra = txtMaPhieuTra.Text;
                    CTTH.MaHangHoa = rMoi[2].ToString();
                    CTTH.SoLuong = Convert.ToInt32(rMoi[3]);
                    CTTH.DonGia = Convert.ToInt32(rMoi[4]);
                    CTTH.ThanhTien = Convert.ToInt32(rMoi[5]);
                    bool f1 = chiTietPhieuTraHangBUS.ThemChiTietPhieuTraHangBUS(ref err, CTTH);
                }
            }
        }
        void XoaChiTietPhieuTraHang_TonKho_dtDBMoi(DataTable dtmoi, DataTable dtcu)
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
                        MessageBox.Show("cong ton kho thanh cong, Ma Hang Hoa:" + TK.MaHangHoa + ", Kho:" + TK.MaKho
                            + ", so luong:" + TK.SoLuong);
                    }
                    // xoa chi tiet phieu
                    CTTH.MaChiTietPhieuTra = "1";
                    CTTH.MaPhieuTra = txtMaPhieuTra.Text;
                    CTTH.MaHangHoa = rCu[2].ToString();
                    CTTH.SoLuong = Convert.ToInt32(rCu[3]);
                    CTTH.DonGia = Convert.ToInt32(rCu[4]);
                    CTTH.ThanhTien = Convert.ToInt32(rCu[5]);
                    bool f1 = chiTietPhieuTraHangBUS.XoaChiTietPhieuTraHangByMaPhieuTraMaHangHoaBUS(ref err, CTTH);
                    if (f1 == true)
                    {
                        MessageBox.Show("xoa thanh cong chi tietphieumuahang, MaPhieuTra: " + CTTH.MaPhieuTra + ", MahangHoa:" + CTTH.MaHangHoa);
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

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            UCLichSuTraHang uclsth = new UCLichSuTraHang();
            Control ctrPanel1 = btnLichSu.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(uclsth);
        }
    }
}
