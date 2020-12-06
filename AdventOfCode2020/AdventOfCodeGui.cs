using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class AdventOfCodeGui : Form
    {
        public AdventOfCodeGui()
        {
            InitializeComponent();
        }

        private void _day01_Click(object sender, EventArgs e)
        {
            string dataPath = "Data\\Day01_Data.txt";
            Day01Function function = new Day01Function(dataPath);
            int a = 0;
            int b = 0;
            if (function.FindSumThatEqualsValue(2020, ref a, ref b))
            {
                _output.Text = a.ToString() + " * " + b.ToString() + " = " + (a * b).ToString();

                int c = 0;
                if (function.FindThreeSumThatEqualsValue(2020, ref a, ref b, ref c))
                {
                    _output.Text += Environment.NewLine + a.ToString() + " * " + b.ToString() + " * " + c.ToString() + " = " + (a * b*c).ToString();
                }
                else
                {
                    _output.Text += Environment.NewLine + "No values found for 3 sum";
                }
            }
            else
            {
                _output.Text = "No values found";
            }

        }

        private void _day02_Click(object sender, EventArgs e)
        {
            string dataPath = "Data\\Day02_Data.txt";

            var fileData=ReadInFileAsLinesOfText(dataPath);

            Day02Function function = new Day02Function(fileData);
            int validPasswordsFound = function.ScanListForValidOldSledPasswords();
            int validTobboganPasswordsFound = function.ScanListForValidCorrectTobogganPasswords();
            _output.Text = "Found " + validPasswordsFound.ToString() + " valid sled passwords";
            _output.Text += Environment.NewLine + "Found " + validTobboganPasswordsFound.ToString() + " valid toboggan passwords";

        }

        private IList<string> ReadInFileAsLinesOfText(string filePath)
        {
            List<string> fileData = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine().Trim();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        fileData.Add(line);
                    }
                }
            }

            return fileData;
        }

        private void _day03_Click(object sender, EventArgs e)
        {
            var fileData = ReadInFileAsLinesOfText("Data\\Day03_Data.txt");
            var map = Day03Functions.RepeatingLineOfMap.CreateMap(fileData);
            long actual = Day03Functions.CountTrees(map, 0, 0, 3, 1);

            _output.Text = "Found " + actual.ToString() + " trees";


            long oneOne = Day03Functions.CountTrees(map, 0, 0, 1, 1);
            long threeOne = Day03Functions.CountTrees(map, 0, 0, 3, 1);
            long fiveOne = Day03Functions.CountTrees(map, 0, 0, 5, 1);
            long sevenOne = Day03Functions.CountTrees(map, 0, 0, 7, 1);
            long oneTwo = Day03Functions.CountTrees(map, 0, 0, 1, 2);
            actual = oneOne * threeOne * fiveOne * sevenOne * oneTwo;

            _output.Text += Environment.NewLine + "Found " + actual.ToString() + " trees to minimize";
            int otherActual = (int)(oneOne * threeOne * fiveOne * sevenOne * oneTwo);
            _output.Text += Environment.NewLine + "Found " + otherActual.ToString() + " trees to minimize if using ints";

        }
    }
}
