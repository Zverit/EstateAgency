namespace EstateAgency
{
	using System;
	using System.Data.OleDb;
	using System.Windows.Forms;

	using EstateAgency.Properties;
	using EstateAgency.Services;

	public partial class Characteristic : Form
	{
		private readonly DataContext dataContext;

        public Characteristic()
        {
            this.InitializeComponent();
			this.dataContext = new DataContext();
        }

        private void CharacteristicLoad(object sender, EventArgs e)
        {

			this.UpdateTable();
        }

		private void UpdateTable()
		{
			this.characteristicGridView.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.Characteristic };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.characteristicGridView.DataSource = bindingSource;
		}

		private void BindingNavigatorAddNewItemClick(object sender, EventArgs e)
		{
			this.applyChangesBtn.Enabled = true;
		}

		private void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ApplyChangesBtnClick(object sender, EventArgs e)
		{
			this.characteristicGridView.EndEdit();
			var dataGridViewRow = this.characteristicGridView.CurrentRow;

			if (dataGridViewRow != null)
			{
				var indexCurrentRow = this.characteristicGridView.Rows[dataGridViewRow.Index].Cells["ID"].Value;

				var odbcConnection = new OleDbConnection { ConnectionString = Settings.Default.AgencyConnectionString };
				odbcConnection.Open();

				if (indexCurrentRow == DBNull.Value)
				{

					var sqlComm = new OleDbCommand("INSERT INTO [Characteristic] (Характеристика) VALUES (@Характеристика)", odbcConnection);

					var district = this.characteristicGridView.Rows[this.characteristicGridView.Rows.Count - 1].Cells["Характеристика"].Value;
					sqlComm.Parameters.AddWithValue("@Район", district);

					sqlComm.ExecuteNonQuery();

				}
				else
				{
					var sqlComm = new OleDbCommand("UPDATE Characteristic SET Характеристика = @Характеристика WHERE ID = @ID", odbcConnection);

					sqlComm.Parameters.AddWithValue("@Характеристика", this.characteristicGridView.Rows[dataGridViewRow.Index].Cells["Характеристика"].Value);
					sqlComm.Parameters.AddWithValue("@ID", indexCurrentRow);
					sqlComm.ExecuteNonQuery();
				}

				odbcConnection.Close();
			}

			this.UpdateTable();
			this.applyChangesBtn.Enabled = false;
		}

		private void CharacteristicGridViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.applyChangesBtn.Enabled = true;
		}

		private void BindingNavigatorDeleteItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show(Resources.Delete_Question, Resources.Confirm_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var odbcConnection = new OleDbConnection { ConnectionString = Settings.Default.AgencyConnectionString };
					odbcConnection.Open();
					var sqlComm = new OleDbCommand("DELETE FROM [Characteristic] WHERE ID = @ID", odbcConnection);


					var dataGridViewRow = this.characteristicGridView.CurrentRow;
					if (dataGridViewRow != null)
					{
						var itemIndex = this.characteristicGridView.Rows[dataGridViewRow.Index].Cells["ID"].Value;
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
    }
}
