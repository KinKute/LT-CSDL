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
	public partial class OrdersForm : Form
	{
		public OrdersForm()
		{
			InitializeComponent();
		}

		private void LoadBill()
		{
			string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT*FROM Bills";

			cmd.Parameters.Add("@date", SqlDbType.DateTime);
			cmd.Parameters["@date"].Value = DateTime.Parse(dtpDate.Value.ToString("dd/MM/yyyy"));

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);

			conn.Close();
			conn.Dispose();

			dgvBill.DataSource = table;
		}

		private void OrdersForm_Load(object sender, EventArgs e)
		{
			LoadBill();
		}

		private void dgvBill_DoubleClick(object sender, EventArgs e)
		{
			var billID = dgvBill.SelectedRows[0].Cells[0].Value.ToString();
			OrderDetailsForm frm = new OrderDetailsForm();
			frm.LoadBillDeTail(billID);
			frm.ShowDialog(this);
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			LoadBill();
		}

		private void btnFill_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXECUTE Bills_GetByDate @date";


				cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);
				cmd.Parameters["@date"].Value = DateTime.Parse(dtpDate.Value.ToString("dd/MM/yyyy"));

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();

				conn.Open();

				adapter.Fill(dt);

				cmd.CommandText = "Select SUM(Amount)from Bills where CheckoutDate =@date";

				var amountDate = cmd.ExecuteScalar();
				lblAmount.Text = amountDate.ToString();
				conn.Close();

				dgvBill.DataSource = dt;
				dgvBill.Columns[0].ReadOnly = true;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "SQL Error");
			}
		}
	}
}
