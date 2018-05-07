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
    public partial class FormDonViTinh : Form
    {

        DonViO DV;
        DonViBUS donViBUS;
        int themOrSua;
        public FormDonViTinh()
        {
            InitializeComponent();
            themOrSua = 1;
        }
        public FormDonViTinh(int themOrSua, DonViO dv)
        {
            this.themOrSua = themOrSua;
            InitializeComponent();
            donViBUS = new DonViBUS();
            DV = dv;
        }

        private void FormDonViTinh_Load(object sender, EventArgs e)
        {
            if (themOrSua == 0)
            {

                txtMaDonVi.Enabled = false;
                txtMaDonVi.Text = DV.MaDonVi;
                txtTenDonVi.Text = DV.TenDonVi;
                txtGhiChu.Text = DV.GhiChu;
                if(DV.ConQuanLy==true)
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

            DV.MaDonVi = txtMaDonVi.Text;
            DV.TenDonVi = txtTenDonVi.Text;
            DV.GhiChu = txtGhiChu.Text;
               
            if (chkConQuanLy.Checked==true)
            {
                DV.ConQuanLy = true;
            }              
            else
            {
                    DV.ConQuanLy = false;
            }
            if(themOrSua==1)
            {               
                try
                {
                    bool f = donViBUS.ThemDonViBUS(ref err,DV);
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
                    bool f = donViBUS.CapNhatDonViBUS(ref err,DV);
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
