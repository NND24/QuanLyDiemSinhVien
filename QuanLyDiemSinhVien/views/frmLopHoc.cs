namespace QuanLyDiemSinhVien.views
{
    public partial class frmLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
            this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
            //qLDSV_TCDataSet.EnforceConstraints = false;

            //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            // this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            // this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

        }
    }
}