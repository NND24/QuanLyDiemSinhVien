namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPhieuDiem(string maSV)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
            this.sqlDataSource1.Fill();
        }

    }
}
