namespace EstateAgency
{
	using System;
	using System.Windows.Forms;
	using System.Data;
	using System.Linq;

	using EstateAgency.Services;

	public partial class Collusive : Form
	{
		private readonly DataContext dataContext;

		private int estateTypeId = 0;

		private int rialtorId = 0;

		private int districtId = 0;

		private int transactionId = 0;

		public Collusive()
		{
			this.InitializeComponent();
			this.dataContext = new DataContext();
		}

		private void UpdateTable()
		{
			this.dataGridView1.AutoGenerateColumns = false;
			var bindingSource = new BindingSource
				                    {
					                    DataSource =
						                    this.dataContext.GetData(
							                    "SELECT *  FROM Collusive a, EstateType b, District c, TransactionType d, Contractor e, Rialtor f WHERE "
												+ (this.checkBox6.Checked ? "a.Актуально = true  AND " + " " : " ")
												+ "a.ТипНедвижID = b.ID "
							                    + "AND a.РайонID = c.ID " + "AND a.ТипСделкиID = d.ID "
							                    + "AND a.КонтрагентID = e.ID " + "AND a.РиэлторID = f.ID" + " "
												+ (this.estateTypeId > 0 ? $"AND a.ТипНедвижID = {this.estateTypeId} " : " ")
												+ (this.districtId > 0 ? $"AND a.РайонID = {this.districtId} " : " ")
												+ (this.transactionId > 0 ? $"AND a.ТипСделкиID = {this.transactionId} " : " ")
												+ (this.rialtorId > 0 ? $"AND a.РиэлторID = {this.rialtorId} " : " "))
				                    };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.dataGridView1.DataSource = bindingSource;
		}

		private void CollusiveLoad(object sender, EventArgs e)
		{
			this.UpdateTable();

			var dataTable = this.dataContext.EstateType;
			var types =
				dataTable.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") }).ToList();
			types.ForEach(
				x =>
					{
						this.estateTypes.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
					});

			this.estateTypes.SelectedIndex = 0;


			var dataTableRialtors = this.dataContext.Rilator;
			var rialtorList =
				dataTableRialtors.AsEnumerable()
					.Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("ФИО") })
					.ToList();
			rialtorList.ForEach(
				x =>
					{
						this.rialtors.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
					});

			this.rialtors.SelectedIndex = 0;

			var dataTableDistrict = this.dataContext.Districts;
			var districtList =
				dataTableDistrict.AsEnumerable()
					.Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Район") })
					.ToList();
			districtList.ForEach(
				x =>
					{
						this.districtBox.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
					});
;
			this.districtBox.SelectedIndex = 0;

			var dataTableTransaction = this.dataContext.TransactionType;
			var transactionList =
				dataTableTransaction.AsEnumerable()
					.Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") })
					.ToList();
			transactionList.ForEach(
				x =>
					{
						this.transactionBox.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
					});

			this.transactionBox.SelectedIndex = 0;
		}

		private void Button2Click(object sender, EventArgs e)
		{
			var collusiveCard = new CollusiveCard(this.dataGridView1.CurrentRow);
			collusiveCard.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox4.Checked)
			{
				var selectedItem = (ComboboxItem)this.districtBox.SelectedItem;
				this.districtId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.districtId = 0;
				this.UpdateTable();
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				var selectedItem = (ComboboxItem)this.estateTypes.SelectedItem;
				this.estateTypeId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.estateTypeId = 0;
				this.UpdateTable();
			}
		}

		private void estateTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox1_CheckedChanged(sender, e);
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox2.Checked)
			{
				var selectedItem = (ComboboxItem)this.rialtors.SelectedItem;
				this.rialtorId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.rialtorId = 0;
				this.UpdateTable();
			}
		}

		private void rialtors_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox2_CheckedChanged(sender, e);
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateTable();
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox5.Checked)
			{
				var selectedItem = (ComboboxItem)this.transactionBox.SelectedItem;
				this.transactionId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.transactionId = 0;
				this.UpdateTable();
			}
		}

		private void districtBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox4_CheckedChanged(sender, e);
		}

		private void transactionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox5_CheckedChanged(sender, e);
		}
	}
}
