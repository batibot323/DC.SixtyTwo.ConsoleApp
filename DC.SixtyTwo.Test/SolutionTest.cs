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

        [Fact]
        public void Solve_Given1_2_ShouldReturn1()
        {
            Assert.Equal(1, uut.Solve(1, 2));
        }

        [Fact]
        public void Solve_Given2_1_ShouldReturn1()
        {
            Assert.Equal(1, uut.Solve(2, 1));
        }

        [Fact]
        public void Solve_Given3_1_ShouldReturn1()
        {
            Assert.Equal(1, uut.Solve(3, 1));
        }

        [Fact]
        public void Solve_Given1_3_ShouldReturn1()
        {
            Assert.Equal(1, uut.Solve(1, 3));
        }

        [Fact]
        public void Solve_Given2_3_ShouldReturn1()
        {
            Assert.Equal(3, uut.Solve(2, 3));
        }

        [Fact]
        public void Solve_Given5_5_ShouldReturn70()
        {
            Assert.Equal(70, uut.Solve(5, 5));
        }
    }
}
