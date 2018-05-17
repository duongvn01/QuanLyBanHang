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
        MuaHangBUS muaHangBUS;

        public UCLichSuMuaHang()
        {
            InitializeComponent();
            muaHangBUS = new MuaHangBUS();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDatDau = Convert.ToDateTime(deNgayBatDau.Text);
            DateTime ngayKetThuc = Convert.ToDateTime(deNgayKetThuc.Text);
            gridControlLichSuMuaHang.DataSource = muaHangBUS.getAllMuaHangByNgayNayNgayKiaBUS(ngayDatDau,ngayKetThuc);
        }
    }
}
