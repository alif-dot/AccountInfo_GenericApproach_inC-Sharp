using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Account_Info.ITypeSpecificBehaviour;

namespace Account_Info
{
	public class TypeSpecificBehaviour<T> : ITypeSpecificBehaviour<T>
	{
		public string GetTypeSpecificBehaviour<T>(T Data) where T : Account
		{
			string Behaviour = "";
			switch (Data.BasicTypes)
			{
				case BasicTypes.PrimaryAccount:
					Behaviour = "A Primary Account.";
					break;
				case BasicTypes.JointAccount:
					Behaviour = "A Joint Account";
					break;
				default:
					Behaviour = "Not In List...";
					break;
			}
			return Behaviour;
		}
	}
}
