using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithmica.Sorting
{
	public class MergeSort
	{
		public int[] Sort(int[] inputArray)
		{
			if (inputArray == null) throw new ArgumentNullException();
			if (inputArray.Length <= 1) return inputArray;
			return Sort(inputArray, 0, inputArray.Length - 1);
		}

		private int[] Sort(int[] inputArray, int lowerIndex, int upperIndex)
		{
			if (inputArray.Length > 1)
			{
				int mid = (inputArray.Length) / 2;
				int[] left = inputArray.Take(mid).ToArray();
				int[] right = inputArray.Skip(mid).Select(i => i).ToArray();
				left = Sort(left, 0, left.Length - 1);
				right = Sort(right, 0, right.Length - 1);
				return Merge(left, right);
			}
			return inputArray;
		}

		private int[] Merge(int[] leftArray, int[] rightArray)
		{
			int[] mergedArray = new int[leftArray.Length + rightArray.Length];
			int currentLeft = 0;
			int currentRight = 0;
			int currentMerged = 0;
			while (currentLeft <= leftArray.Length - 1 && currentRight <= rightArray.Length - 1)
			{
				if (leftArray[currentLeft] <= rightArray[currentRight])
				{
					mergedArray[currentMerged] = leftArray[currentLeft];
					currentLeft++;
				}
				else
				{
					mergedArray[currentMerged] = rightArray[currentRight];
					currentRight++;
				}
				currentMerged++;
			}
			while (currentLeft < leftArray.Length)
			{
				mergedArray[currentMerged] = leftArray[currentLeft];
				currentLeft++;
				currentMerged++;
			}
			while (currentRight < rightArray.Length)
			{
				mergedArray[currentMerged] = rightArray[currentRight];
				currentRight++;
				currentMerged++;
			}
			return mergedArray;
		}
	}
}
