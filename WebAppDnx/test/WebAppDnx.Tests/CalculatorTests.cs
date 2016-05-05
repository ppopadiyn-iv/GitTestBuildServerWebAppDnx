using WebAppDnx.DomainServices;
using Xunit;

namespace WebAppDnx.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator calc_;

        public CalculatorTests()
        {
            calc_ = new Calculator();
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(6, 34, 40)]
        public void AddNumbers(int a, int b, int expected)
        {
            Assert.Equal(expected, calc_.Add(a, b));
        }

        [Theory]
        [InlineData(6, 7, 42)]
        [InlineData(2, 6, 12)]
        public void MultiplyNumbers(int a, int b, int expected)
        {
            Assert.Equal(expected, calc_.Multiply(a, b));
        }
    }
}