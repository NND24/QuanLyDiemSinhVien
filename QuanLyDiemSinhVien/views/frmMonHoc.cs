using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien.views
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private int viTri;
        private String flagmode = "";
        private int positionMH = -1;
        private String tenMH = "";  // Giữ tên Môn học lúc sửa
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
 
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.MONHOC' table. You can move, or remove it, as needed.
            qLDSV_HTCDataSet.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_HTCDataSet.LOPTINCHI);

        }

        private void sOTIET_LTSpinEdit_EditValueChanged(object sender, System.EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMH.Position;
            panelNhapLieu.Enabled = true;
            bdsMH.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gridControlMonHoc.Enabled = false;
            txtMaMH.Enabled = true;
            seSTLT.Value = 0;
            seSTTH.Value = 0;
            flagmode = "ADDMH";
        }

        private bool checkMH()
        {

            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMH.Focus();
                return false;
            }

            if (seSTLT.Value < 0)
            {
                MessageBox.Show("Số Tiết Lý Thuyết >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                seSTLT.Focus();
                return false;
            }
            if (seSTTH.Value < 0)
            {
                MessageBox.Show("Số tiết thưc hành >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                seSTTH.Focus();
                return false;
            }

            if ((seSTLT.Value + seSTTH.Value) <= 0 || (seSTLT.Value + seSTTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                seSTLT.Focus();
                return false;
            }


            if (flagmode.Equals("ADDMH"))
            {
                string query = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_KIEMTRA_ID] " +

                          " @ID = N'" + txtMaMH.Text.Trim() + "',  " +

                          " @Type = N'MAMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Môn Học đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMH.Focus();
                    return false;
                }

            }

            if (flagmode == "ADDMH" || (flagmode == "EDITMH" && tenMH != txtTenMH.Text.Trim()))
            {
                string query2 = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_KIEMTRA_TEN] " +

                          " @Name = N'" + txtTenMH.Text.Trim() + "',  " +

                          " @Type = N'TENMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";
                int result2 = Program.CheckDataHelper(query2);
                if (result2 == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (result2 == 1)
                {
                    MessageBox.Show("Tên Môn Học đã tồn tại. Mời bạn nhập tên khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return false;
                }
            }


            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsloptc.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã mở lớp tín chỉ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này không ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string mamh = "";
                try
                {
                    mamh = ((DataRowView)bdsMH[bdsMH.Position])["MAMH"].ToString();
                    bdsMH.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.qLDSV_HTCDataSet.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
                    bdsMH.Position = bdsMH.Find("MAMH", mamh);
                    return;
                }
            }
            if (bdsMH.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
        
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMH.Position;
            panelNhapLieu.Enabled= true;

            txtMaMH.Enabled= false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gridControlMonHoc.Enabled = false;
            tenMH = txtTenMH.Text.Trim();
            flagmode = "EDITMH";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkMH() == true)
            {
                try
                {
                    bdsMH.EndEdit();
                    bdsMH.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.qLDSV_HTCDataSet.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                flagmode = "";
                tenMH = "";
                gridControlMonHoc.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                panelNhapLieu.Enabled = false;
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagmode == "ADDMH" || flagmode == "EDITMH")
            {
                if (MessageBox.Show("Dữ liệu chưa được lưu! Bạn có muốn thoát không không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
            bdsMH.Position = positionMH;

            panelNhapLieu.Enabled = false;

            btnThem.Enabled = true;

            if (bdsMH.Count > 0)
                btnXoa.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            gridControlMonHoc.Enabled = true;
            flagmode = "";
            tenMH = "";
        }
    }
}