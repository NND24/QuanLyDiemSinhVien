using DevExpress.XtraReports.UI;
using QuanLyDiemSinhVien.reports;
using System;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmReportPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmReportPhieuDiem()
        {
            InitializeComponent();
        }

        private void frmReportPhieuDiem_Load(object sender, EventArgs e)
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

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, System.EventArgs e)
        {
            try
            {
                ReportPhieuDiem rpt = new ReportPhieuDiem(txtMaSV.Text);
                rpt.lblKhoa.Text = "Khoa: " + cmbKhoa.Text.ToUpper();
                rpt.lblSV.Text = "Bảng Điểm Sinh Viên: " + txtMaSV.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinh viên không tồn tại \n " + ex.Message);
                txtMaSV.Focus();
            }
        }


    }
}