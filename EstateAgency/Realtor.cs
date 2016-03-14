namespace EstateAgency
{
	using System;
	using System.Data.OleDb;
	using System.Windows.Forms;

	using EstateAgency.Properties;
	using EstateAgency.Services;

	public partial class Realtor : Form
	{
		private readonly DataContext dataContext;

		public Realtor()
		{
			this.InitializeComponent();
			this.dataContext = new DataContext();
		}

		private void RialtorLoad(object sender, EventArgs e)
		{
			this.UpdateTable();
		}

		private void UpdateTable()
		{
			this.realtorDataView.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.Rilator };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.realtorDataView.DataSource = bindingSource;
		}

		private void BindingNavigatorDeleteItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show(Resources.Delete_Question, Resources.Confirm_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var odbcConnection = new OleDbConnection { ConnectionString = Settings.Default.AgencyConnectionString };
					odbcConnection.Open();
					var sqlComm = new OleDbCommand("DELETE FROM [Rialtor] WHERE ID = @ID", odbcConnection);


					var dataGridViewRow = this.realtorDataView.CurrentRow;
					if (dataGridViewRow != null)
					{
						var itemIndex = this.realtorDataView.Rows[dataGridViewRow.Index].Cells["ID"].Value;
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

		private void BindingNavigatorAddNewItemClick(object sender, EventArgs e)
		{
			this.applyChangeBtn.Enabled = true;
		}

		private void RialtorDataViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.applyChangeBtn.Enabled = true;
		}

		private void ApplyChangeBtnClick(object sender, EventArgs e)
		{
			this.realtorDataView.EndEdit();
			var dataGridViewRow = this.realtorDataView.CurrentRow;

			if (dataGridViewRow != null)
			{
				var indexCurrentRow = this.realtorDataView.Rows[dataGridViewRow.Index].Cells["ID"].Value;

				var odbcConnection = new OleDbConnection { ConnectionString = Settings.Default.AgencyConnectionString };
				odbcConnection.Open();

				if (indexCurrentRow == DBNull.Value)
				{

					var sqlComm = new OleDbCommand("INSERT INTO [Rialtor] (ФИО, Логин, Пароль) VALUES (@ФИО, @Логин, @Пароль)", odbcConnection);

					var fio = this.realtorDataView.Rows[this.realtorDataView.Rows.Count - 1].Cells["ФИО"].Value;
					var login = this.realtorDataView.Rows[this.realtorDataView.Rows.Count - 1].Cells["Логин"].Value;
					var password = this.realtorDataView.Rows[this.realtorDataView.Rows.Count - 1].Cells["Пароль"].Value;

					sqlComm.Parameters.AddWithValue("@ФИО", fio);
					sqlComm.Parameters.AddWithValue("@Логин", login);
					sqlComm.Parameters.AddWithValue("@Пароль", password);

					sqlComm.ExecuteNonQuery();
				}
				else
				{
					var sqlComm = new OleDbCommand("UPDATE Rialtor SET ФИО = @ФИО, Логин = @Логин, Пароль = @Пароль WHERE ID = @ID", odbcConnection);

					sqlComm.Parameters.AddWithValue("@ФИО", this.realtorDataView.Rows[dataGridViewRow.Index].Cells["ФИО"].Value);
					sqlComm.Parameters.AddWithValue("@Логин", this.realtorDataView.Rows[dataGridViewRow.Index].Cells["Логин"].Value);
					sqlComm.Parameters.AddWithValue("@Пароль", this.realtorDataView.Rows[dataGridViewRow.Index].Cells["Пароль"].Value);
					sqlComm.Parameters.AddWithValue("@ID", indexCurrentRow);
					sqlComm.ExecuteNonQuery();
				}

				odbcConnection.Close();
			}

			this.UpdateTable();
			this.applyChangeBtn.Enabled = false;
		}

		private void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
