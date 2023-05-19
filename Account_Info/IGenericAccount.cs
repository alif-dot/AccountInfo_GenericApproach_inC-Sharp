using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Info
{
	public interface IGenericAccount<T>
	{
		string GetGenericBehaviour(T obj);
	}
}
