namespace EstateAgency
{
	using System;
	using System.Data;
	using System.Linq;
	using System.Windows.Forms;

    using EstateAgency.Services;

	public partial class Offers : Form
	{
		private DataContext dataContext;

		private int districtId = 0;

		private int estateTypeId = 0;

		private int rialtorId = 0;

		private int transactionTypeId = 0;

		private string addressValue = string.Empty;

		public Offers()
        {
            this.InitializeComponent();
			this.dataContext = new DataContext();
        }

        private void Offers_Load(object sender, EventArgs e)
        {
			this.UpdateTable();

			var dataTable = this.dataContext.EstateType;
			var types = dataTable.AsEnumerable().Select(m => new { ID = m.Field<int>("ID"), Type = m.Field<string>("Тип") }).ToList();
			types.ForEach(x =>
			{
				this.estateTypes.Items.Add(new ComboboxItem {Text = x.Type, Value = x.ID});
			});
			this.estateTypes.SelectedIndex = 0;

			var dataTableRialtors = this.dataContext.Rilator;
			var rialtorList = dataTableRialtors.AsEnumerable().Select(m => new { ID = m.Field<int>("ID"), Type = m.Field<string>("ФИО") }).ToList();
			rialtorList.ForEach(x =>
			{
				this.rialtors.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
			});
			this.rialtors.SelectedIndex = 0;

			var dataTableDistrict = this.dataContext.Districts;
			var districtList = dataTableDistrict.AsEnumerable().Select(m => new { ID = m.Field<int>("ID"), Type = m.Field<string>("Район") }).ToList();
			districtList.ForEach(x =>
			{
				this.districtBox.Items.Add(new ComboboxItem {Text = x.Type, Value = x.ID});
			});
			this.districtBox.SelectedIndex = 0;

			var dataTableTransaction = this.dataContext.TransactionType;
			var transactionList = dataTableTransaction.AsEnumerable().Select(m => new { ID = m.Field<int>("ID"), Type = m.Field<string>("Тип") }).ToList();
			transactionList.ForEach(x =>
			{
				this.dealsTypeBox.Items.Add(new ComboboxItem { Text = x.Type, Value = x.ID });
			});
			this.dealsTypeBox.SelectedIndex = 0;
		}

		private void UpdateTable()
		{
			this.dataGridView1.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.GetData("SELECT *  FROM Estate a, PhotoEstate b, EstateType c, District d, TransactionType e, Rialtor f, Contractor g WHERE "
			                                                                              + "a.ТипНедвижID = c.ID" + " "
																						  + (this.estateTypeId > 0 ? $"AND a.ТипНедвижID = {this.estateTypeId}" + " " : " ")
																						  + "AND a.ТипСделкиID = e.ID" + " "
																						  + (this.transactionTypeId > 0 ? $"AND a.ТипСделкиID = {this.transactionTypeId}" + " " : " ")
																						  + "AND a.РиэлторID = f.ID" + " "
																						  + (this.rialtorId > 0 ? $"AND a.РиэлторID = {this.rialtorId}" + " " : " ")
																						  + (this.checkBox8.Checked ? "AND a.Актуально = true" + " " : " ")
																						  + "AND a.КонтрагентID = g.ID" + " "
			                                                                              + "AND a.РайонID = d.ID" + " "
																						//  + (this.checkBox3.Checked ? $"AND a.ДатаПредлож > '{this.dateFrom.}'" : " ")
																						  + "AND a.ID = b.НедвижID" + " " 
																						  + (this.districtId > 0 ? $"AND d.ID = {this.districtId}" : " ")
																						  + (this.addressValue != string.Empty ? $"AND a.Адрес = '{this.addressValue}'" : " "))
			};
			this.bindingNavigator1.BindingSource = bindingSource;
			this.dataGridView1.DataSource = bindingSource;
		}

		private void ObjectCardViewClick(object sender, EventArgs e)
		{
			var objectCard = new ObjectCard(this.dataGridView1.CurrentRow);
			objectCard.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
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

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox4.Checked)
			{
				var selectedItem = (ComboboxItem) this.districtBox.SelectedItem;
				this.districtId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.districtId = 0;
				this.UpdateTable();
			}
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateTable();
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

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox6.Checked)
			{
				var selectedItem = (ComboboxItem)this.dealsTypeBox.SelectedItem;
				this.transactionTypeId = selectedItem.Value;
				this.UpdateTable();
			}
			else
			{
				this.transactionTypeId = 0;
				this.UpdateTable();
			}
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox5.Checked)
			{

				this.addressValue = this.textBox1.Text;
				this.UpdateTable();
			}
			else
			{
				this.addressValue = string.Empty;
                this.UpdateTable();
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateTable();
		}

		private void estateTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox1_CheckedChanged(sender, e);
		}

		private void rialtors_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox2_CheckedChanged(sender, e);
		}

		private void districtBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox4_CheckedChanged(sender, e);
		}

		private void dealsTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox6_CheckedChanged(sender, e);
		}
	}

	public class ComboboxItem
	{
		public string Text { get; set; }

		public Int32 Value { get; set; }
	}
}