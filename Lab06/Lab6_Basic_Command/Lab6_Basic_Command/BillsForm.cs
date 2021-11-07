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
	public partial class BillsForm : Form
	{
		bool check = false;
		string query;

		public BillsForm()
		{
			InitializeComponent();
			LoadBills();
		}

		public void LoadBills()
		{
			if (check == false)
			{
				query = "SELECT * FROM Bills";

			}
			string connectionString = @"Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = query;

			connection.Open();

			//string categoryName = command.ExecuteScalar().ToString();
			//this.Text = "Danh sách toàn bộ hóa đơn";


			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Bill");
			adapter.Fill(table);

			dgvBillForm.DataSource = table;

			// Prevent user to edit ID
			dgvBillForm.Columns[0].ReadOnly = true;

			connection.Close();

			command.Dispose();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			string dtpDau = dtpTu.Value.ToShortDateString();
			string dtpCuoi = dtpDen.Value.ToShortDateString();

			query= $"set dateformat dmy select * from Bills where '{dtpDau}' <= CHECKOUTDATE and CHECKOUTDATE <= '{dtpCuoi}'";
			check = true;
			LoadBills();
		}

		private void dgvBillForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//BillDetailsForm billDetails = new BillDetailsForm();
			//string billID = dgvBillForm.SelectedRows[0].Cells[0].Value.ToString();
			//billDetails.LoadBillDetails(int.Parse(billID));
			//billDetails.Show();
		}
	}
}
