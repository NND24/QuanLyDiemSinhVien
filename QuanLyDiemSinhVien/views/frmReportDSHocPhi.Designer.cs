namespace QuanLyDiemSinhVien.views
{
    partial class frmReportDSHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDSHocPhi));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHocKy);
            this.panel2.Controls.Add(this.txtNienKhoa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 271);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Học Kỳ:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(411, 25);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Size = new System.Drawing.Size(212, 26);
            this.txtMaLop.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(506, 185);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(330, 185);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(90, 40);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Niên Khóa:";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(411, 80);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtNienKhoa.Size = new System.Drawing.Size(212, 26);
            this.txtNienKhoa.TabIndex = 10;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(411, 127);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Properties.Appearance.Options.UseFont = true;
            this.txtHocKy.Size = new System.Drawing.Size(212, 26);
            this.txtHocKy.TabIndex = 11;
            // 
            // frmReportDSHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 271);
            this.Controls.Add(this.panel2);
            this.Name = "frmReportDSHocPhi";
            this.Text = "Danh sách đóng học phí";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
    }
}