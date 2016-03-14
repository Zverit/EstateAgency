namespace EstateAgency
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.IO;
	using System.Linq;
	using System.Windows.Forms;
	using Services;

	public partial class ObjectCard : Form
    {
        private readonly DataGridViewRow currentRow;

		private readonly DataContext dataConext;

        public ObjectCard(DataGridViewRow currentRow)
        {
			this.dataConext = new DataContext();
            this.currentRow = currentRow;
            this.InitializeComponent();
        }

		private void ViewerLoad(object sender, EventArgs e)
		{
			var id = this.currentRow.Cells["ID"].Value;
			this.shifr.Text = $"{int.Parse(this.currentRow.Cells["Шифр"].Value.ToString()):###00000000}";
			this.cena.Text = this.currentRow.Cells["Цена"].Value.ToString();
			this.commision.Text = this.currentRow.Cells["Коммисия"].Value.ToString();
			this.date.Text = this.currentRow.Cells["Дата"].Value.ToString();
			this.description.Text = this.currentRow.Cells["Описание"].Value.ToString();
			this.address.Text = this.currentRow.Cells["Адрес"].Value.ToString();

			this.dataGridView1.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataConext.GetData($"SELECT * FROM CharacteristicEstate a, Characteristic b WHERE a.НедвижID = {id} AND a.ХарактID = b.ID")};
			
			this.bindingNavigator1.BindingSource = bindingSource;
			this.dataGridView1.DataSource = bindingSource;

			var byteImage = this.dataConext.GetData($"SELECT * FROM PhotoEstate WHERE НедвижID = {id}").AsEnumerable().Select(m => m.Field<byte[]>("Фото")).FirstOrDefault();
			if (byteImage != null)
			{
				var ms = new MemoryStream(byteImage);
				this.pictureBox1.Image = Image.FromStream(ms);
			}

			var dataTableTransaction = this.dataConext.TransactionType;
			var transactionList = dataTableTransaction.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") }).ToList();
			transactionList.ForEach(x =>
			{
				this.transactionBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});

			this.transactionBox.SelectedIndex = 0;

			var dataTableRialtors = this.dataConext.Rilator;
			var rialtorList = dataTableRialtors.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("ФИО") }).ToList();
			rialtorList.ForEach(x =>
			{
				this.rialtorBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.rialtorBox.SelectedIndex = 0;

			var dataTableDistrict = this.dataConext.Districts;
			var districtList = dataTableDistrict.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Район") }).ToList();
			districtList.ForEach(x =>
			{
				this.districtBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.districtBox.SelectedIndex = 0;

			var dataTableEstateType = this.dataConext.EstateType;
			var estateTypeList = dataTableEstateType.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") }).ToList();
			estateTypeList.ForEach(x =>
			{
				this.estateBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.estateBox.SelectedIndex = 0;

			var dataTableContragets = this.dataConext.Contractor;
			var contractorList = dataTableContragets.AsEnumerable().Select(m => new { ID = m.Field<Int32>("Contractor.ID"), Type = m.Field<string>("ФИО_Наименование") }).ToList();
			contractorList.ForEach(x =>
			{
				this.contragentBox.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.contragentBox.SelectedIndex = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
