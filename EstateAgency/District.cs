namespace EstateAgency
{
	using System;
	using System.Data.OleDb;
	using System.Windows.Forms;

	using EstateAgency.Properties;
	using EstateAgency.Services;

	public partial class District : Form
	{
		private readonly DataContext dataContext;

		public District()
		{
			this.dataContext = new DataContext();
			this.InitializeComponent();
		}

		private void District_Load(object sender, EventArgs e)
		{
			this.UpdateTable();
		}

		private void ToolStripButton1Click(object sender, EventArgs e)
		{
			this.districtDataView.EndEdit();
			var dataGridViewRow = this.districtDataView.CurrentRow;

			if (dataGridViewRow != null)
			{
				var indexCurrentRow = this.districtDataView.Rows[dataGridViewRow.Index].Cells["ID"].Value;

				var odbcConnection = new OleDbConnection { ConnectionString = Settings.Default.AgencyConnectionString };
				odbcConnection.Open();

				if (indexCurrentRow == DBNull.Value)
				{
					
					var sqlComm = new OleDbCommand("INSERT INTO [District] (Район) VALUES (@Район)", odbcConnection);

					var district = this.districtDataView.Rows[this.districtDataView.Rows.Count - 1].Cells["Район"].Value;
					sqlComm.Parameters.AddWithValue("@Район", district);

					sqlComm.ExecuteNonQuery();
					
				}
				else
				{
					var sqlComm = new OleDbCommand("UPDATE District SET Район = @Район WHERE ID = @ID", odbcConnection);
					
					sqlComm.Parameters.AddWithValue("@Район", this.districtDataView.Rows[dataGridViewRow.Index].Cells["Район"].Value);
					sqlComm.Parameters.AddWithValue("@ID", indexCurrentRow);
					sqlComm.ExecuteNonQuery();
				}

				odbcConnection.Close();
			}

			this.UpdateTable();
			this.applyChangeBtn.Enabled = false;
		}

		private void BindingNavigatorDeleteItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show(Resources.Delete_Question, Resources.Confirm_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var odbcConnection = new OleDbConnection { ConnectionString = Settings.Default.AgencyConnectionString };
					odbcConnection.Open();
					var sqlComm = new OleDbCommand("DELETE FROM [District] WHERE ID = @ID", odbcConnection);


					var dataGridViewRow = this.districtDataView.CurrentRow;
					if (dataGridViewRow != null)
					{
						var itemIndex = this.districtDataView.Rows[dataGridViewRow.Index].Cells["ID"].Value;
						sqlComm.Parameters.AddWithValue("@ID", itemIndex);
					}

					sqlComm.ExecuteNonQuery();
					odbcConnection.Close();
				}
				catch (OleDbException exception)
				{
					MessageBox.Show(exception.Message, Resources.Delete_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				this.UpdateTable();
			}
		}

		private void UpdateTable()
		{
			this.districtDataView.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.Districts };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.districtDataView.DataSource = bindingSource;
		}

		private void BindingNavigatorAddNewItemClick(object sender, EventArgs e)
		{
			this.applyChangeBtn.Enabled = true;
		}

		private void DistrictDataViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.applyChangeBtn.Enabled = true;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
