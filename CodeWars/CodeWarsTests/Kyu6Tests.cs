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

        [Fact]
        public void IsPangram()
        {
            var str = "The quick brown fox jumps over the lazy dog";

            var result = Kyu6.IsPangram(str);

            Assert.True(result);
        }

        [Theory]
        [InlineData("abc#d##c", "ac")]
        [InlineData("abc####d##c#", "")]
        public void CleanString(string s, string expectedResult)
        {
            var result = Kyu6.CleanString(s);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void FindMissingLetter()
        {
            Assert.Equal('e', Kyu6.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.Equal('P', Kyu6.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }

        [Fact]
        public void Wave()
        {
            Assert.Equal(new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" }, Kyu6.Wave("hello"));
            Assert.Equal(new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" }, Kyu6.Wave("two words"));
        }

        [Fact]
        public void MultiplesOf3And5()
        {
            Assert.Equal(23, Kyu6.MultiplesOf3And5(10));
        }

        [Theory]
        [InlineData(new string[] { ":D", ":~)", ";~D", ":)" }, 4)]
        [InlineData(new string[] { ":)", ":(", ":D", ":O", ":;" }, 2)]
        [InlineData(new string[] { ";]", ":[", ";*", ":$", ";-D" }, 1)]
        [InlineData(new string[] { ";", ")", ";*", ":$", "8-D" }, 0)]
        public void CountSmileys(string[] smileys, int expectedResult)
        {
            Assert.Equal(expectedResult, Kyu6.CountSmileys(smileys));
        }
    }
}
