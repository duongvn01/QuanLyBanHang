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
    public partial class FormNhanVien : Form
    {
        NhanVienO NV;
        NhanVienBUS nhanVienBUS;
        BoPhanBUS boPhanBUS;
        int themOrSua;
        public FormNhanVien()
        {
            InitializeComponent();
            themOrSua = 1;
            nhanVienBUS = new NhanVienBUS();
            boPhanBUS = new BoPhanBUS();
            //loadLookUpEdit();
        }
        public FormNhanVien(int themOrSua, NhanVienO nv)
        {
            InitializeComponent();
            this.themOrSua = themOrSua;
            nhanVienBUS = new NhanVienBUS();
            boPhanBUS = new BoPhanBUS();
            NV = nv;
                   
        }

        void loadLookUpEdit()
        {
            // load lookupEdit Bo phan
            lueBoPhan.Properties.DataSource = boPhanBUS.getAllBoPhan();
            lueBoPhan.Properties.DisplayMember = "TenBoPhan";
            lueBoPhan.Properties.ValueMember = "MaBoPhan";

            //load lookEdit QuanLy(NhanVien)
            lueQuanLy.Properties.DataSource = nhanVienBUS.getAllNhanVien();
            lueQuanLy.Properties.DisplayMember = "TenNhanVien";
            lueQuanLy.Properties.ValueMember = "MaNhanVien";
        }
        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            FormBoPhan frm = new FormBoPhan();
            frm.ShowDialog();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            NV.MaNhanVien = txtMaNhanVien.Text;
            NV.TenNhanVien = txtTenNhanVien.Text;
            NV.ChucVu = txtChucVu.Text;
            NV.DiaChi = txtDiaChi.Text;
            NV.SoDienThoai = txtSoDienThoai.Text;
            NV.SoDiDong = txtSoDiDong.Text;
            NV.Email = txtEmail.Text;
            if (lueBoPhan.EditValue==null)
            {
                NV.MaBoPhan = "";
            }
            else
            {
                NV.MaBoPhan = lueBoPhan.EditValue.ToString();
            }
            if (lueQuanLy.EditValue==null)
            {
                NV.MaNguoiQuanLy = "";
            }
                
            else
            {
                NV.MaNguoiQuanLy = lueQuanLy.EditValue.ToString(); 
            }
            
            
            if (chkConQuanLy.Checked == true)
            {
                NV.ConQuanLy = true;
            }
            else
            {
                NV.ConQuanLy = false;
            }
            if (themOrSua == 1)
            {

                try
                {
                    bool f = nhanVienBUS.ThemNhanVienBUS(ref err, NV);
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
                    bool f = nhanVienBUS.CapNhatNhanVienBUS(ref err, NV);
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

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadLookUpEdit(); 
            if (themOrSua == 0)
            {
                
                if (NV.ConQuanLy == true)
                {
                    chkConQuanLy.Checked = true;
                }
                else
                {
                    chkConQuanLy.Checked = false;
                }

                txtMaNhanVien.Enabled = false;
                txtMaNhanVien.Text = NV.MaNhanVien;
                txtTenNhanVien.Text = NV.TenNhanVien;
                txtChucVu.Text = NV.ChucVu;
                txtDiaChi.Text = NV.DiaChi;
                txtSoDienThoai.Text = NV.SoDienThoai;
                txtSoDiDong.Text = NV.SoDiDong;
                txtEmail.Text = NV.Email;
                lueBoPhan.EditValue = NV.MaBoPhan;
                lueQuanLy.EditValue = NV.MaNguoiQuanLy;

            }
        }
    }
}
