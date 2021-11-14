using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
	public partial class foodInfoForm : Form
	{
		public foodInfoForm()
		{
			InitializeComponent();
		}

		private void foodInfoForm_Load(object sender, EventArgs e)
		{
			this.InitValues();
		}
		private void InitValues()
		{
			string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();

			// mở kết nối
			conn.Open();

			// lấy dữ liệu từ csdl đưa vào database
			adapter.Fill(ds, "Category");

			// hiển thị nhóm món ăn
			cbbCatName.DataSource = ds.Tables["Category"];
			cbbCatName.DisplayMember = "Name";
			cbbCatName.ValueMember = "ID";

			// đóng kết nối và giải phóng bộ nhớ
			conn.Close();
			conn.Dispose();
		}

		private void ResetText()
		{
			txtFoodId.ResetText();
			txtName.ResetText();
			txtNotes.ResetText();
			txtUnit.ResetText();
			cbbCatName.ResetText();
			nudPrice.ResetText();
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

				// thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
				cmd.Parameters.Add("@price", SqlDbType.Int);
				cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				cmd.Parameters["@id"].Direction = ParameterDirection.Output;

				//truyền giá trị vào thủ tục qua tham số
				cmd.Parameters["@name"].Value = txtName.Text;
				cmd.Parameters["@unit"].Value = txtUnit.Text;
				cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
				cmd.Parameters["@price"].Value = nudPrice.Value;
				cmd.Parameters["@notes"].Value = txtNotes.Text;

				// mở kết nối
				conn.Open();

				int numRowAffected = cmd.ExecuteNonQuery();

				// thông báo kết quả
				if (numRowAffected > 0)
				{
					string foodID = cmd.Parameters["@id"].Value.ToString();

					MessageBox.Show("Successfully add new food, Food id = " + foodID, "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding food failed");
				}

				// đóng kết nối
				conn.Close();
				conn.Dispose();
			}
			// bắt lỗi SQL và các lỗi khác
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
		}

		public void DisplayFoodInfo(DataRowView rowView)
		{
			try
			{
				txtFoodId.Text = rowView["ID"].ToString();
				txtName.Text = rowView["Name"].ToString();
				txtUnit.Text = rowView["Unit"].ToString();
				txtNotes.Text = rowView["Notes"].ToString();
				nudPrice.Text = rowView["Price"].ToString();

				cbbCatName.SelectedIndex = -1;

				// chọn nhóm món ăn tương ứng
				for (int index = 0; index < cbbCatName.Items.Count; index++)
				{
					DataRowView cat = cbbCatName.Items[index] as DataRowView;
					if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
					{
						cbbCatName.SelectedIndex = index;
						break;
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
				this.Close();	
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

				// thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
				cmd.Parameters.Add("@price", SqlDbType.Int);
				cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				// truyền giá trị vào thủ tục qua tham số
				cmd.Parameters["@id"].Value = int.Parse(txtFoodId.Text);
				cmd.Parameters["@name"].Value = txtName.Text;
				cmd.Parameters["@unit"].Value = txtUnit.Text;
				cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
				cmd.Parameters["@price"].Value = nudPrice.Value;
				cmd.Parameters["@notes"].Value = txtNotes.Text;

				// mở kết nối
				conn.Open();

				int numRowAffected = cmd.ExecuteNonQuery();

				//thông báo kết quả
				if (numRowAffected>0)
				{
					MessageBox.Show("Successfully updating food", "Message");

					this.ResetText();
				}
				else
				{
					MessageBox.Show("Updating food failed");
				}

				// đóng kết nỗi
				conn.Close();
				conn.Dispose();
			}

			// bắt lỗi SQL và các lỗi khác
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			AddFoodCategory addFood = new AddFoodCategory();
			addFood.FormClosed += new FormClosedEventHandler(foodInfoForm_FormClosed);
			addFood.Show(this);
		}

		private void foodInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cbbCatName.SelectedIndex;
			cbbCatName.SelectedIndex = -1;
			cbbCatName.SelectedIndex = index;
			InitValues();
		}
	}
}
