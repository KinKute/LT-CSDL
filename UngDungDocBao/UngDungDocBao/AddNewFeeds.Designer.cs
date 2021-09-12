
namespace UngDungDocBao
{
    partial class AddNewFeeds
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbToaSoan = new System.Windows.Forms.ComboBox();
            this.txtTenChuyenMuc = new System.Windows.Forms.TextBox();
            this.txtRssLink = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toà soạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chuyên mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "RssLink";
            // 
            // cbbToaSoan
            // 
            this.cbbToaSoan.FormattingEnabled = true;
            this.cbbToaSoan.Location = new System.Drawing.Point(132, 9);
            this.cbbToaSoan.Name = "cbbToaSoan";
            this.cbbToaSoan.Size = new System.Drawing.Size(219, 28);
            this.cbbToaSoan.TabIndex = 3;
            // 
            // txtTenChuyenMuc
            // 
            this.txtTenChuyenMuc.Location = new System.Drawing.Point(132, 43);
            this.txtTenChuyenMuc.Name = "txtTenChuyenMuc";
            this.txtTenChuyenMuc.Size = new System.Drawing.Size(219, 27);
            this.txtTenChuyenMuc.TabIndex = 4;
            // 
            // txtRssLink
            // 
            this.txtRssLink.Location = new System.Drawing.Point(132, 76);
            this.txtRssLink.Name = "txtRssLink";
            this.txtRssLink.Size = new System.Drawing.Size(307, 27);
            this.txtRssLink.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddNewFeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 147);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRssLink);
            this.Controls.Add(this.txtTenChuyenMuc);
            this.Controls.Add(this.cbbToaSoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewFeeds";
            this.Text = "AddNewFeeds";
            this.Load += new System.EventHandler(this.AddNewFeeds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbToaSoan;
        private System.Windows.Forms.TextBox txtTenChuyenMuc;
        private System.Windows.Forms.TextBox txtRssLink;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}