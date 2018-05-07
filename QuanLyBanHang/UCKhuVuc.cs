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
    public partial class UCKhuVuc : UserControl
    {
        int themOrSua = 1;
        KhuVucO kv;
        KhuVucBUS khuVucBUS;
        public UCKhuVuc()
        {
            InitializeComponent();
            khuVucBUS = new KhuVucBUS();
            kv = new KhuVucO();
        }
        void loadData()
        {
            gridControlKhuVuc.DataSource = khuVucBUS.getAllKhuVuc();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themOrSua = 1;
            FormKhuVuc frm = new FormKhuVuc(themOrSua,kv);
            frm.ShowDialog();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themOrSua = 0;

            FormKhuVuc frm = new FormKhuVuc(themOrSua,kv);
            frm.ShowDialog();
            loadData();
        }

        private void UCKhuVuc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridViewKhuVuc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            kv.MaKhuVuc = gridViewKhuVuc.GetFocusedRowCellValue(colMaKhuVuc).ToString();
            kv.TenKhuVuc = gridViewKhuVuc.GetFocusedRowCellValue(colTenKhuVuc).ToString();
            kv.GhiChu = gridViewKhuVuc.GetFocusedRowCellValue(colGhiChu).ToString();
            kv.ConQuanLy = Convert.ToBoolean(gridViewKhuVuc.GetFocusedRowCellValue(colConQuanLy));
            
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
                    bool f = khuVucBUS.XoaKhuVucBUS(ref err, kv);
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


    }
}
