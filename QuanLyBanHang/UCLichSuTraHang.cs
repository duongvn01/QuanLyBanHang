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
    public partial class UCLichSuTraHang : UserControl
    {
        UCTraHang2 ucth;
        TraHangO TH;
        KhachHangO KH;
        ChiTietTraHangO CTTH;
        TonKhoO TK;

        TraHangBUS traHangBUS;
        KhachHangBUS khachHangBUS;
        ChiTietPhieuTraHangBUS chiTietPhieuTraHangBUS;
        TonKhoBUS tonKhoBUS;
        public UCLichSuTraHang()
        {
            InitializeComponent();
            ucth = new UCTraHang2();

            KH = new KhachHangO();
            TH = new TraHangO();
            CTTH = new ChiTietTraHangO();
            TK = new TonKhoO();

            traHangBUS = new TraHangBUS();
            khachHangBUS = new KhachHangBUS();
            chiTietPhieuTraHangBUS = new ChiTietPhieuTraHangBUS();
            tonKhoBUS = new TonKhoBUS();
        }
        void loadData()
        {
            gridControlLichSuTraHang.DataSource = traHangBUS.getAllTraHang();
        }
        void loadLookUpEdit()
        {
            lueKhachHang.Properties.DataSource = khachHangBUS.getAllKhachHang();
            lueKhachHang.Properties.DisplayMember = "TenKhachHang";
            lueKhachHang.Properties.ValueMember = "MaKhachHang";
  
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDatDau = Convert.ToDateTime(deNgayBatDau.Text);
            DateTime ngayKetThuc = Convert.ToDateTime(deNgayKetThuc.Text);
            gridControlLichSuTraHang.DataSource = traHangBUS.getAllTraHangByNgayNayNgayKiaBUS(ngayDatDau, ngayKetThuc);
        }

        private void gridViewLichSuTraHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            TH.MaPhieuTra = gridViewLichSuTraHang.GetFocusedRowCellValue(colMaPhieuTra).ToString();
            CTTH.MaPhieuTra = gridViewLichSuTraHang.GetFocusedRowCellValue(colMaPhieuTra).ToString();
            TH.MaKho = gridViewLichSuTraHang.GetFocusedRowCellValue(colMaKho).ToString();
        }

        private void UCLichSuTraHang_Load(object sender, EventArgs e)
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
                    bool f = traHangBUS.XoaTraHangBUS(ref err, TH);
                    bool f1 = false;
                    int demThemTK = 0;
                    if (f == true)
                    {
                        DataTable dtChiTietPTH = new DataTable();
                        dtChiTietPTH = chiTietPhieuTraHangBUS.GetAllChiTietPhieuTraHangByMaPhieuTraBUS(CTTH);
                        f1 = chiTietPhieuTraHangBUS.XoaChiTietPhieuTraHangByMaPhieuTraBUS(ref err,CTTH);

                        MessageBox.Show("Xoa thanh cong tra hang");
                        if (f1 == true)
                        {
                            foreach (DataRow r in dtChiTietPTH.Rows)
                            {
                                TK.MaHangHoa = r[2].ToString();
                                TK.MaKho = TH.MaKho;
                                TK.SoLuong = Convert.ToInt32(r[3]);
                                bool f2 = tonKhoBUS.TruSoLuongTonKho(ref err, TK);
                                if (f2 == true)
                                {
                                    demThemTK++;
                                }
                            }

                            MessageBox.Show("Xoa thanh cong chitiettrahang, ma phieu tra:" + CTTH.MaPhieuTra);
                        }

                        if (demThemTK == dtChiTietPTH.Rows.Count)
                        {
                            MessageBox.Show("them thanh cong ton kho,Soluong" + demThemTK);
                        }
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            ucth.TruyenTraHang_MaPhieuTra(TH);
            ucth.SetThemOrSua(0);
            Control ctrPanel1 = btnSua.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(ucth);
        }
    }
}
