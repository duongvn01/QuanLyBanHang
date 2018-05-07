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
    public partial class FormKhoHang : Form
    {
        KhoO K;
        KhoBUS khoBUS;
        NhanVienBUS nhanVienBUS;
        int themOrSua;
        public FormKhoHang()
        {
            InitializeComponent();
            themOrSua = 1;
            nhanVienBUS = new NhanVienBUS();
        }
        
        public FormKhoHang(int themOrSua, KhoO k)
        {
            InitializeComponent();
            this.themOrSua = themOrSua;
            khoBUS = new KhoBUS();
            nhanVienBUS = new NhanVienBUS();
            K = k;        
        }
        void loadLookUpEdit()
        {
            lueQuanLy.Properties.DataSource = nhanVienBUS.getAllNhanVien();
            lueQuanLy.Properties.DisplayMember = "TenNhanVien";
            lueQuanLy.Properties.ValueMember = "MaNhanVien";

        }
        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            loadLookUpEdit();
            if(themOrSua == 0)
            {
                txtMaKho.Enabled = false;
                txtMaKho.Text = K.MaKho;
                txtTenKho.Text = K.TenKho;
                lueQuanLy.EditValue = K.MaNguoiQuanLy;
                txtKyHieu.Text = K.KyHieu;
                txtNguoiLienHe.Text = K.NguoiLienHe;
                txtDiaChi.Text = K.DiaChi;
                txtFax.Text = K.Fax;
                txtSoDienThoai.Text = K.SoDienThoai;
                txtEmail.Text = K.Email;
                txtDienGiai.Text = K.DienGiai;
                if (K.ConQuanLy == true)
                {
                    chkConQuanLy.Checked = true;
                }
                else
                {
                    chkConQuanLy.Checked = false;
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            K.MaKho = txtMaKho.Text;
            K.TenKho = txtTenKho.Text;
            K.MaNguoiQuanLy = lueQuanLy.EditValue.ToString();
            K.KyHieu = txtKyHieu.Text;
            K.NguoiLienHe = txtNguoiLienHe.Text;
            K.DiaChi = txtDiaChi.Text;
            K.Fax = txtFax.Text;
            K.SoDienThoai = txtSoDienThoai.Text;
            K.Email = txtEmail.Text;
            K.DienGiai = txtDienGiai.Text;
            if (chkConQuanLy.Checked == true)
                K.ConQuanLy = true;
            else
            {
                if (chkConQuanLy.Checked == false)
                    K.ConQuanLy = false;
            }
            if (themOrSua == 1)
            {

                try
                {
                    bool f = khoBUS.ThemKhoBUS(ref err, K);
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
                    bool f = khoBUS.CapNhatKhoBUS(ref err, K);
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

    }
}
