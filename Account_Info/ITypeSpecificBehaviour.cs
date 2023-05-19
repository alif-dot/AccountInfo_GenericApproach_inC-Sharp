using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Info
{
	public interface ITypeSpecificBehaviour
	{
		public interface ITypeSpecificBehaviour<T>
		{
			string GetTypeSpecificBehaviour<T>(T Data) where T : Account;
		}
	}
}
