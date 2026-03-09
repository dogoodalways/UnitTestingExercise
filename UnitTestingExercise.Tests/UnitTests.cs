using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(10, 20, 30, 60)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
// Arrange
            Calculator calc = new Calculator();

                
            // Act
            int actual = calc.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 5, 5)]
        [InlineData(7, 7, 0)]
        [InlineData(20, 10, 10)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int actual = calc.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 5, 25)]
        [InlineData(10, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int actual = calc.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 3, 4)]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(9, 3, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int actual = calc.Divide(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
    

}