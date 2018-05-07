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
    public partial class UCDonViTinh : UserControl
    {
        int themOrSua = 1;
        DonViO dv;
        DonViBUS donViBUS;
        public UCDonViTinh()
        {
            InitializeComponent();
            donViBUS = new DonViBUS();
            dv = new DonViO();
        }
        void loadData()
        {
            gridControlDonViTinh.DataSource = donViBUS.getAllDonVi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormDonViTinh frm = new FormDonViTinh(themOrSua, dv);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormDonViTinh frm = new FormDonViTinh(themOrSua, dv);
            frm.ShowDialog();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?",
                "Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string err = "";
                try
                {
                    bool f = donViBUS.XoaDonViBUS(ref err,dv);
                    if (f == true)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc. Loi: " + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong Xoa duoc. Loi: " + err);
                }
            }
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridViewDonViTinh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            dv.MaDonVi = gridViewDonViTinh.GetFocusedRowCellValue(colMaDonVi).ToString();
            dv.TenDonVi = gridViewDonViTinh.GetFocusedRowCellValue(colTenDonVi).ToString();
            dv.GhiChu = gridViewDonViTinh.GetFocusedRowCellValue(colGhiChu).ToString();
            dv.ConQuanLy = Convert.ToBoolean(gridViewDonViTinh.GetFocusedRowCellValue(colConQuanLy));
        }

        private void UCDonViTinh_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
