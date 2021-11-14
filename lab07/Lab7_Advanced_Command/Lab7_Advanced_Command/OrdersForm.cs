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
			OrderDetailsForm frm = new OrderDetailsForm();
			frm.Show(this);
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			LoadBill();
		}
	}
}
