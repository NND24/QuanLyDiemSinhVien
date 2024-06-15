using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.reports;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmReportBangDiemLTC : DevExpress.XtraEditors.XtraForm
    {
        public frmReportBangDiemLTC()
        {
            InitializeComponent();
        }

        private void frmReportBangDiemLTC_Load(object sender, System.EventArgs e)
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

        private void cmbKhoa_SelectedIndexChanged(object sender, System.EventArgs e)
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
            loadCmbNhom(cmbNienKhoa.Text, cmbHocKy.Text, cmbMonHoc.SelectedValue.ToString());
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, System.EventArgs e)
        {
            if (cmbNienKhoa.Text == "" || cmbHocKy.Text == "" || cmbMonHoc.Text == "" || cmbNhom.Text == "")
            {
                MessageBox.Show("Không có thông tin bảng điểm tổng kết", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                ReportBangDiemMonHoc rpt = new ReportBangDiemMonHoc(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text), cmbMonHoc.Text, int.Parse(cmbNhom.Text));

                rpt.lblKhoa.Text = cmbKhoa.Text.ToUpper();
                rpt.lblNienKhoa.Text = cmbNienKhoa.Text;
                rpt.lblHocKy.Text = cmbHocKy.Text;
                rpt.lblMonHoc.Text = cmbMonHoc.Text;
                rpt.lblNhom.Text = cmbNhom.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}