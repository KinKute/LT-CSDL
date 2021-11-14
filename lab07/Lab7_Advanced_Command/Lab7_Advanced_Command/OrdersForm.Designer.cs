
namespace Lab7_Advanced_Command
{
	partial class OrdersForm
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
			this.dgvBill = new System.Windows.Forms.DataGridView();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBill
			// 
			this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBill.Location = new System.Drawing.Point(12, 76);
			this.dgvBill.Name = "dgvBill";
			this.dgvBill.RowHeadersWidth = 51;
			this.dgvBill.RowTemplate.Height = 24;
			this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBill.Size = new System.Drawing.Size(776, 362);
			this.dgvBill.TabIndex = 0;
			this.dgvBill.DoubleClick += new System.EventHandler(this.dgvBill_DoubleClick);
			// 
			// dtpDate
			// 
			this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDate.CustomFormat = "dd/MM/yyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(113, 12);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(141, 22);
			this.dtpDate.TabIndex = 1;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 19);
			this.label5.TabIndex = 6;
			this.label5.Text = "Chọn ngày";
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.dgvBill);
			this.Name = "OrdersForm";
			this.Text = "OrdersForm";
			this.Load += new System.EventHandler(this.OrdersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBill;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label5;
	}
}