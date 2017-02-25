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

			int pos = numbers.IndexOf(',');

			if (pos == -1)
			{
				return int.Parse(numbers);
			}

			string x = numbers.Substring(0, pos);
			string y = numbers.Substring(pos + 1);

			return int.Parse(x) + int.Parse(y);
		}
	}
}
