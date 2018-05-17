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
        //int themOrSua = 1;
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

        DataTable dt;
        public UCMuaHang()
        {
            InitializeComponent();
            initObjectBUS();
            initDataTable();
            //themOrSua = 1;
            tongTien = 0;
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
            dt.Columns.Add("MaHangHoa", typeof(string));
            dt.Columns.Add("TenHangHoa", typeof(string));
            dt.Columns.Add("MaDonVi", typeof(string));
            dt.Columns.Add("TenDonVi", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(double));
            dt.Columns.Add("ThanhTien", typeof(double));
        }
        private void UCMuaHang_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
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
            string maHangHoa= lueHangHoa.EditValue.ToString();
            if(dt!=null)
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
            txtTongTien.Text =TinhTongTien().ToString();
        }
        double TinhTongTien()
        {
            double tong=0;
            foreach (DataRow r in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {                
                tong = tong + Convert.ToDouble(r[6]);
            }
            return tong;
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
        /*TonKhoO LayTonKhoTuDataTable()
        {
            TonKhoO tk = new TonKhoO();
            foreach (DataRow r in dt.Rows)
            {
                string ma = r[0].ToString();
                {
                    int soluong = Convert.ToInt32(r[4]);
                    r[4] = Convert.ToInt32(txtSoLuong.Text) + soluong;
                    r[6] = Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(r[4]);                    
                }
            }
                
        }
        */
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            //them mua hang            
            MH.MaPhieu = txtMaPhieu.Text;
            MH.TenPhieu = txtTenPhieu.Text;
            MH.NgayLapPhieu = Convert.ToDateTime(deNgayLapPhieu.Text);
            MH.SoHoaDonVAT = txtSoHoaDonVAT.Text;
            MH.SoPhieuVietTay = txtSoPhieuVietTay.Text;
            MH.MaThanhToan = lueKieuThanhToan.EditValue.ToString();
            MH.MaHinhThuc = lueHinhThucThanhToan.EditValue.ToString();
            MH.MaNhaCungCap = lueNhaCungCap.EditValue.ToString();
            MH.ThoiHanThanhToan = Convert.ToDateTime(deThoiHanThanhToan.Text);
            MH.GhiChu = txtGhiChu.Text;
            MH.MaNhanVien = lueNhanVien.EditValue.ToString();
            MH.MaKho = lueKho.EditValue.ToString();
            MH.TongTien = Convert.ToDouble(txtTongTien.Text);
            MH.PTramCK = Convert.ToInt32(txtPhanTramChuyenKhoan.Text);
            MH.Thue = Convert.ToInt32(txtPhanTramThue.Text);
            MH.TuongDuongTien = Convert.ToDouble(txtTuongDuongTien.Text);
            MH.TienThanhToan = Convert.ToDouble(txtTienThanhToan.Text);

            //TK = LayTonKhoTuDataTable();
            //if (themOrSua == 1)
            {

                try
                {
                    bool f = muaHangBUS.ThemHangHoaBUS(ref err, MH);
                    int dem = 0;         
                    if (f == true)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            TK.MaHangHoa = r[0].ToString();
                            TK.MaKho = lueKho.EditValue.ToString();
                            TK.SoLuong = Convert.ToInt32(r[4]);
                            bool f1 = tonKhoBUS.ThemTonKhoBUS(ref err, TK);
                            if (f1 == true)
                            {
                                dem++;
                            }
                        }
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc, Loi: " + err);
                    }
                    if (dem == dt.Rows.Count)
                    {
                        MessageBox.Show("Them thanh cong Ton kho: "+dem);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi: " + err);
                }

            }
            /*else
            {

                try
                {
                    bool f = hangHoaBUS.CapNhatHangHoaBUS(ref err, HH);
                    if (f == true)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được. Lỗi: " + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi: " + err);
                }
            }*/
        }

        private void txtPhanTramThue_EditValueChanged(object sender, EventArgs e)
        {
            
            int thue = Convert.ToInt32(txtPhanTramThue.Text);
            tongTien = Convert.ToDouble(txtTongTien.Text);
            double tienThueTuongDuong = (tongTien/100)*thue;
            txtTuongDuongTien.Text = tienThueTuongDuong.ToString();
            
            double tienChuyenKhoan = Convert.ToDouble(txtPhanTramChuyenKhoan.Text)*tongTien/100;
            txtTienThanhToan.Text = (tongTien - tienChuyenKhoan + tienThueTuongDuong).ToString();
        }

    }
}
