using Algorithmica.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmicaTests.Sorting
{
	public class BubbleSortTests
	{
		private SortTestHelper sortHelper;

		public BubbleSortTests()
		{
			sortHelper = new SortTestHelper();
		}

		[Fact]
		public void with_evenarray_should_sort_correctly()
		{
			int[] sut = sortHelper.GenerateUnsortedSequence(10);
			int[] sortedData = new int[10];

			Array.Copy(sut, sortedData, sut.Length);
			Array.Sort(sortedData);

			ISorter<int> bubbleSort = new BubbleSort();
			sut = bubbleSort.Sort(sut);
			Assert.Equal(sortedData, sut);
		}
	}
}
