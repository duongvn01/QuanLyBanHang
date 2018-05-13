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
        MuaHangO MH;
        NhaCungCapO NCC;
        HangHoaO HH;
        DonViO DV;

        MuaHangBUS muaHangBUS;
        NhaCungCapBUS nhaCungCapBUS;
        NhanVienBUS nhanVienBUS;
        KhoBUS khoBUS;
        HangHoaBUS hangHoaBUS;
        DonViBUS donViBUS;

        KieuThanhToanBUS kieuThanhToanBUS;
        HinhThucThanhToanBUS hinhThucThanhToanBUS;

        DataTable dt;
        public UCMuaHang()
        {
            InitializeComponent();
            initObjectBUS();
            initDataTable();
        }

        void initObjectBUS()
        {
            MH = new MuaHangO();
            NCC = new NhaCungCapO();
            HH = new HangHoaO();
            DV = new DonViO();

            muaHangBUS = new MuaHangBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            nhanVienBUS = new NhanVienBUS();
            khoBUS = new KhoBUS();
            hangHoaBUS = new HangHoaBUS();
            donViBUS = new DonViBUS();

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
            dt.Columns.Add("MaHangHoa");
            dt.Columns.Add("TenHangHoa");
            dt.Columns.Add("MaDonVi");
            dt.Columns.Add("TenDonVi");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
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
            if(dt!=null)
            {
                if (KiemTraTrung(lueHangHoa.EditValue.ToString()))
                {
                    /*
                    DataRow r = new DataRow();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (ma == dt.Rows[i][0].ToString())
                        {
                            return true;
                        }
                    }*/
                }
                else
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
                }
            
            }
            

            gridControlMuaHang.DataSource = dt;
        }
        bool ThemVaoDataTable()
        {
            return true;
        }
        bool KiemTraTrung(string ma)
        {
            if (dt != null)
            {
                DataRow r = new DataRow();
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

    }
}
