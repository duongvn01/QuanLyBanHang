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
    public partial class UCHangHoa : UserControl
    {
        int themOrSua = 1;
        HangHoaO hh;
        HangHoaBUS hangHoaBUS;
        public UCHangHoa()
        {
            InitializeComponent();
            hangHoaBUS = new HangHoaBUS();
            hh = new HangHoaO();
        }
        void loadData()
        {
            gridControlHangHoa.DataSource = hangHoaBUS.getAllHangHoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormHangHoa frm = new FormHangHoa(themOrSua, hh);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormHangHoa frm = new FormHangHoa(themOrSua, hh);
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
                    bool f = hangHoaBUS.XoaHangHoaBUS(ref err, hh);
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

        private void gridViewHangHoa_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            hh.MaHangHoa = gridViewHangHoa.GetFocusedRowCellValue(colMaHangHoa).ToString();
            hh.TenHangHoa = gridViewHangHoa.GetFocusedRowCellValue(colTenHangHoa).ToString();
            hh.MaKho =gridViewHangHoa.GetFocusedRowCellValue(colMaKho).ToString();
            hh.MaNhomHang = gridViewHangHoa.GetFocusedRowCellValue(colMaNhomHang).ToString();
            hh.MaVachNSX = gridViewHangHoa.GetFocusedRowCellValue(colMaVachNSX).ToString();
            hh.MaDonVi = gridViewHangHoa.GetFocusedRowCellValue(colMaDonVi).ToString();
            hh.XuatXu = gridViewHangHoa.GetFocusedRowCellValue(colXuatXu).ToString();
            hh.Thue = Convert.ToInt32(gridViewHangHoa.GetFocusedRowCellValue(colThue));
            hh.TonKhoToiThieu = Convert.ToInt32(gridViewHangHoa.GetFocusedRowCellValue(colTonKhoToiThieu));
            hh.TonHienTai = Convert.ToInt32(gridViewHangHoa.GetFocusedRowCellValue(colTonHienTai));
            hh.MaNhaCungCap = gridViewHangHoa.GetFocusedRowCellValue(colMaNhaCungCap).ToString();
            hh.GiaMua = Convert.ToDouble(gridViewHangHoa.GetFocusedRowCellValue(colGiaMua));
            hh.GiaBanSi = Convert.ToDouble(gridViewHangHoa.GetFocusedRowCellValue(colGiaBanSi));
            hh.GiaBanLe = Convert.ToDouble(gridViewHangHoa.GetFocusedRowCellValue(colGiaBanLe));
            hh.ConQuanLy = Convert.ToBoolean(gridViewHangHoa.GetFocusedRowCellValue(colConQuanLy));
        }

        private void UCHangHoa_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
