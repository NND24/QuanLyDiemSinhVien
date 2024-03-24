namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportDSLopTinChi : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSLopTinChi(string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[1].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Fill();
        }

    }
}
