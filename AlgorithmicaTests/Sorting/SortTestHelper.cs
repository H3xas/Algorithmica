using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AlgorithmicaTests.Sorting
{
	public class SortTestHelper
	{
		/// <summary>
		/// Generates unsorted sequence of integers.
		/// Source: http://stackoverflow.com/a/108836
		/// </summary>
		/// <param name="size">size of sequence</param>
		/// <returns>Array of integer</returns>
		public int[] GenerateUnsortedSequence(int size)
		{
			if (size < 0) throw new ArgumentException("size must be a positive number");

			var sequence = Enumerable.Range(0, size);
			RandomNumberGenerator rng = RandomNumberGenerator.Create();

			return sequence.OrderBy(x => GenerateNextInt(rng)).ToArray();
		}

		private int GenerateNextInt(RandomNumberGenerator rng)
		{
			byte[] randomInt = new byte[4];
			rng.GetBytes(randomInt);
			return BitConverter.ToInt32(randomInt, 0);
		}
	}
}
