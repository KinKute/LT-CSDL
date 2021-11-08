
namespace Lab6_Basic_Command
{
	partial class AccountForm
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
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			this.txtTenTK = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xoaTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
			this.danhSachVaiTro = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAccount
			// 
			this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvAccount.Location = new System.Drawing.Point(12, 148);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.RowHeadersWidth = 51;
			this.dgvAccount.RowTemplate.Height = 24;
			this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAccount.Size = new System.Drawing.Size(776, 453);
			this.dgvAccount.TabIndex = 0;
			// 
			// txtTenTK
			// 
			this.txtTenTK.Location = new System.Drawing.Point(113, 10);
			this.txtTenTK.Name = "txtTenTK";
			this.txtTenTK.Size = new System.Drawing.Size(252, 22);
			this.txtTenTK.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 12;
			this.label2.Text = "Tên TK:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(434, 102);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(114, 40);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(674, 102);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(114, 40);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(503, 9);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(252, 22);
			this.txtEmail.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(410, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 18);
			this.label1.TabIndex = 14;
			this.label1.Text = "Email:";
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(113, 66);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(252, 22);
			this.txtFullName.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 18);
			this.label3.TabIndex = 16;
			this.label3.Text = "Tên đầy đủ:";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(113, 38);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(252, 22);
			this.txtPass.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 18);
			this.label4.TabIndex = 18;
			this.label4.Text = "Mật khẩu:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(410, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 18);
			this.label6.TabIndex = 14;
			this.label6.Text = "Điện thoại:";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(503, 41);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(252, 22);
			this.txtNum.TabIndex = 15;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaTaiKhoan,
            this.danhSachVaiTro});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(225, 52);
			// 
			// xoaTaiKhoan
			// 
			this.xoaTaiKhoan.Name = "xoaTaiKhoan";
			this.xoaTaiKhoan.Size = new System.Drawing.Size(224, 24);
			this.xoaTaiKhoan.Text = "Xóa tài khoản";
			// 
			// danhSachVaiTro
			// 
			this.danhSachVaiTro.Name = "danhSachVaiTro";
			this.danhSachVaiTro.Size = new System.Drawing.Size(224, 24);
			this.danhSachVaiTro.Text = "Xem danh sách vai trò";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(554, 102);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(114, 40);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 613);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTenTK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvAccount);
			this.Name = "AccountForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AccountForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAccount;
		private System.Windows.Forms.TextBox txtTenTK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem xoaTaiKhoan;
		private System.Windows.Forms.ToolStripMenuItem danhSachVaiTro;
		private System.Windows.Forms.Button btnUpdate;
	}
}