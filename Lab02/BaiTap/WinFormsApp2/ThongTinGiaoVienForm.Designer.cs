
namespace WinFormsApp2
{
    partial class ThongTinGiaoVienForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSDT);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(167, 26);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(118, 24);
            this.rdSDT.TabIndex = 1;
            this.rdSDT.Text = "Số điện thoại";
            this.rdSDT.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(86, 26);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(75, 24);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.Text = "Họ tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Checked = true;
            this.rdMaGV.Location = new System.Drawing.Point(6, 26);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(74, 24);
            this.rdMaGV.TabIndex = 1;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(18, 102);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(53, 20);
            this.lblMaGV.TabIndex = 1;
            this.lblMaGV.Text = "Mã GV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(109, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(310, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ThongTinGiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 165);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinGiaoVienForm";
            this.Text = "Tìm thông tin giáo viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOK;
    }
}