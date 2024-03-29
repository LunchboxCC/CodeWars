﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Level
{
    public static class Kyu7
    {
        public static bool IsSquare(int n)
        {
            var sqrt = Math.Sqrt(n);
            return (int)sqrt == sqrt;
        }
        public static int BusInOut(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Select(e => e[0] - e[1]).Sum();
        }
    }
}
