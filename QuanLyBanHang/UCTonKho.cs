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
    public partial class UCTonKho : UserControl
    {
        TonKhoO tk;
        TonKhoBUS tonKhoBUS;
        KhoBUS khoBUS;
        public UCTonKho()
        {
            InitializeComponent();
            tk = new TonKhoO();
            tonKhoBUS = new TonKhoBUS();

            //load du lieu cho lueKho
            khoBUS = new KhoBUS();
            lueKho.Properties.DataSource = khoBUS.getAllKhoBUS();
            lueKho.Properties.DisplayMember = "TenKho";
            lueKho.Properties.ValueMember = "MaKho";
        }
        void loadData()
        {
            gridControlTonKho.DataSource = tonKhoBUS.getAllTonKho();
        }

        private void lueKho_EditValueChanged(object sender, EventArgs e)
        {
            tk.MaKho = lueKho.EditValue.ToString();
            gridControlTonKho.DataSource = tonKhoBUS.GetAllTonKhoByMaKhoBUS(tk);
        }

        private void UCTonKho_Load(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
