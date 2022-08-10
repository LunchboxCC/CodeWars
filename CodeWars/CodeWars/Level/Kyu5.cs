using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Level
{
    public static class Kyu5
    {
        public static string GetReadableTime(int seconds)
        {
            // https://www.codewars.com/kata/52685f7382004e774f0001f7
            /* Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

               HH = hours, padded to 2 digits, range: 00 - 99
               MM = minutes, padded to 2 digits, range: 00 - 59
               SS = seconds, padded to 2 digits, range: 00 - 59
               The maximum time never exceeds 359999 (99:59:59)

               You can find some examples in the test fixtures. */

            int hours, minutes;

            hours = seconds / 3600;
            seconds = seconds % 3600;

            minutes = seconds / 60;
            seconds = seconds % 60;

            return $"{hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}";
        }

        public static string GetReadableTimeRefactored(int seconds) 
        {
            var time = TimeSpan.FromSeconds(seconds);
            return string.Format($"{time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}");
        }

        public static long IpsBetween(string start, string end)
        {
            long startSum = 0;
            long endSum = 0;

            int[] arrStart = Array.ConvertAll(start.Split("."), int.Parse);
            int[] arrEnd = Array.ConvertAll(end.Split("."), int.Parse);

            for (int i = 0; i < 4; i++) 
            {
                startSum += (long)(arrStart[i] * Math.Pow(256, 4 - i - 1));
                endSum += (long)(arrEnd[i] * Math.Pow(256, 4 - i - 1));
            }

            return endSum - startSum;
        }

        public static long IpsBetweenWithLinq(string start, string end)
        {
            var startSum = start.Split(".").Select((element, index) => Convert.ToInt32(element) * Math.Pow(256, 3 - index)).Sum();
            var endSum = end.Split(".").Select((element, index) => Convert.ToInt32(element) * Math.Pow(256, 3 - index)).Sum();

            return (long)(endSum - startSum);
        }

        public static string PigIt(string str)
        {
            var arr = str.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsLetter(arr[i][0]))
                    arr[i] = arr[i].Substring(1) + arr[i][0] + "ay";
            }

            return String.Join(" ", arr);
        }

        public static int TrailingZeros(int n)
        {
            int count = 0;

            for (int i = 5; n / i >= 1; i *= 5)
            {
                count += n / i;
            }

            return count;
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            var dict = word.GroupBy(c => c).ToDictionary(k => k.Key, v => v.Count());
            var list = new List<string>();

            word = new string (word.OrderBy(c => c).ToArray());

            foreach (var item in words)
            {
                if (word.Equals(new string(item.OrderBy(c => c).ToArray())))
                    list.Add(item);
            }

            return list;
        }

        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(n => n == 0).ToArray();
        }
        public static string Rgb(int r, int g, int b)
        {
            //char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            //int[] rgb = { r, g, b };

            //rgb = rgb.Select(i => i < 0 || i > 255 ? (i / 255) * 255 : i).ToArray();

            //return string.Join("", rgb.Select(i => hex[i / 16] + "" + hex[i % 16]));

            r = Math.Clamp(r, 0, 255);
            g = Math.Clamp(g, 0, 255);
            b = Math.Clamp(b, 0, 255);

            return r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
        }

        public static string[] DirReduc(String[] arr)
        {
            string[] directions = { "NORTHSOUTH", "SOUTHNORTH", "WESTEAST", "EASTWEST" };

            int dirCount = 0;
            var list = arr.ToList();

            while (list.Count != dirCount)
            {
                dirCount = list.Count;

                for (int i = 1; i < list.Count; i++)
                {
                    if (directions.Contains(list[i - 1] + list[i]))
                    {
                        list.RemoveRange(i - 1, 2);
                        break;
                    }
                }
            }

            return list.ToArray();
        }

        public static string Rot13(string message)
        {
            var result = "";

            for (int i = 0; i < message.Length; i++)
            {
                char lowerC = char.ToLower(message[i]);

                if (lowerC >= 'a' && lowerC <= 'm')
                    result += (char)(message[i] + 13);
                else if (lowerC >= 'n' && lowerC <= 'z')
                    result += (char)(message[i] - 13);
                else
                    result += message[i];
            }

            return result;
        }

        public static BigInteger[] GenerateDiagonal(int n, int l)
        {
            int[][] jagged = new int[l + n][];
            var result = new BigInteger[l];

            for (int i = 0; i < l + n; i++)
            {
                jagged[i] = new int[i + 1];
                
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                        jagged[i][j] = 1;
                    else
                        jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];

                    if (i >= n && i - n == j)
                        result[i - n] = jagged[i][j];
                }
            }

            return result;
        }

        public static string FirstNonRepeatingLetter(string s)
        {        
            var kv = s.ToLower().GroupBy(c => c).Where(kv => kv.Count() == 1).FirstOrDefault();

            if (kv != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.ToLower(s[i]).Equals(kv.Key))
                        return s[i].ToString();
                }
            }

            return "";
        }

        public static string OrderWeight(string strng)
        {
            var split = strng.Split(" ");

            return string.Join(" ", split.OrderBy(s => s.Sum(char.GetNumericValue)).ThenBy(s => s));
        }

        public static int Score(int[] dice)
        {
            //O(2 * n + 6)
            //int score = 0;
            //var counts = dice.GroupBy(d => d).ToDictionary(k => k.Key, v => v.Count());

            //for (int i = 0; i < counts.Count; i++)
            //{
            //    var kv = counts.ElementAt(i);

            //    if (kv.Value >= 3)
            //    {
            //        score += kv.Key * 100;
            //        if (kv.Key == 1)
            //            score += 900;
            //    }

            //    if (kv.Key == 1)
            //        score += kv.Value % 3 * 100;
            //    else if (kv.Key == 5)
            //        score += kv.Value % 3 * 50;
            //}

            //return score;

            //O(n)
            int score = 0;
            int[] counts = new int[6];

            for (int i = 0; i < dice.Length; i++)
            {
                int die = dice[i];
                counts[die - 1]++;

                if (counts[die - 1] == 3)
                {
                    score += die * 100;
                    if (die == 1)
                        score += -200 + 900;
                    else if (die == 5)
                        score -= 100;
                }
                else if (die == 1)
                    score += 100;
                else if (die == 5)
                    score += 50;
            }

            return score;
        }

        public static bool Scramble(string str1, string str2)
        {
            ////var ordered = str1.OrderBy(c => str2);
            ////var groups = str1.GroupBy(c => c).Where(kv => str2.Contains(kv.Key));
            //var list = new List<char>();
            //int count = 0;

            //for (int i = 0; i < str1.Length; i++)
            //{
            //    if (str2.Contains(str1[0]))

            //}

            int[] countArray = new int[26];
            foreach (char c in str2)
            {
                countArray[c - 'a']++;
            }

            foreach (char c in str1)
            {
                if (countArray[c - 'a'] > 0)
                    countArray[c - 'a']--;
            }

            if (countArray.Sum() == 0)
                return true;
            else
                return false;
        }

        public static int[] Snail(int[][] array)
        {
            bool xRight = true;
            bool yUp = true;
            int n = array.Length;
            int reps = n;

            var result = new List<int>();

            return new int[0];

            /*
            for (int i = 1; i < reps - 1; i++)
            {
                for (int j = 0; j < reps; j++)
                {
                    if (xRight)
                        result.Add(array[i][j]);
                    else
                        result.Add(array[i][n - j]);
                }
                
                if (yUp)
                {
                    result.Add(array[][])
                }
            }
            */

            /*
            while (array.Length * array.Length >= result.Count)
            {

            }
            */
        }

        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= arr.Length - i; j++)
                {
                    sum = arr.Skip(i).Take(j).Sum();
                    if (sum > max)
                        max = sum;
                }
            }

            return max;
        }
    }
}
