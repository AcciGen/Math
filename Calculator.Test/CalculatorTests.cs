global using Xunit;
using FluentAssertions;

namespace Calculator.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            //Arrange
            CalculatorBase calculator = new CalculatorBase();

            //Act
            var result = calculator.Add(2, 3);
            int expectedResult = 5;

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(7, 5)]
        public void SubtractTest(int a, int b)
        {
            CalculatorBase calculator = new CalculatorBase();
            
            var result = calculator.Subtract(a, b);

            result.Should().BePositive();
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 2, 8)]
        public void MultiplyTest(int a, int b, int expectedResult)
        {
            CalculatorBase calculator = new CalculatorBase();

            var result = calculator.Multiply(a, b);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DivideTest()
        {
            CalculatorBase calculator = new CalculatorBase();

            var result = calculator.Divide(5, 1);

            Assert.Equal(5, result);
        }
    }
}
