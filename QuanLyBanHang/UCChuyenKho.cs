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
    public partial class UCChuyenKho : UserControl
    {
        int themOrSua = 1;
        double tongTien;

        ChuyenKhoO CK;
        ChiTietChuyenKhoO CTCK;
        HangHoaO HH;
        DonViO DV;
        TonKhoO TK;

        ChuyenKhoBUS chuyenKhoBUS;
        ChiTietChuyenKhoBUS chiTietChuyenKhoBUS;
        NhanVienBUS nhanVienBUS;
        KhoBUS khoBUS;
        HangHoaBUS hangHoaBUS;
        DonViBUS donViBUS;
        TonKhoBUS tonKhoBUS;

        DataTable dt;
        public UCChuyenKho()
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
        public void TruyenChuyenKho_MaPhieuChuyen(ChuyenKhoO ck)
        {
            this.CK = ck;
        }
        void initObjectBUS()
        {
            CK = new ChuyenKhoO();
            CTCK = new ChiTietChuyenKhoO();
            HH = new HangHoaO();
            DV = new DonViO();
            TK = new TonKhoO();
            chuyenKhoBUS = new ChuyenKhoBUS();
            chiTietChuyenKhoBUS = new ChiTietChuyenKhoBUS();
            nhanVienBUS = new NhanVienBUS();
            khoBUS = new KhoBUS();
            hangHoaBUS = new HangHoaBUS();
            donViBUS = new DonViBUS();
            tonKhoBUS = new TonKhoBUS();
        }
        void loadLookUpEdit()
        {
            //  kho chuyen
            lueKhoChuyen.Properties.DataSource = khoBUS.getAllKhoBUS();
            lueKhoChuyen.Properties.DisplayMember = "TenKho";
            lueKhoChuyen.Properties.ValueMember = "MaKho";

            //  kho cnhan
            lueKhoNhan.Properties.DataSource = khoBUS.getAllKhoBUS();
            lueKhoNhan.Properties.DisplayMember = "TenKho";
            lueKhoNhan.Properties.ValueMember = "MaKho";

            //Nguoi chuyen
            lueNguoiChuyen.Properties.DataSource = nhanVienBUS.getAllNhanVien();
            lueNguoiChuyen.Properties.DisplayMember = "TenNhanVien";
            lueNguoiChuyen.Properties.ValueMember = "MaNhanVien";

            //nguoi nhan
            lueNguoiNhan.Properties.DataSource = nhanVienBUS.getAllNhanVien();
            lueNguoiNhan.Properties.DisplayMember = "TenNhanVien";
            lueNguoiNhan.Properties.ValueMember = "MaNhanVien";

            //Hang Hoa
            lueHangHoa.Properties.DataSource = hangHoaBUS.getAllHangHoa();
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
        }
        void initDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("MaChiTietPhieuChuyen", typeof(string));
            dt.Columns.Add("MaPhieuChuyen", typeof(string));
            dt.Columns.Add("MaHangHoa", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double));
            dt.Columns.Add("MaDonVi", typeof(string));
            dt.Columns.Add("TenHangHoa", typeof(string));
            dt.Columns.Add("TenDonVi", typeof(string));

        }
        void loadData()
        {
            gridControlChuyenKho.DataSource = chuyenKhoBUS.getAllChuyenKho();
        }
        
        void LayChiTietPhieuChuyenKhoByMaPhieu(ChuyenKhoO ck)
        {
            CTCK.MaPhieuChuyen = CK.MaPhieuChuyen;
            dt = chiTietChuyenKhoBUS.GetAllChiTietChuyenKhoByMaPhieuChuyenBUS(CTCK);
            gridControlChuyenKho.DataSource = dt;
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
            gridControlChuyenKho.DataSource = dt;
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
                row["MaChiTietPhieuChuyen"] = "1";
                row["MaPhieuChuyen"] = txtMaPhieuChuyen.Text;
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

        void SuaChiTietPhieuChuyenKho_TonKho_dtDBCu(DataTable dtmoi, DataTable dtcu)
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
                            TK.SoLuong = Convert.ToInt32(rCu[3]);
                            int soLuongMoi = Convert.ToInt32(rMoi[3]);
                            if (soLuongMoi != TK.SoLuong)
                            {
                                if (soLuongMoi > TK.SoLuong)
                                {
                                    //tru so luong kho chuyen
                                    TK.MaKho = lueKhoChuyen.EditValue.ToString();
                                    TK.SoLuong = soLuongMoi - TK.SoLuong;                                
                                    bool f = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                                    
                                    if(f==true)
                                    {
                                        MessageBox.Show("Tru thanh cong kho:"+TK.MaKho+",MaHangHoa:"+TK.MaHangHoa+", So luong:"+TK.SoLuong);
                                    }
                                    //cong so luong kho nhan
                                    TK.MaKho = lueKhoNhan.EditValue.ToString();
                                    bool f1 = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);
                                    if (f1 == true)
                                    {
                                        MessageBox.Show("Cong thanh cong kho:" + TK.MaKho + ",MaHangHoa:" + TK.MaHangHoa + ", So luong:" + TK.SoLuong);
                                    }
                                }
                                else
                                {
                                    //cong so luong kho chuyen
                                    TK.MaKho = lueKhoChuyen.EditValue.ToString();
                                    TK.SoLuong = TK.SoLuong - soLuongMoi;
                                    bool f = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);
                                    if (f == true)
                                    {
                                        MessageBox.Show("Cong thanh cong kho:" + TK.MaKho + ",MaHangHoa:" + TK.MaHangHoa + ", So luong:" + TK.SoLuong);
                                    }
                                    bool f1 = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                                    if (f1 == true)
                                    {
                                        MessageBox.Show("Tru thanh cong kho:" + TK.MaKho + ",MaHangHoa:" + TK.MaHangHoa + ", So luong:" + TK.SoLuong);
                                    }
                                }
                            }


                            // cap nhat chi tiet phieuchuyen
                            CTCK.MaChiTietPhieuChuyen = "1";
                            CTCK.MaPhieuChuyen = txtMaPhieuChuyen.Text;
                            CTCK.MaHangHoa = rMoi[2].ToString();
                            CTCK.SoLuong = Convert.ToInt32(rMoi[3]);
                            CTCK.DonGia = Convert.ToInt32(rMoi[4]);
                            CTCK.ThanhTien = Convert.ToInt32(rMoi[5]);
                            bool f2 = chiTietChuyenKhoBUS.CapNhatChiTietChuyenKhoByMaPhieuChuyenMaHangHoaBUS(ref err, CTCK);
                            if(f2==true)
                            {
                                MessageBox.Show("Cap nhat thanh cong chi tiet phieu chuyen,MaPhieuChuyen=" + CTCK.MaPhieuChuyen + ", MaHangHoa:" +CTCK.MaHangHoa);
                            }
                        }
                    }

                }
                else
                {
                    //them ton kho
                    TK.MaHangHoa = rMoi[2].ToString();
                    TK.MaKho = lueKhoChuyen.EditValue.ToString();
                    TK.SoLuong = Convert.ToInt32(rMoi[3]);
                    bool f = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                    if (f == true)
                    {
                        MessageBox.Show("Them thanh cong ton kho, MaHangHoa: " +
                            TK.MaHangHoa + " makho:" + TK.MaKho + "So luong " + TK.SoLuong);
                    }
                    TK.MaKho = lueKhoNhan.EditValue.ToString();
                    bool f1 = tonKhoBUS.ThemTonKhoBUS(ref err, TK);
                    if (f1 == true)
                    {
                        MessageBox.Show("Them thanh cong ton kho, bo sung moi, MaHangHoa: " +
                            TK.MaHangHoa + " makho:" + TK.MaKho + "So luong " + TK.SoLuong);
                    }

                    // them chi tiet phieu
                    CTCK.MaChiTietPhieuChuyen = "1";
                    CTCK.MaPhieuChuyen = txtMaPhieuChuyen.Text;
                    CTCK.MaHangHoa = rMoi[2].ToString();
                    CTCK.SoLuong = Convert.ToInt32(rMoi[3]);
                    CTCK.DonGia = Convert.ToInt32(rMoi[4]);
                    CTCK.ThanhTien = Convert.ToInt32(rMoi[5]);
                    bool f2 = chiTietChuyenKhoBUS.ThemChiTietChuyenKhoBUS(ref err, CTCK);
                    if (f2 == true)
                    {
                        MessageBox.Show("Them thanh cong chuyen kho, bo sung moi, MaPhieuChuyen: " +
                            CTCK.MaPhieuChuyen + " MaHangHoa:" + CTCK.MaHangHoa + "So luong " + CTCK.SoLuong);
                    }
                }
            }
        }
        void XoaChiTietPhieuChuyenKho_TonKho_dtDBMoi(DataTable dtmoi, DataTable dtcu)
        {
            string err = "";
            foreach (DataRow rCu in dtcu.Rows)
            {
                if (KiemTraMaHangHoaTonTaiTrongDB(dtmoi, rCu[2].ToString()) == false)//ko ton tai trong dbmoi
                {
                    //cap nhat tonkho
                    TK.MaHangHoa = rCu[2].ToString();
                    TK.MaKho = lueKhoChuyen.EditValue.ToString();
                    TK.SoLuong = Convert.ToInt32(rCu[3]);
                    bool f = tonKhoBUS.CongSoLuongTonKhoBUS(ref err,TK);
                    if (f == true)
                    {
                        MessageBox.Show("tra lai so luong hang hoa cho kho chuyen thanh cong, Ma Hang Hoa:" + TK.MaHangHoa + ", Kho:" + TK.MaKho
                            + ", so luong:" + TK.SoLuong);
                    }
                    // xoa chi tiet phieu
                    CTCK.MaChiTietPhieuChuyen = "1";
                    CTCK.MaPhieuChuyen = txtMaPhieuChuyen.Text;
                    CTCK.MaHangHoa = rCu[2].ToString();
                    CTCK.SoLuong = Convert.ToInt32(rCu[3]);
                    CTCK.DonGia = Convert.ToInt32(rCu[4]);
                    CTCK.ThanhTien = Convert.ToInt32(rCu[5]);
                    bool f1 = chiTietChuyenKhoBUS.XoaChiTietChuyenKhoByMaPhieuChuyenMaHangHoaBUS(ref err, CTCK);
                    if (f1 == true)
                    {
                        MessageBox.Show("Xoa thanh cong chi tiet ChuyenKho, MaPhieuchuyen: " + CTCK.MaPhieuChuyen + ", MahangHoa:" + CTCK.MaHangHoa);
                    }
                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            //Them ChuyenKho       
            CK.MaPhieuChuyen = txtMaPhieuChuyen.Text;
            CK.NgayLapPhieu = Convert.ToDateTime(deNgayLapPhieu.Text);
            CK.GhiChu = txtGhiChu.Text;
            CK.MaKhoChuyen = lueKhoChuyen.EditValue.ToString();
            CK.MaKhoNhan = lueKhoNhan.EditValue.ToString();
            CK.MaNguoiChuyen = lueNguoiChuyen.EditValue.ToString();
            CK.MaNguoiNhan = lueNguoiNhan.EditValue.ToString();

            //TK = LayTonKhoTuDataTable();
            if (themOrSua == 1)
            {
                try
                {
                    bool f = chuyenKhoBUS.ThemChuyenKhoBUS(ref err, CK);
                    if (f == true)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            //tru kho chuyen
                            TK.MaHangHoa = r[2].ToString();
                            TK.MaKho = lueKhoChuyen.EditValue.ToString();
                            TK.SoLuong = Convert.ToInt32(r[3]);
                            bool f1 = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                            if (f1 == true)
                            {
                                MessageBox.Show("Tru thanh cong kho chuyen, MaKho:" + TK.MaKho + ", MaHangHoa:" + TK.MaHangHoa + ", So Luong:" + TK.SoLuong);
                            }
                            //cong kho nhan
                            TK.MaHangHoa = r[2].ToString();
                            TK.MaKho = lueKhoNhan.EditValue.ToString();
                            TK.SoLuong = Convert.ToInt32(r[3]);
                            bool f2 = tonKhoBUS.CongSoLuongTonKhoBUS(ref err, TK);
                            if (f2 == true)
                            {
                                MessageBox.Show("Cong thanh cong kho nhan, MaKho:" + TK.MaKho + ", MaHangHoa:" + TK.MaHangHoa + ", So Luong:" + TK.SoLuong);
                            }

                            CTCK.MaChiTietPhieuChuyen = "1";
                            CTCK.MaPhieuChuyen = txtMaPhieuChuyen.Text;
                            CTCK.MaHangHoa = r[2].ToString();
                            CTCK.SoLuong = Convert.ToInt32(r[3]);
                            CTCK.DonGia = Convert.ToInt32(r[4]);
                            CTCK.ThanhTien = Convert.ToInt32(r[5]);
                            bool f3 = chiTietChuyenKhoBUS.ThemChiTietChuyenKhoBUS(ref err, CTCK);
                            if (f3 == true)
                            {
                                MessageBox.Show("Them thanh cong chi tiet chuyen kho, MaKho:" + TK.MaKho + ", MaHangHoa:" + CTCK.MaHangHoa + ", So Luong:" + TK.SoLuong);
                            }
                        }
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc, Loi: " + err);
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
                    bool f = chuyenKhoBUS.CapNhatChuyenKhoBUS(ref err, CK);
                    if (f == true)
                    {
                        DataTable dtDBCu = chiTietChuyenKhoBUS.GetAllChiTietChuyenKhoByMaPhieuChuyenBUS(CTCK);
                        DataTable dtDBMoi = dt;
                        // chay theo dtDBCu
                        SuaChiTietPhieuChuyenKho_TonKho_dtDBCu(dtDBMoi, dtDBCu);
                        //ThemChiTietPhieuMuaHang_TonKho_dtDBCu(dtDBMoi,dtDBCu);
                        XoaChiTietPhieuChuyenKho_TonKho_dtDBMoi(dtDBMoi, dtDBCu);
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi: " + err);
                }
            }
        }
        void LayChuyenKhoByMaPhieuChuyen(ChuyenKhoO ck)
        {
            CK = chuyenKhoBUS.getOneChuyenKhoByMaPhieuChuyen(ck);
            //dua du lieu len textbox,lookupedit
            txtMaPhieuChuyen.Text = CK.MaPhieuChuyen;
            deNgayLapPhieu.EditValue = CK.NgayLapPhieu;
            txtGhiChu.Text = CK.GhiChu;
            lueKhoChuyen.EditValue = CK.MaKhoChuyen;
            lueKhoNhan.EditValue = CK.MaKhoNhan;
            lueNguoiChuyen.EditValue = CK.MaNguoiChuyen;
            lueNguoiNhan.EditValue = CK.MaNguoiNhan;
        }
        void LayChiTietChuyenKhoByMaPhieuChuyen(ChuyenKhoO ck)
        {
            CTCK.MaPhieuChuyen = ck.MaPhieuChuyen;
            dt = chiTietChuyenKhoBUS.GetAllChiTietChuyenKhoByMaPhieuChuyenBUS(CTCK);
            gridControlChuyenKho.DataSource = dt;
        }
        private void btnLichSu_Click(object sender, EventArgs e)
        {     
            UCLichSuChuyenKho uclsck = new UCLichSuChuyenKho();
            Control ctrPanel1 = btnLichSu.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(uclsck);
        }

        private void UCChuyenKho_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
            if (themOrSua == 0)
            {
                LayChuyenKhoByMaPhieuChuyen(CK);
                LayChiTietChuyenKhoByMaPhieuChuyen(CK);
            }
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

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (HH.GiaMua * (Convert.ToDouble(txtSoLuong.Text))).ToString();
        }

        private void txtDonGia_EditValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (HH.GiaMua * (Convert.ToDouble(txtSoLuong.Text))).ToString();
        }
    }
}
