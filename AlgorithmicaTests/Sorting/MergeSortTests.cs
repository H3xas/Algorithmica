using Algorithmica.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmicaTests.Sorting
{
	public class MergeSortTests
	{
		[Fact]
		public void with_evenarray_should_sort_correctly()
		{
			int[] data = new int[] { 8, 2, 7, 5 };
			MergeSort mergeSort = new MergeSort();
			data = mergeSort.Sort(data);
			Assert.Equal(new int[] { 2, 5, 7, 8 }, data);
		}

		[Fact]
		public void with_oddarray_should_sort_correctly()
		{
			int[] data = new int[] { 10, 2, 2, 5, 17 };
			MergeSort mergeSort = new MergeSort();
			data = mergeSort.Sort(data);
			Assert.Equal(new int[] { 2, 2, 5, 10, 17 }, data);
		}

		[Fact]
		public void with_nullinputarray_should_throw_npe()
		{
			int[] data = null;
			MergeSort mergeSort = new MergeSort();
			Assert.Throws<ArgumentNullException>(() => mergeSort.Sort(data));
		}
	}
}
