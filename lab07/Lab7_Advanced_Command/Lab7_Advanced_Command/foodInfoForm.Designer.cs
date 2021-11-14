
namespace Lab7_Advanced_Command
{
	partial class foodInfoForm
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFoodId = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cbbCatName = new System.Windows.Forms.ComboBox();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "FoodID";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Unit";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Price";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "CategoryName";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 19);
			this.label6.TabIndex = 6;
			this.label6.Text = "Notes";
			// 
			// txtFoodId
			// 
			this.txtFoodId.Location = new System.Drawing.Point(166, 12);
			this.txtFoodId.Name = "txtFoodId";
			this.txtFoodId.ReadOnly = true;
			this.txtFoodId.Size = new System.Drawing.Size(218, 22);
			this.txtFoodId.TabIndex = 7;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(166, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(404, 22);
			this.txtName.TabIndex = 7;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(166, 68);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(404, 22);
			this.txtUnit.TabIndex = 7;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(167, 154);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(403, 22);
			this.txtNotes.TabIndex = 7;
			// 
			// cbbCatName
			// 
			this.cbbCatName.FormattingEnabled = true;
			this.cbbCatName.Location = new System.Drawing.Point(166, 96);
			this.cbbCatName.Name = "cbbCatName";
			this.cbbCatName.Size = new System.Drawing.Size(292, 24);
			this.cbbCatName.TabIndex = 8;
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(167, 126);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(403, 22);
			this.nudPrice.TabIndex = 9;
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(464, 96);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(106, 24);
			this.btnAddNew.TabIndex = 10;
			this.btnAddNew.Text = "Add &New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(183, 191);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(76, 24);
			this.btnAddFood.TabIndex = 10;
			this.btnAddFood.Text = "&Add";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(281, 191);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(76, 24);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(382, 191);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(76, 24);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// foodInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 262);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.cbbCatName);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtFoodId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "foodInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "foodInfoForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.foodInfoForm_FormClosed);
			this.Load += new System.EventHandler(this.foodInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFoodId;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.ComboBox cbbCatName;
		private System.Windows.Forms.NumericUpDown nudPrice;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancel;
	}
}