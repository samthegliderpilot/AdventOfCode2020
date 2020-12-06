using System;
using System.Linq;
using AdventOfCode2020;
using NUnit.Framework;

namespace Test.AdventOfCode2020
{
    [TestFixture]
    public class TestDay06Functions
    {
        public const string SampleAnswers = @"abc

a
b
c

ab
ac

a
a
a
a

b
";

        [Test]
        public void TestSampleOfAny()
        {
            var data = Day06Functions.ParseGroupsOfAnswers(SampleAnswers.Split(Environment.NewLine));
            int expected = 11;
            Assert.AreEqual(expected, data.Sum(s=>s.GetUniqueNumberOfYeses()));
        }

        [Test]
        public void TestSampleOfAll()
        {
            var data = Day06Functions.ParseGroupsOfAnswers(SampleAnswers.Split(Environment.NewLine));
            int expected = 6;
            Assert.AreEqual(expected, data.Sum(s => s.GetCountOfAllYeses()));
        }
    }
}