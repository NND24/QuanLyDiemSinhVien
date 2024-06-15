using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportDSSVDangKyLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSSVDangKyLTC()
        {
        }

        public ReportDSSVDangKyLTC(String nienKhoa, int hocKy, String maMH, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maMH;
            this.sqlDataSource1.Fill();
        }

    }
}
