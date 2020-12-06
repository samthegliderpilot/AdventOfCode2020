using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;

namespace AdventOfCode2020
{
    public class Day03Functions
    {
        public class RepeatingLineOfMap
        {
            public static IList<RepeatingLineOfMap> CreateMap(IList<string> fileData)
            {
                return fileData.Select(s => new RepeatingLineOfMap(s)).ToList();
            }

            public RepeatingLineOfMap(string line)
            {
                Line = line;
                LineCount = line.Length;
            }

            public string Line { get; }

            public int LineCount { get; } // caching it since it is so commonly used

            public char this[int i]
            {
                get
                {
                    int moded = i % LineCount;
                    return Line[moded];
                }
            }
        }

        public static long CountTrees(IList<RepeatingLineOfMap> map, int startingRow, int startingCol, int colHop, int rowHop)        {
            long trees = 0;
            int colsTraveled = startingCol;
            for (int i = startingRow; i < map.Count-1; i+=rowHop)
            {
                colsTraveled += colHop;
                if (map[i+rowHop][colsTraveled] == '#')
                {
                    trees++;
                }
            }

            return trees;
        }
    }
}