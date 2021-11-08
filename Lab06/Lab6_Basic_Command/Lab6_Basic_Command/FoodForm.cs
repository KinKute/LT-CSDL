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

namespace Lab6_Basic_Command
{
	public partial class FoodForm : Form
	{
		public FoodForm()
		{
			InitializeComponent();
		}

		public void LoadFood(int catedoryID)
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";

			// tạo đối tượng thực thi lệnh
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = "SELECT Name FROM Category where ID =" + catedoryID;

			// mở kết nối tới CSDL
			sqlConnection.Open();

			// gán tên nhóm sản phẩm cho tiêu đề
			string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc món: " + catName;

			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + catedoryID;

			// tạo đối tượng dataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			// hiển thị danh sách món ăn lên form
			//dgvFood.DataSource = dt;
			ChangeName(dt);

			// đóng kết nối, giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = "UPDATE Food SET Name = N'" + txtName.Text + "', Unit = '" + txtUnit.Text + "', FoodCategoryID = " + txtFoodCategoryID.Text + ", Price = " + txtPrice.Text + ", Notes = '" + txtNote.Text + "'" +
													   " WHERE ID = " + txtID.Text;
			// mở kết nối tới csdl
			sqlConnection.Open();

			// thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			// đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm tài khoản thành công");

				//Tải lại dữ liệu
				LoadFood(Convert.ToInt32(txtFoodCategoryID.Text));

				// xoá các ô đã nhập
				txtName.Text = "";
				txtUnit.Text = "";
				txtFoodCategoryID.Text = "";
				txtPrice.Text = "";
				txtNote.Text = "";
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvFood.SelectedRows.Count == 0) return;

			var selectedRow = dgvFood.SelectedRows[0];
			string foodID = selectedRow.Cells[0].Value.ToString();

			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand command;
			command = sqlConnection.CreateCommand();

			// tạo truy vấn
			string query = "DELETE FROM Food WHERE ID =" + foodID;
			command.CommandText = query;

			sqlConnection.Open();

			int numOfRowsEffected = command.ExecuteNonQuery();
			if (numOfRowsEffected != 1)
			{
				MessageBox.Show("Không thực hiện được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				MessageBox.Show("Đã xoá đối tượng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			dgvFood.Rows.Remove(selectedRow);
			sqlConnection.Close();

		}

		public void ChangeName(DataTable table)
		{
			dgvFood.DataSource = table;
			dgvFood.Columns[0].ReadOnly = true;
			dgvFood.Columns[0].HeaderCell.Value = "Mã món";
			dgvFood.Columns[1].HeaderCell.Value = "Tên món ăn";
			dgvFood.Columns[2].HeaderCell.Value = "Đơn vị";
			dgvFood.Columns[3].Visible = false;
			dgvFood.Columns[3].HeaderCell.Value = "Mã loại";
			dgvFood.Columns[4].HeaderCell.Value = "Giá";
			dgvFood.Columns[5].HeaderCell.Value = "Ghi chú";
			dgvFood.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}


		private void FoodForm_Load(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
