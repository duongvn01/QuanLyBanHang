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
    public partial class UCKhachHang : UserControl
    {
        int themOrSua = 1;
        KhachHangO kh;
        KhachHangBUS khachHangBUS;
        public UCKhachHang()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
            kh = new KhachHangO();
        }
        void loadData()
        {
            gridControlKhachHang.DataSource = khachHangBUS.getAllKhachHang();        
        }
        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormKhachHang frm = new FormKhachHang(themOrSua, kh);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormKhachHang frm = new FormKhachHang(themOrSua, kh);
            frm.ShowDialog();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?",
                "Question",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result==DialogResult.OK)
            {
                string err = "";
                try
                {
                    bool f = khachHangBUS.XoaKhachHangBUS(ref err, kh);
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

        private void gridViewKhachHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            kh.MaKhachHang = gridViewKhachHang.GetFocusedRowCellValue(colMaKhachHang).ToString();
            kh.MaKhuVuc = gridViewKhachHang.GetFocusedRowCellValue(colMaKhuVuc).ToString();
            
            kh.TenKhachHang = gridViewKhachHang.GetFocusedRowCellValue(colTenKhachHang).ToString();
            kh.DiaChi = gridViewKhachHang.GetFocusedRowCellValue(colDiaChi).ToString();
            kh.Fax = gridViewKhachHang.GetFocusedRowCellValue(colFax).ToString();
            kh.SoDienThoai = gridViewKhachHang.GetFocusedRowCellValue(colDienThoai).ToString();
            kh.SoDiDong = gridViewKhachHang.GetFocusedRowCellValue(colDiDong).ToString();
            kh.NguoiLienHe = gridViewKhachHang.GetFocusedRowCellValue(colNguoiLienHe).ToString();
            kh.Email = gridViewKhachHang.GetFocusedRowCellValue(colEmail).ToString();
            kh.Website = gridViewKhachHang.GetFocusedRowCellValue(colWebsite).ToString();
            kh.MaSoThue = gridViewKhachHang.GetFocusedRowCellValue(colMaSoThue).ToString();
            kh.TaiKhoan = gridViewKhachHang.GetFocusedRowCellValue(colSoTaiKhoan).ToString();
            kh.NganHang = gridViewKhachHang.GetFocusedRowCellValue(colTenNganHang).ToString();
            kh.ConQuanLy = Convert.ToBoolean(gridViewKhachHang.GetFocusedRowCellValue(colConQuanLy));

        }
        
    }
}
