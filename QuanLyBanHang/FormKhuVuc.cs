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
    public partial class FormKhuVuc : Form
    {
        KhuVucO KV;
        KhuVucBUS khuVucBUS;
        int themOrSua;
        public FormKhuVuc()
        {
            InitializeComponent();
            themOrSua = 1;
        }
        public FormKhuVuc(int themOrSua,KhuVucO kv)
        {
            this.themOrSua = themOrSua;
            khuVucBUS = new KhuVucBUS();
            //KV = new KhuVucO();
            KV = kv;
            InitializeComponent();
        }

        private void FormKhuVuc_Load(object sender, EventArgs e)
        {
            if (themOrSua == 0)
            {
                txtMaKhuVuc.Enabled = false;
                txtMaKhuVuc.Text = KV.MaKhuVuc;
                txtTenKhuVuc.Text = KV.TenKhuVuc;
                txtGhiChu.Text = KV.GhiChu;
                if(KV.ConQuanLy==true)
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
            KV.MaKhuVuc = txtMaKhuVuc.Text;
            KV.TenKhuVuc = txtTenKhuVuc.Text;
            KV.GhiChu = txtGhiChu.Text;
            if (chkConQuanLy.Checked==true)
                KV.ConQuanLy = true;
            else
            {
                if(chkConQuanLy.Checked==false)
                    KV.ConQuanLy = false;
            }
            if(themOrSua==1)
            {
               
                try
                {
                    bool f = khuVucBUS.ThemKhuVucBUS(ref err, KV);
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
                    bool f = khuVucBUS.CapNhatKhuVucBUS(ref err, KV);
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
