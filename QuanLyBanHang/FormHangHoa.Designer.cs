namespace QuanLyBanHang
{
    partial class FormHangHoa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
            this.lueKho = new DevExpress.XtraEditors.LookUpEdit();
            this.radioGroupHangHoaDichVu = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtXuatXu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaVachNSX = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkConQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTonKhoToiThieu = new DevExpress.XtraEditors.CalcEdit();
            this.txtTonHienTai = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lueNhomHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lueDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.txtThue = new DevExpress.XtraEditors.CalcEdit();
            this.lueNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.txtGiaMua = new DevExpress.XtraEditors.CalcEdit();
            this.txtGiaBanSi = new DevExpress.XtraEditors.CalcEdit();
            this.txtGiaBanLe = new DevExpress.XtraEditors.CalcEdit();
            this.btnThemNhaCungCap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDonVi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNhomHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupHangHoaDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXuatXu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVachNSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonKhoToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonHienTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaMua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBanSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBanLe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lueKho
            // 
            this.lueKho.EditValue = "";
            this.lueKho.Location = new System.Drawing.Point(322, 62);
            this.lueKho.Name = "lueKho";
            this.lueKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã Kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên Kho")});
            this.lueKho.Properties.NullText = "";
            this.lueKho.Size = new System.Drawing.Size(189, 20);
            this.lueKho.TabIndex = 84;
            // 
            // radioGroupHangHoaDichVu
            // 
            this.radioGroupHangHoaDichVu.Location = new System.Drawing.Point(27, 6);
            this.radioGroupHangHoaDichVu.Name = "radioGroupHangHoaDichVu";
            this.radioGroupHangHoaDichVu.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Hàng Hóa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Dịch Vụ")});
            this.radioGroupHangHoaDichVu.Size = new System.Drawing.Size(151, 39);
            this.radioGroupHangHoaDichVu.TabIndex = 82;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(27, 353);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(38, 13);
            this.labelControl12.TabIndex = 78;
            this.labelControl12.Text = "Giá Mua";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(107, 212);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(164, 20);
            this.txtXuatXu.TabIndex = 73;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(27, 321);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(69, 13);
            this.labelControl11.TabIndex = 66;
            this.labelControl11.Text = "Nhà Cung Cấp";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(27, 298);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "Tồn Hiện Tại";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(27, 272);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(85, 13);
            this.labelControl9.TabIndex = 63;
            this.labelControl9.Text = "Tồn Kho Tối Thiểu";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(27, 241);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 13);
            this.labelControl10.TabIndex = 61;
            this.labelControl10.Text = "Thuế";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 212);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Xuất Xứ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 189);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Đơn Vị";
            // 
            // txtMaVachNSX
            // 
            this.txtMaVachNSX.Location = new System.Drawing.Point(107, 155);
            this.txtMaVachNSX.Name = "txtMaVachNSX";
            this.txtMaVachNSX.Size = new System.Drawing.Size(426, 20);
            this.txtMaVachNSX.TabIndex = 57;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Mã Vạch NSX";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(298, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 13);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Kho";
            // 
            // chkConQuanLy
            // 
            this.chkConQuanLy.EditValue = true;
            this.chkConQuanLy.Location = new System.Drawing.Point(422, 13);
            this.chkConQuanLy.Name = "chkConQuanLy";
            this.chkConQuanLy.Properties.Caption = "Còn Quản Lý";
            this.chkConQuanLy.Size = new System.Drawing.Size(89, 19);
            this.chkConQuanLy.TabIndex = 54;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(107, 91);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(424, 20);
            this.txtTenHangHoa.TabIndex = 52;
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(107, 63);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(164, 20);
            this.txtMaHangHoa.TabIndex = 53;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Loại Hàng Hóa";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Tên Hàng Hóa";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Mã Hàng Hóa";
            // 
            // txtTonKhoToiThieu
            // 
            this.txtTonKhoToiThieu.Location = new System.Drawing.Point(107, 269);
            this.txtTonKhoToiThieu.Name = "txtTonKhoToiThieu";
            this.txtTonKhoToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTonKhoToiThieu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTonKhoToiThieu.Size = new System.Drawing.Size(164, 20);
            this.txtTonKhoToiThieu.TabIndex = 64;
            // 
            // txtTonHienTai
            // 
            this.txtTonHienTai.Location = new System.Drawing.Point(107, 295);
            this.txtTonHienTai.Name = "txtTonHienTai";
            this.txtTonHienTai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTonHienTai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTonHienTai.Size = new System.Drawing.Size(164, 20);
            this.txtTonHienTai.TabIndex = 68;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(26, 379);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(47, 13);
            this.labelControl16.TabIndex = 66;
            this.labelControl16.Text = "Giá Bán Sỉ";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(27, 408);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(50, 13);
            this.labelControl19.TabIndex = 78;
            this.labelControl19.Text = "Giá Bán Lẻ";
            // 
            // lueNhomHang
            // 
            this.lueNhomHang.EditValue = "";
            this.lueNhomHang.Location = new System.Drawing.Point(107, 121);
            this.lueNhomHang.Name = "lueNhomHang";
            this.lueNhomHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhomHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhomHang", "Mã Nhóm Hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhomHang", "Tên Nhóm Hàng")});
            this.lueNhomHang.Properties.NullText = "";
            this.lueNhomHang.Size = new System.Drawing.Size(404, 20);
            this.lueNhomHang.TabIndex = 84;
            // 
            // lueDonVi
            // 
            this.lueDonVi.EditValue = "";
            this.lueDonVi.Location = new System.Drawing.Point(107, 182);
            this.lueDonVi.Name = "lueDonVi";
            this.lueDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDonVi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonVi", "Mã Đơn Vị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonVi", "Tên Đơn Vị")});
            this.lueDonVi.Properties.NullText = "";
            this.lueDonVi.Size = new System.Drawing.Size(404, 20);
            this.lueDonVi.TabIndex = 84;
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(107, 243);
            this.txtThue.Name = "txtThue";
            this.txtThue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtThue.Size = new System.Drawing.Size(164, 20);
            this.txtThue.TabIndex = 85;
            // 
            // lueNhaCungCap
            // 
            this.lueNhaCungCap.EditValue = "";
            this.lueNhaCungCap.Location = new System.Drawing.Point(107, 321);
            this.lueNhaCungCap.Name = "lueNhaCungCap";
            this.lueNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhaCungCap.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhaCungCap", "Mã Nhà Cung Cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaCungCap", "Tên Nhà Cung Cấp")});
            this.lueNhaCungCap.Properties.NullText = "";
            this.lueNhaCungCap.Size = new System.Drawing.Size(209, 20);
            this.lueNhaCungCap.TabIndex = 84;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(107, 346);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaMua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtGiaMua.Size = new System.Drawing.Size(164, 20);
            this.txtGiaMua.TabIndex = 85;
            // 
            // txtGiaBanSi
            // 
            this.txtGiaBanSi.Location = new System.Drawing.Point(107, 379);
            this.txtGiaBanSi.Name = "txtGiaBanSi";
            this.txtGiaBanSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaBanSi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtGiaBanSi.Size = new System.Drawing.Size(164, 20);
            this.txtGiaBanSi.TabIndex = 85;
            // 
            // txtGiaBanLe
            // 
            this.txtGiaBanLe.Location = new System.Drawing.Point(107, 405);
            this.txtGiaBanLe.Name = "txtGiaBanLe";
            this.txtGiaBanLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaBanLe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtGiaBanLe.Size = new System.Drawing.Size(164, 20);
            this.txtGiaBanLe.TabIndex = 85;
            // 
            // btnThemNhaCungCap
            // 
            this.btnThemNhaCungCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhaCungCap.ImageOptions.Image")));
            this.btnThemNhaCungCap.Location = new System.Drawing.Point(313, 321);
            this.btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            this.btnThemNhaCungCap.Size = new System.Drawing.Size(23, 20);
            this.btnThemNhaCungCap.TabIndex = 83;
            this.btnThemNhaCungCap.Text = "simpleButton1";
            this.btnThemNhaCungCap.Click += new System.EventHandler(this.btnThemNhaCungCap_Click);
            // 
            // btnThemDonVi
            // 
            this.btnThemDonVi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDonVi.ImageOptions.Image")));
            this.btnThemDonVi.Location = new System.Drawing.Point(510, 182);
            this.btnThemDonVi.Name = "btnThemDonVi";
            this.btnThemDonVi.Size = new System.Drawing.Size(23, 20);
            this.btnThemDonVi.TabIndex = 83;
            this.btnThemDonVi.Text = "simpleButton1";
            this.btnThemDonVi.Click += new System.EventHandler(this.btnThemDonVi_Click);
            // 
            // btnThemNhomHang
            // 
            this.btnThemNhomHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhomHang.ImageOptions.Image")));
            this.btnThemNhomHang.Location = new System.Drawing.Point(510, 121);
            this.btnThemNhomHang.Name = "btnThemNhomHang";
            this.btnThemNhomHang.Size = new System.Drawing.Size(23, 20);
            this.btnThemNhomHang.TabIndex = 83;
            this.btnThemNhomHang.Text = "simpleButton1";
            this.btnThemNhomHang.Click += new System.EventHandler(this.btnThemNhomHang_Click);
            // 
            // btnThemKho
            // 
            this.btnThemKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKho.ImageOptions.Image")));
            this.btnThemKho.Location = new System.Drawing.Point(510, 62);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Size = new System.Drawing.Size(23, 20);
            this.btnThemKho.TabIndex = 83;
            this.btnThemKho.Text = "simpleButton1";
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(333, 413);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(32, 36);
            this.btnDong.TabIndex = 47;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(298, 413);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(29, 33);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.txtGiaBanLe);
            this.Controls.Add(this.txtGiaBanSi);
            this.Controls.Add(this.txtGiaMua);
            this.Controls.Add(this.txtThue);
            this.Controls.Add(this.lueNhaCungCap);
            this.Controls.Add(this.btnThemNhaCungCap);
            this.Controls.Add(this.lueDonVi);
            this.Controls.Add(this.btnThemDonVi);
            this.Controls.Add(this.lueNhomHang);
            this.Controls.Add(this.btnThemNhomHang);
            this.Controls.Add(this.lueKho);
            this.Controls.Add(this.btnThemKho);
            this.Controls.Add(this.radioGroupHangHoaDichVu);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMaVachNSX);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chkConQuanLy);
            this.Controls.Add(this.txtTenHangHoa);
            this.Controls.Add(this.txtMaHangHoa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTonKhoToiThieu);
            this.Controls.Add(this.txtTonHienTai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupHangHoaDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXuatXu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVachNSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonKhoToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTonHienTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaMua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBanSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBanLe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueKho;
        private DevExpress.XtraEditors.SimpleButton btnThemKho;
        private DevExpress.XtraEditors.RadioGroup radioGroupHangHoaDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtXuatXu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMaVachNSX;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chkConQuanLy;
        private DevExpress.XtraEditors.TextEdit txtTenHangHoa;
        private DevExpress.XtraEditors.TextEdit txtMaHangHoa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CalcEdit txtTonKhoToiThieu;
        private DevExpress.XtraEditors.CalcEdit txtTonHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.SimpleButton btnThemNhomHang;
        private DevExpress.XtraEditors.LookUpEdit lueNhomHang;
        private DevExpress.XtraEditors.SimpleButton btnThemDonVi;
        private DevExpress.XtraEditors.LookUpEdit lueDonVi;
        private DevExpress.XtraEditors.CalcEdit txtThue;
        private DevExpress.XtraEditors.SimpleButton btnThemNhaCungCap;
        private DevExpress.XtraEditors.LookUpEdit lueNhaCungCap;
        private DevExpress.XtraEditors.CalcEdit txtGiaMua;
        private DevExpress.XtraEditors.CalcEdit txtGiaBanSi;
        private DevExpress.XtraEditors.CalcEdit txtGiaBanLe;
    }
}