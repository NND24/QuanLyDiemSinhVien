namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportBangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangDiemMonHoc(string nienKhoa, int hocKy, string monHoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = monHoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();

        }

    }
}
