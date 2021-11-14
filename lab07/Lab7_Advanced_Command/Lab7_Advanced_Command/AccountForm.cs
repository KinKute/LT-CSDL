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
	public partial class AccountForm : Form
	{
		public AccountForm()
		{
			InitializeComponent();
		}

		private void LoadAccount()
		{
			string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT*FROM Account";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();

			conn.Open();
			adapter.Fill(table);

			dgvData.DataSource = table;
			dgvData.Columns[0].ReadOnly = true;

			conn.Close();
			conn.Dispose();


		}

		private void AccountForm_Load(object sender, EventArgs e)
		{
			LoadAccount();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXECUTE InsertAccount @AccountName, @Password, @FullName, @Email, @Tell, @DateCreate";

				cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100);
				cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 200);
				cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
				cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 200);
				cmd.Parameters.Add("@DateCreate", SqlDbType.SmallDateTime);

				cmd.Parameters["@AccountName"].Value = txtAcc.Text;
				cmd.Parameters["@Password"].Value = txtPass.Text;
				cmd.Parameters["@FullName"].Value = txtFullName.Text;
				cmd.Parameters["@Email"].Value = txtEmail.Text;
				cmd.Parameters["@Tell"].Value = txtTell.Text;
				cmd.Parameters["@DateCreate"].Value = DateTime.Now.ToShortDateString();

				conn.Open();

				int numRowAffected = cmd.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string accName = cmd.Parameters["@AccountName"].Value.ToString();
					MessageBox.Show("Successfully adding new account " + accName, "Message");
					ResetText();
				}
				else
				{
					MessageBox.Show("Adding account failed");
				}

				conn.Close();
				conn.Dispose();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
		}

		private void ResetText()
		{
			txtAcc.Text = "";
			txtPass.Text = "";
			txtFullName.Text = "";
			txtEmail.Text = "";
			txtTell.Text = "";
		}

		private void dgvData_Click(object sender, EventArgs e)
		{
			int index = dgvData.CurrentRow.Index;

			if (index != null)
			{
				txtAcc.Text = dgvData.Rows[index].Cells["AccountName"].Value.ToString();
				txtPass.Text = dgvData.Rows[index].Cells["PassWord"].Value.ToString();
				txtFullName.Text = dgvData.Rows[index].Cells["FullName"].Value.ToString();
				txtEmail.Text = dgvData.Rows[index].Cells["Email"].Value.ToString();
				txtTell.Text = dgvData.Rows[index].Cells["Tell"].Value.ToString();
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetText();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
		{

		}
	}
}
