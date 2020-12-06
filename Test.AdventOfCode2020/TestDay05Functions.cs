using System;
using AdventOfCode2020;
using NUnit.Framework;

namespace Test.AdventOfCode2020
{
    [TestFixture]
    public class TestDay05Functions
    {
        [Test]
        [TestCase("FBFBBFFRLR", 44, 5)]
        [TestCase("BFFFBBFRRR", 70, 7)]
        [TestCase("FFFBBBFRRR", 14, 7)]
        [TestCase("BBFFBBFRLL", 102, 4)]
        public void TestExamples(string fullString, long expectedRow, long expectedCol)
        {
            Tuple<int, int> answer = Day05Functions.GetRowAndColumn(fullString);
            Assert.AreEqual(expectedRow, answer.Item1, "row");
            Assert.AreEqual(expectedCol, answer.Item2, "row");
        }
    }
}