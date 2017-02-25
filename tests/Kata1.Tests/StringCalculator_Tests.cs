using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Kata1.Tests
{
	public class StringCalculator_Tests
	{
		public StringCalculator_Tests()
		{
		}

		[Fact]
		public void Add_WhenEmptyInput_ReturnsZero()
		{
			// Arrange
			var calc = new StringCalculator();

			// Act
			int result = calc.Add("");

			// Assert
			result.Should().Be(0);
		}
	}
}
