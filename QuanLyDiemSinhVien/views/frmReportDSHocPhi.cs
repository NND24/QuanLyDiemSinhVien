using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.reports;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmReportDSHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmReportDSHocPhi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, System.EventArgs e)
        {
            if (txtMaLop.Text.Length > 0)
            {
                MessageBox.Show("Mã lớp không hợp lệ");
                txtMaLop.Focus();
            }
            else
            {
                try
                {
                    string cmd = "EXEC SP_LAY_KHOA_THEO_LOP '" + txtMaLop.Text + "'";
                    DataTable dt = Program.ExecSqlDataTable(cmd);
                    string tenKhoa = dt.Rows[0][0].ToString();
                    ReportHocPhi rpt = new ReportHocPhi(txtMaLop.Text, txtNienKhoa.Text, int.Parse(txtHocKy.Text));
                    rpt.lblKhoa.Text = "KHOA: " + tenKhoa.ToUpper();
                    rpt.lblMaLop.Text = "Mã lớp: " + txtMaLop.Text.ToUpper();
                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                }
                catch
                {
                    MessageBox.Show("Thông tin lớp học không hợp lệ");
                }
            }
        }
    }
}