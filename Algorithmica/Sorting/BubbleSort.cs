using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithmica.Sorting
{
	public class BubbleSort : ISorter<int>
	{
		public int[] Sort(int[] input)
		{
			if (input == null) throw new ArgumentNullException();
			if (input.Length == 1) return input;

			bool changed;

			for (int outer_it = input.Length - 1; outer_it >= 0; --outer_it)
			{
				changed = false;
				for (int nested_it = 0; nested_it < outer_it; ++nested_it)
				{
					if (input[nested_it] > input[nested_it + 1])
					{ 
						int temp = input[nested_it];
						input[nested_it] = input[nested_it + 1];
						input[nested_it + 1] = temp;
						changed = true;
					}
				}
				if (!changed) break;
			}

			return input;
		}
	}
}
