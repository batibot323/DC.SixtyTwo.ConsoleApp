using DC.SixtyTwo.ConsoleApp;
using System;
using Xunit;

namespace DC.SixtyTwo.Test
{
    public class SolutionTest
    {
        private Solution uut;

        public SolutionTest()
        {
            uut = new Solution();
        }

        [Fact]
        public void Solve_Given2_2_ShouldReturn2()
        {
            Assert.Equal(2, uut.Solve(2, 2));
        }
    }
}
