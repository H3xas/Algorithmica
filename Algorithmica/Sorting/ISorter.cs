using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithmica.Sorting
{
	public interface ISorter
	{
		IEnumerable<TItem> Sort<TItem>(IEnumerable<TItem> input);
	}
}
