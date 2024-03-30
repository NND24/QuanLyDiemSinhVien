using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        private string maSV = Program.username.ToUpper();
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsLopDaDangKy = new BindingSource();

        public frmDangKyLTC()
        {
            InitializeComponent();
            layThongTinSinhVien();
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
            }
            catch
            {
                MessageBox.Show("Không tìm thấy sinh viên");
            }
        }

        private void loadCmbNienKhoa()
        {
            string cmd = "EXEC SP_LAY_DS_NIENKHOA";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbNienKhoa.DataSource = dt;
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
        }

        private void loadCmbHocKy(string nienKhoa)
        {
            string cmd = "EXEC SP_LAY_DS_HOCKY '" + nienKhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cmbHocKy.DataSource = dt;
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
        }

        private void frmDangKyLTC_Load(object sender, System.EventArgs e)
        {
            loadCmbNienKhoa();
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadCmbHocKy(cmbNienKhoa.Text);
        }


        private void loadData()
        {
            string cmd = "EXEC SP_LAY_DS_LTC_DANGKY '" + cmbNienKhoa.Text + "', '" + cmbHocKy.Text + "', '" + maSV + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.gcLopTinChi.DataSource = this.bdsLopTinchi;

            string cmd2 = "EXEC SP_LAY_DS_LTC_DADANGKY '" + cmbNienKhoa.Text + "', '" + cmbHocKy.Text + "', '" + maSV + "'";
            DataTable tableLopTCDaDKy = Program.ExecSqlDataTable(cmd2);
            this.bdsLopDaDangKy.DataSource = tableLopTCDaDKy;
            this.gcLopDaDK.DataSource = this.bdsLopDaDangKy;

            panelDangKy.Enabled = false;
            this.btnDangKy.BackColor = System.Drawing.Color.LightGray;
            this.btnHuyDK.BackColor = System.Drawing.Color.LightGray;
            txtMaLopTinChi.Text = null;
            txtMonHoc.Text = null;
            txtGiangVien.Text = null;
        }

        private void btnTim_Click(object sender, System.EventArgs e)
        {
            loadData();
        }

        private void gvLopTinChi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {
                txtMaLopTinChi.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
                txtMonHoc.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["TENMH"].ToString();
                txtGiangVien.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["GIANGVIEN"].ToString();
            }
            panelDangKy.Enabled = true;
            btnDangKy.Enabled = true;
            btnHuyDK.Enabled = false;
            this.btnDangKy.BackColor = System.Drawing.Color.LightBlue;
            this.btnHuyDK.BackColor = System.Drawing.Color.LightGray;
        }

        private void gvLopDaDK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (bdsLopDaDangKy.Count > 0)
            {
                txtMaLopTinChi.Text = ((DataRowView)bdsLopDaDangKy[bdsLopDaDangKy.Position])["MALTC"].ToString();
                txtMonHoc.Text = ((DataRowView)bdsLopDaDangKy[bdsLopDaDangKy.Position])["TENMH"].ToString();
                txtGiangVien.Text = ((DataRowView)bdsLopDaDangKy[bdsLopDaDangKy.Position])["GIANGVIEN"].ToString();
            }
            panelDangKy.Enabled = true;
            btnDangKy.Enabled = false;
            btnHuyDK.Enabled = true;
            this.btnDangKy.BackColor = System.Drawing.Color.LightGray;
            this.btnHuyDK.BackColor = System.Drawing.Color.LightBlue;
        }

        private void btnDangKy_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng ký lớp học này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC SP_DANGKY_LTC '" + txtMaLopTinChi.Text + "', '" + maSV + "'";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
            }
        }

        private void btnHuyDK_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy đăng ký lớp học này?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC SP_HUYDANGKY_LTC '" + txtMaLopTinChi.Text + "', '" + maSV + "'";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy ký thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Hủy ký thất bại!");
                }
            }
        }


    }
}