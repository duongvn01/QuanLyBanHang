namespace QuanLyBanHang
{
    partial class UCLichSuTraHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLichSuTraHang));
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.lueKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.deNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlLichSuTraHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewLichSuTraHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLapPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuTraHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuTraHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(348, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 24);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa Chữa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lueKhachHang
            // 
            this.lueKhachHang.Location = new System.Drawing.Point(10, 53);
            this.lueKhachHang.Name = "lueKhachHang";
            this.lueKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKhachHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhaCungCap", "Mã Nhà Cung Cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaCungCap", "Tên Nhà Cung Cấp")});
            this.lueKhachHang.Properties.NullText = "";
            this.lueKhachHang.Size = new System.Drawing.Size(382, 20);
            this.lueKhachHang.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(163, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Từ Ngày";
            // 
            // deNgayKetThuc
            // 
            this.deNgayKetThuc.EditValue = null;
            this.deNgayKetThuc.Location = new System.Drawing.Point(189, 16);
            this.deNgayKetThuc.Name = "deNgayKetThuc";
            this.deNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Size = new System.Drawing.Size(100, 20);
            this.deNgayKetThuc.TabIndex = 27;
            // 
            // deNgayBatDau
            // 
            this.deNgayBatDau.EditValue = null;
            this.deNgayBatDau.Location = new System.Drawing.Point(57, 16);
            this.deNgayBatDau.Name = "deNgayBatDau";
            this.deNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Size = new System.Drawing.Size(100, 20);
            this.deNgayBatDau.TabIndex = 28;
            // 
            // btnXem
            // 
            this.btnXem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnXem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXem.Location = new System.Drawing.Point(305, 7);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(37, 40);
            this.btnXem.TabIndex = 26;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(444, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gridControlLichSuTraHang
            // 
            this.gridControlLichSuTraHang.Location = new System.Drawing.Point(3, 79);
            this.gridControlLichSuTraHang.MainView = this.gridViewLichSuTraHang;
            this.gridControlLichSuTraHang.Name = "gridControlLichSuTraHang";
            this.gridControlLichSuTraHang.Size = new System.Drawing.Size(998, 341);
            this.gridControlLichSuTraHang.TabIndex = 34;
            this.gridControlLichSuTraHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichSuTraHang});
            // 
            // gridViewLichSuTraHang
            // 
            this.gridViewLichSuTraHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuTra,
            this.colNgayLapPhieu,
            this.colMaKhachHang,
            this.colTenKhachHang,
            this.colTongTien,
            this.colChuyenKhoan,
            this.colThue,
            this.colTienThanhToan,
            this.colGhiChu,
            this.colMaKho,
            this.colTenKho,
            this.colMaNhanVien,
            this.colTenNhanVien});
            this.gridViewLichSuTraHang.GridControl = this.gridControlLichSuTraHang;
            this.gridViewLichSuTraHang.Name = "gridViewLichSuTraHang";
            this.gridViewLichSuTraHang.OptionsFind.AlwaysVisible = true;
            this.gridViewLichSuTraHang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewLichSuTraHang_RowCellClick);
            // 
            // colMaPhieuTra
            // 
            this.colMaPhieuTra.Caption = "Mã Phiếu Trả";
            this.colMaPhieuTra.FieldName = "MaPhieuTra";
            this.colMaPhieuTra.Name = "colMaPhieuTra";
            this.colMaPhieuTra.OptionsColumn.AllowEdit = false;
            this.colMaPhieuTra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colMaPhieuTra.Visible = true;
            this.colMaPhieuTra.VisibleIndex = 0;
            // 
            // colNgayLapPhieu
            // 
            this.colNgayLapPhieu.Caption = "Ngày Lập Phiếu";
            this.colNgayLapPhieu.FieldName = "NgayLapPhieu";
            this.colNgayLapPhieu.Name = "colNgayLapPhieu";
            this.colNgayLapPhieu.OptionsColumn.AllowEdit = false;
            this.colNgayLapPhieu.Visible = true;
            this.colNgayLapPhieu.VisibleIndex = 1;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.Caption = "Mã Khách Hàng";
            this.colMaKhachHang.FieldName = "MaKhachHang";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.OptionsColumn.AllowEdit = false;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Tên Khách Hàng";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.OptionsColumn.AllowEdit = false;
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 2;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.OptionsColumn.AllowEdit = false;
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 3;
            // 
            // colChuyenKhoan
            // 
            this.colChuyenKhoan.Caption = "Chuyển Khoản";
            this.colChuyenKhoan.FieldName = "PTramCK";
            this.colChuyenKhoan.Name = "colChuyenKhoan";
            this.colChuyenKhoan.OptionsColumn.AllowEdit = false;
            this.colChuyenKhoan.Visible = true;
            this.colChuyenKhoan.VisibleIndex = 4;
            // 
            // colThue
            // 
            this.colThue.Caption = "Thuế";
            this.colThue.FieldName = "Thue";
            this.colThue.Name = "colThue";
            this.colThue.OptionsColumn.AllowEdit = false;
            this.colThue.Visible = true;
            this.colThue.VisibleIndex = 5;
            // 
            // colTienThanhToan
            // 
            this.colTienThanhToan.Caption = "Tiền Thanh Toán";
            this.colTienThanhToan.FieldName = "TienThanhToan";
            this.colTienThanhToan.Name = "colTienThanhToan";
            this.colTienThanhToan.OptionsColumn.AllowEdit = false;
            this.colTienThanhToan.Visible = true;
            this.colTienThanhToan.VisibleIndex = 6;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
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
            this.colTenKho.VisibleIndex = 8;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã Nhân Viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Tên Nhân Viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 9;
            // 
            // UCLichSuTraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlLichSuTraHang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lueKhachHang);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deNgayKetThuc);
            this.Controls.Add(this.deNgayBatDau);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Name = "UCLichSuTraHang";
            this.Size = new System.Drawing.Size(1048, 486);
            this.Load += new System.EventHandler(this.UCLichSuTraHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuTraHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuTraHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LookUpEdit lueKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deNgayKetThuc;
        private DevExpress.XtraEditors.DateEdit deNgayBatDau;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gridControlLichSuTraHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichSuTraHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuTra;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLapPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colThue;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
    }
}
