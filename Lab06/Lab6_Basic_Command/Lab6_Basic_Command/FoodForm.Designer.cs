
namespace Lab6_Basic_Command
{
	partial class FoodForm
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
			this.dgvFood = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtFoodCategoryID = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvFood
			// 
			this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFood.Location = new System.Drawing.Point(12, 143);
			this.dgvFood.Name = "dgvFood";
			this.dgvFood.RowHeadersWidth = 51;
			this.dgvFood.RowTemplate.Height = 24;
			this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFood.Size = new System.Drawing.Size(955, 493);
			this.dgvFood.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(733, 97);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(114, 40);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(853, 97);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(114, 40);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 18);
			this.label2.TabIndex = 8;
			this.label2.Text = "ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 18);
			this.label1.TabIndex = 8;
			this.label1.Text = "Tên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Đơn vị tính:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(491, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Danh mục thực phẩm:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(494, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Giá:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(491, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 18);
			this.label6.TabIndex = 9;
			this.label6.Text = "Ghi chú:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(149, 9);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(252, 22);
			this.txtID.TabIndex = 10;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(149, 37);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(252, 22);
			this.txtName.TabIndex = 10;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(149, 65);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(252, 22);
			this.txtUnit.TabIndex = 10;
			// 
			// txtFoodCategoryID
			// 
			this.txtFoodCategoryID.Location = new System.Drawing.Point(683, 13);
			this.txtFoodCategoryID.Name = "txtFoodCategoryID";
			this.txtFoodCategoryID.Size = new System.Drawing.Size(252, 22);
			this.txtFoodCategoryID.TabIndex = 10;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(683, 41);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(252, 22);
			this.txtPrice.TabIndex = 10;
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(683, 69);
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(252, 22);
			this.txtNote.TabIndex = 10;
			// 
			// FoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(979, 648);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtFoodCategoryID);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dgvFood);
			this.Name = "FoodForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FoodForm";
			this.Load += new System.EventHandler(this.FoodForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFood;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtFoodCategoryID;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtNote;
	}
}