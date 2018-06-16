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
    public partial class UCLichSuBanHang : UserControl
    {
        UCBanHang ucbh = new UCBanHang();
        BanHangO BH;
        ChiTietPhieuBanHangO CTPBH;
        TonKhoO TK;
        BanHangBUS banHangBUS;
        KhachHangBUS khachHangBUS;
        ChiTietPhieuBanHangBUS chiTietPhieuBanHangBUS;
        TonKhoBUS tonKhoBUS;
        public UCLichSuBanHang()
        {
            InitializeComponent();

            BH = new BanHangO();
            CTPBH = new ChiTietPhieuBanHangO();
            TK = new TonKhoO();

            banHangBUS = new BanHangBUS();
            khachHangBUS = new KhachHangBUS();
            chiTietPhieuBanHangBUS = new ChiTietPhieuBanHangBUS();
            tonKhoBUS = new TonKhoBUS();
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
            BH.MaKho = gridViewLichSuBanHang.GetFocusedRowCellValue(colMaKho).ToString();
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
                    bool f1 = false;
                    int demThemTK = 0;
                    if (f == true)
                    {
                        DataTable dtChiTietPMH = new DataTable();
                        dtChiTietPMH = chiTietPhieuBanHangBUS.GetAllChiTietPhieuBanHangByMaPhieuBanBUS(CTPBH);
                        f1 = chiTietPhieuBanHangBUS.XoaChiTietPhieuBanHangByMaPhieuBanBUS(ref err, CTPBH);
                        MessageBox.Show("Xoa thanh cong muahang");
                        if (f1 == true)
                        {
                            foreach (DataRow r in dtChiTietPMH.Rows)
                            {
                                TK.MaHangHoa = r[2].ToString();
                                TK.MaKho = BH.MaKho;
                                TK.SoLuong = Convert.ToInt32(r[3]);
                                bool f2 = tonKhoBUS.ThemTonKhoBUS(ref err,TK);
                                if (f2 == true)
                                {
                                    demThemTK++;
                                }
                            }

                            MessageBox.Show("Xoa thanh cong chitietbanhang, ma phieu ban:" + CTPBH.MaPhieuBan);
                        }

                        if (demThemTK == dtChiTietPMH.Rows.Count)
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
            ucbh.TruyenBanHang_MaPhieuBan(BH);
            ucbh.SetThemOrSua(0);
            Control ctrPanel1 = btnSua.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(ucbh);
        }
        
        
    }
}
