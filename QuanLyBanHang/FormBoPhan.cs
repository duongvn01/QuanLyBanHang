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
    public partial class FormBoPhan : Form
    {
        BoPhanO BP;
        BoPhanBUS boPhanBUS;
        int themOrSua;
        public FormBoPhan()
        {
            InitializeComponent();
            themOrSua = 1;
            boPhanBUS = new BoPhanBUS();
            BP = new BoPhanO();
        }
        public FormBoPhan(int themOrSua, BoPhanO bp)
        {
            InitializeComponent();
            this.themOrSua = themOrSua;
            boPhanBUS = new BoPhanBUS();
            BP = new BoPhanO();
            BP = bp;           
        }

        private void FormBoPhan_Load(object sender, EventArgs e)
        {
            if (themOrSua == 0)
            {

                txtMaBoPhan.Enabled = false;
                txtMaBoPhan.Text = BP.MaBoPhan;
                txtTenBoPhan.Text = BP.TenBoPhan;
                txtGhiChu.Text = BP.GhiChu;
                if (BP.ConQuanLy == true)
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
            BP.MaBoPhan = txtMaBoPhan.Text;
            BP.TenBoPhan = txtTenBoPhan.Text;
            BP.GhiChu = txtGhiChu.Text;
            if (chkConQuanLy.Checked == true)
                BP.ConQuanLy = true;
            else
            {
                    BP.ConQuanLy = false;
            }
            if (themOrSua == 1)
            {

                try
                {                
                    bool f = boPhanBUS.ThemBoPhanBUS(ref err, BP);
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
                    bool f = boPhanBUS.CapNhatBoPhanBUS(ref err,BP);
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
