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
    public partial class UCLichSuMuaHang : UserControl
    {
        UCMuaHang ucmh;
        MuaHangO MH;
        ChiTietPhieuMuaHangO CTPMH;
        TonKhoO TK;

        MuaHangBUS muaHangBUS;
        NhaCungCapBUS nhaCungCapBUS;
        ChiTietPhieuMuaHangBUS chiTietPhieuMuaHangBUS;
        TonKhoBUS tonKhoBUS;
        public UCLichSuMuaHang()
        {
            InitializeComponent();
            ucmh = new UCMuaHang();
            MH = new MuaHangO();
            CTPMH = new ChiTietPhieuMuaHangO();
            TK = new TonKhoO();

            muaHangBUS = new MuaHangBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            chiTietPhieuMuaHangBUS = new ChiTietPhieuMuaHangBUS();
            tonKhoBUS = new TonKhoBUS();
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
            MH.MaKho = gridViewLichSuMuaHang.GetFocusedRowCellValue(colMaKho).ToString();
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
                    bool f1 = false;
                    int demXoaTK=0;
                    if (f == true)
                    {
                        DataTable dtChiTietPMH = new DataTable();
                        dtChiTietPMH = chiTietPhieuMuaHangBUS.GetAllChiTietPhieuMuaHangByMaPhieuBUS(CTPMH);
                        f1 = chiTietPhieuMuaHangBUS.XoaChiTietPhieuMuaHangByMaPhieuBUS(ref err, CTPMH);
                        MessageBox.Show("Xoa thanh cong muahang");
                        if(f1==true)
                        {
                            MessageBox.Show("Xoa thanh cong chitietphieumuahang");
                            loadData();
                            foreach (DataRow r in dtChiTietPMH.Rows)
                            {
                                TK.MaHangHoa = r[2].ToString();
                                TK.MaKho = MH.MaKho;
                                TK.SoLuong = Convert.ToInt32(r[3]);
                                bool f2 = tonKhoBUS.XuatTonKhoBUS(ref err, TK);
                                if(f2==true)
                                {
                                    demXoaTK ++;
                                }
                            }

                            MessageBox.Show("Xoa thanh cong chitietmuahang, ma phieu:"+CTPMH.MaPhieu);
                        }
                        
                        if(demXoaTK==dtChiTietPMH.Rows.Count)
                        {
                            MessageBox.Show("Xuat thanh cong ton kho,Soluong"+demXoaTK);
                        }
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Khong Xoa duoc mua hang. Loi: " + err);
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
            ucmh.TruyenMuaHang_MaPhieu(MH);
            ucmh.SetThemOrSua(0);
            Control ctrPanel1 = btnSua.Parent.Parent;
            ctrPanel1.Controls.Clear();
            ctrPanel1.Controls.Add(ucmh);
        }
    }
}
