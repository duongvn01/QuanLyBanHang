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
    public partial class UCNhanVien : UserControl
    {

        int themOrSua = 1;
        NhanVienO nv;
        NhanVienBUS nhanVienBUS;
        public UCNhanVien()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
            nv = new NhanVienO();
        }
        void loadData()
        {
            gridControlNhanVien.DataSource = nhanVienBUS.getAllNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormNhanVien frm = new FormNhanVien(themOrSua, nv);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormNhanVien frm = new FormNhanVien(themOrSua, nv);
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
                    bool f = nhanVienBUS.XoaNhanVienBUS(ref err, nv);
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

        private void gridViewNhanVien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            nv.MaNhanVien = gridViewNhanVien.GetFocusedRowCellValue(colMaNhanVien).ToString();
            nv.TenNhanVien = gridViewNhanVien.GetFocusedRowCellValue(colTenNhanVien).ToString();
            nv.ChucVu = gridViewNhanVien.GetFocusedRowCellValue(colChucVu).ToString();
            nv.DiaChi = gridViewNhanVien.GetFocusedRowCellValue(colDiaChi).ToString();
            nv.SoDienThoai = gridViewNhanVien.GetFocusedRowCellValue(colDienThoai).ToString();
            nv.SoDiDong = gridViewNhanVien.GetFocusedRowCellValue(colDiDong).ToString();
            nv.Email = gridViewNhanVien.GetFocusedRowCellValue(colEmail).ToString();
            nv.MaBoPhan = gridViewNhanVien.GetFocusedRowCellValue(colMaBoPhan).ToString();
            nv.MaNguoiQuanLy = gridViewNhanVien.GetFocusedRowCellValue(colMaNguoiQuanLy).ToString();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
