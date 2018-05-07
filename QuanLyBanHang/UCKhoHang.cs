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
    public partial class UCKhoHang : UserControl
    {
        int themOrSua = 1;
        KhoO k;
        KhoBUS khoBUS;
        public UCKhoHang()
        {
            InitializeComponent();
            khoBUS = new KhoBUS();
            k = new KhoO();           
        }
        void loadData()
        {
            gridControlKhoHang.DataSource = khoBUS.getAllKhoBUS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormKhoHang frm = new FormKhoHang(themOrSua, k);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormKhoHang frm = new FormKhoHang(themOrSua, k);
            frm.ShowDialog();
            loadData();
        }

        private void UCKhoHang_Load(object sender, EventArgs e)
        {
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
                    bool f = khoBUS.XoaKhoBUS(ref err, k);
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

        private void gridViewKhoHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            k.MaKho = gridViewKhoHang.GetFocusedRowCellValue(colMaKho).ToString();
            k.TenKho = gridViewKhoHang.GetFocusedRowCellValue(colTenKho).ToString();
            k.MaNguoiQuanLy = gridViewKhoHang.GetFocusedRowCellValue(colMaNguoiQuanLy).ToString();
            k.KyHieu = gridViewKhoHang.GetFocusedRowCellValue(colKyHieu).ToString();
            k.NguoiLienHe = gridViewKhoHang.GetFocusedRowCellValue(colNguoiLienHe).ToString();
            k.DiaChi = gridViewKhoHang.GetFocusedRowCellValue(colDiaChi).ToString();
            k.Fax = gridViewKhoHang.GetFocusedRowCellValue(colFax).ToString();
            k.SoDienThoai = gridViewKhoHang.GetFocusedRowCellValue(colSoDienThoai).ToString();
            k.Email = gridViewKhoHang.GetFocusedRowCellValue(colEmail).ToString();
            k.DienGiai = gridViewKhoHang.GetFocusedRowCellValue(colDienGiai).ToString();
            k.ConQuanLy = Convert.ToBoolean(gridViewKhoHang.GetFocusedRowCellValue(colConQuanLy));
        }
    }
}
