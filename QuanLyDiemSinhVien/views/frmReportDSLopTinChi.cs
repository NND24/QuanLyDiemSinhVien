using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.reports;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmReportDSLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        public frmReportDSLopTinChi()
        {
            InitializeComponent();
        }

        private void frmReportDSLopTinChi_Load(object sender, System.EventArgs e)
        {
            Program.bds_dspm.Filter = "TENPHONG NOT LIKE 'Kế Toán%' ";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
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
                loadCmbNienKhoa();
                loadCmbHocKy(cmbNienKhoa.Text);
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

        private void cmbNienKhoa_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadCmbHocKy(cmbNienKhoa.Text);
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, System.EventArgs e)
        {
            if (cmbNienKhoa.Text == "" || cmbHocKy.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                ReportDSLopTinChi rpt = new ReportDSLopTinChi(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));

                rpt.lblKhoa.Text = "KHOA " + cmbKhoa.Text.ToUpper();
                rpt.lblNienKhoa.Text = cmbNienKhoa.Text;
                rpt.lblHocKy.Text = cmbHocKy.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}