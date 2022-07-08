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

        [Theory]
        [InlineData("10.0.0.0", "10.0.0.50", 50)]
        [InlineData("20.0.0.10", "20.0.1.0", 246)]
        public void IpsBetween(string start, string end, long expectedResult)
        {
            var result = Kyu5.IpsBetween(start, end);

            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData("10.0.0.0", "10.0.0.50", 50)]
        [InlineData("20.0.0.10", "20.0.1.0", 246)]
        public void IpsBetweenWithLinq(string start, string end, long expectedResult)
        {
            var result = Kyu5.IpsBetween(start, end);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("Pig latin is cool", "igPay atinlay siay oolcay")]
        [InlineData("This is my string", "hisTay siay ymay tringsay")]
        public void PigIt(string str, string expectedResult)
        {
            var result = Kyu5.PigIt(str);

            Assert.Equal(expectedResult, result);
        }
    }
}
