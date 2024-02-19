﻿namespace QuanLyDiemSinhVien.views
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
            this.btnDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemHetMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnDangKyLTC,
            this.btnXemDiem,
            this.btnDanhSachLTC,
            this.btnDanhSachSinhVien,
            this.btnBangDiemHetMon,
            this.btnBangDiemTongKet,
            this.btnBangDiemSinhVien,
            this.btnDanhSachHocPhi,
            this.btnTaoNguoiDung,
            this.btnDoiMatKhau,
            this.btnDangXuat,
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
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLopTinChi
            // 
            this.btnLopTinChi.Caption = "Lớp Tín Chỉ";
            this.btnLopTinChi.Id = 3;
            this.btnLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLopTinChi.ImageOptions.Image")));
            this.btnLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLopTinChi.ImageOptions.LargeImage")));
            this.btnLopTinChi.Name = "btnLopTinChi";
            this.btnLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLopTinChi_ItemClick);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập Điểm";
            this.btnNhapDiem.Id = 4;
            this.btnNhapDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.Image")));
            this.btnNhapDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.ImageOptions.LargeImage")));
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapDiem_ItemClick);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học Phí";
            this.btnHocPhi.Id = 5;
            this.btnHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.Image")));
            this.btnHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHocPhi.ImageOptions.LargeImage")));
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // btnDangKyLTC
            // 
            this.btnDangKyLTC.Caption = "Đăng Ký Lớp Tín Chỉ";
            this.btnDangKyLTC.Id = 6;
            this.btnDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyLTC.ImageOptions.Image")));
            this.btnDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKyLTC.ImageOptions.LargeImage")));
            this.btnDangKyLTC.Name = "btnDangKyLTC";
            this.btnDangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKyLTC_ItemClick);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Caption = "Xem Điểm";
            this.btnXemDiem.Id = 7;
            this.btnXemDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.ImageOptions.Image")));
            this.btnXemDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.ImageOptions.LargeImage")));
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDiem_ItemClick);
            // 
            // btnDanhSachLTC
            // 
            this.btnDanhSachLTC.Caption = "Danh Sách Lớp Tín Chỉ";
            this.btnDanhSachLTC.Id = 8;
            this.btnDanhSachLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachLTC.ImageOptions.Image")));
            this.btnDanhSachLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachLTC.ImageOptions.LargeImage")));
            this.btnDanhSachLTC.Name = "btnDanhSachLTC";
            this.btnDanhSachLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachLTC_ItemClick);
            // 
            // btnDanhSachSinhVien
            // 
            this.btnDanhSachSinhVien.Caption = "Danh Sách Sinh Viên Theo Lớp Tín Chỉ";
            this.btnDanhSachSinhVien.Id = 9;
            this.btnDanhSachSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachSinhVien.ImageOptions.Image")));
            this.btnDanhSachSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachSinhVien.ImageOptions.LargeImage")));
            this.btnDanhSachSinhVien.Name = "btnDanhSachSinhVien";
            this.btnDanhSachSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachSinhVien_ItemClick);
            // 
            // btnBangDiemHetMon
            // 
            this.btnBangDiemHetMon.Caption = "Bảng Điểm Hết Môn Của Lớp Tín Chỉ";
            this.btnBangDiemHetMon.Id = 10;
            this.btnBangDiemHetMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemHetMon.ImageOptions.Image")));
            this.btnBangDiemHetMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemHetMon.ImageOptions.LargeImage")));
            this.btnBangDiemHetMon.Name = "btnBangDiemHetMon";
            this.btnBangDiemHetMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemHetMon_ItemClick);
            // 
            // btnBangDiemTongKet
            // 
            this.btnBangDiemTongKet.Caption = "Bảng Điểm Tổng Kết Theo Lớp";
            this.btnBangDiemTongKet.Id = 11;
            this.btnBangDiemTongKet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemTongKet.ImageOptions.Image")));
            this.btnBangDiemTongKet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemTongKet.ImageOptions.LargeImage")));
            this.btnBangDiemTongKet.Name = "btnBangDiemTongKet";
            this.btnBangDiemTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemTongKet_ItemClick);
            // 
            // btnBangDiemSinhVien
            // 
            this.btnBangDiemSinhVien.Caption = "Bảng Điểm Sinh Viên";
            this.btnBangDiemSinhVien.Id = 12;
            this.btnBangDiemSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemSinhVien.ImageOptions.Image")));
            this.btnBangDiemSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiBangDiemSinhVien.ImageOptions.LargeImage")));
            this.btnBangDiemSinhVien.Name = "btnBangDiemSinhVien";
            this.btnBangDiemSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemSinhVien_ItemClick);
            // 
            // btnDanhSachHocPhi
            // 
            this.btnDanhSachHocPhi.Caption = "Danh Sách Đóng Học Phí";
            this.btnDanhSachHocPhi.Id = 13;
            this.btnDanhSachHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachHocPhi.ImageOptions.Image")));
            this.btnDanhSachHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDanhSachHocPhi.ImageOptions.LargeImage")));
            this.btnDanhSachHocPhi.Name = "btnDanhSachHocPhi";
            this.btnDanhSachHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachHocPhi_ItemClick);
            // 
            // btnTaoNguoiDung
            // 
            this.btnTaoNguoiDung.Caption = "Tạo Người Dùng";
            this.btnTaoNguoiDung.Id = 14;
            this.btnTaoNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoNguoiDung.ImageOptions.Image")));
            this.btnTaoNguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoNguoiDung.ImageOptions.LargeImage")));
            this.btnTaoNguoiDung.Name = "btnTaoNguoiDung";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 15;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 16;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Id = 17;
            this.btnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.Image")));
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangKyLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXemDiem);
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
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachLTC);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachSinhVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangDiemHetMon);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangDiemTongKet);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangDiemSinhVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDanhSachHocPhi);
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
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTaoNguoiDung);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDangXuat);
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
        private DevExpress.XtraBars.BarButtonItem btnDangKyLTC;
        private DevExpress.XtraBars.BarButtonItem btnXemDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachLTC;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemHetMon;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemTongKet;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnTaoNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusMa;
        private System.Windows.Forms.ToolStripStatusLabel statusTen;
        private System.Windows.Forms.ToolStripStatusLabel statusKhoa;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}