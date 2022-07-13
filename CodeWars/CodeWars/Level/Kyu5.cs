using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
