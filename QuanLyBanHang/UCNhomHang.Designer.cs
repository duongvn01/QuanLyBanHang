namespace QuanLyBanHang
{
    partial class UCNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhomHang));
            this.gridControlNhomHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhomHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConQuanLy = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhomHang
            // 
            this.gridControlNhomHang.Location = new System.Drawing.Point(8, 49);
            this.gridControlNhomHang.MainView = this.gridViewNhomHang;
            this.gridControlNhomHang.Name = "gridControlNhomHang";
            this.gridControlNhomHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ConQuanLy,
            this.repositoryItemCheckEdit2});
            this.gridControlNhomHang.Size = new System.Drawing.Size(732, 389);
            this.gridControlNhomHang.TabIndex = 5;
            this.gridControlNhomHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhomHang});
            // 
            // gridViewNhomHang
            // 
            this.gridViewNhomHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhomHang,
            this.colTenNhomHang,
            this.colGhiChu,
            this.colConQuanLy});
            this.gridViewNhomHang.GridControl = this.gridControlNhomHang;
            this.gridViewNhomHang.Name = "gridViewNhomHang";
            this.gridViewNhomHang.OptionsFind.AlwaysVisible = true;
            this.gridViewNhomHang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewNhomHang_RowCellClick);
            // 
            // colMaNhomHang
            // 
            this.colMaNhomHang.Caption = "Mã  Nhóm Hàng";
            this.colMaNhomHang.FieldName = "MaNhomHang";
            this.colMaNhomHang.Name = "colMaNhomHang";
            this.colMaNhomHang.OptionsColumn.AllowEdit = false;
            this.colMaNhomHang.Visible = true;
            this.colMaNhomHang.VisibleIndex = 0;
            this.colMaNhomHang.Width = 178;
            // 
            // colTenNhomHang
            // 
            this.colTenNhomHang.Caption = "Tên Nhóm Hàng";
            this.colTenNhomHang.FieldName = "TenNhomHang";
            this.colTenNhomHang.Name = "colTenNhomHang";
            this.colTenNhomHang.OptionsColumn.AllowEdit = false;
            this.colTenNhomHang.Visible = true;
            this.colTenNhomHang.VisibleIndex = 1;
            this.colTenNhomHang.Width = 193;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 216;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.ColumnEdit = this.ConQuanLy;
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 3;
            this.colConQuanLy.Width = 332;
            // 
            // ConQuanLy
            // 
            this.ConQuanLy.AutoHeight = false;
            this.ConQuanLy.Name = "ConQuanLy";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // btnNapLai
            // 
            this.btnNapLai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNapLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNapLai.ImageOptions.Image")));
            this.btnNapLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNapLai.Location = new System.Drawing.Point(158, 3);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(42, 40);
            this.btnNapLai.TabIndex = 9;
            this.btnNapLai.Text = "Nạp Lại";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(114, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(47, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa Chữa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(38, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UCNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlNhomHang);
            this.Controls.Add(this.btnNapLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "UCNhomHang";
            this.Size = new System.Drawing.Size(760, 425);
            this.Load += new System.EventHandler(this.UCNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhomHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.SimpleButton btnNapLai;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
