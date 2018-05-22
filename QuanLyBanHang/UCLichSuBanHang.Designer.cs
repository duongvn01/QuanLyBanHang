namespace QuanLyBanHang
{
    partial class UCLichSuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLichSuBanHang));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.deNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.gridViewLichSuBanHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControlLichSuBanHang = new DevExpress.XtraGrid.GridControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(160, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Từ Ngày";
            // 
            // deNgayKetThuc
            // 
            this.deNgayKetThuc.EditValue = null;
            this.deNgayKetThuc.Location = new System.Drawing.Point(186, 12);
            this.deNgayKetThuc.Name = "deNgayKetThuc";
            this.deNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThuc.Size = new System.Drawing.Size(100, 20);
            this.deNgayKetThuc.TabIndex = 17;
            // 
            // deNgayBatDau
            // 
            this.deNgayBatDau.EditValue = null;
            this.deNgayBatDau.Location = new System.Drawing.Point(54, 12);
            this.deNgayBatDau.Name = "deNgayBatDau";
            this.deNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDau.Size = new System.Drawing.Size(100, 20);
            this.deNgayBatDau.TabIndex = 18;
            // 
            // gridViewLichSuBanHang
            // 
            this.gridViewLichSuBanHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuBan,
            this.colTenPhieu,
            this.colNgayLapPhieu,
            this.colMaKhachHang,
            this.colTenKhachHang,
            this.colTongTien,
            this.colChuyenKhoan,
            this.colThue,
            this.colTienThanhToan,
            this.colGhiChu,
            this.colMaKho,
            this.colTenKho});
            this.gridViewLichSuBanHang.GridControl = this.gridControlLichSuBanHang;
            this.gridViewLichSuBanHang.Name = "gridViewLichSuBanHang";
            this.gridViewLichSuBanHang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewLichSuBanHang_RowCellClick);
            // 
            // colMaPhieuBan
            // 
            this.colMaPhieuBan.Caption = "Mã Phiếu Bán";
            this.colMaPhieuBan.FieldName = "MaPhieuBan";
            this.colMaPhieuBan.Name = "colMaPhieuBan";
            this.colMaPhieuBan.OptionsColumn.AllowEdit = false;
            this.colMaPhieuBan.Visible = true;
            this.colMaPhieuBan.VisibleIndex = 0;
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
            this.colTenKhachHang.VisibleIndex = 3;
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
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 8;
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
            this.colTenKho.VisibleIndex = 9;
            // 
            // gridControlLichSuBanHang
            // 
            this.gridControlLichSuBanHang.Location = new System.Drawing.Point(3, 87);
            this.gridControlLichSuBanHang.MainView = this.gridViewLichSuBanHang;
            this.gridControlLichSuBanHang.Name = "gridControlLichSuBanHang";
            this.gridControlLichSuBanHang.Size = new System.Drawing.Size(998, 341);
            this.gridControlLichSuBanHang.TabIndex = 15;
            this.gridControlLichSuBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichSuBanHang});
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(345, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 40);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnXem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXem.Location = new System.Drawing.Point(302, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(37, 40);
            this.btnXem.TabIndex = 16;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // UCLichSuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deNgayKetThuc);
            this.Controls.Add(this.deNgayBatDau);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.gridControlLichSuBanHang);
            this.Name = "UCLichSuBanHang";
            this.Size = new System.Drawing.Size(1008, 462);
            this.Load += new System.EventHandler(this.UCLichSuBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deNgayKetThuc;
        private DevExpress.XtraEditors.DateEdit deNgayBatDau;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colThue;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLapPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichSuBanHang;
        private DevExpress.XtraGrid.GridControl gridControlLichSuBanHang;
    }
}
