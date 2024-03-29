﻿using CodeWars.Level;
using System.Numerics;

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

        [Theory]
        [InlineData(5, 1)]
        [InlineData(25, 6)]
        [InlineData(531, 131)]
        public void TrailingZeros(int n, int expectedResult)
        {
            var result = Kyu5.TrailingZeros(n);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Anagrams()
        {
            Assert.Equal(new List<string> { "carer", "arcre", "carre" }, Kyu5.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }

        [Fact]
        public void MoveZeroes()
        {
            Assert.Equal(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kyu5.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }

        [Fact]
        public void Rgb()
        {
            Assert.Equal("FFFFFF", Kyu5.Rgb(255, 255, 255));
            Assert.Equal("FFFFFF", Kyu5.Rgb(255, 255, 300));
            Assert.Equal("000000", Kyu5.Rgb(0, 0, 0));
            Assert.Equal("9400D3", Kyu5.Rgb(148, 0, 211));
            Assert.Equal("9400D3", Kyu5.Rgb(148, -20, 211));
            Assert.Equal("90C3D4", Kyu5.Rgb(144, 195, 212));
            Assert.Equal("D4350C", Kyu5.Rgb(212, 53, 12));
        }

        [Fact]
        public void DirReduc()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            Assert.Equal(b, Kyu5.DirReduc(a));
        }

        [Fact]
        public void Rot13()
        {
            Assert.Equal("Grfg", Kyu5.Rot13("Test"));
        }

        [Fact]
        public void GenerateDiagonal()
        {
            Assert.Equal(new BigInteger[] { 1, 3, 6, 10, 15 }, Kyu5.GenerateDiagonal(2, 5));
        }

        [Fact]
        public void FirstNonRepeatingLetter()
        {
            Assert.Equal("e", Kyu5.FirstNonRepeatingLetter("moonmen"));
            Assert.Equal("", Kyu5.FirstNonRepeatingLetter("tennet"));
        }

        [Fact]
        public void OrderWeight()
        {
            Assert.Equal("2000 103 123 4444 99", Kyu5.OrderWeight("103 123 4444 99 2000"));
        }

        [Fact]
        public void Score()
        {
            Assert.Equal(450, Kyu5.Score(new int[] { 2, 4, 4, 5, 4 }));
        }

        [Fact]
        public void Scramblies()
        {
            Assert.Equal(true, Kyu5.Scramble("cedewaraaossoqqyt", "codewars"));
        }

        [Fact]
        public void MaxSequence()
        {
            Assert.Equal(6, Kyu5.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
