﻿using CodeWars.Level;

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

        //[Theory]
        //[InlineData("", "")]
        //[InlineData("AAAABBBCCDAABBB", "ABCDAB")]
        //public void UniqueInOrder(IEnumerable<T> iterable, IEnumerable<T> expectedResult)
        [Fact]
        public void UniqueInOrder()
        {
            Assert.Equal("", Kyu6.UniqueInOrder(""));
            Assert.Equal("ABCDAB", Kyu6.UniqueInOrder("AAAABBBCCDAABBB"));
        }

        [Fact]
        public void DigitalRoot()
        {
            Assert.Equal(6, Kyu6.DigitalRoot(456));
        }

        [Fact]
        public void ArrayDiff()
        {
            Assert.Equal(new int[] { 2 }, Kyu6.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.Equal(new int[] { 2, 2 }, Kyu6.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.Equal(new int[] { 1 }, Kyu6.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.Equal(new int[] { 1, 2, 2 }, Kyu6.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.Equal(new int[] { }, Kyu6.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
            Assert.Equal(new int[] { 3 }, Kyu6.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }

        [Fact]
        public void Meeting()
        {
            var expected = "(ARNO, ANN)(BELL, JOHN)(CORNWELL, ALEX)(DORNY, ABBA)(KERN, LEWIS)(KORN, ALEX)(META, GRACE)(SCHWARZ, VICTORIA)(STAN, MADISON)(STAN, MEGAN)(WAHL, ALEXIS)";
            var input = "Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn";

            Assert.Equal(expected, Kyu6.Meeting(input));
        }

        [Fact]
        public void Find()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.Equal(206847684, Kyu6.Find(exampleTest2));
        }

        [Fact]
        public void Likes()
        {
            Assert.Equal("no one likes this", Kyu6.Likes(new string[0]));
            Assert.Equal("Peter likes this", Kyu6.Likes(new string[] { "Peter" }));
            Assert.Equal("Jacob and Alex like this", Kyu6.Likes(new string[] { "Jacob", "Alex" }));
            Assert.Equal("Max, John and Mark like this", Kyu6.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.Equal("Alex, Jacob and 2 others like this", Kyu6.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        [Fact]
        public void GetIt()
        {
            Assert.Equal(5, Kyu6.FindIt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [Fact]
        public void CreatePhoneNumber()
        {
            Assert.Equal("(123) 456-7890", Kyu6.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }

        [Fact]
        public void DuplicateCount()
        {
            Assert.Equal(2, Kyu6.DuplicateCount("aabBcde"));
        }

        [Fact]
        public void IsValidWalk()
        {
            Assert.False(Kyu6.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
        }

        [Fact]
        public void AlphabetPosition()
        {
            Assert.Equal("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kyu6.AlphabetPosition("The narwhal bacons at midnight."));
        }

        [Fact]
        public void Persistence()
        {
            Assert.Equal(2, Kyu6.Persistence(25));
        }

        [Fact]
        public void DuplicateEncode()
        {
            Assert.Equal(")())())", Kyu6.DuplicateEncode("Success"));
        }

        
        [InlineData(new[] { 1, 2, 2, 2 }, 1)]
        [InlineData(new[] { -2, 2, 2, 2 }, -2)]
        [InlineData(new[] { 11, 11, 14, 11, 11 }, 14)]
        [Theory]
        public void GetUnique(IEnumerable<int> numbers, int expectedResult)
        {
            Assert.Equal(expectedResult, Kyu6.GetUnique(numbers));
        }

        [Fact]
        public void Solution()
        {
            Assert.Equal(new string[] { "ab", "c_" }, Kyu6.Solution("abc"));
        }

        [Fact]
        public void DiagonalDifference()
        {
            int n = 3;
            int[,] rows = { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };

            var arr = new List<List<int>>();
            var nRow = new List<int>();
            nRow.Add(n);
            arr.Add(nRow);
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                var rowList = new List<int>();
                for (int j = 0; j < rows.GetLength(0); j++)
                {
                    rowList.Add(rows[i, j]);
                }
                
                arr.Add(rowList);
            }

            Assert.Equal(15, Kyu6.DiagonalDifference(arr));
        }

        [Fact]
        public void SortArray()
        {
            Assert.Equal(new int[] { 1, 3, 2, 8, 5, 4 }, Kyu6.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        [Fact]
        public void SubtitleMaker()
        {
            var expected = new List<List<string>>();
            expected.Add(new List<string> { "There", "is", "one", "sentence", "that" });
            expected.Add(new List<string> { "is", "a", "bit", "longer." });
            expected.Add(new List<string> { "The", "second", "one", "is", "shorter" });

            Assert.Equal(expected, Kyu6.SubtitleMaker("There is one sentence that is a bit longer. The second one is shorter"));
        }

        [Fact]
        public void SubtitleMakerAlt()
        {
            var expected = new List<List<string>>();
            expected.Add(new List<string> { "There", "is", "one", "sentence", "that" });
            expected.Add(new List<string> { "is", "a", "bit", "longer." });
            expected.Add(new List<string> { "The", "second", "one", "is", "shorter" });

            Assert.Equal(expected, Kyu6.SubtitleMakerAlt("There is one sentence that is a bit longer. The second one is shorter"));
        }

        [Fact]
        public void SubtitleMakerAltAlt()
        {
            var expected = new List<List<string>>();
            expected.Add(new List<string> { "There", "is", "one", "sentence", "that" });
            expected.Add(new List<string> { "is", "a", "bit", "longer." });
            expected.Add(new List<string> { "The", "second", "one", "is", "shorter" });

            Assert.Equal(expected, Kyu6.SubtitleMakerAltAlt("There is one sentence that is a bit longer. The second one is shorter"));
        }

        [Fact]
        public void SecondLargestPerimeter()
        {
            var expected = 2;
            var input = new int[3,3] { { 1, 2, 3 }, { 7, 6, 8 }, { 4, 5, 6 } };

            Assert.Equal(expected, Kyu6.SecondLargestPerimeter(input));
        }

        [Fact]
        public void SecondLargestPerimeterJagged()
        {
            var expected = 1;
            var input = new int[4][] { new int[3] { 1, 2, 3 }, new int[3] { 7, 6, 8 }, new int[3] { 4, 5, 6 }, new int[3] { 11, 15, 33 } };

            Assert.Equal(expected, Kyu6.SecondLargestPerimeterLinq(input));
        }

        [Fact]
        public void TowerBuilder()
        {
            Assert.Equal(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kyu6.TowerBuilder(3)));
        }

        [Fact]
        public void DeleteNth()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = Kyu6.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            Assert.Equal(expected, actual);
        }
    }
}
