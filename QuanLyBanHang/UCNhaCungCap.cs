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
    public partial class UCNhaCungCap : UserControl
    {
        int themOrSua = 1;
        NhaCungCapO ncc;
        NhaCungCapBUS nhaCungCapBUS;
        public UCNhaCungCap()
        {
            InitializeComponent();
            nhaCungCapBUS = new NhaCungCapBUS();
            ncc = new NhaCungCapO();
        }
        void loadData()
        {
            gridControlNhaCungCap.DataSource = nhaCungCapBUS.getAllNhaCungCap();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormNhaCungCap frm = new FormNhaCungCap(themOrSua, ncc);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormNhaCungCap frm = new FormNhaCungCap(themOrSua,ncc);
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
                    bool f = nhaCungCapBUS.XoaNhaCungCapBUS(ref err, ncc);
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

        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridViewNhaCungCap_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            ncc.MaNhaCungCap = gridViewNhaCungCap.GetFocusedRowCellValue(colMaNhaCungCap).ToString();
            ncc.TenNhaCungCap = gridViewNhaCungCap.GetFocusedRowCellValue(colTenNhaCungCap).ToString();
            ncc.MaKhuVuc = gridViewNhaCungCap.GetFocusedRowCellValue(colMaKhuVuc).ToString();
            ncc.DiaChi = gridViewNhaCungCap.GetFocusedRowCellValue(colDiaChi).ToString();
            ncc.MaSoThue = gridViewNhaCungCap.GetFocusedRowCellValue(colMaSoThue).ToString();
            ncc.Fax = gridViewNhaCungCap.GetFocusedRowCellValue(colFax).ToString();
            ncc.SoDienThoai = gridViewNhaCungCap.GetFocusedRowCellValue(colDienThoai).ToString();
            ncc.SoDiDong = gridViewNhaCungCap.GetFocusedRowCellValue(colDiDong).ToString();
            ncc.Email = gridViewNhaCungCap.GetFocusedRowCellValue(colEmail).ToString();
            ncc.Website = gridViewNhaCungCap.GetFocusedRowCellValue(colWebsite).ToString();
            ncc.TaiKhoan = gridViewNhaCungCap.GetFocusedRowCellValue(colSoTaiKhoan).ToString();
            ncc.NganHang = gridViewNhaCungCap.GetFocusedRowCellValue(colTenNganHang).ToString();
            ncc.GioiHanNo = Convert.ToDouble(gridViewNhaCungCap.GetFocusedRowCellValue(colGioiHanNo));
           
            ncc.NoHienTai = Convert.ToDouble(gridViewNhaCungCap.GetFocusedRowCellValue(colNoHienTai));
            ncc.ChietKhau = Convert.ToInt32(gridViewNhaCungCap.GetFocusedRowCellValue(colChietKhau));
            ncc.NguoiLienHe = gridViewNhaCungCap.GetFocusedRowCellValue(colNguoiLienHe).ToString();
            ncc.ChucVu = gridViewNhaCungCap.GetFocusedRowCellValue(colChucVu).ToString();
            ncc.ThongTinKhac = gridViewNhaCungCap.GetFocusedRowCellValue(colThongTinKhac).ToString();
            ncc.ConQuanLy = Convert.ToBoolean(gridViewNhaCungCap.GetFocusedRowCellValue(colConQuanLy));
        }
    }
}
