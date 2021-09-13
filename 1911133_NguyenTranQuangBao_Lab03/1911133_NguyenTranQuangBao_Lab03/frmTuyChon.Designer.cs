
namespace _1911133_NguyenTranQuangBao_Lab03
{
    partial class frmTuyChon
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdMaSV = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTim.Location = new System.Drawing.Point(478, 54);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(53, 29);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(190, 53);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(282, 27);
            this.txtThongTin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // btnSapXep
            // 
            this.btnSapXep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSapXep.Location = new System.Drawing.Point(15, 274);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(94, 29);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(493, 274);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // rdMaSV
            // 
            this.rdMaSV.AutoSize = true;
            this.rdMaSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdMaSV.ForeColor = System.Drawing.Color.Blue;
            this.rdMaSV.Location = new System.Drawing.Point(6, 52);
            this.rdMaSV.Name = "rdMaSV";
            this.rdMaSV.Size = new System.Drawing.Size(74, 24);
            this.rdMaSV.TabIndex = 0;
            this.rdMaSV.TabStop = true;
            this.rdMaSV.Text = "Mã SV";
            this.rdMaSV.UseVisualStyleBackColor = true;
            this.rdMaSV.CheckedChanged += new System.EventHandler(this.rdMaSV_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdHoTen.ForeColor = System.Drawing.Color.Blue;
            this.rdHoTen.Location = new System.Drawing.Point(204, 52);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(77, 24);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.rdNgaySinh.Location = new System.Drawing.Point(390, 52);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(100, 24);
            this.rdNgaySinh.TabIndex = 2;
            this.rdNgaySinh.TabStop = true;
            this.rdNgaySinh.Text = "Ngày sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            this.rdNgaySinh.CheckedChanged += new System.EventHandler(this.rdNgaySinh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNgaySinh);
            this.groupBox1.Controls.Add(this.rdMaSV);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtThongTin);
            this.groupBox2.Location = new System.Drawing.Point(15, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Name = "frmTuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTuyChon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdMaSV;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}