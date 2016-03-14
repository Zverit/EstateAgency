namespace EstateAgency
{
	using System;
	using System.Data;
	using System.Linq;
	using System.Windows.Forms;

	using EstateAgency.Services;

	public partial class CollusiveCard : Form
	{
		private readonly DataGridViewRow currentRow;

		private readonly DataContext dataConext;

		public CollusiveCard(DataGridViewRow currentRow)
		{
			this.currentRow = currentRow;			
			this.dataConext = new DataContext();
			this.InitializeComponent();
		}

		private void CollusiveCardLoad(object sender, EventArgs e)
		{
			var id = this.currentRow.Cells["ID"].Value;
			this.dataGridView2.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataConext.GetData($"SELECT * FROM Characteristic c , CollusiveCharactieristic a WHERE {id} = a.ЗаявкаID AND a.ХарактID = c.ID") };

			this.bindingNavigator1.BindingSource = bindingSource;
			this.dataGridView2.DataSource = bindingSource;

			var dataTableTransaction = this.dataConext.TransactionType;
			var transactionList = dataTableTransaction.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") }).ToList();
			transactionList.ForEach(x =>
			{
				this.transactionTypeBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});

			this.transactionTypeBox.SelectedIndex = 0;

			var dataTableEstateType = this.dataConext.EstateType;
			var estateTypeList = dataTableEstateType.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") }).ToList();
			estateTypeList.ForEach(x =>
			{
				this.estateBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.estateBox.SelectedIndex = 0;

			var dataTableDistrict = this.dataConext.Districts;
			var districtList = dataTableDistrict.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Район") }).ToList();
			districtList.ForEach(x =>
			{
				this.districtBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.districtBox.SelectedIndex = 5;

			var dataTableContragets = this.dataConext.Contractor;
			var contractorList = dataTableContragets.AsEnumerable().Select(m => new { ID = m.Field<Int32>("Contractor.ID"), Type = m.Field<string>("ФИО_Наименование") }).ToList();
			contractorList.ForEach(x =>
			{
				this.contractorBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.contractorBox.SelectedIndex = 0;

			var dataTableRialtors = this.dataConext.Rilator;
			var rialtorList = dataTableRialtors.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("ФИО") }).ToList();
			rialtorList.ForEach(x =>
			{
				this.rialtorBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.rialtorBox.SelectedIndex = 0;

			this.description.Text = this.currentRow.Cells["Описание"].Value.ToString();
			this.shifr.Text = $"{int.Parse(this.currentRow.Cells["ID"].Value.ToString()):###00000000}";
			this.topical.Checked = (bool)this.currentRow.Cells["ЗаявкаАктуальна"].Value;
			this.PriceTo.Text =  this.currentRow.Cells["ЦенаДо"].Value.ToString();
			this.date.Text = this.currentRow.Cells["ДатаПодачи"].Value.ToString();

			this.FindEstate();
		}

		private void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button2Click(object sender, EventArgs e)
		{
			this.FindEstate();
		}

		private void FindEstate()
		{
			this.dataGridView1.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataConext.GetData($"SELECT * FROM Estate  a, Contractor b, Rialtor c, District d WHERE a.Цена <= {this.PriceTo.Text} AND a.РайонID = d.ID AND a.КонтрагентID = b.ID AND a.РиэлторID = c.ID") };
			this.dataGridView1.DataSource = bindingSource;
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
