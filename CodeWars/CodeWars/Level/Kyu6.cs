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

        public static string Meeting(string s)
        {
            string[] people = s.Split(";");
            string[] result = new string[people.Length];

            for (int i = 0; i < people.Length; i++)
            {
                int colon = people[i].IndexOf(':');
                result[i] = $"({people[i].Substring(colon + 1)}, {people[i].Substring(0, colon)})".ToUpper();
            }

            return string.Join("", result.OrderBy(p => p.Substring(1)));
        }

        public static int Find(int[] integers)
        {
            //var evenList = new List<int>();
            //var oddList = new List<int>();

            //foreach (int i in integers)
            //{
            //    if (i % 2 == 0)
            //        evenList.Add(i);
            //    else
            //        oddList.Add(i);
            //}

            //return oddList.Count > evenList.Count ? evenList.ElementAt(0) : oddList.ElementAt(0);

            return integers.GroupBy(i => i % 2).FirstOrDefault(kv => kv.Count() == 1).First();
        }

        public static string Likes(string[] name)
        {
            string result = name.Length switch
            {
                0 => "no one likes this",
                1 => $"{name[0]} likes this",
                2 => $"{name[0]} and {name[1]} like this",
                3 => $"{name[0]}, {name[1]} and {name[2]} like this",
                _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this"
            };

            return result;
        }

        public static int FindIt(int[] seq)
        {
            return seq.GroupBy(x => x).Where(kv => kv.Count() % 2 == 1).FirstOrDefault().FirstOrDefault();
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({string.Join("",numbers.Take(3))}) {string.Join("", numbers.Skip(3).Take(3))}-{string.Join("", numbers.Skip(6).Take(4))}";
        }

        public static int DuplicateCount(string str)
        {
            return str.GroupBy(char.ToUpper).Count(kv => kv.Count() > 1);
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            int vertical = 0;
            int horizontal = 0;
            
            foreach (string str in walk)
            {
                switch (str)
                {
                    case "n":
                        vertical++;
                        break;
                    case "s":
                        vertical--;
                        break;
                    case "w":
                        horizontal++;
                        break;
                    case "e":
                        horizontal--;
                        break;
                }
            }

            return vertical == 0 && horizontal == 0;
        }
    }
}