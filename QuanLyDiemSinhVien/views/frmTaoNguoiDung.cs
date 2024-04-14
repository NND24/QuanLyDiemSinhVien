using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmTaoNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoNguoiDung()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmTaoNguoiDung_Load(object sender, System.EventArgs e)
        {
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);

            if (Program.mGroup == "KHOA" || Program.mGroup == "PGV")
            {
                if (Program.mGroup == "KHOA")
                {
                    rbtnKhoa.Checked = true;
                    rbtnPGV.Enabled = rbtnPKT.Enabled = false;
                }
                else
                {
                    rbtnPGV.Checked = true;
                    rbtnPKT.Enabled = false;
                }
            }
            else
            {
                rbtnPKT.Checked = true;
                rbtnPGV.Enabled = rbtnKhoa.Enabled = false;
            }
        }

        private void btnDangKy_Click(object sender, System.EventArgs e)
        {
            string selectedValue = "";
            foreach (Control control in radioGroupNhom.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    selectedValue = radioButton.Text;
                }
            }

            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!");
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!");
                txtMatKhau.Focus();
            }
            else
            {
                string cmd = "EXEC SP_TAO_TAIKHOAN '" + txtTenDangNhap.Text + "', '" + txtMatKhau.Text + "', '" + cmbGiangVien.SelectedValue.ToString() + "', '" + selectedValue + "'";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại!");
                }
            }
        }
    }
}