using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        string loginNameSV = "";

        private void LayDSPM(string cmd)
        {
            DataTable dt = new DataTable();

            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);

            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc\n" + ex.Message);
                return 0;
            }
        }

        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.Properties.UseSystemPasswordChar = true;
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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbKhoa.SelectedIndex = 0;
            Program.servername = cmbKhoa.SelectedValue.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtTenDangNhap.Text.Trim();
            Program.password = txtMatKhau.Text.Trim();

            if (Program.KetNoi(false) == 1)
            {
                string strCmd = "EXEC SP_KIEMTRA_DANGNHAP '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            else if (!cmbKhoa.Text.ToString().Equals("Kế Toán"))
            {
                Program.mlogin = "SINHVIEN";
                Program.password = "123456";
                loginNameSV = txtTenDangNhap.Text;
                Program.passSV = txtMatKhau.Text;

                if (Program.KetNoi() == 0) return;

                string strCmd = "EXEC SP_KIEMTRA_DANGNHAP_SV '" + Program.mlogin + "', '" + loginNameSV + "', '" + Program.passSV + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ \n Vui lòng kiểm tra lại");
                return;
            }

            Program.mPhongBan = cmbKhoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.password;

            if (Program.myReader == null) return;
            Program.myReader.Read();


            try
            {
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }

                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();

                Program.frmChinh = new frmMain();
                Program.frmChinh.statusMa.Text = "MÃ: " + Program.username.ToUpper();
                Program.frmChinh.statusTen.Text = "TÊN: " + Program.mHoten;
                Program.frmChinh.statusKhoa.Text = "QUYỀN: " + Program.mGroup;


                this.Visible = false;
                Thread.Sleep(500);
                Program.frmChinh.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ \n Vui lòng kiểm tra lại \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        public void loadAgain()
        {
            cmbKhoa.SelectedItem = Program.mGroup;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            txtTenDangNhap.Text = null;
            txtMatKhau.Text = null;
            txtTenDangNhap.Focus();
        }
    }
}