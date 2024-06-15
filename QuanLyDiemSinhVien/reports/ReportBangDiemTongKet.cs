using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyDiemSinhVien.reports
{
    public partial class ReportBangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangDiemTongKet()
        {
        }

        public ReportBangDiemTongKet(String nienKhoa)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Fill();
        }

    }
}
