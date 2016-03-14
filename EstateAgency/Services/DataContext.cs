namespace EstateAgency.Services
{
	using System.Data;
	using System.Data.OleDb;

	public class DataContext
	{
		readonly string  myConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Agency.mdb";

		public DataTable Districts
		{
			get
			{
				return this.GetData("SELECT *  FROM District");
			}
		}

		public DataTable Rilator
		{
			get
			{
				return this.GetData("SELECT *  FROM Rialtor");
			}
		}

		public DataTable Deals
		{
			get
			{
				return this.GetData("SELECT *  FROM Deal ");
			}
		}

		public DataTable Characteristic
		{
			get
			{
				return this.GetData("SELECT *  FROM Characteristic");
			}
		}
		public DataTable Contractor
		{
			get
			{
				return this.GetData("SELECT *  FROM Contractor INNER JOIN ContractorType ON Contractor.ТипКонтрагентаID = ContractorType.ID ");
			}
		}

		public DataTable EstateType
		{
			get
			{
				return this.GetData("SELECT * FROM EstateType");
			}
		}

		public DataTable ContractorType
		{
			get
			{
				return this.GetData("SELECT * FROM ContractorType");
			}
		}


		public DataTable TransactionType
		{
			get
			{
				return this.GetData("SELECT * FROM TransactionType");
			}
		}

		public DataTable GetData(string command)
		{
			var odbcConnection = new OleDbConnection { ConnectionString = this.myConnectionString };
			odbcConnection.Open();

			var cmd = new OleDbCommand(command, odbcConnection);
			var ds = new DataSet();

			var adapter = new OleDbDataAdapter(cmd);
			var table = new DataTable();
			adapter.Fill(ds);
			adapter.Fill(table);
			odbcConnection.Close();

			return table;
		}
	}

}
