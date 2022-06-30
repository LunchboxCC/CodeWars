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
    }
}
