using System.Data;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, System.EventArgs e)
        {
            loadCmbNienKhoa();
        }

        private void loadCmbNienKhoa()
        {
            string cmd = "EXEC dbo.SP_LAY_NIENKHOA";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }

        private void loadCmbHocKy(string nienKhoa)
        {
            string cmd = "EXEC dbo.SP_LAY_DS_HOCKY '" + nienKhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbHocKy.DataSource = dt;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
        }

        private void loadCmbMonHoc(string nienKhoa, string hocKy)
        {
            string cmd = "EXEC dbo.SP_LAY_DS_MONHOC '" + nienKhoa + "', " + hocKy;
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "MAMH";
            cmbMonHoc.ValueMember = "MAMH";
        }

        private void loadCmbNhom(string nienKhoa, string hocKy, string maMH)
        {
            string cmd = "EXEC dbo.SP_LAY_DS_NHOM '" + nienKhoa + "', " + hocKy + "', " + maMH;
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbNhom.DataSource = dt;
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";
        }

        DataTable dkTable = new DataTable();
        private void loadTableDK()
        {
            string cmd = "EXEC SP_LAY_DS_DKMH '" + cmbNienKhoa.Text + "', " + cmbHocKy.Text + "', " + cmbNhom.Text + "', " + cmbMonHoc.Text + "'";
            dkTable = Program.ExecSqlDataTable(cmd);
            this.gc_DS_DangKy.DataSource = dkTable;
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
            string cmd = "EXEC SP_LAY_DS_LTC '" + cmbNienKhoa.Text + "', " + cmbHocKy.Text + "', " + cmbNhom.Text + "', " + cmbMonHoc.Text + "'";
            DataTable ltcTable = Program.ExecSqlDataTable(cmd);
            this.gc_DS_LTC.DataSource = ltcTable;
            btnCapNhat.Enabled = true;
            cmbKhoa.Enabled = false;
            panelControl3.Enabled = btnBatDau.Enabled = false;
            this.DIEM_CC.OptionsColumn.AllowFocus = true;
            this.DIEM_GK.OptionsColumn.AllowFocus = true;
            this.DIEM_CK.OptionsColumn.AllowFocus = true;
            gc_DS_DangKy.Enabled = true;

        }
    }
}