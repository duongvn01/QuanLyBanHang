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
public delegate void delSendToBanHangObject(BanHangO bh);

namespace QuanLyBanHang
{
    public partial class UCLichSuBanHang : UserControl
    {
       
        PassData_CallTo displayData_There;

        BanHangO BH;
        ChiTietPhieuBanHangO CTPBH;

        BanHangBUS banHangBUS;
        KhachHangBUS khachHangBUS;
        ChiTietPhieuBanHangBUS chiTietPhieuBanHangBUS;
        public UCLichSuBanHang(PassData_CallTo displayData_There)
        {
            InitializeComponent();
            BH = new BanHangO();
            CTPBH = new ChiTietPhieuBanHangO();

            banHangBUS = new BanHangBUS();
            khachHangBUS = new KhachHangBUS();
            chiTietPhieuBanHangBUS = new ChiTietPhieuBanHangBUS();
            this.displayData_There = displayData_There;
        }
        void loadData()
        {
            gridControlLichSuBanHang.DataSource = banHangBUS.getAllBanHang();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDatDau = Convert.ToDateTime(deNgayBatDau.Text);
            DateTime ngayKetThuc = Convert.ToDateTime(deNgayKetThuc.Text);
            gridControlLichSuBanHang.DataSource = banHangBUS.getAllBanHangByNgayNayNgayKiaBUS(ngayDatDau, ngayKetThuc);
        }

        private void UCLichSuBanHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridViewLichSuBanHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            BH.MaPhieuBan = gridViewLichSuBanHang.GetFocusedRowCellValue(colMaPhieuBan).ToString();
            CTPBH.MaPhieuBan = gridViewLichSuBanHang.GetFocusedRowCellValue(colMaPhieuBan).ToString();
            if (displayData_There != null) //checks to make sure not null
            {
                displayData_There(BH.MaPhieuBan); //pass the data over to the other UserControl          
            }
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
                    bool f = banHangBUS.XoaBanHangBUS(ref err, BH);
                    bool f1 = chiTietPhieuBanHangBUS.XoaChiTietPhieuBanHangByMaPhieuBUS(ref err, CTPBH);
                    if (f == true)
                    {
                        MessageBox.Show("Xoa thanh cong ban hang");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc ban hang. Loi: " + err);
                    }
                    if (f1 == true)
                    {
                        MessageBox.Show("Xoa thanh cong chitietphieubanhang");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc chitietphieubanhang. Loi: " + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong Xoa duoc. Loi: " + err);
                }
            }           
        }
        
        
    }
}
