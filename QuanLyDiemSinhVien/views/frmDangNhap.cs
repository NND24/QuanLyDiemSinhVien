namespace QuanLyDiemSinhVien.views
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}