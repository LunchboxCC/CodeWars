using CodeWars.Level;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    public class Kyu7Tests
    {
        [Theory]
        [InlineData(-1, false)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(25, true)]
        public void IsSquare(int n, bool expectedResult)
        {
            var result = Kyu7.IsSquare(n);

            Assert.Equal(expectedResult, result);
        }
    }
}
