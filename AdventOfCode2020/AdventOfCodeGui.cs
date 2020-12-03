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

        private void _day1_Click(object sender, EventArgs e)
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

        private void _day2_Click(object sender, EventArgs e)
        {
            string dataPath = "Data\\Day02_Data.txt";
            
            List<string> fileData = new List<string>();
            using (StreamReader reader = new StreamReader(dataPath))
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

            Day02Function function = new Day02Function(fileData);
            int validPasswordsFound = function.ScanListForValidOldSledPasswords();
            int validTobboganPasswordsFound = function.ScanListForValidCorrectTobogganPasswords();
            _output.Text = "Found " + validPasswordsFound.ToString() + " valid sled passwords";
            _output.Text += Environment.NewLine + "Found " + validTobboganPasswordsFound.ToString() + " valid toboggan passwords";

        }
    }
}
