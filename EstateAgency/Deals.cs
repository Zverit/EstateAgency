namespace EstateAgency
{
	using System;
	using System.Data;
	using System.Linq;
	using System.Windows.Forms;

	using EstateAgency.Services;

	public partial class Deals : Form
	{
		private DataContext dataContext;

		private int rialtorId;

		private int transactionId;

		public Deals()
		{
			this.InitializeComponent();
			this.dataContext = new DataContext();
		}

		private void DealsLoad(object sender, EventArgs e)
		{
			this.UpdateTable();

			var dataTableRialtors = this.dataContext.Rilator;
			var rialtorList = dataTableRialtors.AsEnumerable().Select(m => new { ID = m.Field<int>("ID"), Type = m.Field<string>("ФИО") }).ToList();
			rialtorList.ForEach(x =>
			{
				this.rialtorBox.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
			});
			this.rialtorBox.SelectedIndex = 0;

			var dataTableTransaction = this.dataContext.TransactionType;
			var transactionList = dataTableTransaction.AsEnumerable().Select(m => new { ID = m.Field<int>("ID"), Type = m.Field<string>("Тип") }).ToList();
			transactionList.ForEach(x =>
			{
				this.transactionTypeBox.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
			});
			this.transactionTypeBox.SelectedIndex = 0;
		}

		private void UpdateTable()
		{
			this.dealsGridView.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.GetData("SELECT * FROM Deal deal, Rialtor t, TransactionType type WHERE "
																							
																						  + "deal.РиэлторID = t.ID AND deal.ТипСделкиID = type.ID" + " "
																						  + (this.rialtorId > 0 ? $"AND deal.РиэлторID = {this.rialtorId} " : " ")
																						  + (this.transactionId > 0 ? $"AND deal.ТипСделкиID = {this.transactionId} " : " ")
																						  ) };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.dealsGridView.DataSource = bindingSource;
		}

		private void DataGridView1SelectionChanged(object sender, EventArgs e)
		{
			this.typeSideGridView.AutoGenerateColumns = false;
			var dataGridViewRow = this.dealsGridView.CurrentRow;
			if (dataGridViewRow != null)
			{
				var currentRow = dataGridViewRow.Index;
				var value = this.dealsGridView.Rows[currentRow].Cells["ID"].Value;

					var characteristicBindingSource = new BindingSource
						                                  {
							                                  DataSource =
								                                  this.dataContext.GetData(
									                                  "SELECT * FROM Contractor b  " + ",TransactionSide a, SideType d "
									                                  + $"WHERE a.СделкаID = {value} and a.ТипСтороныID = d.ID and a.КонтрагентID = b.ID")
						                                  };

					this.typeSideGridView.DataSource = characteristicBindingSource;
				}
			
		}

		private void CloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox3.Checked)
			{
				var selectedItem = (ComboboxItem)this.rialtorBox.SelectedItem;
				this.rialtorId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.rialtorId = 0;
				this.UpdateTable();
			}
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox4.Checked)
			{
				var selectedItem = (ComboboxItem)this.transactionTypeBox.SelectedItem;
				this.transactionId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.transactionId = 0;
				this.UpdateTable();
			}
		}

		private void transactionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox4_CheckedChanged(sender, e);
		}

		private void rialtorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox3_CheckedChanged(sender, e);
		}
	}
}
