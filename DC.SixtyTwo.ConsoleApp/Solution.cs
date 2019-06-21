using System;
using System.Collections.Generic;
using System.Text;

namespace DC.SixtyTwo.ConsoleApp
{
    public class Solution
    {
        private int maxX, maxY, currentX, currentY, answer;

        public Solution()
        {
            maxX = 0;
            maxY = 0;
            answer = 0;
            currentX = 0;
            currentY = 0;
        }
        public int Solve (int m, int n)
        {
            maxX = m - 1;
            maxY = n - 1;
            TakeAStep();
            return answer;
        }

        private void TakeAStep()
        {
            if (IsFinished())
            {
                answer++;
            }
            else
            {
                if (currentX < maxX)
                {
                    StepAlongX();
                }
                if (currentY < maxY)
                {
                    StepAlongY();
                }
            }
        }

        private void StepAlongY()
        {
            currentY++;
            TakeAStep();
        }

        private void StepAlongX()
        {
            currentX++;
            TakeAStep();
        }

        private bool IsFinished()
        {
            if (currentX == maxX && currentY == maxY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
