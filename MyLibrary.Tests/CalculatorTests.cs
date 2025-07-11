using MyLibrary;
using Xunit;

namespace MyLibrary.Tests
{
    /// <summary>
    /// Unit tests for the Calculator class.
    /// </summary>
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }

        [Fact]
        public void Subtract_ReturnsDifference()
        {
            var calc = new Calculator();
            Assert.Equal(1, calc.Subtract(3, 2));
        }

        [Fact]
        public void Multiply_ReturnsProduct()
        {
            var calc = new Calculator();
            Assert.Equal(6, calc.Multiply(2, 3));
        }

        [Fact]
        public void Divide_ReturnsQuotient()
        {
            var calc = new Calculator();
            Assert.Equal(2, calc.Divide(6, 3));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(1, 0));
        }
    }
} 