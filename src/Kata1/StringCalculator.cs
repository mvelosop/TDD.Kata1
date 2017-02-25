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

			string[] numberList = numbers.Split(',');

			int result = 0;

			foreach (var number in numberList)
			{
				result += int.Parse(number);
			}

			return result;
		}
	}
}
