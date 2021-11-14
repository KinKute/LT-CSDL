
namespace Lab7_Advanced_Command
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSeperator = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblCatName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearchByName = new System.Windows.Forms.TextBox();
			this.btnBill = new System.Windows.Forms.Button();
			this.btnAcc = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn nhóm món ăn";
			// 
			// cbbCategory
			// 
			this.cbbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(209, 11);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(171, 24);
			this.cbbCategory.TabIndex = 1;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvFoodList.Location = new System.Drawing.Point(12, 44);
			this.dgvFoodList.MultiSelect = false;
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.RowHeadersWidth = 51;
			this.dgvFoodList.RowTemplate.Height = 24;
			this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFoodList.Size = new System.Drawing.Size(1225, 342);
			this.dgvFoodList.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmSeperator,
            this.tsmAddFood,
            this.tsmUpdateFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(218, 100);
			// 
			// tsmCalculateQuantity
			// 
			this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
			this.tsmCalculateQuantity.Size = new System.Drawing.Size(217, 24);
			this.tsmCalculateQuantity.Text = "Tính số lượng bàn ăn";
			this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
			// 
			// tsmSeperator
			// 
			this.tsmSeperator.Name = "tsmSeperator";
			this.tsmSeperator.Size = new System.Drawing.Size(217, 24);
			this.tsmSeperator.Text = "toolStripMenuItem2";
			// 
			// tsmAddFood
			// 
			this.tsmAddFood.Name = "tsmAddFood";
			this.tsmAddFood.Size = new System.Drawing.Size(217, 24);
			this.tsmAddFood.Text = "Thêm món ăn";
			this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
			// 
			// tsmUpdateFood
			// 
			this.tsmUpdateFood.Name = "tsmUpdateFood";
			this.tsmUpdateFood.Size = new System.Drawing.Size(217, 24);
			this.tsmUpdateFood.Text = "Cập nhật món ăn";
			this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 422);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Có tất cả:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(137, 422);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "món ăn thuộc nhóm:";
			// 
			// lblQuantity
			// 
			this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(98, 422);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(21, 19);
			this.lblQuantity.TabIndex = 0;
			this.lblQuantity.Text = "...";
			// 
			// lblCatName
			// 
			this.lblCatName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCatName.AutoSize = true;
			this.lblCatName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCatName.Location = new System.Drawing.Point(306, 422);
			this.lblCatName.Name = "lblCatName";
			this.lblCatName.Size = new System.Drawing.Size(21, 19);
			this.lblCatName.TabIndex = 0;
			this.lblCatName.Text = "...";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(404, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tìm kiếm theo tên:";
			// 
			// txtSearchByName
			// 
			this.txtSearchByName.Location = new System.Drawing.Point(576, 13);
			this.txtSearchByName.Name = "txtSearchByName";
			this.txtSearchByName.Size = new System.Drawing.Size(252, 22);
			this.txtSearchByName.TabIndex = 3;
			this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
			// 
			// btnBill
			// 
			this.btnBill.Location = new System.Drawing.Point(834, 13);
			this.btnBill.Name = "btnBill";
			this.btnBill.Size = new System.Drawing.Size(125, 25);
			this.btnBill.TabIndex = 4;
			this.btnBill.Text = "Xuất hoá đơn";
			this.btnBill.UseVisualStyleBackColor = true;
			this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
			// 
			// btnAcc
			// 
			this.btnAcc.Location = new System.Drawing.Point(965, 11);
			this.btnAcc.Name = "btnAcc";
			this.btnAcc.Size = new System.Drawing.Size(125, 25);
			this.btnAcc.TabIndex = 4;
			this.btnAcc.Text = "Tài khoản";
			this.btnAcc.UseVisualStyleBackColor = true;
			this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1249, 450);
			this.Controls.Add(this.btnAcc);
			this.Controls.Add(this.btnBill);
			this.Controls.Add(this.txtSearchByName);
			this.Controls.Add(this.dgvFoodList);
			this.Controls.Add(this.cbbCategory);
			this.Controls.Add(this.lblCatName);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
		private System.Windows.Forms.ToolStripMenuItem tsmSeperator;
		private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
		private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSearchByName;
		private System.Windows.Forms.Button btnBill;
		private System.Windows.Forms.Button btnAcc;
	}
}

