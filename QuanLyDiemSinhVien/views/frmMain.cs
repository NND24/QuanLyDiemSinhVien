﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            if (Program.mGroup.Equals("PGV"))
            {
                ribbonPageQuanLy.Visible = true;
                ribbonPageBaoCao.Visible = true;
                ribbonPageQuanLyKhoa_PGV.Visible = true;
                ribbonPageQuanLyKhoa_PGV.Enabled = true;
                reportPagePGV_Khoa.Visible = true;
                reportPagePGV_Khoa.Enabled = true;
                btnTaoNguoiDung.Enabled = true;
                ribbon.SelectedPage = ribbonPageQuanLy;
                btnDoiMatKhau.Enabled = true;
            }
            else if (Program.mGroup.Equals("KHOA"))
            {
                ribbonPageQuanLy.Visible = true;
                ribbonPageBaoCao.Visible = true;
                ribbonPageQuanLyKhoa_PGV.Visible = true;
                ribbonPageQuanLyKhoa_PGV.Enabled = true;
                reportPagePGV_Khoa.Visible = true;
                reportPagePGV_Khoa.Enabled = true;
                btnTaoNguoiDung.Enabled = true;
                ribbon.SelectedPage = ribbonPageQuanLy;
                btnDoiMatKhau.Enabled = true;
            }
            else if (Program.mGroup.Equals("SV"))
            {
                ribbonPageSinhVien.Visible = true;
                ribbonPageBaoCao.Visible = false;
                ribbonPageQuanLy.Visible = false;
                btnDangKyLTC.Enabled = true;
                btnXemDiem.Enabled = true;
                btnTaoNguoiDung.Visibility = BarItemVisibility.Never;
                ribbon.SelectedPage = ribbonPageSinhVien;
                btnDoiMatKhau.Enabled = true;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                ribbonPageQuanLy.Visible = true;
                ribbonPageBaoCao.Visible = true;
                ribbonQuanLyPKT.Visible = true;
                ribbonQuanLyPKT.Enabled = true;
                reportPagePKT.Visible = true;
                reportPagePKT.Enabled = true;
                btnTaoNguoiDung.Enabled = true;
                btnDoiMatKhau.Enabled = true;
                ribbonPageQuanLyKhoa_PGV.Visible = false;
                reportPagePGV_Khoa.Visible = false;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLopHoc = new frmLopHoc();
                Program.frmLopHoc.MdiParent = this;
                Program.frmLopHoc.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmMonHoc = new frmMonHoc();
                Program.frmMonHoc.MdiParent = this;
                Program.frmMonHoc.Show();
            }
        }

        private void btnLopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLopTinChi = new frmLopTinChi();
                Program.frmLopTinChi.MdiParent = this;
                Program.frmLopTinChi.Show();
            }
        }

        private void btnNhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmNhapDiem = new frmNhapDiem();
                Program.frmNhapDiem.MdiParent = this;
                Program.frmNhapDiem.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmHocPhi = new frmHocPhi();
                Program.frmHocPhi.MdiParent = this;
                Program.frmHocPhi.Show();
            }
        }

        private void btnDangKyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDangKyLTC = new frmDangKyLTC();
                Program.frmDangKyLTC.MdiParent = this;
                Program.frmDangKyLTC.Show();
            }
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmXemDiem = new frmXemDiem();
                Program.frmXemDiem.MdiParent = this;
                Program.frmXemDiem.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                Program.frmChinh.Dispose();
                Program.frmDangNhap.Visible = true;

            }
        }

        private void btnDanhSachLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportDSLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDSLopTinChi frmdsltc = new frmReportDSLopTinChi();
                frmdsltc.MdiParent = this;
                frmdsltc.Show();
            }
        }

        private void btnDanhSachSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportDSSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDSSinhVien frmdssv = new frmReportDSSinhVien();
                frmdssv.MdiParent = this;
                frmdssv.Show();
            }
        }

        private void btnBangDiemHetMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportBangDiemLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmReportBangDiemLTC frmBangDiemLTC = new frmReportBangDiemLTC();
                frmBangDiemLTC.MdiParent = this;
                frmBangDiemLTC.Show();
            }
        }

        private void btnBangDiemTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportBangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frmReportBangDiemTongKet frmBangDiemTongKet = new frmReportBangDiemTongKet();
                frmBangDiemTongKet.MdiParent = this;
                frmBangDiemTongKet.Show();
            }
        }

        private void btnBangDiemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportPhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmReportPhieuDiem frmBangDiemSV = new frmReportPhieuDiem();
                frmBangDiemSV.MdiParent = this;
                frmBangDiemSV.Show();
            }
        }

        private void btnDanhSachHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportDSHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDSHocPhi frmHocPhi = new frmReportDSHocPhi();
                frmHocPhi.MdiParent = this;
                frmHocPhi.Show();
            }
        }

        private void btnTaoNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmTaoNguoiDung));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoNguoiDung frmTaoNguoiDung = new frmTaoNguoiDung();
                frmTaoNguoiDung.MdiParent = this;
                frmTaoNguoiDung.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {
                frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
                frmDoiMatKhau.MdiParent = this;
                frmDoiMatKhau.Show();
            }
        }
    }
}