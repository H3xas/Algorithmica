using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithmica.DataStructures
{
	public abstract class Node <T>
	{
		public T Data { get; private set; }

		public Node(T data)
		{
			Data = data;
		} 
	}
}
