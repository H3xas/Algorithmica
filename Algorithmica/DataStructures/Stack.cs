using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmica.DataStructures
{
	public class Stack<TItem>
	{
		protected List<TItem> dataStorage;
		private int currentIndex = 0;

		public Stack()
		{
			dataStorage = new List<TItem>();
		}

		public Stack(IEnumerable<TItem> initialData)
		{
			dataStorage = new List<TItem>(initialData);
			currentIndex = dataStorage.Count - 1;
		}

		public TItem Peek()
		{
			throw new NotImplementedException();
		}
		public TItem Pop()
		{
			if (IsEmpty()) throw new InvalidOperationException();

			TItem item = dataStorage[currentIndex];
			dataStorage.RemoveAt(currentIndex);
			currentIndex--;
			return item;
		}

		public bool TryPop(out TItem item)
		{
			if (IsEmpty())
			{
				item = default(TItem);
				return false;
			}
			
			item = dataStorage[currentIndex];
			dataStorage.RemoveAt(currentIndex);
			currentIndex--;
			return true;
		}

		public void Push()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			return dataStorage.Count == 0;
		}
	}
}