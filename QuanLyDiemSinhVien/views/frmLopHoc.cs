using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        private int viTri;
        private int positionSV = -1;
        private String flagModeClass = "";
        private String flagModeSV = "";
        private String cacheTenLop = "";

        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, System.EventArgs e)
        {
            qLDSV_HTCDataSet.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_HTCDataSet.DANGKY);

            Program.bds_dspm.Filter = "TENPHONG NOT LIKE 'Kế Toán%' ";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }
            if (bdsLop.Count > 0)
            {
                btnXoa.Enabled = btnSua.Enabled = panelSinhVien.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedItem.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);

                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.qLDSV_HTCDataSet.DANGKY);
            }
        }

        private void gridViewLop_RowCountChanged(object sender, EventArgs e)
        {
            if (bdsLop.Count > 0 && !flagModeClass.Equals("ADDCLASS"))
            {
                btnXoa.Enabled = btnSua.Enabled = panelSinhVien.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = btnSua.Enabled = panelSinhVien.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.AddNew();
            try
            {
                DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_MAKHOA");
                string maKhoa = dt.Rows[0][0].ToString();
                txtKhoa.Text = maKhoa;
            }
            catch
            {
                bdsLop.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }

            viTri = bdsLop.Position;
            panelNhapLieu.Enabled = true;
            cmbKhoa.Enabled = false;

            flagModeClass = "ADDCLASS";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gridControlLop.Enabled = panelSinhVien.Enabled = false;
            txtMaLop.Enabled = true;
        }

        private bool checkClass()
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                txtMaLop.Focus();
                return false;
            }
            else if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!");
                txtTenLop.Focus();
                return false;
            }
            else if (txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!");
                txtKhoaHoc.Focus();
                return false;
            }

            if (flagModeClass == "ADDCLASS")
            {
                string query = " DECLARE @return_value INT " +
                               " EXEC @return_value = [dbo].[SP_KIEMTRA_ID] " +
                               " @ID = N'" + txtMaLop.Text.Trim() + "',  " +
                               " @TYPE = N'MALOP' " +
                               " SELECT 'Return Value' = @return_value";
                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối tới database. Vui lòng thử lại sau!");
                    return false;
                }
                else if (resultMa == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (resultMa == 2)
                {
                    MessageBox.Show("Mã lớp đã tồn tại ở khoa khác. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (flagModeClass == "ADDCLASS" || flagModeClass == "EDITCLASS" && cacheTenLop != txtTenLop.Text.Trim())
            {
                string query2 = "DECLARE @return_value INT " +
                               " EXEC @return_value = [dbo].[SP_KIEMTRA_TEN] " +
                               " @NAME = N'" + txtTenLop.Text.Trim() + "', " +
                               " @TYPE = N'TENLOP' " +
                               " SELECT 'Return Value' = @return_value";
                int resultMa2 = Program.CheckDataHelper(query2);
                if (resultMa2 == -1)
                {
                    MessageBox.Show("Lỗi kết nối tới database. Vui lòng thử lại sau!");
                    return false;
                }
                else if (resultMa2 == 1)
                {
                    MessageBox.Show("Tên lớp đã tồn tại. Vui lòng nhập tên khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (resultMa2 == 2)
                {
                    MessageBox.Show("Tên lớp đã tồn tại ở khoa khác. Vui lòng nhập tên khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkClass())
            {
                try
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    flagModeClass = "!" + flagModeClass;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_HTCDataSet.LOP);
                }
                catch (Exception ex)
                {
                    flagModeClass = flagModeClass.Substring(1);
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message);
                    return;
                }

                gridControlLop.Enabled = panelSinhVien.Enabled = true;
                btnThem.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                panelNhapLieu.Enabled = false;
                cmbKhoa.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = true;
                cacheTenLop = "";
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLop.Position;
            panelNhapLieu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            cmbKhoa.Enabled = false;
            txtMaLop.Enabled = false;
            flagModeClass = "EDITCLASS";
            cacheTenLop = txtTenLop.Text.Trim();

            gridControlLop.Enabled = panelSinhVien.Enabled = false;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            flagModeClass = "";

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);

            if (btnThem.Enabled == false) bdsLop.Position = viTri;
            gridControlLop.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            cmbKhoa.Enabled = true;
            cacheTenLop = "";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLop = "";
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp vì lớp đã có sinh viên");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_HTCDataSet.LOP);
                }
                catch
                {
                    MessageBox.Show("Lỗi xóa lớp. Vui lòng xóa lại");
                    this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                if (MessageBox.Show("Dữ liệu chưa được cập nhật! Bạn có muốn thoát không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            qLDSV_HTCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            qLDSV_HTCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            qLDSV_HTCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = Program.passSV;
            bdsSinhVien.AddNew();
            positionSV = bdsSinhVien.Count - 1;

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now.AddYears(-5);
            colNGAYSINH.ColumnEdit = ed;

            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = false;
            cmbKhoa.Enabled = gridControlLop.Enabled = false;
            btnPhucHoiSV.Enabled = btnGhiSV.Enabled = true;
            panelSinhVien.Enabled = true;
            flagModeSV = "ADDSV";
        }

        private bool checkSV()
        {
            DataRowView dt = (DataRowView)bdsSinhVien[positionSV];
            if (dt["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!");
                return false;
            }
            else if (dt["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!");
                return false;
            }
            else if (dt["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được để trống!");
                return false;
            }
            else if (dt["PHAI"].ToString().Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phái!");
                return false;
            }

            if (flagModeSV == "ADDSV")
            {
                string query = " DECLARE @return_value INT " +
                               " EXEC @return_value = [dbo].[SP_KIEMTRA_ID] " +
                               " @ID = N'" + dt["MASV"].ToString().Trim() + "',  " +
                               " @TYPE = N'MASV' " +
                               " SELECT 'Return Value' = @return_value";
                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối tới database. Vui lòng thử lại sau!");
                    return false;
                }
                else if (resultMa == 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (resultMa == 2)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại ở khoa khác. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (checkSV())
            {
                try
                {
                    bdsSinhVien.EndEdit();
                    bdsSinhVien.ResetCurrentItem();
                    flagModeSV = "";
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_HTCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    flagModeSV = "ADDSV";
                    MessageBox.Show("Lỗi ghi sinh viên");
                    return;
                }

                gridControlLop.Enabled = true;
                positionSV = -1;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnThemSV.Enabled = true;
                btnPhucHoiSV.Enabled = btnGhiSV.Enabled = false;
                btnXoaSV.Enabled = btnSuaSV.Enabled = true;
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string maSV = "";
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng ký lớp tín chỉ");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên khỏi lớp học này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maSV = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                    bdsSinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_HTCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên");
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", maSV);
                    return;
                }
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            positionSV = bdsSinhVien.Position;
            flagModeSV = "EDITSV";

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now.AddYears(-5);
            colNGAYSINH.ColumnEdit = ed;

            btnGhiSV.Enabled = btnPhucHoi.Enabled = true;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnSuaSV.Enabled = false;
            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            gridControlLop.Enabled = cmbKhoa.Enabled = false;
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {
            bdsSinhVien.CancelEdit();
            flagModeSV = "";
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);

            if (flagModeSV.Equals("EDITSV")) bdsSinhVien.Position = positionSV;
            positionSV = -1;
            btnGhiSV.Enabled = btnPhucHoi.Enabled = false;
            btnThemSV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            gridControlLop.Enabled = cmbKhoa.Enabled = true;
        }

        private void gridViewSV_ShownEditor(object sender, CancelEventArgs e)
        {
            if (bdsSinhVien.Position != positionSV || gridViewSV.FocusedColumn.FieldName == "MALOP"
                || (gridViewSV.FocusedColumn.FieldName == "DANGHIHOC" && flagModeSV.Equals("ADDSV")
                || (gridViewSV.FocusedColumn.FieldName == "MASV" && flagModeSV.Equals("EDITSV"))))
            {
                e.Cancel = true;
            }
        }

        private void gridViewSV_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewSV.FocusedColumn.FieldName == "MASV")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[NB][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length != 10)
                {
                    e.ErrorText = "Mã sinh viên không đúng định dạng";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }
        }

        private void gridViewSV_RowCountChanged(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count > 0 && flagModeSV.Equals("ADDSV"))
            {
                btnXoaSV.Enabled = btnSuaSV.Enabled = true;
            }
            else
            {
                btnXoaSV.Enabled = btnSuaSV.Enabled = false;
            }
        }
    }
}