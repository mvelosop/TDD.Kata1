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

		[Fact]
		public void Add_WhenOneNumber_ReturnsValue()
		{
			// Arrange
			var calc = new StringCalculator();

			// Act
			int result = calc.Add("1");

			// Assert
			result.Should().Be(1);
		}

		[Theory]
		[InlineData(0, "")]
		[InlineData(1, "1")]
		public void Add_WhenValidInput_ReturnsSum(int expected, string input)
		{
			// Arrange
			var calc = new StringCalculator();

			// Act
			int result = calc.Add(input);

			// Assert
			result.Should().Be(expected);
		}
	}
}
