using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kata1
{
	public class StringCalculator
	{
		public StringCalculator()
		{
		}

		public int Add(string numbers)
		{
			if (string.IsNullOrWhiteSpace(numbers))
			{
				return 0;
			}

			char[] seps = new[] { ',', '\n' };

			if (numbers.StartsWith("//"))
			{
				seps = new[] { numbers[2] };
				numbers = numbers.Substring(4);
			}

			int[] numberList = numbers.Split(seps).Select(n => int.Parse(n)).ToArray();

			return numberList.Sum();
		}
	}
}
