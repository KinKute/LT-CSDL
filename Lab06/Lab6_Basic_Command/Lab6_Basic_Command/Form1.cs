using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab6_Basic_Command
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			// tạo chuỗi kết nối tới cơ sở dữ liệu restaurantManagement
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";

			// tạo đối tượng kết nối
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			string query = "SELECT ID, Name, Type FROM Category";

			// thực thi query
			sqlCommand.CommandText = query;

			// mở kết nối tới CSDL
			sqlConnection.Open();

			// thực thi lệnh bằng phương thức ExcuteReader
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			// gọi hàm hiển thị dữ liệu lên màn hình
			this.DisplayCategory(sqlDataReader);

			// đóng kết nối
			sqlConnection.Close();
		}

		//hàm hiển thị dữ liệu lên lv
		private void DisplayCategory(SqlDataReader reader)
		{
			while (reader.Read())
			{
				// tạo 1 dòng mới trong listview
				ListViewItem item = new ListViewItem(reader["ID"].ToString());

				// thêm dòng mới vào lv
				lvCategory.Items.Add(item);

				// bổ sung các thông tin khác cho lv
				item.SubItems.Add(reader["Name"].ToString());
				item.SubItems.Add(reader["Type"].ToString());
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" + "VALUES (N'" + txtName.Text + "'," + txtType.Text + ")";

			// mở kết nối tới csdl
			sqlConnection.Open();

			// thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			// đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm món ăn thành công");

				// tải lại dữ liệu
				btnLoad.PerformClick();

				// xoá các ô đã nhập
				txtName.Text = "";
				txtType.Text = "";

			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
			}
			

		}

		private void lvCategory_Click(object sender, EventArgs e)
		{
			ListViewItem item = lvCategory.SelectedItems[0];

			txtID.Text = item.Text;
			txtName.Text = item.SubItems[1].Text;
			txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text +
																"', [Type] = " + (txtType.Text == "Thức uống" ? 0 : 1) +
																" WHERE ID = " + txtID.Text;

			// Mở kết nối tới CSDL
			sqlConnection.Open();

			// thực thi lệnh bằng phương thức excutereader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			// đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				// cập nhật lại dữ liệu trên lv
				ListViewItem item = lvCategory.SelectedItems[0];

				item.SubItems[1].Text = txtName.Text;
				item.SubItems[2].Text = txtType.Text;

				// xoá các ô đã nhập
				txtID.Text = "";
				txtName.Text = "";
				txtType.Text = "";

				// disable các nút xoá và cập nhật
				btnUpdate.Enabled = false;
				btnDelete.Enabled = false;

				MessageBox.Show("Cập nhật món thành công");

			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;

			// mở kết nối
			sqlConnection.Open();

			// thực thi lệnh bằng phương thức excutereader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			// đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				// cập nhật lại dữ liệu trên lv
				ListViewItem item = lvCategory.SelectedItems[0];
				lvCategory.Items.Remove(item);

				item.SubItems[1].Text = txtName.Text;
				item.SubItems[2].Text = txtType.Text;

				// xoá các ô đã nhập
				txtID.Text = "";
				txtName.Text = "";
				txtType.Text = "";

				// disable các nút xoá và cập nhật
				btnUpdate.Enabled = false;
				btnDelete.Enabled = false;

				MessageBox.Show("Cập nhật món thành công");

			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void tsmDelete_Click(object sender, EventArgs e)
		{
			if (lvCategory.SelectedItems.Count > 0)
			{
				btnDelete.PerformClick();
			}
		}

		private void tsmViewFood_Click(object sender, EventArgs e)
		{
			if (txtID.Text != "")
			{
				FoodForm foodForm = new FoodForm();
				foodForm.Show(this);
				foodForm.LoadFood(Convert.ToInt32(txtID.Text));
			}
		}

		private void btnBill_Click(object sender, EventArgs e)
		{
			BillsForm billsForm = new BillsForm();
			billsForm.ShowDialog();
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			AccountForm acc = new AccountForm();
			acc.ShowDialog();
		}

		private void btnTable_Click(object sender, EventArgs e)
		{
			tableForm table = new tableForm();
			table.ShowDialog();
		}
	}
}
