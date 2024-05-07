using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtChucVu.Text = Program.mGroup;
            txtMa.Text = Program.username.ToUpper();
            txtHoTen.Text = Program.mHoten;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhauHT.Text != Program.password)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!");
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!");
                return;
            }

            try
            {
                String cmd = "EXEC SP_DOI_MATKHAU " + Program.mlogin + " ,'" + txtMatKhauHT.Text + "','" + txtMatKhauMoi.Text + "';";
                SqlDataReader dataReader = Program.ExecSqlDataReader(cmd);
                if (dataReader != null)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "thông báo!", MessageBoxButtons.OK);
                    Program.frmChinh.Visible = false;
                    Program.frmDangNhap.Visible = true;
                    Program.bds_dspm.RemoveFilter();
                    Program.frmDangNhap.loadAgain();
                }
                else
                {
                    MessageBox.Show("không thể thay đổi mật khẩu! Hay kiểm tra mật khẩu của bạn", "Thông báo", MessageBoxButtons.OK);
                    txtMatKhauHT.Text = null;
                    txtMatKhauMoi.Text = null;
                    txtNhapLaiMK.Text = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("không thể thay đổi mật khẩu! Hay kiểm tra mật khẩu của bạn" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                txtMatKhauHT.Text = null;
                txtMatKhauMoi.Text = null;
                txtNhapLaiMK.Text = null;
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhauHT.Text = null;
            txtMatKhauMoi.Text = null;
            txtNhapLaiMK.Text = null;
        }
    }
}