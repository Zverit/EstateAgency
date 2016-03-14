namespace EstateAgency
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;

	public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
	        this.button1_Click(sender, e);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.chart1.DataSource = GetItems();

			this.chart1.Series.Clear();

			var hoursSeries = this.chart1.Series.Add("Предложения");
			hoursSeries.XValueMember = "Name";
			hoursSeries.YValueMembers = "Hours";
			hoursSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
		}

		private List<StatisticItem> GetItems()
		{
			var items = new List<StatisticItem>()
			{
				new StatisticItem("Май", 120),
				new StatisticItem("Июнь", 40),
				new StatisticItem("Июль", 70),
				new StatisticItem("Август", 10),
			};
			// compute the percentages
			var totalHours = items.Sum(x => x.Hours);
			foreach (var item in items)
				item.Percent = (item.Hours * 100.0) / totalHours;
			return items;
		}

		private List<StatisticItem> GetItems1()
		{
			var items = new List<StatisticItem>()
			{
				new StatisticItem("Май", 20),
				new StatisticItem("Июнь", 40),
				new StatisticItem("Июль", 170),
				new StatisticItem("Август", 30),
			};
			// compute the percentages
			var totalHours = items.Sum(x => x.Hours);
			foreach (var item in items)
				item.Percent = (item.Hours * 100.0) / totalHours;
			return items;
		}
		class StatisticItem
		{
			public String Name { get; set; }
			public double Hours { get; set; }
			public double Percent { get; set; }
			public StatisticItem(string name, double hours)
			{
				this.Name = name;
				this.Hours = hours;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.chart1.DataSource = GetItems1();

			this.chart1.Series.Clear();

			var hoursSeries = this.chart1.Series.Add("Предложения");
			hoursSeries.XValueMember = "Name";
			hoursSeries.YValueMembers = "Hours";
			hoursSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
		}
	}
}
