using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormMain : DevExpress.XtraBars.TabForm
    {
        public FormMain()
        {
            InitializeComponent();
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
            UCMuaHang mh = new UCMuaHang();
            panel1.Controls.Clear();
            panel1.Controls.Add(mh);
        }

        private void barbtnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCTonKho tk = new UCTonKho();
            panel1.Controls.Clear();
            panel1.Controls.Add(tk);
        }
    }
}
