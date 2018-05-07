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
        }
        void loadLookUpEdit()
        {
            //load look up edit kho
            lueKho.Properties.DataSource = khoBUS.getAllKhoBUS();
            lueKho.Properties.DisplayMember = "TenKho";
            lueKho.Properties.ValueMember = "MaKho";

            //Nhom Hang
            lueKho.Properties.DataSource = nhomHangBUS.getAllNhomHang();
            lueKho.Properties.DisplayMember = "TenNhomHang";
            lueKho.Properties.ValueMember = "MaNhomHang";

            //Don Vi
            lueKho.Properties.DataSource = donViBUS.getAllDonVi();
            lueKho.Properties.DisplayMember = "TenDonVi";
            lueKho.Properties.ValueMember = "MaDonVi";

            //Nha Cung Cap
            lueKho.Properties.DataSource = nhaCungCapBUS.getAllNhaCungCap();
            lueKho.Properties.DisplayMember = "TenNhaCungCap";
            lueKho.Properties.ValueMember = "MaNhaCungCap";
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

                /*if (HH.ConQuanLy == true)
                {
                    chkConQuanLy.Checked = true;
                }
                else
                {
                    chkConQuanLy.Checked = false;
                }*/
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {/*
            string err = "";
            K.MaKho = txtMaKho.Text;
            K.TenKho = txtTenKho.Text;
            K.MaNguoiQuanLy = lueQuanLy.EditValue.ToString();
            K.KyHieu = txtKyHieu.Text;
            K.NguoiLienHe = txtNhaCungCap.Text;
            K.DiaChi = txtDiaChi.Text;
            K.Fax = txtFax.Text;
            K.SoDienThoai = txtSoDienThoai.Text;
            K.Email = txtXuatXu.Text;
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
            }*/
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
