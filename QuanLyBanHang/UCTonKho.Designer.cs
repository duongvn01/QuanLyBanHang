namespace QuanLyBanHang
{
    partial class UCTonKho
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
            this.lueKho = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlTonKho = new DevExpress.XtraGrid.GridControl();
            this.gridViewTonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lueKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lueKho
            // 
            this.lueKho.EditValue = "";
            this.lueKho.Location = new System.Drawing.Point(0, 12);
            this.lueKho.Name = "lueKho";
            this.lueKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã Kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên Kho")});
            this.lueKho.Properties.NullText = "";
            this.lueKho.Size = new System.Drawing.Size(231, 20);
            this.lueKho.TabIndex = 46;
            this.lueKho.EditValueChanged += new System.EventHandler(this.lueKho_EditValueChanged);
            // 
            // gridControlTonKho
            // 
            this.gridControlTonKho.Location = new System.Drawing.Point(3, 51);
            this.gridControlTonKho.MainView = this.gridViewTonKho;
            this.gridControlTonKho.Name = "gridControlTonKho";
            this.gridControlTonKho.Size = new System.Drawing.Size(805, 394);
            this.gridControlTonKho.TabIndex = 47;
            this.gridControlTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTonKho});
            // 
            // gridViewTonKho
            // 
            this.gridViewTonKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHangHoa,
            this.colTenHangHoa,
            this.colMaKho,
            this.colTenKho,
            this.colMaDonVi,
            this.colTenDonVi,
            this.colMaNhomHang,
            this.colTenNhomHang,
            this.colSoLuong});
            this.gridViewTonKho.GridControl = this.gridControlTonKho;
            this.gridViewTonKho.Name = "gridViewTonKho";
            this.gridViewTonKho.OptionsFind.AlwaysVisible = true;
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
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.Width = 69;
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
            // colMaDonVi
            // 
            this.colMaDonVi.Caption = "Mã đơnVị";
            this.colMaDonVi.FieldName = "MaDonVi";
            this.colMaDonVi.Name = "colMaDonVi";
            this.colMaDonVi.Width = 69;
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
            // colMaNhomHang
            // 
            this.colMaNhomHang.Caption = "Mã Nhóm Hàng";
            this.colMaNhomHang.FieldName = "MaNhomHang";
            this.colMaNhomHang.Name = "colMaNhomHang";
            this.colMaNhomHang.Width = 69;
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
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            // 
            // UCTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlTonKho);
            this.Controls.Add(this.lueKho);
            this.Name = "UCTonKho";
            this.Size = new System.Drawing.Size(826, 448);
            this.Load += new System.EventHandler(this.UCTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueKho;
        private DevExpress.XtraGrid.GridControl gridControlTonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
    }
}
