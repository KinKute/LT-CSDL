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
	public partial class tableForm : Form
	{
		public tableForm()
		{
			InitializeComponent();
			LoadTable();
		}

		public void LoadTable()
		{
			// tạo đối tượng kết nối
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";

			// tạo đối tượng thực thi lệnh
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			// thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = "SELECT * FROM Table ";

			// mở kết nối tới CSDL
			sqlConnection.Open();


			// tạo đối tượng dataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Table");
			da.Fill(dt);

			// hiển thị danh sách món ăn lên form
			dgvTable.DataSource = dt;
			//ChangeName(dt);

			// đóng kết nối, giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void SetColumnsHeaderText(DataTable dt)
		{
			//dgvTable.DataSource = dt;
			//dgvTable.Columns[0].HeaderText = "Tên TK";
			//dgvTable.Columns[1].HeaderText = "Mật khẩu";
			//dgvTable.Columns[2].HeaderText = "Tên đầy đủ";
			//dgvTable.Columns[3].HeaderText = "Email";
			//dgvTable.Columns[4].HeaderText = "Điện thoại";
			//dgvTable.Columns[5].HeaderText = "Ngày tạo";
		}
	}
}
