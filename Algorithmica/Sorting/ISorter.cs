﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithmica.Sorting
{
	public interface ISorter <TItem>
	{
		TItem[] Sort(TItem[] input);
	}
}
