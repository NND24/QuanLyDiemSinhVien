using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmTaoNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoNguoiDung()
        {
            InitializeComponent();
            txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmTaoNguoiDung_Load(object sender, System.EventArgs e)
        {
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);

            if (Program.mGroup == "KHOA")
            {
                rbtnKhoa.Checked = true;
                rbtnPGV.Enabled = rbtnPKT.Enabled = false;
            }
            else if (Program.mGroup == "PGV")
            {
                rbtnPGV.Checked = true;
                rbtnKhoa.Enabled = rbtnPKT.Enabled = false;
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