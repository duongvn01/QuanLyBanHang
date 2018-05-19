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
public delegate void delSendToMuaHangObject(MuaHangO mh);

namespace QuanLyBanHang
{
    public partial class UCLichSuMuaHang : UserControl
    {
        PassData_CallTo displayData_There;

        MuaHangO MH;
        ChiTietPhieuMuaHangO CTPMH;

        MuaHangBUS muaHangBUS;
        NhaCungCapBUS nhaCungCapBUS;
        ChiTietPhieuMuaHangBUS chiTietPhieuMuaHangBUS;
        public UCLichSuMuaHang(PassData_CallTo displayData_There)
        {
            InitializeComponent();
            MH = new MuaHangO();
            CTPMH = new ChiTietPhieuMuaHangO();

            muaHangBUS = new MuaHangBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            chiTietPhieuMuaHangBUS = new ChiTietPhieuMuaHangBUS();

            this.displayData_There = displayData_There;
        }
        void loadData()
        {
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHang();
        }
        void loadLookUpEdit()
        {
            lueNhaCungCap.Properties.DataSource = nhaCungCapBUS.getAllNhaCungCap();
            lueNhaCungCap.Properties.DisplayMember = "TenNhaCungCap";
            lueNhaCungCap.Properties.ValueMember = "MaNhaCungCap";
  
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDatDau = Convert.ToDateTime(deNgayBatDau.Text);
            DateTime ngayKetThuc = Convert.ToDateTime(deNgayKetThuc.Text);
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHangByNgayNayNgayKiaBUS(ngayDatDau,ngayKetThuc);
        }

        private void lueNhaCungCap_EditValueChanged(object sender, EventArgs e)
        {
            MH.MaNhaCungCap = lueNhaCungCap.EditValue.ToString();
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHangByMaNhaCungCapBUS(MH);
        }

        private void UCLichSuMuaHang_Load(object sender, EventArgs e)
        {
            loadData();
            loadLookUpEdit();
        }

        private void gridViewLichSuMuaHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            MH.MaPhieu = gridViewLichSuMuaHang.GetFocusedRowCellValue(colMaPhieu).ToString();
            CTPMH.MaPhieu = gridViewLichSuMuaHang.GetFocusedRowCellValue(colMaPhieu).ToString();

            if (displayData_There != null) //checks to make sure not null
            {
                displayData_There(MH.MaPhieu); //pass the data over to the other UserControl          
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
                    bool f = muaHangBUS.XoaMuaHangBUS(ref err, MH);
                    bool f1 = chiTietPhieuMuaHangBUS.XoaChiTietPhieuMuaHangByMaPhieuBUS(ref err, CTPMH);
                    if (f == true)
                    {
                        MessageBox.Show("Xoa thanh cong muahang");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc mua hang. Loi: " + err);
                    }
                    if (f1 == true)
                    {
                        MessageBox.Show("Xoa thanh cong chitietphieumuahang");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc chitietphieumuahang. Loi: " + err);
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
