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
    public partial class UCNhomHang : UserControl
    {

        int themOrSua = 1;
        NhomHangO nh;
        NhomHangBUS nhomHangBUS;
        public UCNhomHang()
        {
            InitializeComponent();
            nhomHangBUS = new NhomHangBUS();
            nh = new NhomHangO();

        }
        void loadData()
        {
            gridControlNhomHang.DataSource = nhomHangBUS.getAllNhomHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormNhomHang frm = new FormNhomHang(themOrSua, nh);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormNhomHang frm = new FormNhomHang(themOrSua, nh);
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
                    bool f = nhomHangBUS.XoaNhomHangBUS(ref err, nh);
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

        private void UCNhomHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridViewNhomHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            nh.MaNhomHang = gridViewNhomHang.GetFocusedRowCellValue(colMaNhomHang).ToString();
            nh.TenNhomHang = gridViewNhomHang.GetFocusedRowCellValue(colTenNhomHang).ToString();
            nh.GhiChu = gridViewNhomHang.GetFocusedRowCellValue(colGhiChu).ToString();
            nh.ConQuanLy = Convert.ToBoolean(gridViewNhomHang.GetFocusedRowCellValue(colConQuanLy));
        }
    }
}
