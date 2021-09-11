
namespace WinFormsApp1
{
    partial class TrungTamForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMaHV = new System.Windows.Forms.ComboBox();
            this.lblTinhTienHocTrungTam = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.chkTinHocA = new System.Windows.Forms.CheckBox();
            this.chkTinHocB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTienTHA = new System.Windows.Forms.Label();
            this.lblTienTHB = new System.Windows.Forms.Label();
            this.lblTienTAB = new System.Windows.Forms.Label();
            this.lblTienTAA = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboMaHV
            // 
            this.cboMaHV.FormattingEnabled = true;
            this.cboMaHV.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.cboMaHV.Location = new System.Drawing.Point(150, 93);
            this.cboMaHV.Name = "cboMaHV";
            this.cboMaHV.Size = new System.Drawing.Size(151, 28);
            this.cboMaHV.TabIndex = 0;
            // 
            // lblTinhTienHocTrungTam
            // 
            this.lblTinhTienHocTrungTam.AutoSize = true;
            this.lblTinhTienHocTrungTam.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTinhTienHocTrungTam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTinhTienHocTrungTam.Location = new System.Drawing.Point(12, 9);
            this.lblTinhTienHocTrungTam.Name = "lblTinhTienHocTrungTam";
            this.lblTinhTienHocTrungTam.Size = new System.Drawing.Size(589, 45);
            this.lblTinhTienHocTrungTam.TabIndex = 1;
            this.lblTinhTienHocTrungTam.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(442, 94);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(62, 24);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(519, 94);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(50, 24);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.AutoSize = true;
            this.lblMaHocVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHocVien.Location = new System.Drawing.Point(21, 96);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(112, 20);
            this.lblMaHocVien.TabIndex = 2;
            this.lblMaHocVien.Text = "Mã Học Viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(21, 134);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 20);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayDangKy.Location = new System.Drawing.Point(21, 167);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(123, 20);
            this.lblNgayDangKy.TabIndex = 2;
            this.lblNgayDangKy.Text = "Ngày Đăng Ký";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.Location = new System.Drawing.Point(99, 346);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 20);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.Location = new System.Drawing.Point(329, 96);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(84, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 127);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(419, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(150, 160);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(263, 27);
            this.dtpNgayDangKy.TabIndex = 4;
            // 
            // chkTinHocA
            // 
            this.chkTinHocA.AutoSize = true;
            this.chkTinHocA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTinHocA.Location = new System.Drawing.Point(65, 212);
            this.chkTinHocA.Name = "chkTinHocA";
            this.chkTinHocA.Size = new System.Drawing.Size(95, 23);
            this.chkTinHocA.TabIndex = 5;
            this.chkTinHocA.Text = "Tin học A";
            this.chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // chkTinHocB
            // 
            this.chkTinHocB.AutoSize = true;
            this.chkTinHocB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTinHocB.Location = new System.Drawing.Point(65, 245);
            this.chkTinHocB.Name = "chkTinHocB";
            this.chkTinHocB.Size = new System.Drawing.Size(96, 23);
            this.chkTinHocB.TabIndex = 6;
            this.chkTinHocB.Text = "Tin học B";
            this.chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            this.chkTiengAnhB.AutoSize = true;
            this.chkTiengAnhB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTiengAnhB.Location = new System.Drawing.Point(65, 311);
            this.chkTiengAnhB.Name = "chkTiengAnhB";
            this.chkTiengAnhB.Size = new System.Drawing.Size(113, 23);
            this.chkTiengAnhB.TabIndex = 8;
            this.chkTiengAnhB.Text = "Tiếng Anh B";
            this.chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            this.chkTiengAnhA.AutoSize = true;
            this.chkTiengAnhA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTiengAnhA.Location = new System.Drawing.Point(65, 278);
            this.chkTiengAnhA.Name = "chkTiengAnhA";
            this.chkTiengAnhA.Size = new System.Drawing.Size(112, 23);
            this.chkTiengAnhA.TabIndex = 7;
            this.chkTiengAnhA.Text = "Tiếng Anh A";
            this.chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTinhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTinhTien.Location = new System.Drawing.Point(99, 380);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(113, 49);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(233, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(367, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 49);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTienTHA
            // 
            this.lblTienTHA.AutoSize = true;
            this.lblTienTHA.Location = new System.Drawing.Point(265, 215);
            this.lblTienTHA.Name = "lblTienTHA";
            this.lblTienTHA.Size = new System.Drawing.Size(99, 20);
            this.lblTienTHA.TabIndex = 12;
            this.lblTienTHA.Text = "300.000 đồng";
            // 
            // lblTienTHB
            // 
            this.lblTienTHB.AutoSize = true;
            this.lblTienTHB.Location = new System.Drawing.Point(265, 248);
            this.lblTienTHB.Name = "lblTienTHB";
            this.lblTienTHB.Size = new System.Drawing.Size(99, 20);
            this.lblTienTHB.TabIndex = 2;
            this.lblTienTHB.Text = "500.000 đồng";
            // 
            // lblTienTAB
            // 
            this.lblTienTAB.AutoSize = true;
            this.lblTienTAB.Location = new System.Drawing.Point(265, 314);
            this.lblTienTAB.Name = "lblTienTAB";
            this.lblTienTAB.Size = new System.Drawing.Size(99, 20);
            this.lblTienTAB.TabIndex = 2;
            this.lblTienTAB.Text = "600.000 đồng";
            // 
            // lblTienTAA
            // 
            this.lblTienTAA.AutoSize = true;
            this.lblTienTAA.Location = new System.Drawing.Point(265, 281);
            this.lblTienTAA.Name = "lblTienTAA";
            this.lblTienTAA.Size = new System.Drawing.Size(99, 20);
            this.lblTienTAA.TabIndex = 2;
            this.lblTienTAA.Text = "400.000 đồng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(215, 339);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(149, 27);
            this.txtTongTien.TabIndex = 9;
            // 
            // TrungTamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienTAA);
            this.Controls.Add(this.lblTienTAB);
            this.Controls.Add(this.lblTienTHB);
            this.Controls.Add(this.lblTienTHA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.chkTiengAnhA);
            this.Controls.Add(this.chkTiengAnhB);
            this.Controls.Add(this.chkTinHocB);
            this.Controls.Add(this.chkTinHocA);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaHocVien);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lblTinhTienHocTrungTam);
            this.Controls.Add(this.cboMaHV);
            this.Name = "TrungTamForm";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaHV;
        private System.Windows.Forms.Label lblTinhTienHocTrungTam;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.CheckBox chkTinHocA;
        private System.Windows.Forms.CheckBox chkTinHocB;
        private System.Windows.Forms.CheckBox chkTiengAnhB;
        private System.Windows.Forms.CheckBox chkTiengAnhA;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTienTHA;
        private System.Windows.Forms.Label lblTienTHB;
        private System.Windows.Forms.Label lblTienTAB;
        private System.Windows.Forms.Label lblTienTAA;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}

