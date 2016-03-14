namespace EstateAgency
{
	using System;
	using System.Windows.Forms;

	using EstateAgency.Services;

	public partial class TypicalCharacteristic : Form
	{
		private readonly DataContext dataContext;

		public TypicalCharacteristic()
		{
			this.dataContext = new DataContext();
			this.InitializeComponent();
			this.UpdateTable();
		}

		private void UpdateTable()
		{
			this.estateTypeGridView.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.EstateType };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.estateTypeGridView.DataSource = bindingSource;

		}

		private void TypicalCharacteristicLoad(object sender, EventArgs e)
		{
			
		}

		private void EstateTypeGridViewSelectionChanged(object sender, EventArgs e)
		{
			this.characteristicTypeGridView.AutoGenerateColumns = false;
			var dataGridViewRow = this.estateTypeGridView.CurrentRow;
			if (dataGridViewRow != null)
			{
				var currentRow = dataGridViewRow.Index;

				var characteristicBindingSource = new BindingSource
				{
					DataSource = this.dataContext.GetData(
					string.Format("SELECT * FROM CharacteristicType a INNER JOIN Characteristic b ON a.ХарактID = b.ID WHERE a.ТипНедвижID={0}",
					this.estateTypeGridView.Rows[currentRow].Cells["ID"].Value))
				};
				this.characteristicTypeGridView.DataSource = characteristicBindingSource;
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
