using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private string maSV = "";
        private int positionHocPhi = -1;
        private int positionCTHocPhi = -1;
        private bool ignoreBoxError = false;
        private string modeSave = "";

        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void getThongTinSV()
        {
            DataTable dt = new DataTable();
            maSV = txtMaSV.Text.Trim();
            string cmd = "EXEC SP_LAY_THONGTIN_SINHVIEN '" + maSV + "'";
            dt = Program.ExecSqlDataTable(cmd);

            txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
            txtLop.Text = dt.Rows[0]["MALOP"].ToString();
        }

        private void loadDataHocPhiSV()
        {
            try
            {
                getThongTinSV();
                this.sp_LAY_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_LAY_HOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_HOCPHI, maSV);
                gc_HocPhi.DataSource = bds_SP_LAY_HOCPHI;

                btnThem.Enabled = true;
                if (bds_SP_LAY_HOCPHI.Count == 0)
                {
                    btnSua.Enabled = btnXoa.Enabled = false;
                    panelControl2.Enabled = true;
                    panelControl1.Enabled = false;
                    return;
                }
                bds_SP_LAY_HOCPHI.Position = 0;
                loadCTDongHocPhi();
                panelControl2.Enabled = true;
                panelControl1.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                gc_CTDongHocPhi.DataSource = null;
                gc_CTDongHocPhi.DataSource = null;
                txtHoTen.Text = null;
                txtLop.Text = null;
                panelControl2.Enabled = false;
                txtMaSV.Focus();
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                maSV = null;
                positionCTHocPhi = -1;
                return;
            }
        }

        private void loadCTDongHocPhi()
        {
            positionHocPhi = bds_SP_LAY_HOCPHI.Position;
            String nienKhoa = ((DataRowView)bds_SP_LAY_HOCPHI[positionHocPhi])["NIENKHOA"].ToString();
            String hocKy = ((DataRowView)bds_SP_LAY_HOCPHI[positionHocPhi])["HOCKY"].ToString();

            this.sp_LAY_CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_LAY_CT_DONGHOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_CT_DONGHOCPHI, maSV, nienKhoa, int.Parse(hocKy));
            gc_CTDongHocPhi.DataSource = bds_SP_LAY_CTDONG_HOCPHI;


            if (bds_SP_LAY_CTDONG_HOCPHI.Count > 0)
            {
                btnSua.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = btnXoa.Enabled = true;
            }

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            loadDataHocPhiSV();
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadDataHocPhiSV();
            }
        }

        private void gridViewLop_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadCTDongHocPhi();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập sinh viên muốn thêm học phí");
            }
            else if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống!");
            }
            else
            {
                modeSave = "ADD";
                positionHocPhi = bds_SP_LAY_HOCPHI.Position;
                bds_SP_LAY_HOCPHI.AddNew();

                panelNhapHocPhi.Enabled = true;
                txtDaDong.Visible = labelDaDong.Visible = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                txtNienKhoa.Enabled = true;
                txtHocKy.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = true;
                panelSearch.Enabled = false;
                gc_HocPhi.Enabled = false;
                panelControl1.Enabled = false;
            }
        }


        private bool IsYearFormat(string input)
        {
            // Biểu thức chính quy kiểm tra xem chuỗi có phải định dạng năm (yyyy) không
            string pattern = @"^\d{4}$";

            // Kiểm tra nếu chuỗi khớp với biểu thức chính quy
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckHocPhi()
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return false;
            }
            if (!IsYearFormat(txtNienKhoa.Text.Trim()))
            {
                MessageBox.Show("Niên khóa phải là số và định dạng kiểu năm (yyyy)!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return false;
            }

            if (txtHocKy.Text.Trim() == "" || int.Parse(txtHocKy.Text.Trim()) < 1 || int.Parse(txtHocKy.Text.Trim()) > 4)
            {
                MessageBox.Show("Học kỳ bạn nhập không hợp lệ 1 <= HOCKY <=4!", "", MessageBoxButtons.OK);
                txtHocKy.Focus();
                return false;
            }
            if (txtHocPhi.Text.Trim() == "" || int.Parse(txtHocKy.Text.Trim()) < 1)
            {
                MessageBox.Show("Học phí không được để trống và phải >= 1!", "", MessageBoxButtons.OK);
                txtHocPhi.Focus();
                return false;
            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckHocPhi())
            {
                return;
            }

            string nienKhoa = txtNienKhoa.Text.Trim();
            int hocKy = (int)txtHocKy.Value;
            int hocPhi = (int)txtHocPhi.Value;

            string commandText = modeSave.Equals("ADD") ?
                "SP_THEM_HOCPHI" :
                "SP_CAPNHAT_HOCPHI";

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = commandText;
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaSV", maSV);
                        command.Parameters.AddWithValue("@NienKhoa", nienKhoa);
                        command.Parameters.AddWithValue("@HocKy", hocKy);
                        command.Parameters.AddWithValue("@HocPhi", hocPhi);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Cập nhật học phí thất bại!");
                            return;
                        }
                    }
                }

                RefreshDataAfterSave(nienKhoa, hocKy);

                MessageBox.Show("Học phí đã được cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RefreshDataAfterSave(string nienKhoa, int hocKy)
        {
            this.sp_LAY_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_LAY_HOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_HOCPHI, maSV);
            this.sp_LAY_CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_LAY_CT_DONGHOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_CT_DONGHOCPHI, maSV, nienKhoa, hocKy);

            for (int i = 0; i < bds_SP_LAY_HOCPHI.Count; i++)
            {
                DataRowView row = (DataRowView)bds_SP_LAY_HOCPHI[i];
                if (row["NIENKHOA"].ToString().Trim() == nienKhoa && Convert.ToInt32(row["HOCKY"]) == hocKy)
                {
                    bds_SP_LAY_HOCPHI.Position = i;
                    positionHocPhi = i;
                    break;
                }
            }

            panelSearch.Enabled = true;
            panelNhapHocPhi.Enabled = false;
            btnThem.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = true;
            gc_HocPhi.Enabled = panelControl1.Enabled = true;
        }


        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập sinh viên muốn sửa học phí");
            }
            else
            {
                modeSave = "Edit"; // Corrected modeSave value
                panelNhapHocPhi.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnGhi.Enabled = btnPhucHoi.Enabled = true;
                txtDaDong.Visible = labelDaDong.Visible = false;
                txtNienKhoa.Enabled = false;
                txtHocKy.Enabled = false;
                positionHocPhi = bds_SP_LAY_HOCPHI.Position;
                panelSearch.Enabled = false;
                panelControl1.Enabled = false;
                gc_HocPhi.Enabled = false;
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên muốn xóa học phí.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin học phí này không?", "Xác nhận", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            string maSV = txtMaSV.Text.Trim();
            string nienKhoa = txtNienKhoa.Text.Trim();
            int hocKy = (int)txtHocKy.Value;

            try
            {
                string cmd = $"EXEC SP_XOA_HOCPHI '{maSV}', '{nienKhoa}', {hocKy}";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                    return;

                try
                {
                    this.sp_LAY_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_LAY_HOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_HOCPHI, txtMaSV.Text.Trim());

                    if (bds_SP_LAY_HOCPHI.Count == 0)
                    {
                        btnSua.Enabled = btnXoa.Enabled = false;
                        panelControl1.Enabled = false;
                        return;
                    }

                    gc_HocPhi.DataSource = bds_SP_LAY_HOCPHI;
                    bds_SP_LAY_HOCPHI.Position = 0;
                    loadCTDongHocPhi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa Học Phí: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (modeSave == "ADD" || modeSave == "Edit")
            {
                bds_SP_LAY_HOCPHI.CancelEdit();
                this.sp_LAY_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_LAY_HOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_HOCPHI, maSV);

                gc_HocPhi.Enabled = panelControl1.Enabled = true;
                panelSearch.Enabled = true;
                panelNhapHocPhi.Enabled = false;
                btnThem.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

                if (bds_SP_LAY_HOCPHI.Count == 0)
                {
                    bds_SP_LAY_CTDONG_HOCPHI.DataSource = null;
                    panelControl1.Enabled = false;
                    return;
                }

                bds_SP_LAY_HOCPHI.Position = positionHocPhi;
                loadCTDongHocPhi();
            }
        }

        private bool ghiCTHocPhi()
        {
            try
            {
                DataRowView dt = (DataRowView)bds_SP_LAY_CTDONG_HOCPHI[bds_SP_LAY_CTDONG_HOCPHI.Position];
                string nienKhoa = txtNienKhoa.Text;
                int hocKy = int.Parse(txtHocKy.Text);
                int soTiendDong = int.Parse(dt["SOTIENDONG"].ToString());
                DateTime ngayDong = Convert.ToDateTime(dt["NGAYDONG"]);

                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SP_DONG_HOCPHI";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaSV", maSV);
                        command.Parameters.AddWithValue("@NienKhoa", nienKhoa);
                        command.Parameters.AddWithValue("@HocKy", hocKy);
                        command.Parameters.AddWithValue("@NgayDong", ngayDong);
                        command.Parameters.AddWithValue("@SoTienDong", soTiendDong);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Refresh data after successful execution
                            this.sp_LAY_HOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_HOCPHI, maSV);
                            this.sp_LAY_CT_DONGHOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_CT_DONGHOCPHI, maSV, nienKhoa, hocKy);

                            panelSearch.Enabled = true;
                            panelNhapHocPhi.Enabled = false;
                            btnThem.Enabled = true;
                            btnGhi.Enabled = btnPhucHoi.Enabled = false;
                            btnXoa.Enabled = btnSua.Enabled = true;
                            gc_HocPhi.Enabled = true;

                            // Set position to -1 to indicate no active position
                            positionCTHocPhi = -1;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật học phí thất bại! \nVui lòng cập nhật sau");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


        private void gv_CTDongHocPhi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rowView = e.Row as DataRowView;
            if (rowView != null)
            {
                string sotienString = rowView["SOTIENDONG"].ToString();
                if (string.IsNullOrWhiteSpace(sotienString))
                {
                    e.ErrorText = "Bạn chưa nhập đầy đủ thông tin về số tiền cần đóng!";
                    e.Valid = false;
                    return;
                }

                int sotien;
                if (!int.TryParse(sotienString, out sotien) || sotien <= 0)
                {
                    e.ErrorText = "Số tiền đóng phải là một số nguyên dương!";
                    e.Valid = false;
                    return;
                }

                // Directly perform the action if confirmed
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn đóng {sotien} vnđ cho Sinh viên: {txtHoTen.Text}, Niên Khóa: {txtNienKhoa.Text}, Học Kỳ: {txtHocKy.Text}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (ghiCTHocPhi())
                    {
                        btnDongHocPhi.Enabled = true;
                        btnThoatDongHP.Enabled = false;
                    }
                }
                else
                {
                    // Rollback changes or handle cancellation
                    this.sp_LAY_CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_LAY_CT_DONGHOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_CT_DONGHOCPHI, maSV, txtNienKhoa.Text, int.Parse(txtHocKy.Text));
                    if (bds_SP_LAY_CTDONG_HOCPHI.Count == 0)
                        btnSua.Enabled = btnXoa.Enabled = true;
                    panelNhapHocPhi.Enabled = false;
                    btnThem.Enabled = true;

                    panelSearch.Enabled = true;
                    gc_HocPhi.Enabled = true;
                    btnDongHocPhi.Enabled = true;
                    btnThoatDongHP.Enabled = false;
                    positionCTHocPhi = -1;
                }
            }
        }


        private void gv_CTDongHocPhi_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (ignoreBoxError)
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            else
            {
                DialogResult dr = XtraMessageBox.Show(e.ErrorText, e.WindowCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.No)
                {
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
                    panelSearch.Enabled = true;
                    panelNhapHocPhi.Enabled = false;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = false;
                    panelSearch.Enabled = true;
                    gc_HocPhi.Enabled = true;
                    positionCTHocPhi = -1;
                    ignoreBoxError = false;
                    btnDongHocPhi.Enabled = true;
                    btnThoatDongHP.Enabled = false;
                }
                else
                {
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                }

            }
        }

        private void gv_CTDongHocPhi_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gv_CTDongHocPhi.FocusedColumn.FieldName != "SOTIENDONG")
            {
                return;
            }

            if (!int.TryParse(e.Value.ToString(), out int soTienDong) || soTienDong <= 0)
            {
                e.ErrorText = "Số tiền đóng phải lớn hơn 0";
                e.Valid = false;
                return;
            }

            int hocPhi = Convert.ToInt32(((DataRowView)bds_SP_LAY_HOCPHI[positionHocPhi])["HOCPHI"]);
            int daDong = Convert.ToInt32(((DataRowView)bds_SP_LAY_HOCPHI[positionHocPhi])["DADONG"]);
            int soTienConDong = hocPhi - daDong;

            if (soTienDong > soTienConDong)
            {
                e.ErrorText = $"Số tiền cần đóng chỉ là {soTienConDong} vnđ.\nVui lòng không đóng nhiều hơn số tiền này";
                e.Valid = false;
            }
        }


        private void gv_CTDongHocPhi_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (bds_SP_LAY_CTDONG_HOCPHI.Position != positionCTHocPhi)
                e.Cancel = true;
        }


        private void btnDongHocPhi_Click(object sender, EventArgs e)
        {
            int sotiencandong = int.Parse(((DataRowView)bds_SP_LAY_HOCPHI[positionHocPhi])["HOCPHI"].ToString()) - int.Parse(((DataRowView)bds_SP_LAY_HOCPHI[positionHocPhi])["DADONG"].ToString());
            if (sotiencandong == 0)
            {
                MessageBox.Show("Sinh Viên đã đóng đủ học phí cho học kỳ này! ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bds_SP_LAY_CTDONG_HOCPHI.AddNew();
            gv_CTDongHocPhi.SetRowCellValue(gv_CTDongHocPhi.FocusedRowHandle, "NGAYDONG", DateTime.Now.ToString());
            positionCTHocPhi = bds_SP_LAY_CTDONG_HOCPHI.Count - 1;
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now;
            colNGAYDONG.ColumnEdit = ed;

            btnDongHocPhi.Enabled = false;
            btnThoatDongHP.Enabled = true;

            btnThem.Enabled = false;
            btnGhi.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            panelSearch.Enabled = false;
            gc_HocPhi.Enabled = false;
        }

        private void btnThoatDongHP_Click(object sender, EventArgs e)
        {
            bds_SP_LAY_CTDONG_HOCPHI.CancelEdit();
            this.sp_LAY_CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_LAY_CT_DONGHOCPHITableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LAY_CT_DONGHOCPHI, maSV, txtNienKhoa.Text, int.Parse(txtHocKy.Text));
            if (bds_SP_LAY_CTDONG_HOCPHI.Count == 0)
                btnSua.Enabled = btnXoa.Enabled = true;

            panelNhapHocPhi.Enabled = false;
            btnThem.Enabled = true;
            panelSearch.Enabled = true;
            gc_HocPhi.Enabled = true;
            btnDongHocPhi.Enabled = true;
            btnThoatDongHP.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelSearch.Enabled == false)
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
    }
}