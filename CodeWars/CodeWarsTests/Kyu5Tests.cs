using CodeWars.Level;

namespace CodeWarsTests
{
    public class Kyu5Tests
    {
        [Theory]
        [InlineData(60, "00:01:00")]
        [InlineData(41271, "11:27:51")]
        [InlineData(86399, "23:59:59")]
        public void GetReadableTime(int seconds, string expectedResult)
        {
            var result = Kyu5.GetReadableTime(seconds);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(60, "00:01:00")]
        [InlineData(41271, "11:27:51")]
        [InlineData(86399, "23:59:59")]
        public void GetReadableTimeRefactored(int seconds, string expectedResult)
        {
            var result = Kyu5.GetReadableTimeRefactored(seconds);

            Assert.Equal(expectedResult, result);
        }
    }
}
