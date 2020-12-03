using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020
{
    public class Day01Function
    {
        public Day01Function(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File " + filePath + " does not exist");
            }

            List<int>  values = new List<int>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string thisLine = reader.ReadLine().Trim();
                    int value = -1;
                    if (int.TryParse(thisLine, out value))
                    {
                        values.Add(value);
                    }
                }
            }

            Data = values;
        }

        public IList<int> Data { get; }

        public bool FindSumThatEqualsValue(int desiredValue, ref int a, ref int b)
        {
            for (var i = 0; i < Data.Count; i++)
            {
                int aVal = Data[i];
                for (var j = i + 1; j < Data.Count; j++)
                {
                    int bVal = Data[j];
                    int mult = aVal + bVal;
                    if (mult == desiredValue)
                    {
                        a = aVal;
                        b = bVal;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool FindThreeSumThatEqualsValue(int desiredValue, ref int a, ref int b, ref int c)
        {
            for (var i = 0; i < Data.Count; i++)
            {
                int aVal = Data[i];
                for (var j = i + 1; j < Data.Count; j++)
                {
                    int bVal = Data[j];
                    for (var k = j + 1; k < Data.Count; k++)
                    {
                        int cVal = Data[k];
                        int mult = aVal + bVal + cVal;
                        if (mult == desiredValue)
                        {
                            a = aVal;
                            b = bVal;
                            c = cVal;
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}