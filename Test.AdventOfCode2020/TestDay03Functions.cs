using System;
using System.Linq;
using AdventOfCode2020;
using NUnit.Framework;

namespace Test.AdventOfCode2020
{
    [TestFixture]
    public class TestDay03Functions
    {
        public const string SampleData =
@"..##.......
#...#...#..
.#....#..#.
..#.#...#.#
.#...##..#.
..#.##.....
.#.#.#....#
.#........#
#.##...#...
#...##....#
.#..#...#.#";

        [Test]
        public void TestSampleData()
        {
            var map = Day03Functions.RepeatingLineOfMap.CreateMap(SampleData.Split(Environment.NewLine).ToList());
            int expected = 7;
            long actual = Day03Functions.CountTrees(map, 0, 0, 3, 1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTwoRowsOfSampleData()
        {
            var map = Day03Functions.RepeatingLineOfMap.CreateMap(SampleData.Split(Environment.NewLine).Take(3).ToList());
            int expected = 1;
            long actual = Day03Functions.CountTrees(map, 0, 0, 3, 1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMinimizing()
        {
            var map = Day03Functions.RepeatingLineOfMap.CreateMap(SampleData.Split(Environment.NewLine).ToList());
            int expected = 336;
            long oneOne = Day03Functions.CountTrees(map, 0, 0, 1, 1);
            long threeOne = Day03Functions.CountTrees(map, 0, 0, 3, 1);
            long fiveOne = Day03Functions.CountTrees(map, 0, 0, 5, 1);
            long sevenOne = Day03Functions.CountTrees(map, 0, 0, 7, 1);
            long oneTwo = Day03Functions.CountTrees(map, 0, 0, 1, 2);
            long actual = oneOne * threeOne * fiveOne * sevenOne * oneTwo;
            Assert.AreEqual(expected, actual);
        }
    }
}