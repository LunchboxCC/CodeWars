using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Level
{
    public static class Kyu6
    {
        public static int CountBits(int n)
        {
            /* https://www.codewars.com/kata/526571aae218b8ee490006f4
               Write a function that takes an integer as input, and returns the number of bits that are equal to 
               one in the binary representation of that number. You can guarantee that input is non-negative.

               Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case */

            var binary = Convert.ToString(n, 2);

            return binary.Count(b => b == '1');
        }
    }
}