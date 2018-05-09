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
    public partial class FormNhomHang : Form
    {
        NhomHangO NH;
        NhomHangBUS nhomHangBUS;
        int themOrSua;
        public FormNhomHang()
        {
            InitializeComponent();
            themOrSua = 1;
            nhomHangBUS = new NhomHangBUS();
            NH = new NhomHangO();
        }
        public FormNhomHang(int themOrSua, NhomHangO nh)
        {
            this.themOrSua = themOrSua;
            InitializeComponent();
            nhomHangBUS = new NhomHangBUS();
            NH = nh;
        }

        private void FormNhomHang_Load(object sender, EventArgs e)
        {
            if (themOrSua == 0)
            {
                txtMaNhomHang.Enabled = false;
                txtMaNhomHang.Text = NH.MaNhomHang;
                txtTenNhomHang.Text = NH.TenNhomHang;
                txtGhiChu.Text = NH.GhiChu;

                if(NH.ConQuanLy==true)
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
            string err="";

            NH.MaNhomHang = txtMaNhomHang.Text;
            NH.TenNhomHang = txtTenNhomHang.Text;
            NH.GhiChu = txtGhiChu.Text;
               
            if (chkConQuanLy.Checked==true)
            {
                NH.ConQuanLy = true;
            }              
            else
            {
                    NH.ConQuanLy = false;
            }
            if(themOrSua==1)
            {               
                try
                {
                    
                    bool f = nhomHangBUS.ThemNhomHangBUS(ref err, NH);
                    if(f==true)
                    {
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong them duoc, Loi: "+err); 
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi: "+err);
                }
                
            }
            else
            {
              
                try
                {

                    bool f = nhomHangBUS.CapNhatNhomHangBUS(ref err, NH);
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
                    MessageBox.Show("Không sửa được. Lỗi: "+err);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
