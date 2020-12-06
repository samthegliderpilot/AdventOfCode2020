using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day02Function
    {
        public class Password
        {
            public static Tuple<Password, string> ReadLineFromDataFile(string lineFromFile)
            {
                string[] parts = lineFromFile.Split(':');
                string[] boundsAndChar = parts[0].Split(' ');
                char requiredChar = boundsAndChar[1][0];

                string[] bounds = boundsAndChar[0].Split('-');
                int lowerBound = int.Parse(bounds[0]);
                int upperBound = int.Parse(bounds[1]);
                string password = parts[1].Trim();

                return new Tuple<Password, string>(new Password(){RequiredChar = requiredChar, LowerRequired = lowerBound, UpperRequired = upperBound}, password);
            }

            public Password()
            {
            }

            public char RequiredChar { get; private set; }
            public int LowerRequired { get; private set; }
            public int UpperRequired { get; private set; }

            public bool IsValidSledPassword(string potentialPassword)
            {
                int countOfLetter = 0;
                foreach (var letter in potentialPassword)
                {
                    if (letter == RequiredChar)
                    {
                        countOfLetter++;
                    }
                }
                return countOfLetter >= LowerRequired && countOfLetter <= UpperRequired;
            }

            public bool IsValidTobogganPassword(string potentialPassword)
            {
                char atLower = potentialPassword[LowerRequired - 1];
                char atUpper = potentialPassword[UpperRequired - 1];
                return (atLower == RequiredChar && atUpper != RequiredChar) ||
                       (atLower != RequiredChar && atUpper == RequiredChar);
            }
        }

        public Day02Function(IEnumerable<string> fileData)
        {
            List<Tuple<Password, string>> values = new List<Tuple<Password, string>>();
            foreach (string line in fileData)
            {

                if (!string.IsNullOrWhiteSpace(line))
                {
                    values.Add(Password.ReadLineFromDataFile(line));
                }
            }
            PasswordData = values;
        }

        public int ScanListForValidOldSledPasswords()
        {
            int validPasswordsFound = 0;
            foreach (var pair in PasswordData)
            {
                if (pair.Item1.IsValidSledPassword(pair.Item2))
                {
                    validPasswordsFound++;
                }
            }

            return validPasswordsFound;
        }

        public int ScanListForValidCorrectTobogganPasswords()
        {
            int validPasswordsFound = 0;
            foreach (var pair in PasswordData)
            {
                if (pair.Item1.IsValidTobogganPassword(pair.Item2))
                {
                    validPasswordsFound++;
                }
            }

            return validPasswordsFound;
        }

        public List<Tuple<Password, string>> PasswordData { get; }
    }
}