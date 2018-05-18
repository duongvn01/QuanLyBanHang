using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bussiness_Logic_Layer;
using Object;

namespace QuanLyBanHang
{
    public partial class UCLichSuMuaHang : UserControl
    {
        MuaHangO MH;
        MuaHangBUS muaHangBUS;
        NhaCungCapBUS nhaCungCapBUS;

        public UCLichSuMuaHang()
        {
            InitializeComponent();
            MH = new MuaHangO();
            muaHangBUS = new MuaHangBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
        }
        void loadData()
        {
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHang();
        }
        void loadLookUpEdit()
        {
            lueNhaCungCap.Properties.DataSource = nhaCungCapBUS.getAllNhaCungCap();
            lueNhaCungCap.Properties.DisplayMember = "TenNhaCungCap";
            lueNhaCungCap.Properties.ValueMember = "MaNhaCungCap";
  
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDatDau = Convert.ToDateTime(deNgayBatDau.Text);
            DateTime ngayKetThuc = Convert.ToDateTime(deNgayKetThuc.Text);
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHangByNgayNayNgayKiaBUS(ngayDatDau,ngayKetThuc);
        }

        private void lueNhaCungCap_EditValueChanged(object sender, EventArgs e)
        {
            MH.MaNhaCungCap = lueNhaCungCap.EditValue.ToString();
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHangByMaNhaCungCapBUS(MH);
        }

        private void UCLichSuMuaHang_Load(object sender, EventArgs e)
        {
            loadData();
            loadLookUpEdit();
        }

        private void gridViewLichSuMuaHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            MH.MaPhieu = gridViewLichSuMuaHang.GetFocusedRowCellValue(colMaPhieu).ToString();
            UCMuaHang ucmh = new UCMuaHang();
            ucmh.SendToMuaHang(MH.MaPhieu);
        }
    }
}
