using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.reports;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmReportDSSinhVien : DevExpress.XtraEditors.XtraForm
    {
        string maMH;
        public frmReportDSSinhVien()
        {
            InitializeComponent();
            cmbNienKhoa.SelectedIndexChanged += cmbNienKhoa_SelectedIndexChanged;
            cmbHocKy.SelectedIndexChanged += cmbHocKy_SelectedIndexChanged;
            cmbMonHoc.SelectedIndexChanged += cmbMonHoc_SelectedIndexChanged;
            cmbNhom.SelectedIndexChanged += cmbKhoa_SelectedIndexChanged;
        }

        private void frmReportDSSinhVien_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.MONHOC1' table. You can move, or remove it, as needed.
            this.mONHOC1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOC1TableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC1);
            Program.bds_dspm.Filter = "TENPHONG NOT LIKE 'Kế Toán%' ";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = true;
            }

            loadCmbNienKhoa();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
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
                //loadCmbNienKhoa();
                //loadCmbHocKy(cmbNienKhoa.Text);
            }
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
            cmbMonHoc.DisplayMember = "TENMH";
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

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            ReportDSSVDangKyLTC rpt = new ReportDSSVDangKyLTC(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), maMH, int.Parse(cmbNhom.Text));


            rpt.lblKhoa.Text = cmbKhoa.Text;
            rpt.lblNienKhoa.Text = cmbNienKhoa.Text;
            rpt.lblHocKy.Text = cmbHocKy.Text;
            rpt.lblMonHoc.Text = cmbMonHoc.Text;
            rpt.lblNhom.Text = cmbNhom.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadCmbNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMonHoc.SelectedValue.ToString());
            try
            {
                maMH = cmbMonHoc.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCmbHocKy(cmbNienKhoa.Text);
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCmbMonHoc(cmbNienKhoa.Text, cmbHocKy.Text);
        }

        private void cmbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}