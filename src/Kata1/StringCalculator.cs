using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata1
{
	public class StringCalculator
	{
		public StringCalculator()
		{
		}

		public int Add(string numbers)
		{
			IEnumerable<int> numberList = GetNumberList(numbers);

			return numberList.Sum();
		}

		private IEnumerable<int> GetNumberList(string numbers)
		{
			if (string.IsNullOrWhiteSpace(numbers))
			{
				return new[] { 0 };
			}

			char[] seps = new[] { ',', '\n' };

			if (numbers.StartsWith("//"))
			{
				seps = new[] { numbers[2] };

				numbers = numbers.Substring(4);
			}

			return numbers.Split(seps).Select(n => int.Parse(n));
		}
	}
}
