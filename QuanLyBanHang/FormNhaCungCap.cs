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
    public partial class FormNhaCungCap : Form
    {

        NhaCungCapO NCC;
        NhaCungCapBUS nhaCungCapBUS;
        KhuVucBUS khuVucBUS;
        int themOrSua;
        public FormNhaCungCap()
        {
            InitializeComponent();
            themOrSua = 1;

            khuVucBUS = new KhuVucBUS();

            // load lookupEdit khu vuc
            lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
            lueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lueKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        public FormNhaCungCap(int themOrSua, NhaCungCapO ncc)
        {
            InitializeComponent();
            this.themOrSua = themOrSua;
            nhaCungCapBUS = new NhaCungCapBUS();
            NCC = ncc;

            khuVucBUS = new KhuVucBUS();

            // load lookupEdit khu vuc
            lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
            lueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lueKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            NCC.MaNhaCungCap = txtMaNhaCungCap.Text;
            NCC.TenNhaCungCap = txtTenNhaCungCap.Text;
            //?
            //KH.MaKhuVuc = cbKhuVuc.Text;
            NCC.MaKhuVuc = lueKhuVuc.EditValue.ToString();

            NCC.DiaChi = txtDiaChi.Text;
            NCC.MaSoThue = txtMaSoThue.Text;
            NCC.Fax = txtFax.Text;
            NCC.SoDienThoai = txtSoDienThoai.Text;
            NCC.SoDiDong = txtSoDiDong.Text;
            NCC.Email = txtEmail.Text;
            NCC.Website = txtWebsite.Text;
            NCC.TaiKhoan = txtTaiKhoan.Text;
            NCC.NganHang = txtNganHang.Text;
            NCC.GioiHanNo = Convert.ToInt32(txtGioiHanNo.Text);
            NCC.NoHienTai = Convert.ToInt32(txtNoHienTai.Text);
            NCC.ChietKhau = Convert.ToInt32(txtChietKhau.Text);
            NCC.NguoiLienHe = txtNguoiLienHe.Text;
            NCC.ChucVu = txtChucVu.Text;
            NCC.ThongTinKhac = txtThongTinKhac.Text;

            if (chkConQuanLy.Checked == true)
            {
                NCC.ConQuanLy = true;
            }
            else
            {
                if (chkConQuanLy.Checked == false)
                    NCC.ConQuanLy = false;
            }
            if (themOrSua == 1)
            {

                try
                {
                    bool f = nhaCungCapBUS.ThemNhaCungCapBUS(ref err, NCC);
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
                    bool f = nhaCungCapBUS.CapNhatNhaCungCapBUS(ref err, NCC);
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

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            if (themOrSua == 0)
            {
                if (NCC.ConQuanLy == true)
                {
                    chkConQuanLy.Checked = true;
                }
                else
                {
                    chkConQuanLy.Enabled = false;
                }
                txtMaNhaCungCap.Enabled = false;
                txtMaNhaCungCap.Text = NCC.MaNhaCungCap;
                //cbKhuVuc.Text = NCC.MaKhuVuc;
                //lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
                lueKhuVuc.EditValue = NCC.MaKhuVuc;

                txtTenNhaCungCap.Text = NCC.TenNhaCungCap;
                txtDiaChi.Text = NCC.DiaChi;
                txtMaSoThue.Text = NCC.MaSoThue;
                txtFax.Text = NCC.Fax;
                txtSoDienThoai.Text = NCC.SoDienThoai;
                txtSoDiDong.Text = NCC.SoDiDong;
                txtEmail.Text = NCC.Email;
                txtWebsite.Text = NCC.Website;
                txtTaiKhoan.Text = NCC.TaiKhoan;
                txtNganHang.Text = NCC.NganHang;
                txtGioiHanNo.Text = NCC.GioiHanNo.ToString();
                txtNoHienTai.Text = NCC.NoHienTai.ToString();
                txtChietKhau.Text = NCC.ChietKhau.ToString();
                txtNguoiLienHe.Text = NCC.NguoiLienHe;
                txtChucVu.Text = NCC.ChucVu;
                txtThongTinKhac.Text = NCC.ThongTinKhac;
            }
        }

        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            FormKhuVuc frm = new FormKhuVuc();
            frm.ShowDialog();
        }
    }
}
