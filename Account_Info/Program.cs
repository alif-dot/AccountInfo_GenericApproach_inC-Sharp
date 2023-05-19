using Account_Info;
using System.Security.Principal;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			Console.Write("ID : ");
			string id = Console.ReadLine();

			Console.Write("Name :  ");
			string name = Console.ReadLine();

			Console.Write("Account Number : ");
			long number = long.Parse(Console.ReadLine());

			Console.Write("CreateDate : ");
			DateTime createDate = DateTime.Parse(Console.ReadLine());

			Console.Write("AccountType : [SavingsAccount=1,CurrentAccount=2,SalaryAccount=3,FixedDepositAccount=4,NRIAccount=5]");
			AccountTypes types = (AccountTypes)int.Parse(Console.ReadLine());

			Console.Write("Basic Types : [PrimaryAccount=1,JointAccount=2]  ");
			BasicTypes basicTypes = (BasicTypes)int.Parse(Console.ReadLine());

			Console.Write("Balance : ");
			double balance = double.Parse(Console.ReadLine());
			Account account = new Account(id, name, number, createDate, types, basicTypes, balance);

			Console.WriteLine("*****************************************************************");

			Console.WriteLine("ID : {0}", account.ID);
			Console.WriteLine("Name : {0}", account.Name);
			Console.WriteLine("Account Number : {0}", account.AccountNumber);
			Console.WriteLine("Create Date : {0}", account.CreateDate.ToString("dddd, dd MM yyyy"));
			Console.WriteLine("Account Type : {0}", account.AccountTypes);
			Console.WriteLine("Basic Type : {0}", account.BasicTypes);
			Console.WriteLine("Balance : {0}", account.Balance);
			GenericAccount<Account> a = new GenericAccount<Account>();

			Console.WriteLine($"Generic Behaviour : {a.GetGenericBehaviour(account)}");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

		Console.ReadKey();
	}
}