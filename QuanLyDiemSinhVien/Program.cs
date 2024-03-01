using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static string constr_publisher = "Data Source=DESKTOP-UHICCE5;Initial Catalog=QLDSV_HTC;User ID=sa;Password='123456789';";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String passSV = "";

        public static String database = "QLDSV_HTC";
        public static String remoteLogin = "HTKN";
        public static String remotePass = "123456789";

        public static String mloginDN = "";
        public static String passDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mPhongBan = 0;

        public static BindingSource bds_dspm = new BindingSource(); // giữ danh sách phân mảnh khi đăng nhập
        public static views.frmDangNhap frmDangNhap;
        public static views.frmMain frmChinh;
        public static views.frmLopHoc frmLopHoc;
        public static views.frmMonHoc frmMonHoc;
        public static views.frmLopTinChi frmLopTinChi;
        public static views.frmNhapDiem frmNhapDiem;
        public static views.frmHocPhi frmHocPhi;
        public static views.frmDangKyLTC frmDangKyLTC;
        public static views.frmXemDiem frmXemDiem;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nVui lòng xem lại user name và password\n" + e.Message, "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                da.Fill(dt);
                Program.conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap = new views.frmDangNhap();
            // frmChinh = new views.frmMain();
            Application.Run(frmDangNhap);
        }
    }
}
