﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace AdventOfCode2020
{
    /// <summary>
    /// The ah-ha moment was realizing that the strings were really just binary numbers.
    /// </summary>
    public class Day05Functions
    {
        public static int ConvertFirstHalfOfString(string frontBacks)
        {
            string toBinaryString = frontBacks.Replace("F", "0").Replace("B","1");
            return Convert.ToInt32(toBinaryString, 2);
        }

        public static int ConvertSecondHalfOfString(string rightLefts)
        {
            string toBinaryString = rightLefts.Replace("L", "0").Replace("R", "1");
            return Convert.ToInt32(toBinaryString, 2);
        }

        public static Tuple<int, int> GetRowAndColumn(string fullString)
        {
            string frontBacks = fullString.Remove(7, 3);
            string rightLefts = fullString.Remove(0, 7);

            return new Tuple<int, int>(ConvertFirstHalfOfString(frontBacks), ConvertSecondHalfOfString(rightLefts));
        }
        
        public static int GetSeatId(string fullString)
        {
            var vals = GetRowAndColumn(fullString);
            return vals.Item1*8+ vals.Item2;
        }

        public static List<int> GetAndSortSeatIds(IList<string> ticketPasses)
        {
            var knownSeatIds = ticketPasses.Select(GetSeatId).ToList();
            knownSeatIds.Sort();
            return knownSeatIds;
        }

        public static int GetMissingSeatNumber(List<int> knownSeats)
        {
            
            int checkedSeatId = knownSeats[0];
            int foundSeat = -1;
            for (int i = 0; i < knownSeats.Count; i++)
            {
                int thisSeat = knownSeats[i];
                if (checkedSeatId != thisSeat)
                {
                    foundSeat = checkedSeatId;
                    break;
                }

                checkedSeatId++;

            }

            return foundSeat;
        }
    }
}