
namespace WinFormsApp2
{
    partial class GiaoVienForm
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
            this.lblMaSo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNSinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.lblDCMail = new System.Windows.Forms.Label();
            this.lblDSMH = new System.Windows.Forms.Label();
            this.lblMHGVD = new System.Windows.Forms.Label();
            this.lblWS = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.lbDanhSachMH = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbMonHocDay = new System.Windows.Forms.ListBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linklbLienHe = new System.Windows.Forms.LinkLabel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaSo.Location = new System.Drawing.Point(12, 59);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(57, 20);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSDT.Location = new System.Drawing.Point(410, 102);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(58, 20);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số ĐT";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(12, 95);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 20);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblNSinh
            // 
            this.lblNSinh.AutoSize = true;
            this.lblNSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNSinh.Location = new System.Drawing.Point(12, 128);
            this.lblNSinh.Name = "lblNSinh";
            this.lblNSinh.Size = new System.Drawing.Size(89, 20);
            this.lblNSinh.TabIndex = 4;
            this.lblNSinh.Text = "Ngày Sinh";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGT.Location = new System.Drawing.Point(410, 62);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(84, 20);
            this.lblGT.TabIndex = 5;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgoaiNgu.Location = new System.Drawing.Point(12, 191);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(93, 20);
            this.lblNgoaiNgu.TabIndex = 6;
            this.lblNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // lblDCMail
            // 
            this.lblDCMail.AutoSize = true;
            this.lblDCMail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDCMail.Location = new System.Drawing.Point(410, 133);
            this.lblDCMail.Name = "lblDCMail";
            this.lblDCMail.Size = new System.Drawing.Size(114, 20);
            this.lblDCMail.TabIndex = 7;
            this.lblDCMail.Text = "Địa chỉ Email";
            // 
            // lblDSMH
            // 
            this.lblDSMH.AutoSize = true;
            this.lblDSMH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDSMH.Location = new System.Drawing.Point(120, 304);
            this.lblDSMH.Name = "lblDSMH";
            this.lblDSMH.Size = new System.Drawing.Size(162, 20);
            this.lblDSMH.TabIndex = 8;
            this.lblDSMH.Text = "Danh sách môn học";
            // 
            // lblMHGVD
            // 
            this.lblMHGVD.AutoSize = true;
            this.lblMHGVD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMHGVD.Location = new System.Drawing.Point(432, 304);
            this.lblMHGVD.Name = "lblMHGVD";
            this.lblMHGVD.Size = new System.Drawing.Size(186, 20);
            this.lblMHGVD.TabIndex = 9;
            this.lblMHGVD.Text = "Môn học giáo viên dạy";
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWS.Location = new System.Drawing.Point(514, 591);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(69, 20);
            this.lblWS.TabIndex = 10;
            this.lblWS.Text = "Website";
            // 
            // cboMaSo
            // 
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cboMaSo.Location = new System.Drawing.Point(120, 59);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(108, 28);
            this.cboMaSo.TabIndex = 11;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(535, 59);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(62, 24);
            this.rdNam.TabIndex = 12;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(606, 60);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(50, 24);
            this.rdNu.TabIndex = 13;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(268, 27);
            this.txtHoTen.TabIndex = 14;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(531, 99);
            this.mtxtSoDT.Mask = "(\\0633).000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(125, 27);
            this.mtxtSoDT.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 128);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(268, 27);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(531, 133);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(196, 27);
            this.txtMail.TabIndex = 17;
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(120, 191);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(150, 92);
            this.chklbNgoaiNgu.TabIndex = 18;
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.FormattingEnabled = true;
            this.lbDanhSachMH.ItemHeight = 20;
            this.lbDanhSachMH.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhSachMH.Location = new System.Drawing.Point(120, 328);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachMH.Size = new System.Drawing.Size(191, 184);
            this.lbDanhSachMH.TabIndex = 19;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(343, 352);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(55, 47);
            this.btnChon.TabIndex = 20;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 430);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 47);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbMonHocDay
            // 
            this.lbMonHocDay.FormattingEnabled = true;
            this.lbMonHocDay.ItemHeight = 20;
            this.lbMonHocDay.Location = new System.Drawing.Point(441, 328);
            this.lbMonHocDay.Name = "lbMonHocDay";
            this.lbMonHocDay.Size = new System.Drawing.Size(191, 184);
            this.lbMonHocDay.TabIndex = 22;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(299, 540);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::WinFormsApp2.Properties.Resources.Untitled;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(441, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(589, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linklbLienHe
            // 
            this.linklbLienHe.AutoSize = true;
            this.linklbLienHe.Location = new System.Drawing.Point(589, 591);
            this.linklbLienHe.Name = "linklbLienHe";
            this.linklbLienHe.Size = new System.Drawing.Size(56, 20);
            this.linklbLienHe.TabIndex = 24;
            this.linklbLienHe.TabStop = true;
            this.linklbLienHe.Text = "Liên hệ";
            this.linklbLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbLienHe_LinkClicked);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(176, 540);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(47, 541);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 29);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // GiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 620);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.linklbLienHe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbMonHocDay);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbDanhSachMH);
            this.Controls.Add(this.chklbNgoaiNgu);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.lblWS);
            this.Controls.Add(this.lblMHGVD);
            this.Controls.Add(this.lblDSMH);
            this.Controls.Add(this.lblDCMail);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblNSinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSo);
            this.Name = "GiaoVienForm";
            this.Text = "Giáo Viên";
            this.Load += new System.EventHandler(this.GiaoVienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNSinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.Label lblDCMail;
        private System.Windows.Forms.Label lblDSMH;
        private System.Windows.Forms.Label lblMHGVD;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.ListBox lbDanhSachMH;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbMonHocDay;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linklbLienHe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
    }
}

