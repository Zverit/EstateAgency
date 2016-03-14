namespace EstateAgency
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;

	using EstateAgency.Properties;
	using EstateAgency.Services;

	public partial class Contractor : Form
	{
		private DataContext dataContext;
		public Contractor()
		{
			this.InitializeComponent();
			this.dataContext = new DataContext();
		}

		private void ContractorLoad(object sender, EventArgs e)
		{
			this.bindingNavigator1.Items.Add(new CheckTextBoxToolStripItem());
			this.UpdateTable();

			var dataTable = this.dataContext.ContractorType;
			var types = dataTable.AsEnumerable().Select(m => new { ID = m.Field<Int32>("ID"), Type = m.Field<string>("Тип") }).ToList();
			types.ForEach(x =>
			{
				this.contractorTypes.Items.Add(new { Text = x.Type, Value = x.ID });
			});
			this.contractorTypes.DisplayMember = "Text";
			this.contractorTypes.ValueMember = "Value";
			this.contractorTypes.SelectedIndex = 1;
		}

		private void UpdateTable()
		{
			this.dataGridView1.AutoGenerateColumns = false;
			var bindingSource = new BindingSource { DataSource = this.dataContext.Contractor };
			this.bindingNavigator1.BindingSource = bindingSource;
			this.dataGridView1.DataSource = bindingSource;
		}

		private void BindingNavigatorAddNewItemClick(object sender, EventArgs e)
		{

		}

		private void ToolStripButton2Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			var dataGridViewRow = this.dataGridView1.CurrentRow;
			if (dataGridViewRow != null)
			{
				this.name.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["ФИО_Наименование"].Value.ToString();
				this.rekvezit.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["Реквизиты"].Value.ToString();
				this.address.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["Адрес"].Value.ToString();
				this.kpp.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["КПП"].Value.ToString();
				this.inn.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["ИНН"].Value.ToString();
				this.passport.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["Паспорт"].Value.ToString();
				this.tel.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["Телефоны"].Value.ToString();
				this.information.Text = this.dataGridView1.Rows[dataGridViewRow.Index].Cells["Информация"].Value.ToString();
			}
		}
	}

	class CheckTextBoxToolStripItem : ToolStripControlHost
	{
		private readonly FlowLayoutPanel controlPanel;
		private readonly CheckBox chk = new CheckBox();
		private readonly ComboBox txt = new ComboBox();

		public CheckTextBoxToolStripItem()
			: base(new FlowLayoutPanel())
		{
			this.controlPanel = (FlowLayoutPanel)this.Control;
			this.controlPanel.BackColor = Color.Transparent;

			// Add two child controls.
			this.chk.AutoSize = true;
			this.chk.Text = Resources.ToolStripFilter;
			var margin = this.chk.Margin;
			margin.Top = 5;
			this.chk.Margin = margin;

			this.txt.Enabled = false;
			margin = this.txt.Margin;
			margin.Top = 3;
			this.txt.Margin = margin;

			this.controlPanel.Controls.Add(this.chk);
			this.controlPanel.Controls.Add(this.txt);
		}
		public bool TextEnabled
		{
			get { return this.chk.Checked; }
			set
			{
				this.chk.Checked = value;
			}
		}
		protected override void OnSubscribeControlEvents(Control control)
		{
			base.OnSubscribeControlEvents(control);
			this.chk.CheckedChanged += this.CheckedChanged;
		}

		protected override void OnUnsubscribeControlEvents(Control control)
		{
			base.OnUnsubscribeControlEvents(control);
			this.chk.CheckedChanged -= this.CheckedChanged;
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			this.txt.Enabled = this.TextEnabled;
		}
	}
}
