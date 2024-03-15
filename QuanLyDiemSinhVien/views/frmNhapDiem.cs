using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        DataTable dkTable = new DataTable();
        DataTable ltcTable = new DataTable();
        int maLTC;

        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, System.EventArgs e)
        {
            qLDSV_HTCDataSet.EnforceConstraints = false;
            this.loptinchiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.loptinchiTableAdapter.Fill(this.qLDSV_HTCDataSet.LOPTINCHI);


            Program.bds_dspm.Filter = "TENPHONG NOT LIKE 'Kế Toán%' ";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }

            loadCmbNienKhoa();
        }

        private void loadCmbNienKhoa()
        {
            string cmd = "EXEC SP_LAY_DS_NIENKHOA";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }

        private void loadCmbHocKy(string nienKhoa)
        {
            string cmd = "EXEC SP_LAY_DS_HOCKY '" + nienKhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbHocKy.DataSource = dt;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
        }

        private void loadCmbMonHoc(string nienKhoa, string hocKy)
        {
            string cmd = "EXEC SP_LAY_DS_MONHOC '" + nienKhoa + "', '" + hocKy + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "MAMH";
            cmbMonHoc.ValueMember = "MAMH";
        }

        private void loadCmbNhom(string nienKhoa, string hocKy, string maMH)
        {
            string cmd = "EXEC SP_LAY_DS_NHOM '" + nienKhoa + "', '" + hocKy + "', '" + maMH + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbNhom.DataSource = dt;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";
        }


        private void loadTableDK()
        {
            string cmd = "EXEC SP_LAY_DSSV_DANGKY '" + maLTC + "'";
            dkTable = Program.ExecSqlDataTable(cmd);
            this.gc_DSSV_DangKy.DataSource = dkTable;
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadCmbHocKy(cmbNienKhoa.Text);
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadCmbMonHoc(cmbNienKhoa.Text, cmbHocKy.Text);
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadCmbNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMonHoc.Text);
        }

        private void btnBatDau_Click(object sender, System.EventArgs e)
        {
            string cmd = "EXEC SP_LAY_DS_LTC '" + cmbNienKhoa.Text + "', '" + cmbHocKy.Text + "', '" + cmbNhom.Text + "', '" + cmbMonHoc.Text + "'";
            ltcTable = Program.ExecSqlDataTable(cmd);
            this.gc_DS_LTC.DataSource = ltcTable;
            btnCapNhat.Enabled = true;
            cmbKhoa.Enabled = false;
            loadTableDK();
            panelControlNhapTT.Enabled = btnBatDau.Enabled = false;
            this.DIEM_CC.OptionsColumn.AllowFocus = true;
            this.DIEM_GK.OptionsColumn.AllowFocus = true;
            this.DIEM_CK.OptionsColumn.AllowFocus = true;
            gc_DSSV_DangKy.Enabled = true;
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBatDau.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void btnCapNhat_Click(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(String));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(int));
            dt.Columns.Add("DIEM_CK", typeof(int));

            for (int i = 0; i < dkTable.Rows.Count; i++)
            {
                dt.Rows.Add(dkTable.Rows[i]["LOPTC"], dkTable.Rows[i]["MASV"], dkTable.Rows[i]["DIEM_CC"], dkTable.Rows[i]["DIEM_GK"], dkTable.Rows[i]["DIEM_CK"]);
            }

            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand sqlCmd = new SqlCommand("SP_CAPNHAT_DIEM", Program.conn);
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(para);
                sqlCmd.ExecuteNonQuery();
                loadTableDK();
                panelControlNhapTT.Enabled = btnBatDau.Enabled = true;
                btnCapNhat.Enabled = false;
                cmbKhoa.Enabled = true;
                this.DIEM_CC.OptionsColumn.AllowFocus = false;
                this.DIEM_GK.OptionsColumn.AllowFocus = false;
                this.DIEM_CK.OptionsColumn.AllowFocus = false;
                this.btnCapNhat.BackColor = System.Drawing.SystemColors.ButtonShadow;
                this.btnBatDau.BackColor = System.Drawing.SystemColors.MenuHighlight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi điểm thất bại\n" + ex.Message, "", MessageBoxButtons.OK);
                loadTableDK();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Enabled == true)
            {
                if (MessageBox.Show("Dữ liệu chưa được cập nhật! Bạn có muốn thoát không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    panelControlNhapTT.Enabled = btnBatDau.Enabled = true;
                    btnCapNhat.Enabled = false;
                    cmbKhoa.Enabled = true;
                    this.gc_DSSV_DangKy.DataSource = null;
                    this.gc_DS_LTC.DataSource = null;
                    gc_DSSV_DangKy.Enabled = false;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void gv_DSSV_DangKy_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(e.Value);
                if (value > 10 || value < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm Không Hợp lệ: 0 < Điểm < 10";
                }
            }
            catch { }
        }

        private void gv_DS_LTC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = gv_DS_LTC.FocusedRowHandle;
            if (index >= 0 && index < ltcTable.Rows.Count)
            {
                DataRow row = ltcTable.Rows[index];
                maLTC = Convert.ToInt32(row["MALTC"]);

                loadTableDK();
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedItem.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmbKhoa.SelectedItem.ToString();
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
                loadCmbNienKhoa();
            }
        }
    }
}