namespace QuanLyDiemSinhVien.views
{
    partial class frmReportDSSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDSSinhVien));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qLDSV_HTCDataSet = new QuanLyDiemSinhVien.QLDSV_HTCDataSet();
            this.bdsTenMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOC1TableAdapter = new QuanLyDiemSinhVien.QLDSV_HTCDataSetTableAdapters.MONHOC1TableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenMH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbMonHoc);
            this.panel2.Controls.Add(this.cmbNhom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbKhoa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.cmbHocKy);
            this.panel2.Controls.Add(this.cmbNienKhoa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 756);
            this.panel2.TabIndex = 1;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(474, 171);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(212, 27);
            this.cmbMonHoc.TabIndex = 12;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // cmbNhom
            // 
            this.cmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(474, 211);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(212, 27);
            this.cmbNhom.TabIndex = 9;
            this.cmbNhom.SelectedIndexChanged += new System.EventHandler(this.cmbNhom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Môn Học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhóm:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(474, 44);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(212, 27);
            this.cmbKhoa.TabIndex = 8;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khoa:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(586, 256);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 40);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(410, 256);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 40);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "In";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(474, 126);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(212, 27);
            this.cmbHocKy.TabIndex = 4;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(474, 85);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(212, 27);
            this.cmbNienKhoa.TabIndex = 2;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học Kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Niên Khóa:";
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTenMH
            // 
            this.bdsTenMH.DataMember = "MONHOC1";
            this.bdsTenMH.DataSource = this.qLDSV_HTCDataSet;
            // 
            // mONHOC1TableAdapter
            // 
            this.mONHOC1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOC1TableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmReportDSSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 756);
            this.Controls.Add(this.panel2);
            this.Name = "frmReportDSSinhVien";
            this.Text = "Danh sách sinh viên theo lớp tín chỉ";
            this.Load += new System.EventHandler(this.frmReportDSSinhVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource bdsTenMH;
        private QLDSV_HTCDataSetTableAdapters.MONHOC1TableAdapter mONHOC1TableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMonHoc;
    }
}