namespace QuanLyBanHang
{
    partial class UCLichSuMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLichSuMuaHang));
            this.gridControlLichSuMuaHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewLichSuMuaHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLapPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHoaDonVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.deNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.deNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuMuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuMuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaCungCap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLichSuMuaHang
            // 
            this.gridControlLichSuMuaHang.Location = new System.Drawing.Point(0, 76);
            this.gridControlLichSuMuaHang.MainView = this.gridViewLichSuMuaHang;
            this.gridControlLichSuMuaHang.Name = "gridControlLichSuMuaHang";
            this.gridControlLichSuMuaHang.Size = new System.Drawing.Size(998, 353);
            this.gridControlLichSuMuaHang.TabIndex = 0;
            this.gridControlLichSuMuaHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichSuMuaHang});
            // 
            // gridViewLichSuMuaHang
            // 
            this.gridViewLichSuMuaHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieu,
            this.colTenPhieu,
            this.colNgayLapPhieu,
            this.colMaNhaCungCap,
            this.colTenNhaCungCap,
            this.colTongTien,
            this.colChuyenKhoan,
            this.colThue,
            this.colTienThanhToan,
            this.colSoHoaDonVAT,
            this.colGhiChu,
            this.colMaKho,
            this.colTenKho});
            this.gridViewLichSuMuaHang.GridControl = this.gridControlLichSuMuaHang;
            this.gridViewLichSuMuaHang.Name = "gridViewLichSuMuaHang";
            this.gridViewLichSuMuaHang.OptionsFind.AlwaysVisible = true;
            this.gridViewLichSuMuaHang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewLichSuMuaHang_RowCellClick);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.Caption = "Mã Phiếu";
            this.colMaPhieu.FieldName = "MaPhieu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.OptionsColumn.AllowEdit = false;
            this.colMaPhieu.Visible = true;
            this.colMaPhieu.VisibleIndex = 0;
            // 
            // colTenPhieu
            // 
            this.colTenPhieu.Caption = "Tên Phiếu";
            this.colTenPhieu.FieldName = "TenPhieu";
            this.colTenPhieu.Name = "colTenPhieu";
            this.colTenPhieu.OptionsColumn.AllowEdit = false;
            this.colTenPhieu.Visible = true;
            this.colTenPhieu.VisibleIndex = 1;
            // 
            // colNgayLapPhieu
            // 
            this.colNgayLapPhieu.Caption = "Ngày Lập Phiếu";
            this.colNgayLapPhieu.FieldName = "NgayLapPhieu";
            this.colNgayLapPhieu.Name = "colNgayLapPhieu";
            this.colNgayLapPhieu.OptionsColumn.AllowEdit = false;
            this.colNgayLapPhieu.Visible = true;
            this.colNgayLapPhieu.VisibleIndex = 2;
            // 
            // colMaNhaCungCap
            // 
            this.colMaNhaCungCap.Caption = "Mã Nhà Cung Cấp";
            this.colMaNhaCungCap.FieldName = "MaNhaCungCap";
            this.colMaNhaCungCap.Name = "colMaNhaCungCap";
            this.colMaNhaCungCap.OptionsColumn.AllowEdit = false;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.Caption = "Tên Nhà Cung Cấp";
            this.colTenNhaCungCap.FieldName = "TenNhaCungCap";
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.OptionsColumn.AllowEdit = false;
            this.colTenNhaCungCap.Visible = true;
            this.colTenNhaCungCap.VisibleIndex = 3;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.OptionsColumn.AllowEdit = false;
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            // 
            // colChuyenKhoan
            // 
            this.colChuyenKhoan.Caption = "Chuyển Khoản";
            this.colChuyenKhoan.FieldName = "PTramCK";
            this.colChuyenKhoan.Name = "colChuyenKhoan";
            this.colChuyenKhoan.OptionsColumn.AllowEdit = false;
            this.colChuyenKhoan.Visible = true;
            this.colChuyenKhoan.VisibleIndex = 5;
            // 
            // colThue
            // 
            this.colThue.Caption = "Thuế";
            this.colThue.FieldName = "Thue";
            this.colThue.Name = "colThue";
            this.colThue.OptionsColumn.AllowEdit = false;
            this.colThue.Visible = true;
            this.colThue.VisibleIndex = 6;
            // 
            // colTienThanhToan
            // 
            this.colTienThanhToan.Caption = "Tiền Thanh Toán";
            this.colTienThanhToan.FieldName = "TienThanhToan";
            this.colTienThanhToan.Name = "colTienThanhToan";
            this.colTienThanhToan.OptionsColumn.AllowEdit = false;
            this.colTienThanhToan.Visible = true;
            this.colTienThanhToan.VisibleIndex = 7;
            // 
            // colSoHoaDonVAT
            // 
            this.colSoHoaDonVAT.Caption = "Số Hóa Đơn VAT";
            this.colSoHoaDonVAT.FieldName = "SoHoaDonVAT";
            this.colSoHoaDonVAT.Name = "colSoHoaDonVAT";
            this.colSoHoaDonVAT.OptionsColumn.AllowEdit = false;
            this.colSoHoaDonVAT.Visible = true;
            this.colSoHoaDonVAT.VisibleIndex = 8;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.OptionsColumn.AllowEdit = false;
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 10;
            // 
            // btnXem
            // 
            this.btnXem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnXem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXem.Location = new System.Drawing.Point(299, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(37, 40);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // deNgayBatDau
            // 
            this.deNgayBatDau.EditValue = null;
            this.deNgayBatDau.Location = new System.Drawing.Point(51, 13);
            this.deNgayBatDau.Name = "deNgayBatDau";
            this.deNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Size = new System.Drawing.Size(100, 20);
            this.deNgayBatDau.TabIndex = 10;
            // 
            // deNgayKetThuc
            // 
            this.deNgayKetThuc.EditValue = null;
            this.deNgayKetThuc.Location = new System.Drawing.Point(183, 13);
            this.deNgayKetThuc.Name = "deNgayKetThuc";
            this.deNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Size = new System.Drawing.Size(100, 20);
            this.deNgayKetThuc.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Từ Ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(157, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Đến";
            // 
            // lueNhaCungCap
            // 
            this.lueNhaCungCap.Location = new System.Drawing.Point(3, 50);
            this.lueNhaCungCap.Name = "lueNhaCungCap";
            this.lueNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhaCungCap.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhaCungCap", "Mã Nhà Cung Cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaCungCap", "Tên Nhà Cung Cấp")});
            this.lueNhaCungCap.Properties.NullText = "";
            this.lueNhaCungCap.Size = new System.Drawing.Size(382, 20);
            this.lueNhaCungCap.TabIndex = 12;
            this.lueNhaCungCap.EditValueChanged += new System.EventHandler(this.lueNhaCungCap_EditValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(438, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(342, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 24);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa Chữa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UCLichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lueNhaCungCap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deNgayKetThuc);
            this.Controls.Add(this.deNgayBatDau);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.gridControlLichSuMuaHang);
            this.Name = "UCLichSuMuaHang";
            this.Size = new System.Drawing.Size(1001, 446);
            this.Load += new System.EventHandler(this.UCLichSuMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuMuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuMuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaCungCap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLichSuMuaHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichSuMuaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLapPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colThue;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHoaDonVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.DateEdit deNgayBatDau;
        private DevExpress.XtraEditors.DateEdit deNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lueNhaCungCap;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}
