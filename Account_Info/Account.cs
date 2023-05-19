using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Info
{
	public class Account
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public long AccountNumber { get; set; }
		public DateTime CreateDate { get; set; }
		public AccountTypes AccountTypes { get; set; }
		public BasicTypes BasicTypes { get; set; }
		public double Balance { get; set; }
		public Account()
		{

		}
		public Account(string id, string name, long number, DateTime createDate, AccountTypes types, BasicTypes basicTypes, double balance)
		{
			this.ID = id;
			this.Name = name;
			this.AccountNumber = number;
			this.CreateDate = createDate;
			this.AccountTypes = types;
			this.BasicTypes = basicTypes;
			this.Balance = balance;
		}
	}
}
