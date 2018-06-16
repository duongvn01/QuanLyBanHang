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
    public partial class UCMuaHang : UserControl
    {

        int themOrSua = 1;
        double tongTien;
        MuaHangO MH;

        NhaCungCapO NCC;
        HangHoaO HH;
        DonViO DV;
        ChiTietPhieuMuaHangO CTPMH;
        TonKhoO TK;

        MuaHangBUS muaHangBUS;
        NhaCungCapBUS nhaCungCapBUS;
        NhanVienBUS nhanVienBUS;
        KhoBUS khoBUS;
        HangHoaBUS hangHoaBUS;
        DonViBUS donViBUS;
        TonKhoBUS tonKhoBUS;

        KieuThanhToanBUS kieuThanhToanBUS;
        HinhThucThanhToanBUS hinhThucThanhToanBUS;

        ChiTietPhieuMuaHangBUS chiTietPhieuMuaHangBUS;

        DataTable dt;
        public UCMuaHang()
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
        void initObjectBUS()
        {
            MH = new MuaHangO();
            NCC = new NhaCungCapO();
            HH = new HangHoaO();
            DV = new DonViO();
            CTPMH = new ChiTietPhieuMuaHangO();
            TK = new TonKhoO();
            muaHangBUS = new MuaHangBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            nhanVienBUS = new NhanVienBUS();
            khoBUS = new KhoBUS();
            hangHoaBUS = new HangHoaBUS();
            donViBUS = new DonViBUS();
            tonKhoBUS = new TonKhoBUS();
            chiTietPhieuMuaHangBUS = new ChiTietPhieuMuaHangBUS();

            kieuThanhToanBUS = new KieuThanhToanBUS();
            hinhThucThanhToanBUS = new HinhThucThanhToanBUS();
        }
        void loadLookUpEdit()
        {
            //load lookupedit Nha Cung Cap
            lueNhaCungCap.Properties.DataSource = nhaCungCapBUS.getAllNhaCungCap();
            lueNhaCungCap.Properties.DisplayMember = "MaNhaCungCap";
            lueNhaCungCap.Properties.ValueMember = "MaNhaCungCap";

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
            dt.Columns.Add("MaChiTietPhieu", typeof(string));
            dt.Columns.Add("MaPhieu", typeof(string));
            dt.Columns.Add("MaHangHoa", typeof(string)); 
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double));
            dt.Columns.Add("MaDonVi", typeof(string));
            dt.Columns.Add("TenHangHoa", typeof(string));
            dt.Columns.Add("TenDonVi", typeof(string));

        }
        public void TruyenMuaHang_MaPhieu(MuaHangO mh)
        {
            this.MH = mh;
        }
        void LayMuaHangByMaPhieu(MuaHangO mh)
        {
            MH = muaHangBUS.getOneMuaHangByMaPhieu(mh);
            //dua du lieu len textbox,lookupedit
            txtMaPhieu.Text = MH.MaPhieu;
            txtTenPhieu.Text = MH.TenPhieu;
            deNgayLapPhieu.EditValue = MH.NgayLapPhieu;
            txtSoHoaDonVAT.Text = MH.SoHoaDonVAT;
            txtSoPhieuVietTay.Text = MH.SoPhieuVietTay;
            lueKieuThanhToan.EditValue = MH.MaThanhToan;

            lueNhaCungCap.EditValue = MH.MaNhaCungCap;

            deThoiHanThanhToan.EditValue = MH.ThoiHanThanhToan;
            lueHinhThucThanhToan.EditValue = MH.MaHinhThuc;

            lueNhanVien.EditValue = MH.MaNhanVien;
            lueKho.EditValue = MH.MaKho;
            txtGhiChu.Text = MH.GhiChu;
        }
        void LayChiTietPhieuMuaHangByMaPhieu(MuaHangO mh)
        {
            CTPMH.MaPhieu = mh.MaPhieu;
            dt = chiTietPhieuMuaHangBUS.GetAllChiTietPhieuMuaHangByMaPhieuBUS(CTPMH);
            gridControlMuaHang.DataSource = dt;
        }
        private void UCMuaHang_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
            if (themOrSua == 0)
            {
                LayMuaHangByMaPhieu(MH);
                LayChiTietPhieuMuaHangByMaPhieu(MH);
            }
        }
        private void lueNhaCungCap_EditValueChanged(object sender, EventArgs e)
        {
            NCC.MaNhaCungCap = lueNhaCungCap.EditValue.ToString();
            NCC = nhaCungCapBUS.getOneNhaCungCap(NCC);
            txtTenNhaCungCap.Text = NCC.TenNhaCungCap;
            txtDiaChi.Text = NCC.DiaChi;
            txtSoDienThoai.Text = NCC.SoDienThoai;
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
            gridControlMuaHang.DataSource = dt;
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
                row["MaChiTietPhieu"] = "1";
                row["MaPhieu"] = txtMaPhieu.Text;
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

        private void gridViewMuaHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            CTPMH.MaHangHoa = gridViewMuaHang.GetFocusedRowCellValue(colMaHangHoa).ToString();
        }
        private void btnRemoveKhoiGridview_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn không muốn mua mặt hàng này không?",
                "Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool f = RemoveKhoiDataTable(CTPMH.MaHangHoa);
            }
        }
        private void btnTimHangHoa_Click(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            //them mua hang            
            MH.MaPhieu = txtMaPhieu.Text;
            MH.TenPhieu = txtTenPhieu.Text;
            MH.NgayLapPhieu = Convert.ToDateTime(deNgayLapPhieu.EditValue);
            MH.SoHoaDonVAT = txtSoHoaDonVAT.Text;
            MH.SoPhieuVietTay = txtSoPhieuVietTay.Text;
            MH.MaThanhToan = lueKieuThanhToan.EditValue.ToString();
            MH.MaHinhThuc = lueHinhThucThanhToan.EditValue.ToString();
            MH.MaNhaCungCap = lueNhaCungCap.EditValue.ToString();
            MH.ThoiHanThanhToan = Convert.ToDateTime(deThoiHanThanhToan.EditValue);
            MH.GhiChu = txtGhiChu.Text;
            MH.MaNhanVien = lueNhanVien.EditValue.ToString();
            MH.MaKho = lueKho.EditValue.ToString();
            MH.TongTien = Convert.ToDouble(txtTongTien.EditValue);
            MH.PTramCK = Convert.ToInt32(txtPhanTramChuyenKhoan.EditValue);
            MH.Thue = Convert.ToInt32(txtPhanTramThue.EditValue);
            MH.TuongDuongTien = Convert.ToDouble(txtTuongDuongTien.EditValue);
            MH.TienThanhToan = Convert.ToDouble(txtTienThanhToan.EditValue);
            //TK = LayTonKhoTuDataTable();
            if (txtMaPhieu.Text == "" || txtTenPhieu.Text == "" || MH.NgayLapPhieu == Convert.ToDateTime("1/1/0001 12:00:00 AM") || MH.ThoiHanThanhToan == Convert.ToDateTime("1/1/0001 12:00:00 AM")
                || MH.MaThanhToan == "" || MH.MaHinhThuc == "" || MH.MaNhaCungCap == "" || MH.MaNhanVien == "" || MH.MaKho == "" || MH.TongTien == 0||MH.TienThanhToan==0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {


                if (themOrSua == 1)
                {
                    try
                    {
                        bool f = muaHangBUS.ThemMuaHangBUS(ref err, MH);
                        int demTonKho = 0, demChiTietPMH = 0;
                        if (f == true)
                        {
                            foreach (DataRow r in dt.Rows)
                            {
                                TK.MaHangHoa = r[2].ToString();
                                TK.MaKho = lueKho.EditValue.ToString();
                                TK.SoLuong = Convert.ToInt32(r[3]);
                                bool f1 = tonKhoBUS.ThemTonKhoBUS(ref err, TK);

                                CTPMH.MaChiTietPhieu = "1";
                                CTPMH.MaPhieu = txtMaPhieu.Text;
                                CTPMH.MaHangHoa = r[2].ToString();
                                CTPMH.SoLuong = Convert.ToInt32(r[3]);
                                CTPMH.DonGia = Convert.ToInt32(r[4]);
                                CTPMH.ThanhTien = Convert.ToInt32(r[5]);
                                bool f2 = chiTietPhieuMuaHangBUS.ThemChiTietPhieuMuaHangBUS(ref err, CTPMH);
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
                        bool f = muaHangBUS.CapNhatMuaHangBUS(ref err, MH);
                        if (f == true)
                        {
                            DataTable dtDBCu = chiTietPhieuMuaHangBUS.GetAllChiTietPhieuMuaHangByMaPhieuBUS(CTPMH);
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
        bool KiemTraMaHangHoaTonTaiTrongDB(DataTable dtcu,string ma)
        {
            foreach (DataRow rCu in dtcu.Rows)
            {
                if(ma==rCu[2].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        void ThemChiTietPhieuMuaHang_TonKho_dtDBCu(DataTable dtmoi, DataTable dtcu)
        {
            string err = "";
                foreach (DataRow rMoi in dtmoi.Rows)
                {
                    if (KiemTraMaHangHoaTonTaiTrongDB(dtcu,rMoi[2].ToString()))
                    {
                        foreach (DataRow rCu in dtcu.Rows)
                        {
                            if(rCu[2].Equals(rMoi[2]))
                            {                        
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
                            }
                        }
                        
                    }
                    else
                    {
                        
                        TK.MaHangHoa = rMoi[2].ToString();
                        TK.MaKho = lueKho.EditValue.ToString();
                        TK.SoLuong = Convert.ToInt32(rMoi[3]);
                        bool f = tonKhoBUS.ThemTonKhoBUS(ref err,TK);
                        if(f==true)
                        {
                            MessageBox.Show("Them thanh cong ton kho, bo sung moi, MaHangHoa: " +
                                TK.MaHangHoa + " makho:" + TK.MaKho + "So luong " + TK.SoLuong);
                        }
                    }
                    
                }
        }
        void SuaChiTietPhieuMuaHang_TonKho_dtDBCu(DataTable dtmoi, DataTable dtcu)
        {
                string err = "";
                foreach (DataRow rMoi in dtmoi.Rows)
                {
                    if (KiemTraMaHangHoaTonTaiTrongDB(dtcu,rMoi[2].ToString()))
                    {
                        foreach (DataRow rCu in dtcu.Rows)
                        {
                            if(rCu[2].Equals(rMoi[2]))
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


                                // cap nhat chi tiet phieu
                                CTPMH.MaChiTietPhieu = "1";
                                CTPMH.MaPhieu = txtMaPhieu.Text;
                                CTPMH.MaHangHoa = rMoi[2].ToString();
                                CTPMH.SoLuong = Convert.ToInt32(rMoi[3]);
                                CTPMH.DonGia = Convert.ToInt32(rMoi[4]);
                                CTPMH.ThanhTien = Convert.ToInt32(rMoi[5]);
                                bool f1 = chiTietPhieuMuaHangBUS.CapNhatChiTietPhieuMuaHangByMaPhieuMaHangHoaBUS(ref err,CTPMH);
                            }
                      }
                        
                 }
                    else
                    {
                        //them ton kho
                        TK.MaHangHoa = rMoi[2].ToString();
                        TK.MaKho = lueKho.EditValue.ToString();
                        TK.SoLuong = Convert.ToInt32(rMoi[3]);
                        bool f = tonKhoBUS.ThemTonKhoBUS(ref err,TK);
                        if(f==true)
                        {
                            MessageBox.Show("Them thanh cong ton kho, bo sung moi, MaHangHoa: " +
                                TK.MaHangHoa + " makho:" + TK.MaKho + "So luong " + TK.SoLuong);
                        }

                        // them chi tiet phieu
                        CTPMH.MaChiTietPhieu = "1";
                        CTPMH.MaPhieu = txtMaPhieu.Text;
                        CTPMH.MaHangHoa = rMoi[2].ToString();
                        CTPMH.SoLuong = Convert.ToInt32(rMoi[3]);
                        CTPMH.DonGia = Convert.ToInt32(rMoi[4]);
                        CTPMH.ThanhTien = Convert.ToInt32(rMoi[5]);
                        bool f1 = chiTietPhieuMuaHangBUS.ThemChiTietPhieuMuaHangBUS(ref err, CTPMH);
                    }
            }
        }
        void XoaChiTietPhieuMuaHang_TonKho_dtDBMoi(DataTable dtmoi, DataTable dtcu)
        {
            string err = "";
            foreach (DataRow rCu in dtcu.Rows)
            {
                if (KiemTraMaHangHoaTonTaiTrongDB(dtmoi, rCu[2].ToString())==false)//ko ton tai trong dbmoi
                {
                            //cap nhat tonkho
                            TK.MaHangHoa = rCu[2].ToString();
                            TK.MaKho = lueKho.EditValue.ToString();
                            TK.SoLuong = Convert.ToInt32(rCu[3]);
                            bool f = tonKhoBUS.XuatTonKhoBUS(ref err,TK);
                            if (f == true)
                            {
                                  MessageBox.Show("xuat ton kho thanh cong, Ma Hang Hoa:"+TK.MaHangHoa +", Kho:"+TK.MaKho
                                      +", so luong:"+TK.SoLuong);
                            }
                            // xoa chi tiet phieu
                            CTPMH.MaChiTietPhieu = "1";
                            CTPMH.MaPhieu = txtMaPhieu.Text;
                            CTPMH.MaHangHoa = rCu[2].ToString();
                            CTPMH.SoLuong = Convert.ToInt32(rCu[3]);
                            CTPMH.DonGia = Convert.ToInt32(rCu[4]);
                            CTPMH.ThanhTien = Convert.ToInt32(rCu[5]);
                            bool f1 = chiTietPhieuMuaHangBUS.XoaChiTietPhieuMuaHangByMaPhieuMaHangHoaBUS(ref err, CTPMH);
                            if (f1 == true)
                            {
                                MessageBox.Show("xoa thanh cong chi tietphieumuahang, MaPhieu: "+CTPMH.MaPhieu+", MahangHoa:"+CTPMH.MaHangHoa);
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

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {
            /*UCLichSuMuaHang lsmh = new UCLichSuMuaHang();
            FormMain fm = new FormMain();
            fm.Show();*/
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            FormHangHoa hh = new FormHangHoa();
            hh.Show();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FormNhaCungCap ncc = new FormNhaCungCap();
            ncc.Show();
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

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhieu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            UCLichSuMuaHang uclsmh = new UCLichSuMuaHang();
            Control ctrPanel1 = btnLichSu.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(uclsmh);
        }
    }
}
