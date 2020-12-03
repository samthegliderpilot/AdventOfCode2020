using System.Collections.Generic;
using AdventOfCode2020;
using NUnit.Framework;

namespace Test.AdventOfCode2020
{
    public class TestDay02Functions
    {
        [Test]
        public void TestSledPassword()
        {
            List<string> potentialData = new List<string>();
            potentialData.Add("8-11 l: qllllqllklhlvtl"); // valid
            potentialData.Add("1-3 m: wmmmmmttm");  // invalid
            potentialData.Add("2-4 p: pgppp"); // valid
            potentialData.Add("11-12 n: nnndnnnnnnnn"); //valid

            Day02Function day02 = new Day02Function(potentialData);
            Assert.AreEqual(3, day02.ScanListForValidOldSledPasswords());
        }

        [Test]
        [TestCase("1-3 a: abcde", true)]
        [TestCase("1-3 b: cdefg", false)]
        [TestCase("2-9 c: ccccccccc", false)]
        
        public void TestTobogganPassword(string line, bool isValid)
        {
            List<string> potentialData = new List<string>();
            potentialData.Add(line);
            
            Day02Function day02 = new Day02Function(potentialData);
            Assert.AreEqual(isValid ? 1 : 0, day02.ScanListForValidCorrectTobogganPasswords());
        }
    }
}