using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithmica.DataStructures
{
	public abstract class Node <T>
	{
		public T Data { get; private set; }

		protected Node(T data)
		{
			Data = data;
		}
	}
}
