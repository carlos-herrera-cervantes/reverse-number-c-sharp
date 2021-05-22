using ReverseIntegerConsoleApp.Models;
using Xunit;

namespace ReverseIntegerTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void Reverse_Should_Return_Reversed_Number()
        {
            int number = 123;
            int result = SuperInteger.Reverse(number);
            const int ExpectedResult = 321;

            Assert.Equal<int>(result, ExpectedResult);
        }
    }
}