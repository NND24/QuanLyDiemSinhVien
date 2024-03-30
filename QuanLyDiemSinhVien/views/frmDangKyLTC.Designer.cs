namespace QuanLyDiemSinhVien.views
{
    partial class frmDangKyLTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyLTC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcLopTinChi = new DevExpress.XtraGrid.GridControl();
            this.gvLopTinChi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIANGVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDangKy = new DevExpress.XtraEditors.PanelControl();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuyDK = new System.Windows.Forms.Button();
            this.txtGiangVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLopTinChi = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcLopDaDK = new DevExpress.XtraGrid.GridControl();
            this.gvLopDaDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDangKy)).BeginInit();
            this.panelDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLopTinChi.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopDaDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopDaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.cmbHocKy);
            this.panel1.Controls.Add(this.cmbNienKhoa);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 113);
            this.panel1.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(964, 38);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(115, 40);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(713, 72);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 27);
            this.cmbHocKy.TabIndex = 4;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(713, 26);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(121, 27);
            this.cmbNienKhoa.TabIndex = 3;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(581, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Học Kỳ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(581, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Niên Khóa:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.lblMaSV);
            this.panel4.Controls.Add(this.lblKhoa);
            this.panel4.Controls.Add(this.lblLop);
            this.panel4.Controls.Add(this.lblHoTen);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 113);
            this.panel4.TabIndex = 0;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(296, 32);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(53, 15);
            this.lblMaSV.TabIndex = 9;
            this.lblMaSV.Text = "lblMaSV";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(296, 92);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(49, 15);
            this.lblKhoa.TabIndex = 8;
            this.lblKhoa.Text = "lblKhoa";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(296, 72);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(41, 15);
            this.lblLop.TabIndex = 7;
            this.lblLop.Text = "lblLop";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(296, 52);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(56, 15);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "lblHoTen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Khoa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Lớp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Họ Và Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Sinh Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // gcLopTinChi
            // 
            this.gcLopTinChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLopTinChi.Location = new System.Drawing.Point(0, 113);
            this.gcLopTinChi.MainView = this.gvLopTinChi;
            this.gcLopTinChi.Name = "gcLopTinChi";
            this.gcLopTinChi.Size = new System.Drawing.Size(1186, 184);
            this.gcLopTinChi.TabIndex = 5;
            this.gcLopTinChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLopTinChi});
            // 
            // gvLopTinChi
            // 
            this.gvLopTinChi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colGIANGVIEN,
            this.colDADANGKY});
            this.gvLopTinChi.GridControl = this.gcLopTinChi;
            this.gvLopTinChi.Name = "gvLopTinChi";
            this.gvLopTinChi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLopTinChi_RowClick);
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            // 
            // colGIANGVIEN
            // 
            this.colGIANGVIEN.Caption = "Giảng viên";
            this.colGIANGVIEN.FieldName = "GIANGVIEN";
            this.colGIANGVIEN.Name = "colGIANGVIEN";
            this.colGIANGVIEN.Visible = true;
            this.colGIANGVIEN.VisibleIndex = 4;
            // 
            // colDADANGKY
            // 
            this.colDADANGKY.Caption = "Đã đăng ký";
            this.colDADANGKY.FieldName = "DADANGKY";
            this.colDADANGKY.Name = "colDADANGKY";
            this.colDADANGKY.Visible = true;
            this.colDADANGKY.VisibleIndex = 5;
            // 
            // panelDangKy
            // 
            this.panelDangKy.Controls.Add(this.btnDangKy);
            this.panelDangKy.Controls.Add(this.btnHuyDK);
            this.panelDangKy.Controls.Add(this.txtGiangVien);
            this.panelDangKy.Controls.Add(this.txtMonHoc);
            this.panelDangKy.Controls.Add(this.txtMaLopTinChi);
            this.panelDangKy.Controls.Add(this.label5);
            this.panelDangKy.Controls.Add(this.label4);
            this.panelDangKy.Controls.Add(this.label3);
            this.panelDangKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDangKy.Location = new System.Drawing.Point(0, 297);
            this.panelDangKy.Name = "panelDangKy";
            this.panelDangKy.Size = new System.Drawing.Size(596, 260);
            this.panelDangKy.TabIndex = 6;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(181, 159);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(114, 33);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDK.Location = new System.Drawing.Point(383, 159);
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.Size = new System.Drawing.Size(114, 33);
            this.btnHuyDK.TabIndex = 8;
            this.btnHuyDK.Text = "Hủy Đăng Ký";
            this.btnHuyDK.UseVisualStyleBackColor = true;
            this.btnHuyDK.Click += new System.EventHandler(this.btnHuyDK_Click);
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Location = new System.Drawing.Point(226, 106);
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiangVien.Properties.Appearance.Options.UseFont = true;
            this.txtGiangVien.Size = new System.Drawing.Size(271, 26);
            this.txtGiangVien.TabIndex = 7;
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Location = new System.Drawing.Point(226, 63);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHoc.Properties.Appearance.Options.UseFont = true;
            this.txtMonHoc.Size = new System.Drawing.Size(271, 26);
            this.txtMonHoc.TabIndex = 6;
            // 
            // txtMaLopTinChi
            // 
            this.txtMaLopTinChi.Location = new System.Drawing.Point(226, 20);
            this.txtMaLopTinChi.Name = "txtMaLopTinChi";
            this.txtMaLopTinChi.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLopTinChi.Properties.Appearance.Options.UseFont = true;
            this.txtMaLopTinChi.Size = new System.Drawing.Size(271, 26);
            this.txtMaLopTinChi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giảng Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Lớp Tín Chỉ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcLopDaDK);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(596, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 260);
            this.panel2.TabIndex = 11;
            // 
            // gcLopDaDK
            // 
            this.gcLopDaDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLopDaDK.Location = new System.Drawing.Point(0, 20);
            this.gcLopDaDK.MainView = this.gvLopDaDK;
            this.gcLopDaDK.Name = "gcLopDaDK";
            this.gcLopDaDK.Size = new System.Drawing.Size(590, 240);
            this.gcLopDaDK.TabIndex = 1;
            this.gcLopDaDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLopDaDK});
            // 
            // gvLopDaDK
            // 
            this.gvLopDaDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvLopDaDK.GridControl = this.gcLopDaDK;
            this.gvLopDaDK.Name = "gvLopDaDK";
            this.gvLopDaDK.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLopDaDK_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Đã đăng ký";
            this.gridColumn1.FieldName = "DADANGKY";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Giảng viên";
            this.gridColumn2.FieldName = "GIANGVIEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhóm";
            this.gridColumn3.FieldName = "NHOM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên môn học";
            this.gridColumn4.FieldName = "TENMH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã môn học";
            this.gridColumn5.FieldName = "MAMH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã lớp tín chỉ";
            this.gridColumn6.FieldName = "MALTC";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 20);
            this.panel3.TabIndex = 0;
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Thêm";
            this.barLargeButtonItem2.Id = 7;
            this.barLargeButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.Image")));
            this.barLargeButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.LargeImage")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Thêm";
            this.barLargeButtonItem3.Id = 7;
            this.barLargeButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.ImageOptions.Image")));
            this.barLargeButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.ImageOptions.LargeImage")));
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đã đăng ký";
            this.gridColumn7.FieldName = "DADANGKY";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // frmDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDangKy);
            this.Controls.Add(this.gcLopTinChi);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangKyLTC";
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.frmDangKyLTC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDangKy)).EndInit();
            this.panelDangKy.ResumeLayout(false);
            this.panelDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLopTinChi.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLopDaDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLopDaDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcLopTinChi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLopTinChi;
        private DevExpress.XtraEditors.PanelControl panelDangKy;
        private DevExpress.XtraEditors.TextEdit txtGiangVien;
        private DevExpress.XtraEditors.TextEdit txtMonHoc;
        private DevExpress.XtraEditors.TextEdit txtMaLopTinChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gcLopDaDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLopDaDK;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuyDK;
        private System.Windows.Forms.Label lblMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIANGVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}