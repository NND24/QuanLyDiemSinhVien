using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maKhoa = "";

        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_LTC);

        }

        private void frmLopTinChi_Load(object sender, System.EventArgs e)
        {


            qLDSV_TCDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_LTC.LOPTINCHI' table. You can move, or remove it, as needed.
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS_LTC.DANGKY' table. You can move, or remove it, as needed.
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

            maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString();
            Console.WriteLine(maKhoa);
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mPhongBan;
            loadCmbMonHoc();
            loadCmbGiangVien();

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = true;
            }
        }

        private void loadCmbMonHoc()
        {
            string cmd = "EXEC SP_LAY_DS_TATCA_MONHOC";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbMonHoc.DataSource = dt;
                cmbMonHoc.DisplayMember = "TENMH"; // Trường hiển thị
                cmbMonHoc.ValueMember = "MAMH";    // Trường giá trị
            }
            else
            {
                cmbMonHoc.DataSource = null;
            }
        }

        private void loadCmbGiangVien()
        {
            string cmd = "EXEC SP_LAY_DS_TATCA_GIANGVIEN";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                cmbGiangVien.DataSource = dt;
                cmbGiangVien.DisplayMember = "HoTen"; // Trường hiển thị
                cmbGiangVien.ValueMember = "MAGV";    // Trường giá trị
            }
            else
            {
                cmbGiangVien.DataSource = null;
            }
        }

        private void textEdit1_EditValueChanged(object sender, System.EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            panelControl1.Enabled = true;
            bdsLTC.AddNew();
            txtMaKhoa.Text = maKhoa;
            try
            {
                DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_MAKHOA");
                //String makhoa = dt.Rows[0][0].ToString();
                cmbKhoa.Text = maKhoa;
            }
            catch

            {
                bdsLTC.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = btnThoat.Enabled = true;
            gcLopTinChi.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            if (btnThem.Enabled == false) bdsLTC.Position = vitri;
            gcLopTinChi.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLTC.Position;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =  false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
            gcLopTinChi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 maltc = 0;
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ này do đã có sinh viên đăng ký", "",
                            MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp tín chỉ này không? ", "Xác nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maltc = int.Parse(((DataRowView)bdsLTC[bdsLTC.Position])["MALTC"].ToString());
                    bdsLTC.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet);
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ này do đã có sinh viên đăng ký","",
                            MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp tín chỉ này không? ", "Xác nhận", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maltc = int.Parse(((DataRowView)bdsLTC[bdsLTC.Position])["MALTC"].ToString());
                    bdsLTC.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp tín chỉ. Bạn hãy xóa lại\n" + ex.Message, "",
                                MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("MALTC", maltc);
                    return;
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp tín chỉ. Bạn hãy xóa lại\n" + ex.Message, "",
                                MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
                    bdsLTC.Position = bdsLTC.Find("MALTC", maltc);
                    return;
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng điền niên khóa!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            if (txtHocKy.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                txtHocKy.Focus();
                return;
            }

            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn môn học!", "", MessageBoxButtons.OK);
                cmbMonHoc.Focus();
                return;
            }
            if (txtMaGiangVien.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn giáo viên!", "", MessageBoxButtons.OK);
                cmbGiangVien.Focus();
                return;
            }
            if (seNhom.Text.Trim() == "0")
            {
                MessageBox.Show("vui lòng chọn nhóm!", "", MessageBoxButtons.OK);
                seNhom.Focus();
                return;
            }

            if (seSoSinhVienToiThieu.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập số sinh viên tối thiểu!", "", MessageBoxButtons.OK);
                seSoSinhVienToiThieu.Focus();
                return;
            }

            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                this.LOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI);
                gcLopTinChi.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = cmbKhoa.Enabled = true;
            btnGhi.Enabled = false;
            panelControl1.Enabled = false;
            cmbKhoa.Enabled = true;
         
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonHoc.SelectedItem != null)
            {
                DataRowView selectedRow = cmbMonHoc.SelectedItem as DataRowView;
                txtMaMonHoc.Text = selectedRow["MAMH"].ToString();
            }
            else
            {
                txtMaMonHoc.Text = string.Empty;
            }
        }

        private void cmbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGiangVien.SelectedItem != null)
            {
                DataRowView selectedRow = cmbGiangVien.SelectedItem as DataRowView;
                txtMaGiangVien.Text = selectedRow["MAGV"].ToString();
            }
            else
            {
                txtMaGiangVien.Text = string.Empty;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
                
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);
                maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload : " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}