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
    public partial class FormKhachHang : Form
    {
        KhachHangO KH;
        KhachHangBUS khachHangBUS;
        KhuVucBUS khuVucBUS;
        int themOrSua;
        public FormKhachHang()
        {
            InitializeComponent();
            themOrSua = 1;
            khuVucBUS = new KhuVucBUS();

            // load lookupEdit khu vuc
            lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
            lueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lueKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }
        public FormKhachHang(int themOrSua, KhachHangO kh)
        {
            InitializeComponent();
            this.themOrSua = themOrSua;
            khachHangBUS = new KhachHangBUS();
            khuVucBUS = new KhuVucBUS();
            KH = kh;
            // load lookupEdit khu vuc
            lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
            lueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lueKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }
        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            FormKhuVuc frm = new FormKhuVuc();
            frm.ShowDialog();
        }

        private void cbKhuVuc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            KH.MaKhachHang = txtMaKhachHang.Text;
            KH.TenKhachHang = txtTenKhachHang.Text;
            //?
            KH.MaKhuVuc = lueKhuVuc.EditValue.ToString();

            KH.DiaChi = txtDiaChi.Text;
            KH.MaSoThue = txtMaSoThue.Text;
            KH.Fax = txtFax.Text;
            KH.SoDienThoai = txtSoDienThoai.Text;
            KH.SoDiDong = txtSoDiDong.Text;
            KH.Email = txtEmail.Text;
            KH.Website = txtWebsite.Text;
            KH.TaiKhoan = txtTaiKhoan.Text;
            KH.NganHang = txtNganHang.Text;
            try
            {
                KH.MaKhuVuc = lueKhuVuc.EditValue.ToString();
            }
            catch
            {
                MessageBox.Show("Điền thông tin cho khu vực");
            }
            if(txtGioiHanNo.Text!="")
            {
                KH.GioiHanNo = Convert.ToInt32(txtGioiHanNo.Text);
            }
            if(txtChietKhau.Text!="")
            {
                KH.ChietKhau = Convert.ToInt32(txtChietKhau.Text);
            }
            if(txtNoHienTai.Text!="")
            {
                KH.NoHienTai = Convert.ToInt32(txtNoHienTai.Text);
            }         
            KH.NguoiLienHe = txtNguoiLienHe.Text;
            KH.ThongTinKhac = txtThongTinKhac.Text;

            if (chkConQuanLy.Checked == true)
            {
                KH.ConQuanLy=true;
            }
            else
            {
                if (chkConQuanLy.Checked == false)
                    KH.ConQuanLy = false;
            }
            if (radioGroupDaiLyKhachLe.SelectedIndex == 0)
            {
                KH.SiOrLe = true;
            }
            else
            {
                KH.SiOrLe = false;
            }

            if (themOrSua == 1)
            {

                try
                {
                    bool f = khachHangBUS.ThemKhachHangBUS(ref err, KH);
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
                    bool f = khachHangBUS.CapNhatKhachHangBUS(ref err, KH);
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

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            if (themOrSua == 0)
            {
                if(KH.SiOrLe==true)
                {
                    radioGroupDaiLyKhachLe.SelectedIndex=0;
                }
                else
                {
                    radioGroupDaiLyKhachLe.SelectedIndex=1;
                }
                if(KH.ConQuanLy==true)
                {
                    chkConQuanLy.Checked=true;
                }
                else
                {
                    chkConQuanLy.Enabled=false;
                }
                txtMaKhachHang.Enabled = false;
                txtMaKhachHang.Text = KH.MaKhachHang;
                
                //?
                lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
                lueKhuVuc.EditValue = KH.MaKhuVuc;

                txtTenKhachHang.Text = KH.TenKhachHang;
                txtDiaChi.Text = KH.DiaChi;
                txtMaSoThue.Text = KH.MaSoThue;
                txtFax.Text = KH.Fax;
                txtSoDienThoai.Text = KH.SoDienThoai;
                txtSoDiDong.Text = KH.SoDiDong;
                txtEmail.Text = KH.Email;
                txtWebsite.Text = KH.Website;
                txtTaiKhoan.Text = KH.TaiKhoan;
                txtNganHang.Text = KH.NganHang;
                txtGioiHanNo.Text = KH.GioiHanNo.ToString();
                txtNoHienTai.Text = KH.NoHienTai.ToString();
                txtChietKhau.Text = KH.ChietKhau.ToString();
                txtNguoiLienHe.Text = KH.NguoiLienHe;
                txtThongTinKhac.Text = KH.ThongTinKhac;
               
            }
        }
        private void lueKhuVuc_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            lueKhuVuc.Properties.DataSource = khuVucBUS.getAllKhuVuc();
            lueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lueKhuVuc.Properties.ValueMember = "MaKhuVuc";
            */
        }

        private void lueKhuVuc_EditValueChanged(object sender, EventArgs e)
        {
            KH.MaKhuVuc = lueKhuVuc.EditValue.ToString();
        }
            
        
    }
}
