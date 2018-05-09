namespace QuanLyBanHang
{
    partial class UCHangHoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHangHoa));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.colMaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKhoToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.colXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVachNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBanSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBanLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHangHoaOrDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlHangHoa = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnNapLai
            // 
            this.btnNapLai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNapLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNapLai.ImageOptions.Image")));
            this.btnNapLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNapLai.Location = new System.Drawing.Point(157, 3);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(49, 40);
            this.btnNapLai.TabIndex = 14;
            this.btnNapLai.Text = "Nạp Lại";
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(113, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 40);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(2, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(38, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // colMaNhaCungCap
            // 
            this.colMaNhaCungCap.Caption = "Mã Nhà Cung Cấp";
            this.colMaNhaCungCap.FieldName = "MaNhaCungCap";
            this.colMaNhaCungCap.Name = "colMaNhaCungCap";
            this.colMaNhaCungCap.Width = 20;
            // 
            // colTonHienTai
            // 
            this.colTonHienTai.Caption = "Tồn Hiện Tại";
            this.colTonHienTai.FieldName = "TonHienTai";
            this.colTonHienTai.Name = "colTonHienTai";
            this.colTonHienTai.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colTonHienTai.Visible = true;
            this.colTonHienTai.VisibleIndex = 6;
            this.colTonHienTai.Width = 68;
            // 
            // colTonKhoToiThieu
            // 
            this.colTonKhoToiThieu.Caption = "Tồn Kho Tối Thiểu";
            this.colTonKhoToiThieu.FieldName = "TonKhoToiThieu";
            this.colTonKhoToiThieu.Name = "colTonKhoToiThieu";
            this.colTonKhoToiThieu.Visible = true;
            this.colTonKhoToiThieu.VisibleIndex = 5;
            this.colTonKhoToiThieu.Width = 93;
            // 
            // colThue
            // 
            this.colThue.Caption = "Thuế";
            this.colThue.FieldName = "Thue";
            this.colThue.Name = "colThue";
            this.colThue.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colThue.Width = 69;
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(46, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 40);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa Chữa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // colXuatXu
            // 
            this.colXuatXu.Caption = "Xuất Xứ";
            this.colXuatXu.FieldName = "XuatXu";
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.Width = 69;
            // 
            // colMaDonVi
            // 
            this.colMaDonVi.Caption = "Mã đơnVị";
            this.colMaDonVi.FieldName = "MaDonVi";
            this.colMaDonVi.Name = "colMaDonVi";
            this.colMaDonVi.Width = 69;
            // 
            // colMaVachNSX
            // 
            this.colMaVachNSX.Caption = "Mã Vạch NSX";
            this.colMaVachNSX.FieldName = "MaVachNSX";
            this.colMaVachNSX.Name = "colMaVachNSX";
            this.colMaVachNSX.Width = 69;
            // 
            // colTenNhomHang
            // 
            this.colTenNhomHang.Caption = "Tên Nhóm Hàng";
            this.colTenNhomHang.FieldName = "TenNhomHang";
            this.colTenNhomHang.Name = "colTenNhomHang";
            this.colTenNhomHang.Visible = true;
            this.colTenNhomHang.VisibleIndex = 3;
            this.colTenNhomHang.Width = 79;
            // 
            // colMaNhomHang
            // 
            this.colMaNhomHang.Caption = "Mã Nhóm Hàng";
            this.colMaNhomHang.FieldName = "MaNhomHang";
            this.colMaNhomHang.Name = "colMaNhomHang";
            this.colMaNhomHang.Width = 69;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 2;
            this.colTenKho.Width = 79;
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.Width = 69;
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.Caption = "Tên Hàng Hóa";
            this.colTenHangHoa.FieldName = "TenHangHoa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.OptionsColumn.AllowEdit = false;
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 1;
            this.colTenHangHoa.Width = 90;
            // 
            // colMaHangHoa
            // 
            this.colMaHangHoa.Caption = "Mã Hàng Hóa";
            this.colMaHangHoa.FieldName = "MaHangHoa";
            this.colMaHangHoa.Name = "colMaHangHoa";
            this.colMaHangHoa.OptionsColumn.AllowEdit = false;
            this.colMaHangHoa.Visible = true;
            this.colMaHangHoa.VisibleIndex = 0;
            this.colMaHangHoa.Width = 72;
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHangHoa,
            this.colTenHangHoa,
            this.colMaKho,
            this.colTenKho,
            this.colMaNhomHang,
            this.colTenNhomHang,
            this.colMaVachNSX,
            this.colMaDonVi,
            this.colTenDonVi,
            this.colXuatXu,
            this.colThue,
            this.colTonKhoToiThieu,
            this.colTonHienTai,
            this.colMaNhaCungCap,
            this.colTenNhaCungCap,
            this.colGiaMua,
            this.colGiaBanSi,
            this.colGiaBanLe,
            this.colConQuanLy,
            this.colHangHoaOrDichVu});
            this.gridViewHangHoa.GridControl = this.gridControlHangHoa;
            this.gridViewHangHoa.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenKhuVuc", this.colMaNhaCungCap, "Tên Khu Vực")});
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsFind.AlwaysVisible = true;
            this.gridViewHangHoa.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewHangHoa_RowCellClick);
            // 
            // colTenDonVi
            // 
            this.colTenDonVi.Caption = "Tên Đơn Vị";
            this.colTenDonVi.FieldName = "TenDonVi";
            this.colTenDonVi.Name = "colTenDonVi";
            this.colTenDonVi.Visible = true;
            this.colTenDonVi.VisibleIndex = 4;
            this.colTenDonVi.Width = 79;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.Caption = "Tên Nhà Cung Cấp";
            this.colTenNhaCungCap.FieldName = "TenNhaCungCap";
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.Visible = true;
            this.colTenNhaCungCap.VisibleIndex = 7;
            this.colTenNhaCungCap.Width = 175;
            // 
            // colGiaMua
            // 
            this.colGiaMua.Caption = "Giá Mua";
            this.colGiaMua.FieldName = "GiaMua";
            this.colGiaMua.Name = "colGiaMua";
            this.colGiaMua.Visible = true;
            this.colGiaMua.VisibleIndex = 8;
            this.colGiaMua.Width = 62;
            // 
            // colGiaBanSi
            // 
            this.colGiaBanSi.Caption = "Giá Bán Sỉ";
            this.colGiaBanSi.FieldName = "GiaBanSi";
            this.colGiaBanSi.Name = "colGiaBanSi";
            this.colGiaBanSi.Visible = true;
            this.colGiaBanSi.VisibleIndex = 9;
            this.colGiaBanSi.Width = 58;
            // 
            // colGiaBanLe
            // 
            this.colGiaBanLe.Caption = "Giá Bán Lẻ";
            this.colGiaBanLe.FieldName = "GiaBanLe";
            this.colGiaBanLe.Name = "colGiaBanLe";
            this.colGiaBanLe.Visible = true;
            this.colGiaBanLe.VisibleIndex = 10;
            this.colGiaBanLe.Width = 57;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 11;
            this.colConQuanLy.Width = 85;
            // 
            // colHangHoaOrDichVu
            // 
            this.colHangHoaOrDichVu.Caption = "Tính Chất";
            this.colHangHoaOrDichVu.FieldName = "HangHoaOrDichVu";
            this.colHangHoaOrDichVu.Name = "colHangHoaOrDichVu";
            // 
            // gridControlHangHoa
            // 
            this.gridControlHangHoa.Location = new System.Drawing.Point(2, 49);
            this.gridControlHangHoa.MainView = this.gridViewHangHoa;
            this.gridControlHangHoa.Name = "gridControlHangHoa";
            this.gridControlHangHoa.Size = new System.Drawing.Size(1015, 389);
            this.gridControlHangHoa.TabIndex = 10;
            this.gridControlHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // UCHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNapLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridControlHangHoa);
            this.Name = "UCHangHoa";
            this.Size = new System.Drawing.Size(1103, 461);
            this.Load += new System.EventHandler(this.UCHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNapLai;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTonHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colTonKhoToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colThue;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVachNSX;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBanSi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBanLe;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colHangHoaOrDichVu;
        private DevExpress.XtraGrid.GridControl gridControlHangHoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
