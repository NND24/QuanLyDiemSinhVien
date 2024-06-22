using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.reports;
using System;
using System.Data;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmReportBangDiemTongKet : DevExpress.XtraEditors.XtraForm
    {
        public frmReportBangDiemTongKet()
        {
            InitializeComponent();
        }

        private void frmReportBangDiemTongKet_Load(object sender, System.EventArgs e)
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
            loadCmbLop(cmbKhoa.Text);
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbKhoa.SelectedIndex == 0)
            {
                loadCmbLop("Công Nghệ Thông Tin");

            }
            else
            {
                loadCmbLop("Viễn Thông");
            }
        }

        private void loadCmbLop(String tenKhoa)
        {
            String maKhoa = "";
            if (tenKhoa.Equals("Công Nghệ Thông Tin"))
            {
                maKhoa = "CNTT";
            }
            else if (tenKhoa.Equals("Viễn Thông"))
            {
                maKhoa = "VT";
            }
            string cmd = "EXEC SP_LAY_DS_LOP '" + maKhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "MALOP";
            cmbLop.ValueMember = "MALOP";
        }
        private String layKhoaHoc(string maLop)
        {
            string cmd = "EXEC SP_LAY_KHOAHOC '" + maLop + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            string khoaHoc = dt.Rows[0][0].ToString();
            return khoaHoc;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportBangDiemTongKet rpt = new ReportBangDiemTongKet(cmbLop.Text);


            rpt.lblLop.Text = cmbLop.Text;
            rpt.lblKhoaHoc.Text = layKhoaHoc(cmbLop.Text);
            rpt.lblKhoa.Text = cmbKhoa.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}