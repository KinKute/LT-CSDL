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
	public partial class AddFoodCategory : Form
	{
		public AddFoodCategory()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXECUTE InsertCategory @id OUTPUT, @name, @type";

				// thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@type", SqlDbType.Int);

				cmd.Parameters["@id"].Direction = ParameterDirection.Output;

				//truyền giá trị vào thủ tục qua tham số
				cmd.Parameters["@name"].Value = txtName.Text;
				cmd.Parameters["@type"].Value = txtType.Text;

				// mở kết nối
				conn.Open();

				int numRowAffected = cmd.ExecuteNonQuery();

				// thông báo kết quả
				if (numRowAffected > 0)
				{
					string catFoodID = cmd.Parameters["@id"].Value.ToString();

					MessageBox.Show("Successfully add new category food, Category Food id = " + catFoodID, "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding category food failed");
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
			//catch (Exception exception)
			//{
			//	MessageBox.Show(exception.Message, "Error");
			//}
		}

		private void AddFoodCategory_FormClosed(object sender, FormClosedEventArgs e)
		{

		}
	}
}
