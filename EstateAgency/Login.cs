namespace EstateAgency
{
	using System;
	using System.Data;
	using System.Linq;
	using System.Windows.Forms;

	using EstateAgency.Services;

	public partial class Login : Form
	{
		private readonly DataContext dataContext;

		public Login()
		{
			this.dataContext = new DataContext();
			this.InitializeComponent();
		}

		private void CancelClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OkClick(object sender, EventArgs e)
		{
			var main = new Main();
			var users = this.dataContext.GetData($"SELECT * FROM Rialtor WHERE Логин = '{this.textBox1.Text}' AND Пароль = '{this.textBox2.Text}'").AsEnumerable().ToList();
			if (users.Count > 0)
			{
				main.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Неверные логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void LoginLoad(object sender, EventArgs e)
		{
			this.textBox2.PasswordChar = '*';
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				this.OkClick(sender, e);
			}
		}
	}
}
