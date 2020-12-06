using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace AdventOfCode2020
{
    public class Day06Functions
    {
        public static IList<GroupOfAnswers> ParseGroupsOfAnswers(IList<string> fileContents)
        {
            List<string> thisGroupsAnswers = new List<string>();
            List<GroupOfAnswers> groupsAnswers = new List<GroupOfAnswers>();
            bool force = false;
            int i = 0;
            foreach (string line in fileContents)
            {
                if (i == fileContents.Count-1)
                {
                    thisGroupsAnswers.Add(line);
                    force = true;
                }

                i++;
                if (string.IsNullOrWhiteSpace(line) || force)
                {
                    if (thisGroupsAnswers.Count == 1 && string.IsNullOrWhiteSpace(thisGroupsAnswers[0]) || thisGroupsAnswers.Count == 0)
                    {
                        continue;
                    }
                    groupsAnswers.Add(new GroupOfAnswers(thisGroupsAnswers.Where(s=>!string.IsNullOrWhiteSpace(s)).ToList()));
                    thisGroupsAnswers.Clear();
                    continue;
                }
                thisGroupsAnswers.Add(line);

            }

            return groupsAnswers;
        }
        public class GroupOfAnswers
        {
            public GroupOfAnswers(IList<string> groupsAnswers)
            {
                PersonsAnswers = groupsAnswers.ToList();
            }

            public IList<string> PersonsAnswers { get; }

            private string CreateSingleString()
            {
                StringBuilder builder = new StringBuilder();
                PersonsAnswers.Select(s => builder.Append(s.Trim())).ToList();
                return builder.ToString();
            }

            public int GetUniqueNumberOfYeses()
            {
                return CreateSingleString().Distinct().Count();
            }

            public int GetCountOfAllYeses()
            {
                int count = 0;
                if (PersonsAnswers.Count == 1)
                {
                    count = PersonsAnswers[0].Length;
                    return count;
                }

                for (int i = 0; i < PersonsAnswers[0].Length; i++)
                {
                    var thisAnswer = PersonsAnswers[0][i];
                    bool allHaveIt = true;
                    for (int b = 1; b < PersonsAnswers.Count; b++)
                    {
                        allHaveIt = allHaveIt && PersonsAnswers[b].Contains(thisAnswer);
                    }

                    if (allHaveIt)
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
}