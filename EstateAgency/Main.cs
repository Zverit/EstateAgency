namespace EstateAgency
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class Main : Form
    {
        public Main()
        {
	       this.InitializeComponent();
        }

        private void ХарактеристикиToolStripMenuItemClick(object sender, EventArgs e)
        {
            var characteristic = new Characteristic();
            characteristic.Show();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            var newForm = new Statistics();

            newForm.Show();
        }

        private void Button3Click(object sender, EventArgs e)
        {
            var deals = new Deals();
            deals.Show();
        }

        private void РайоныToolStripMenuItemClick(object sender, EventArgs e)
        {
            var district = new District();
            district.Show();
        }

        private void РиToolStripMenuItemClick(object sender, EventArgs e)
        {
            var rialtor = new Realtor();
            rialtor.Show();
        }

        private void КонтрагентыToolStripMenuItemClick(object sender, EventArgs e)
        {
            var contractor = new Contractor();
            contractor.Show();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var offers = new Offers();
            offers.Show();
        }

        private void БазаПредложенийНедвижимостиToolStripMenuItemClick(object sender, EventArgs e)
        {
            var offers = new Offers();
            offers.Show();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var collusive = new Collusive();
            collusive.Show();
        }

        private void ЗаключенныеСделкиToolStripMenuItemClick(object sender, EventArgs e)
        {
            var deals = new Deals();
            deals.Show();
        }

        private void ЗаявкиНаОбъектыToolStripMenuItemClick(object sender, EventArgs e)
        {
            var collusive = new Collusive();
            collusive.Show();
        }

        private void ВыходToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void СтатистикаToolStripMenuItemClick(object sender, EventArgs e)
		{
			var statistic = new Statistics();

			statistic.Show();
		}

		private void MainFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void ТиповыеХарактеристикиПоВидамToolStripMenuItemClick(object sender, EventArgs e)
		{
			var typicalCharacteristic = new TypicalCharacteristic();
			typicalCharacteristic.Show();
		}

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			БазаПредложенийНедвижимостиToolStripMenuItemClick(sender, e);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			ЗаключенныеСделкиToolStripMenuItemClick(sender, e);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			ЗаявкиНаОбъектыToolStripMenuItemClick(sender, e);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			СтатистикаToolStripMenuItemClick(sender, e);
		}
	}
}