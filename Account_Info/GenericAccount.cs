using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Info
{
	public class GenericAccount<T> : IGenericAccount<T>
	{
		public string GetGenericBehaviour(T obj)
		{
			string behaviour = string.Empty;
			if (obj is Account)
			{
				Account account = obj as Account;
				switch (account.AccountTypes)
				{
					case AccountTypes.SavingsAccount:
						behaviour = "This account is a savings account";
						break;
					case AccountTypes.CurrentAccount:
						behaviour = "This account is a current account";
						break;
					case AccountTypes.SalaryAccount:
						behaviour = "This account is a salary account";
						break;
					case AccountTypes.FixedDepositAccount:
						behaviour = "This is a Fixed Deposit account";
						break;
					case AccountTypes.NRIAccount:
						behaviour = "This account is a NRI account";
						break;
					default:
						behaviour = "Business Account";
						break;
				}
			}
			return behaviour;
		}
	}
}
