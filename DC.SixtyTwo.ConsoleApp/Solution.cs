using System;
using System.Collections.Generic;
using System.Text;

namespace DC.SixtyTwo.ConsoleApp
{
    public class Solution
    {
        public int Solve (int m, int n)
        {
            int distanceFromX = m - 1;
            int distanceFromY = n - 1;
            return distanceFromX + distanceFromY;
        }
    }
}
