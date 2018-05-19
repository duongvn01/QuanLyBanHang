using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraEditors;
using Object;
namespace QuanLyBanHang
{
    public delegate void PassData_CallTo(string textBoxData); 
    public partial class FormMain : DevExpress.XtraBars.TabForm
    {
        MuaHangO MH;
        UCMuaHang ucmh;
        UCLichSuMuaHang uclsmh;
        public FormMain()
        {
            InitializeComponent();
            MH = new MuaHangO();

            ucmh = new UCMuaHang();
            uclsmh = new UCLichSuMuaHang(new PassData_CallTo(ucmh.textBoxChange));
        }

        private void barbtnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCKhuVuc kv = new UCKhuVuc();
            panel1.Controls.Clear();
            panel1.Controls.Add(kv);
        }

        private void barbtnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCKhachHang kh = new UCKhachHang();
            panel1.Controls.Clear();
            panel1.Controls.Add(kh);
        }

        private void barbtnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCNhaCungCap ncc = new UCNhaCungCap();
            panel1.Controls.Clear();
            panel1.Controls.Add(ncc);
        }

        private void barbtnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCBoPhan bp = new UCBoPhan();
            panel1.Controls.Clear();
            panel1.Controls.Add(bp);
        }

        private void barbtnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCNhanVien nv = new UCNhanVien();
            panel1.Controls.Clear();
            panel1.Controls.Add(nv);
        }

        private void barbtnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCKhoHang k = new UCKhoHang();
            panel1.Controls.Clear();
            panel1.Controls.Add(k);
        }

        private void barbtnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCDonViTinh dvt = new UCDonViTinh();
            panel1.Controls.Clear();
            panel1.Controls.Add(dvt);
        }

        private void barbtnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCNhomHang nh = new UCNhomHang();
            panel1.Controls.Clear();
            panel1.Controls.Add(nh);
        }

        private void barbtnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCHangHoa hh = new UCHangHoa();
            panel1.Controls.Clear();
            panel1.Controls.Add(hh);
        }

        private void barbtnMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucmh = new UCMuaHang();
            uclsmh = new UCLichSuMuaHang(new PassData_CallTo(ucmh.textBoxChange));

            panel1.Controls.Clear();
            panel1.Controls.Add(ucmh);
           
            ucmh.Width = 1025;
            ucmh.Height = 530;
            btnLichSuMuaHang.Visible = true;
            btnSua.Visible = true;

            panel1.Controls.Add(uclsmh);
            uclsmh.Width = 0;
            uclsmh.Height = 0;
        }

        private void barbtnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCTonKho tk = new UCTonKho();
            panel1.Controls.Add(tk);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(ucmh);
            panel1.Controls.Add(uclsmh);
            uclsmh.Location = new System.Drawing.Point(0, 0);
            uclsmh.Location = new System.Drawing.Point(0, 0);

            uclsmh.Width = 0;
            uclsmh.Height = 0;
            ucmh.Width = 0;
            ucmh.Height = 0;
        }

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {

            uclsmh.Width = 1000;
            uclsmh.Height = 450;

            ucmh.Width = 0;
            ucmh.Height = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {         
            panel1.Controls.Clear();
            panel1.Controls.Add(ucmh);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(uclsmh);
            panel1.Controls.Add(ucmh);
            uclsmh.Location = new System.Drawing.Point(0, 0);
            uclsmh.Width = 0;
            uclsmh.Height = 0;

            ucmh.Location = new System.Drawing.Point(0, 0);
            ucmh.Width = 1025;
            ucmh.Height = 530;



        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
