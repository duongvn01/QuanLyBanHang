using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bussiness_Logic_Layer;
using Object;


namespace QuanLyBanHang
{
    public partial class FormHangHoa : Form
    {

        HangHoaO HH;

        HangHoaBUS hangHoaBUS;
        KhoBUS khoBUS;
        NhomHangBUS nhomHangBUS;
        DonViBUS donViBUS;
        NhaCungCapBUS nhaCungCapBUS;

        int themOrSua;
        public FormHangHoa()
        {
            InitializeComponent();
            themOrSua = 1;
            hangHoaBUS = new HangHoaBUS();
            initBUS();
        }

        public FormHangHoa(int themOrSua,HangHoaO hh)
        {
            InitializeComponent();
            this.themOrSua = themOrSua;
            initBUS();
            HH = hh;        
        }
        void initBUS()
        {
            hangHoaBUS = new HangHoaBUS();
            khoBUS = new KhoBUS();
            nhomHangBUS = new NhomHangBUS();
            donViBUS = new DonViBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            HH = new HangHoaO();
        }
        void loadLookUpEdit()
        {
            //load look up edit kho
            lueKho.Properties.DataSource = khoBUS.getAllKhoBUS();
            lueKho.Properties.DisplayMember = "TenKho";
            lueKho.Properties.ValueMember = "MaKho";

            //Nhom Hang
            lueNhomHang.Properties.DataSource = nhomHangBUS.getAllNhomHang();
            lueNhomHang.Properties.DisplayMember = "TenNhomHang";
            lueNhomHang.Properties.ValueMember = "MaNhomHang";

            //Don Vi
            lueDonVi.Properties.DataSource = donViBUS.getAllDonVi();
            lueDonVi.Properties.DisplayMember = "TenDonVi";
            lueDonVi.Properties.ValueMember = "MaDonVi";

            //Nha Cung Cap
            lueNhaCungCap.Properties.DataSource = nhaCungCapBUS.getAllNhaCungCap();
            lueNhaCungCap.Properties.DisplayMember = "TenNhaCungCap";
            lueNhaCungCap.Properties.ValueMember = "MaNhaCungCap";
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
            if(themOrSua == 0)
            {
                txtMaHangHoa.Enabled = false;
                txtMaHangHoa.Text = HH.MaHangHoa;
                lueKho.EditValue = HH.MaKho;
                txtTenHangHoa.Text = HH.TenHangHoa;
                lueNhomHang.EditValue = HH.MaNhomHang;
                txtMaVachNSX.Text = HH.MaVachNSX;
                lueDonVi.EditValue = HH.MaDonVi;
                txtXuatXu.Text = HH.XuatXu;
                txtThue.Text = HH.Thue.ToString();
                txtTonKhoToiThieu.Text = HH.TonKhoToiThieu.ToString();
                txtTonHienTai.Text = HH.TonHienTai.ToString();
                lueNhaCungCap.EditValue = HH.MaNhaCungCap;
                txtGiaMua.Text = HH.GiaMua.ToString();
                txtGiaBanSi.Text = HH.GiaBanSi.ToString();
                txtGiaBanLe.Text = HH.GiaBanLe.ToString();
               
                if (HH.ConQuanLy == true)
                {
                    chkConQuanLy.Checked = true;
                }
                else
                {
                    chkConQuanLy.Checked = false;
                }
                if (HH.HangHoaOrDichVu == true)
                {
                    radioGroupHangHoaDichVu.SelectedIndex =0;
                }
                else
                {
                    radioGroupHangHoaDichVu.SelectedIndex = 1;
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            HH.MaHangHoa = txtMaHangHoa.Text;
            HH.MaKho = lueKho.EditValue.ToString();
            HH.TenHangHoa = txtTenHangHoa.Text;
            HH.MaNhomHang = lueNhomHang.EditValue.ToString();
            HH.MaVachNSX = txtMaVachNSX.Text;
            HH.MaDonVi = lueDonVi.EditValue.ToString();
            HH.XuatXu = txtXuatXu.Text;
            HH.Thue = Convert.ToInt32(txtThue.Text);
            HH.TonKhoToiThieu = Convert.ToInt32(txtTonKhoToiThieu.Text);
            HH.TonHienTai = Convert.ToInt32(txtTonHienTai.Text);
            HH.MaNhaCungCap = lueNhaCungCap.EditValue.ToString();
            HH.GiaMua = Convert.ToInt32(txtGiaMua.Text);
            HH.GiaBanSi = Convert.ToInt32(txtGiaBanSi.Text);
            HH.GiaBanLe = Convert.ToInt32(txtGiaBanLe.Text);
            if (chkConQuanLy.Checked == true)
            {
                HH.ConQuanLy = true;
            }         
            else
            {
                HH.ConQuanLy = false;
            }
            if(radioGroupHangHoaDichVu.SelectedIndex==0)
            {
                HH.HangHoaOrDichVu = true;
            }
            else
            {
                HH.HangHoaOrDichVu = false;
            }
            if (themOrSua == 1)
            {

                try
                {
                    bool f = hangHoaBUS.ThemHangHoaBUS(ref err, HH);
                    if (f == true)
                    {
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
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            FormKhoHang frm = new FormKhoHang();
            frm.ShowDialog();
        }

        private void btnThemNhomHang_Click(object sender, EventArgs e)
        {
            FormNhomHang frm = new FormNhomHang();
            frm.ShowDialog();
        }

        private void btnThemDonVi_Click(object sender, EventArgs e)
        {
            FormDonViTinh frm = new FormDonViTinh();
            frm.ShowDialog();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FormNhaCungCap frm = new FormNhaCungCap();
            frm.ShowDialog();
        }
    }
}
