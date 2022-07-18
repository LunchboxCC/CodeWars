using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool IsPangram(string str)
        {          
            var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            str = str.ToLower();

            return !letters.Where(l => !str.Contains(l)).Any();
            //return letters.Where(l => Char.IsLetter(l)).Distinct().Count() == 26;
        }

        public static string CleanString(string s)
        {
            //var sb = new StringBuilder();
            var stack = new Stack<char>();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                    stack.TryPop(out char result);
                else
                    stack.Push(s[i]);
            }

            return new string(stack.Reverse().ToArray());
        }

        public static List<string> Wave(string str)
        {
            var list = str.Select((c, i) => str.Substring(0, i) + char.ToUpper(c) + str.Substring(i + 1)).Where(s => s != str).ToList();

            return list;
        }

        public static char FindMissingLetter(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (Convert.ToChar(array[i] + 1) != array[i + 1])
                    return Convert.ToChar(array[i] + 1);
            }

            return ' ';
        }

        public static int MultiplesOf3And5(int value)
        {
            return Enumerable.Range(0, value).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }

        public static int CountSmileys(string[] smileys)
        {
            var regex = new Regex("([:;])([-~])?([)D])");

            return smileys.Count(s => regex.IsMatch(s));
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new List<T>();
            var previous = default(T);

            foreach (var element in iterable)
            {
                if (!element.Equals(previous))
                {
                    result.Add(element);
                    previous = element;
                }
            }

            return result;
            //return iterable.Where((e, i) => i == 0 || !e.Equals(iterable.ElementAt(i - 1)));
        }

        public static int DigitalRoot(long n)
        {
            if (n < 10)
                return (int)n;

            int sum = n.ToString().Select(n => (int)Char.GetNumericValue(n)).Sum();
            return DigitalRoot(sum);
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}