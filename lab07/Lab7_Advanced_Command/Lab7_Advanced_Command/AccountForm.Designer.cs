
namespace Lab7_Advanced_Command
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
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAcc = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTell = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xemDanhSáchCácVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemNhậtKýHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvData
			// 
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvData.Location = new System.Drawing.Point(12, 137);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowHeadersWidth = 51;
			this.dgvData.RowTemplate.Height = 24;
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(776, 310);
			this.dgvData.TabIndex = 0;
			this.dgvData.Click += new System.EventHandler(this.dgvData_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 19);
			this.label5.TabIndex = 7;
			this.label5.Text = "Account name";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(390, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "Password";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Full name";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(390, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Emaiil";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tell";
			// 
			// txtAcc
			// 
			this.txtAcc.Location = new System.Drawing.Point(135, 12);
			this.txtAcc.Name = "txtAcc";
			this.txtAcc.Size = new System.Drawing.Size(178, 22);
			this.txtAcc.TabIndex = 8;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(498, 14);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(178, 22);
			this.txtPass.TabIndex = 9;
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(135, 40);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(178, 22);
			this.txtFullName.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(498, 42);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(178, 22);
			this.txtEmail.TabIndex = 9;
			// 
			// txtTell
			// 
			this.txtTell.Location = new System.Drawing.Point(135, 68);
			this.txtTell.Name = "txtTell";
			this.txtTell.Size = new System.Drawing.Size(178, 22);
			this.txtTell.TabIndex = 9;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchCácVaiTròToolStripMenuItem,
            this.xemNhậtKýHoạtĐộngToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(251, 52);
			// 
			// xemDanhSáchCácVaiTròToolStripMenuItem
			// 
			this.xemDanhSáchCácVaiTròToolStripMenuItem.Name = "xemDanhSáchCácVaiTròToolStripMenuItem";
			this.xemDanhSáchCácVaiTròToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
			this.xemDanhSáchCácVaiTròToolStripMenuItem.Text = "Xem danh sách các vai trò";
			// 
			// xemNhậtKýHoạtĐộngToolStripMenuItem
			// 
			this.xemNhậtKýHoạtĐộngToolStripMenuItem.Name = "xemNhậtKýHoạtĐộngToolStripMenuItem";
			this.xemNhậtKýHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
			this.xemNhậtKýHoạtĐộngToolStripMenuItem.Text = "Xem nhật ký hoạt động";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(439, 98);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 33);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(520, 98);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnUpdate.TabIndex = 12;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(601, 98);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 33);
			this.btnReset.TabIndex = 12;
			this.btnReset.Text = "&Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtTell);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtAcc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgvData);
			this.Name = "AccountForm";
			this.Text = "AccountForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountForm_FormClosed);
			this.Load += new System.EventHandler(this.AccountForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAcc;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTell;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem xemDanhSáchCácVaiTròToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHoạtĐộngToolStripMenuItem;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnReset;
	}
}