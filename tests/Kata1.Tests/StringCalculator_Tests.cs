﻿using FluentAssertions;
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

		[Theory]
		[InlineData(0, "")]
		[InlineData(1, "1")]
		[InlineData(3, "1, 2")]
		[InlineData(6, "1, 2, 3")]
		[InlineData(10, "1, 2, 3, 4")]
		[InlineData(6, "1\n2, 3")]
		[InlineData(3, "//;\n1; 2")]
		public void Add_WhenValidInput_ReturnsSum(int expected, string input)
		{
			// Arrange
			var calc = new StringCalculator();

			// Act
			int result = calc.Add(input);

			// Assert
			result.Should().Be(expected);
		}

		[Theory]
		[InlineData("-3", "1, 2, -3")]
		[InlineData("-3, -4", "1, 2, -3, -4")]
		public void Add_WhenNegatives_ThrowsExceptionMessage(string expected, string input)
		{
			// Arrange
			var calc = new StringCalculator();

			// Act
			Action act = () => calc.Add(input);

			// Assert
			act.ShouldThrow<Exception>("because negatives are not allowed").Which.Message.Contains(expected);
		}
	}
}
