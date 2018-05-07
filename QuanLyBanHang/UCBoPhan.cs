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
    public partial class UCBoPhan : UserControl
    {

        int themOrSua = 1;
        BoPhanO bp;
        BoPhanBUS boPhanBUS;
        public UCBoPhan()
        {
            InitializeComponent();
            boPhanBUS = new BoPhanBUS();
            bp = new BoPhanO();
        }
        void loadData()
        {
            gridControlBoPhan.DataSource = boPhanBUS.getAllBoPhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormBoPhan frm = new FormBoPhan(themOrSua, bp);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;
            FormBoPhan frm = new FormBoPhan(themOrSua, bp);
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
                    bool f = boPhanBUS.XoaBoPhanBUS(ref err, bp);
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

        private void gridViewBoPhan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {          
            bp.MaBoPhan = gridViewBoPhan.GetFocusedRowCellValue(colMaBoPhan).ToString();
            bp.TenBoPhan = gridViewBoPhan.GetFocusedRowCellValue(colTenBoPhan).ToString();
            bp.GhiChu = gridViewBoPhan.GetFocusedRowCellValue(colGhiChu).ToString();
            bp.ConQuanLy = Convert.ToBoolean(gridViewBoPhan.GetFocusedRowCellValue(colConQuanLy));
        }

        private void UCBoPhan_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
