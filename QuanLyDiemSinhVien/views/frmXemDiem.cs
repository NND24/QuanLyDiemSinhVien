using System.Windows.Forms;
using System.Data;
using System;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmXemDiem : DevExpress.XtraEditors.XtraForm
    {
        private string maSV = Program.username.ToUpper();
        private BindingSource bdsXemDiem = new BindingSource();
        public frmXemDiem()
        {
            InitializeComponent();
            layThongTinSinhVien();
            layDiemSV();
        }

        private void layThongTinSinhVien()
        {
            try
            {
                DataTable dt = new DataTable();
                string cmd = "EXEC SP_LAY_THONGTIN_SINHVIEN '" + maSV + "'";
                dt = Program.ExecSqlDataTable(cmd);

                lblMaSV.Text = maSV;
                lblHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
                lblLop.Text = dt.Rows[0]["MALOP"].ToString() + " " + dt.Rows[0]["TENLOP"].ToString();
                lblKhoa.Text = dt.Rows[0]["TENKHOA"].ToString();
                // Load vào table
                
            }
            catch
            {
                MessageBox.Show("Không tìm thấy sinh viên");
            }
        
        }

        private void layDiemSV()
        {
            DataTable dt = new DataTable();
            string cmd1 = "EXEC SP_XEM_DIEM_SV '" + maSV + "'";
            dt = Program.ExecSqlDataTable(cmd1);
            this.bdsXemDiem.DataSource = dt;
            this.gcXemDiem.DataSource = this.bdsXemDiem;
        }



    }
}