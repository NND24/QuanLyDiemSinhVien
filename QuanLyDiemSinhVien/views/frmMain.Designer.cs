namespace QuanLyDiemSinhVien.views
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDanhSachLTC = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDanhSachSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBangDiemHetMon = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBangDiemTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBangDiemSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDanhSachHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTaoNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusKhoa = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLopHoc,
            this.btnMonHoc,
            this.btnLopTinChi,
            this.btnNhapDiem,
            this.btnHocPhi,
            this.bbiDangKyLTC,
            this.bbiXemDiem,
            this.bbiDanhSachLTC,
            this.bbiDanhSachSinhVien,
            this.bbiBangDiemHetMon,
            this.bbiBangDiemTongKet,
            this.bbiBangDiemSinhVien,
            this.bbiDanhSachHocPhi,
            this.bbiTaoNguoiDung,
            this.bbiDoiMatKhau,
            this.bbiDangXuat,
            this.btnSinhVien});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageQuanLy,
            this.ribbonPageSinhVien,
            this.ribbonPageBaoCao,
            this.ribbonPageCauHinh});
            this.ribbon.Size = new System.Drawing.Size(818, 177);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Caption = "Lớp Học";
            this.btnLopHoc.Id = 1;
            this.btnLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLopHoc.ImageOptions.Image")));
            this.btnLopHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLopHoc.ImageOptions.LargeImage")));
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLopHoc_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn Học";
            this.btnMonHoc.Id = 2;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            // 
            // btnLopTinChi
            // 
            this.btnLopTinChi.Caption = "Lớp Tín Chỉ";
            this.btnLopTinChi.Id = 3;
            this.btnLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLopTinChi.ImageOptions.Image")));
            this.btnLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLopTinChi.ImageOptions.LargeImage")));
            this.btnLopTinChi.Name = "btnLopTinChi";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập Điểm";
            this.btnNhapDiem.Id = 4;
            this.btnNhapDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.Image")));
            this.btnNhapDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.LargeImage")));
            this.btnNhapDiem.Name = "btnNhapDiem";
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học Phí";
            this.btnHocPhi.Id = 5;
            this.btnHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.Image")));
            this.btnHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.LargeImage")));
            this.btnHocPhi.Name = "btnHocPhi";
            // 
            // bbiDangKyLTC
            // 
            this.bbiDangKyLTC.Caption = "Đăng Ký Lớp Tín Chỉ";
            this.bbiDangKyLTC.Id = 6;
            this.bbiDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDangKyLTC.ImageOptions.Image")));
            this.bbiDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDangKyLTC.ImageOptions.LargeImage")));
            this.bbiDangKyLTC.Name = "bbiDangKyLTC";
            // 
            // bbiXemDiem
            // 
            this.bbiXemDiem.Caption = "Xem Điểm";
            this.bbiXemDiem.Id = 7;
            this.bbiXemDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXemDiem.ImageOptions.Image")));
            this.bbiXemDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiXemDiem.ImageOptions.LargeImage")));
            this.bbiXemDiem.Name = "bbiXemDiem";
            // 
            // bbiDanhSachLTC
            // 
            this.bbiDanhSachLTC.Caption = "Danh Sách Lớp Tín Chỉ";
            this.bbiDanhSachLTC.Id = 8;
            this.bbiDanhSachLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachLTC.ImageOptions.Image")));
            this.bbiDanhSachLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachLTC.ImageOptions.LargeImage")));
            this.bbiDanhSachLTC.Name = "bbiDanhSachLTC";
            // 
            // bbiDanhSachSinhVien
            // 
            this.bbiDanhSachSinhVien.Caption = "Danh Sách Sinh Viên Theo Lớp Tín Chỉ";
            this.bbiDanhSachSinhVien.Id = 9;
            this.bbiDanhSachSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachSinhVien.ImageOptions.Image")));
            this.bbiDanhSachSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachSinhVien.ImageOptions.LargeImage")));
            this.bbiDanhSachSinhVien.Name = "bbiDanhSachSinhVien";
            // 
            // bbiBangDiemHetMon
            // 
            this.bbiBangDiemHetMon.Caption = "Bảng Điểm Hết Môn Của Lớp Tín Chỉ";
            this.bbiBangDiemHetMon.Id = 10;
            this.bbiBangDiemHetMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemHetMon.ImageOptions.Image")));
            this.bbiBangDiemHetMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemHetMon.ImageOptions.LargeImage")));
            this.bbiBangDiemHetMon.Name = "bbiBangDiemHetMon";
            // 
            // bbiBangDiemTongKet
            // 
            this.bbiBangDiemTongKet.Caption = "Bảng Điểm Tổng Kết Theo Lớp";
            this.bbiBangDiemTongKet.Id = 11;
            this.bbiBangDiemTongKet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemTongKet.ImageOptions.Image")));
            this.bbiBangDiemTongKet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemTongKet.ImageOptions.LargeImage")));
            this.bbiBangDiemTongKet.Name = "bbiBangDiemTongKet";
            // 
            // bbiBangDiemSinhVien
            // 
            this.bbiBangDiemSinhVien.Caption = "Bảng Điểm Sinh Viên";
            this.bbiBangDiemSinhVien.Id = 12;
            this.bbiBangDiemSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemSinhVien.ImageOptions.Image")));
            this.bbiBangDiemSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemSinhVien.ImageOptions.LargeImage")));
            this.bbiBangDiemSinhVien.Name = "bbiBangDiemSinhVien";
            // 
            // bbiDanhSachHocPhi
            // 
            this.bbiDanhSachHocPhi.Caption = "Danh Sách Đóng Học Phí";
            this.bbiDanhSachHocPhi.Id = 13;
            this.bbiDanhSachHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachHocPhi.ImageOptions.Image")));
            this.bbiDanhSachHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachHocPhi.ImageOptions.LargeImage")));
            this.bbiDanhSachHocPhi.Name = "bbiDanhSachHocPhi";
            // 
            // bbiTaoNguoiDung
            // 
            this.bbiTaoNguoiDung.Caption = "Tạo Người Dùng";
            this.bbiTaoNguoiDung.Id = 14;
            this.bbiTaoNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiTaoNguoiDung.ImageOptions.Image")));
            this.bbiTaoNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiTaoNguoiDung.ImageOptions.LargeImage")));
            this.bbiTaoNguoiDung.Name = "bbiTaoNguoiDung";
            // 
            // bbiDoiMatKhau
            // 
            this.bbiDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.bbiDoiMatKhau.Id = 15;
            this.bbiDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDoiMatKhau.ImageOptions.Image")));
            this.bbiDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDoiMatKhau.ImageOptions.LargeImage")));
            this.bbiDoiMatKhau.Name = "bbiDoiMatKhau";
            // 
            // bbiDangXuat
            // 
            this.bbiDangXuat.Caption = "Đăng Xuất";
            this.bbiDangXuat.Id = 16;
            this.bbiDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDangXuat.ImageOptions.Image")));
            this.bbiDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDangXuat.ImageOptions.LargeImage")));
            this.bbiDangXuat.Name = "bbiDangXuat";
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 17;
            this.btnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.Image")));
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPageQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageQuanLy.ImageOptions.Image")));
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLopHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLopTinChi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapDiem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHocPhi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageSinhVien
            // 
            this.ribbonPageSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPageSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageSinhVien.ImageOptions.Image")));
            this.ribbonPageSinhVien.Name = "ribbonPageSinhVien";
            this.ribbonPageSinhVien.Text = "Sinh Viên";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiDangKyLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiXemDiem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageBaoCao
            // 
            this.ribbonPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPageBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageBaoCao.ImageOptions.Image")));
            this.ribbonPageBaoCao.Name = "ribbonPageBaoCao";
            this.ribbonPageBaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiDanhSachLTC);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiDanhSachSinhVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiBangDiemHetMon);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiBangDiemTongKet);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiBangDiemSinhVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbiDanhSachHocPhi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageCauHinh
            // 
            this.ribbonPageCauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPageCauHinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageCauHinh.ImageOptions.Image")));
            this.ribbonPageCauHinh.Name = "ribbonPageCauHinh";
            this.ribbonPageCauHinh.Text = "Cấu Hình";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiTaoNguoiDung);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiDoiMatKhau);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiDangXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMa,
            this.statusTen,
            this.statusKhoa});
            this.statusBar.Location = new System.Drawing.Point(0, 427);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(818, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusMa
            // 
            this.statusMa.Name = "statusMa";
            this.statusMa.Size = new System.Drawing.Size(27, 17);
            this.statusMa.Text = "Mã:";
            // 
            // statusTen
            // 
            this.statusTen.Name = "statusTen";
            this.statusTen.Size = new System.Drawing.Size(28, 17);
            this.statusTen.Text = "Tên:";
            // 
            // statusKhoa
            // 
            this.statusKhoa.Name = "statusKhoa";
            this.statusKhoa.Size = new System.Drawing.Size(37, 17);
            this.statusKhoa.Text = "Khoa:";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 449);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnLopHoc;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLopTinChi;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private DevExpress.XtraBars.BarButtonItem btnHocPhi;
        private DevExpress.XtraBars.BarButtonItem bbiDangKyLTC;
        private DevExpress.XtraBars.BarButtonItem bbiXemDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem bbiDanhSachLTC;
        private DevExpress.XtraBars.BarButtonItem bbiDanhSachSinhVien;
        private DevExpress.XtraBars.BarButtonItem bbiBangDiemHetMon;
        private DevExpress.XtraBars.BarButtonItem bbiBangDiemTongKet;
        private DevExpress.XtraBars.BarButtonItem bbiBangDiemSinhVien;
        private DevExpress.XtraBars.BarButtonItem bbiDanhSachHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem bbiTaoNguoiDung;
        private DevExpress.XtraBars.BarButtonItem bbiDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem bbiDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusMa;
        private System.Windows.Forms.ToolStripStatusLabel statusTen;
        private System.Windows.Forms.ToolStripStatusLabel statusKhoa;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}