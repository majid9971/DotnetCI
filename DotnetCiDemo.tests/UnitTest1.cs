using Xunit;
using DotnetCiDemo;

namespace DotnetCiDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            int result = Program.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
