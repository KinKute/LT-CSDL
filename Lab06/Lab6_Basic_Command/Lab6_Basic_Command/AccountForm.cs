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
	public partial class AccountForm : Form
	{
		public AccountForm()
		{
			InitializeComponent();
			LoadAcc();
			AddAccountBinding();
		}


		public void LoadAcc()
		{
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT * FROM Account"; ;

			connection.Open();

			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Bill");
			adapter.Fill(table);

			SetColumnsHeaderText(table);

			// Prevent user to edit ID
			dgvAccount.Columns[0].ReadOnly = true;

			connection.Close();

			command.Dispose();
		}


		private void SetColumnsHeaderText(DataTable dt)
		{
			dgvAccount.DataSource = dt;
			dgvAccount.Columns[0].HeaderText = "Tên TK";
			dgvAccount.Columns[1].HeaderText = "Mật khẩu";
			dgvAccount.Columns[2].HeaderText = "Tên đầy đủ";
			dgvAccount.Columns[3].HeaderText = "Email";
			dgvAccount.Columns[4].HeaderText = "Điện thoại";
			dgvAccount.Columns[5].HeaderText = "Ngày tạo";

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvAccount.SelectedRows.Count == 0) return;

			var selectedRow = dgvAccount.SelectedRows[0];
			string accID = selectedRow.Cells[0].Value.ToString();

			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand command;
			command = sqlConnection.CreateCommand();

			// tạo truy vấn
			command.CommandText = string.Format("delete * from Account");
			//command.CommandText = query;

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
			dgvAccount.Rows.Remove(selectedRow);
			sqlConnection.Close();
			sqlConnection.Dispose();

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = string.Format("insert into Account(AccountName,Password, FullName, Email, Tell, DateCreated) values ('{0}', '{1}', N'{2}', '{3}', '{4}', '{5}')", txtTenTK.Text, txtPass.Text, txtFullName.Text, txtEmail.Text, txtNum.Text, DateTime.Now);
			// mở kết nối tới csdl
			sqlConnection.Open();

			// thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm tài khoản thành công");

				//Tải lại dữ liệu
				LoadAcc();

				// xoá các ô đã nhập
				txtTenTK.Text = "";
				txtPass.Text = "";
				txtFullName.Text = "";
				txtEmail.Text = "";
				txtNum.Text = "";
			}

			else
			{
				MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
			}

			// đóng kết nối
			sqlConnection.Close();
		}

		public void AddAccountBinding()
		{
			txtTenTK.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "AccountName"));
			txtPass.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Password"));
			txtFullName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "FullName"));
			txtEmail.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Email"));
			txtNum.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tell"));
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
		}
	}
}
