using System;
using System.Collections.Generic;
using System.Text;

namespace DC.SixtyTwo.ConsoleApp
{
    public class Solution
    {
        private int maxX, maxY, answer;

        public Solution()
        {
            maxX = 0;
            maxY = 0;
            answer = 0;
        }
        public int Solve (int m, int n)
        {
            maxX = m - 1;
            maxY = n - 1;
            TakeAStep(0, 0);
            return answer;
        }

        private void TakeAStep(int currentX, int currentY)
        {
            if (IsFinished(currentX, currentY))
            {
                answer++;
            }
            else
            {
                if (currentX < maxX)
                {
                    StepAlongX(currentX, currentY);
                }
                if (currentY < maxY)
                {
                    StepAlongY(currentX, currentY);
                }
            }
        }

        private void StepAlongY(int currentX, int currentY)
        {
            currentY++;
            TakeAStep(currentX, currentY);
        }

        private void StepAlongX(int currentX, int currentY)
        {
            currentX++;
            TakeAStep(currentX, currentY);
        }

        private bool IsFinished(int currentX, int currentY)
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
