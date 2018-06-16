namespace QuanLyBanHang
{
    partial class UCLichSuChuyenKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLichSuChuyenKho));
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.deNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.colTenKhoChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.colNgayLapPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewLichSuChuyenKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlLichSuChuyenKho = new DevExpress.XtraGrid.GridControl();
            this.colTenKhoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNguoiChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNguoiChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuChuyenKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuChuyenKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(349, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 24);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa Chữa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(164, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Từ Ngày";
            // 
            // deNgayKetThuc
            // 
            this.deNgayKetThuc.EditValue = null;
            this.deNgayKetThuc.Location = new System.Drawing.Point(190, 7);
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
            this.deNgayBatDau.Location = new System.Drawing.Point(58, 7);
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
            this.btnXem.Location = new System.Drawing.Point(306, -2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(37, 40);
            this.btnXem.TabIndex = 26;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // colTenKhoChuyen
            // 
            this.colTenKhoChuyen.Caption = "Tên Kho Chuyển";
            this.colTenKhoChuyen.FieldName = "TenKhoChuyen";
            this.colTenKhoChuyen.Name = "colTenKhoChuyen";
            this.colTenKhoChuyen.OptionsColumn.AllowEdit = false;
            this.colTenKhoChuyen.Visible = true;
            this.colTenKhoChuyen.VisibleIndex = 3;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(445, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // colMaPhieuChuyen
            // 
            this.colMaPhieuChuyen.Caption = "Mã Phiếu Chuyển";
            this.colMaPhieuChuyen.FieldName = "MaPhieuChuyen";
            this.colMaPhieuChuyen.Name = "colMaPhieuChuyen";
            this.colMaPhieuChuyen.OptionsColumn.AllowEdit = false;
            this.colMaPhieuChuyen.Visible = true;
            this.colMaPhieuChuyen.VisibleIndex = 0;
            // 
            // gridViewLichSuChuyenKho
            // 
            this.gridViewLichSuChuyenKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuChuyen,
            this.colNgayLapPhieu,
            this.colGhiChu,
            this.colTenKhoChuyen,
            this.colTenKhoNhan,
            this.colTenNguoiChuyen,
            this.colTenNguoiNhan,
            this.colMaKhoChuyen,
            this.colMaKhoNhan,
            this.colMaNguoiChuyen,
            this.colMaNguoiNhan});
            this.gridViewLichSuChuyenKho.GridControl = this.gridControlLichSuChuyenKho;
            this.gridViewLichSuChuyenKho.Name = "gridViewLichSuChuyenKho";
            this.gridViewLichSuChuyenKho.OptionsFind.AlwaysVisible = true;
            // 
            // gridControlLichSuChuyenKho
            // 
            this.gridControlLichSuChuyenKho.Location = new System.Drawing.Point(3, 44);
            this.gridControlLichSuChuyenKho.MainView = this.gridViewLichSuChuyenKho;
            this.gridControlLichSuChuyenKho.Name = "gridControlLichSuChuyenKho";
            this.gridControlLichSuChuyenKho.Size = new System.Drawing.Size(1069, 384);
            this.gridControlLichSuChuyenKho.TabIndex = 25;
            this.gridControlLichSuChuyenKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichSuChuyenKho});
            // 
            // colTenKhoNhan
            // 
            this.colTenKhoNhan.Caption = "Tên Kho Nhận";
            this.colTenKhoNhan.FieldName = "TenKhoNhan";
            this.colTenKhoNhan.Name = "colTenKhoNhan";
            this.colTenKhoNhan.Visible = true;
            this.colTenKhoNhan.VisibleIndex = 4;
            // 
            // colMaKhoChuyen
            // 
            this.colMaKhoChuyen.Caption = "Mã Kho Chuyển";
            this.colMaKhoChuyen.FieldName = "MaKhoChuyen";
            this.colMaKhoChuyen.Name = "colMaKhoChuyen";
            // 
            // colMaKhoNhan
            // 
            this.colMaKhoNhan.Caption = "Mã Kho Nhận";
            this.colMaKhoNhan.FieldName = "MaKhoNhan";
            this.colMaKhoNhan.Name = "colMaKhoNhan";
            // 
            // colTenNguoiNhan
            // 
            this.colTenNguoiNhan.Caption = "Tên Người Nhận";
            this.colTenNguoiNhan.FieldName = "TenNguoiNhan";
            this.colTenNguoiNhan.Name = "colTenNguoiNhan";
            this.colTenNguoiNhan.Visible = true;
            this.colTenNguoiNhan.VisibleIndex = 5;
            // 
            // colMaNguoiNhan
            // 
            this.colMaNguoiNhan.Caption = "Mã Người Nhận";
            this.colMaNguoiNhan.FieldName = "MaNguoiNhan";
            this.colMaNguoiNhan.Name = "colMaNguoiNhan";
            // 
            // colMaNguoiChuyen
            // 
            this.colMaNguoiChuyen.Caption = "Mã Người Chuyển";
            this.colMaNguoiChuyen.FieldName = "MaNguoiChuyen";
            this.colMaNguoiChuyen.Name = "colMaNguoiChuyen";
            // 
            // colTenNguoiChuyen
            // 
            this.colTenNguoiChuyen.Caption = "Tên Người Chuyển";
            this.colTenNguoiChuyen.FieldName = "TenNguoiChuyen";
            this.colTenNguoiChuyen.Name = "colTenNguoiChuyen";
            this.colTenNguoiChuyen.Visible = true;
            this.colTenNguoiChuyen.VisibleIndex = 6;
            // 
            // UCLichSuChuyenKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deNgayKetThuc);
            this.Controls.Add(this.deNgayBatDau);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gridControlLichSuChuyenKho);
            this.Name = "UCLichSuChuyenKho";
            this.Size = new System.Drawing.Size(1153, 466);
            this.Load += new System.EventHandler(this.UCLichSuChuyenKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuChuyenKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuChuyenKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deNgayKetThuc;
        private DevExpress.XtraEditors.DateEdit deNgayBatDau;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLapPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuChuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichSuChuyenKho;
        private DevExpress.XtraGrid.GridControl gridControlLichSuChuyenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoiChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNguoiChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNguoiNhan;
    }
}
