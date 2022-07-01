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

        [Fact]
        public void BusInOut()
        {
            var peopleList = new List<int[]>() 
            { 
                new[] { 10, 0 }, 
                new[] { 3, 5 }, 
                new[] { 5, 8 } 
            };
            Assert.Equal(5, Kyu7.BusInOut(peopleList));
        }

        [Fact]
        public void BusInOutSecond()
        {
            var peopleList = new List<int[]>() 
            { 
                new[] { 3, 0 }, 
                new[] { 9, 1 }, 
                new[] { 4, 10 }, 
                new[] { 12, 2 }, 
                new[] { 6, 1 }, 
                new[] { 7, 10 } 
            };
            Assert.Equal(17, Kyu7.BusInOut(peopleList));
        }
    }
}
