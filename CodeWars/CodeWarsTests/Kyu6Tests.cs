using CodeWars.Level;

namespace CodeWarsTests
{
    public class Kyu6Tests
    {

        [Theory]
        [InlineData(7, 3)]
        [InlineData(9, 2)]
        [InlineData(1234, 5)]
        public void CountBits(int n, int expectedResult)
        {
            var result = Kyu6.CountBits(n);

            Assert.Equal(expectedResult, result);
        }
    }
}
