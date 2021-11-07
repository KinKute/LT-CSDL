
namespace Lab6_Basic_Command
{
	partial class BillsForm
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
			this.dgvBillForm = new System.Windows.Forms.DataGridView();
			this.dtpTu = new System.Windows.Forms.DateTimePicker();
			this.dtpDen = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFind = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBillForm)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBillForm
			// 
			this.dgvBillForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvBillForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBillForm.Location = new System.Drawing.Point(12, 69);
			this.dgvBillForm.Name = "dgvBillForm";
			this.dgvBillForm.RowHeadersWidth = 51;
			this.dgvBillForm.RowTemplate.Height = 24;
			this.dgvBillForm.Size = new System.Drawing.Size(776, 369);
			this.dgvBillForm.TabIndex = 0;
			this.dgvBillForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillForm_CellContentClick);
			// 
			// dtpTu
			// 
			this.dtpTu.CustomFormat = "dd/MM/yyyy";
			this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTu.Location = new System.Drawing.Point(90, 12);
			this.dtpTu.Name = "dtpTu";
			this.dtpTu.Size = new System.Drawing.Size(200, 22);
			this.dtpTu.TabIndex = 1;
			// 
			// dtpDen
			// 
			this.dtpDen.CustomFormat = "dd/MM/yyyy";
			this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDen.Location = new System.Drawing.Point(462, 12);
			this.dtpDen.Name = "dtpDen";
			this.dtpDen.Size = new System.Drawing.Size(200, 22);
			this.dtpDen.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Từ ngày:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(351, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Đến ngày:";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(668, 11);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(75, 23);
			this.btnFind.TabIndex = 10;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// BillsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpDen);
			this.Controls.Add(this.dtpTu);
			this.Controls.Add(this.dgvBillForm);
			this.Name = "BillsForm";
			this.Text = "BillsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvBillForm)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBillForm;
		private System.Windows.Forms.DateTimePicker dtpTu;
		private System.Windows.Forms.DateTimePicker dtpDen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFind;
	}
}