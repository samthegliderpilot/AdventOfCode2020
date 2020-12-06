using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public class Day04Functions
    {
        public static IList<PassportData> CreatePassportData(IList<string> fileContents)
        {
            string buffer = "";
            List<PassportData> passports = new List<PassportData>();
            foreach (string line in fileContents)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    string[] splitBySpaces = buffer.Split(' ');
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    foreach (var lineData in splitBySpaces.Where(s =>!string.IsNullOrWhiteSpace(s)))
                    {
                        string[] keyValue = lineData.Split(':');
                        data[keyValue[0]] = keyValue[1];
                    }
                    passports.Add(new PassportData(data));
                    buffer = "";
                    continue;
                }
                buffer = buffer.Trim() + " " + line.Trim();

            }

            return passports;
        }

        public class PassportData
        {
            private static readonly string[] _validEyes = new[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            
            public PassportData(Dictionary<string, string> data)
            {
                data.TryGetValue("byr", out _birthYear);
                data.TryGetValue("iyr", out _issueYear);
                data.TryGetValue("eyr", out _expirationYear);
                data.TryGetValue("hgt", out _height);
                data.TryGetValue("hcl", out _hairColor);
                data.TryGetValue("ecl", out _eyeColor);
                data.TryGetValue("pid", out _passportId);
                data.TryGetValue("cid", out _countryId);
            }

            public PassportData(string birthYear, string issueYear, string expirationYear, string height,
                string hairColor, string eyeColor, string passportId, string countryId)
            {
                _birthYear = birthYear;
                _issueYear = issueYear;
                _expirationYear = expirationYear;
                _height = height;
                _hairColor = hairColor;
                _eyeColor = eyeColor;
                _passportId = passportId;
                _countryId = countryId;
            }

            private string _birthYear;
            private string _issueYear;
            private string _expirationYear;
            private string _height;
            private string _hairColor;
            private string _eyeColor;
            private string _passportId;
            private string _countryId;
            
            public bool IsValidIgnoringPassportId()
            {
                return !string.IsNullOrWhiteSpace(_birthYear) &&
                       !string.IsNullOrWhiteSpace(_issueYear) &&
                       !string.IsNullOrWhiteSpace(_expirationYear) &&
                       !string.IsNullOrWhiteSpace(_height) &&
                       !string.IsNullOrWhiteSpace(_hairColor) &&
                       !string.IsNullOrWhiteSpace(_eyeColor) &&
                       !string.IsNullOrWhiteSpace(_passportId);
                // allow null country id per rules

            }

            private bool ValidateIntString(string stringValue, int min, int max)
            {
                int intVal = -1;
                if (int.TryParse(stringValue, out intVal))
                {
                    if (intVal >= min && intVal <= max)
                    {
                        return true;
                    }
                }

                return false;
            }

            private bool ValidateHeight(string heightString)
            {
                if (heightString.EndsWith("cm"))
                {
                    return ValidateIntString(heightString.Remove(heightString.Length - 2, 2), 150, 193);
                }
                else if (heightString.EndsWith("in"))
                {
                    return ValidateIntString(heightString.Remove(heightString.Length - 2, 2), 59, 76);
                }

                return false;
            }

            private bool ValidateHairColor(string hairColorString)
            {
                if (!hairColorString.StartsWith("#"))
                {
                    return false;
                }

                string hairColorNoPound = hairColorString.Remove(0, 1);
                if (hairColorNoPound.Length != 6)
                {
                    return false;
                }
                Regex r = new Regex("^[a-f0-9]*$");
                if (r.Matches(hairColorNoPound)[0].Length != 6)
                {
                    return false;
                }

                return true;
            }

            public bool IsDataValid()
            {
                // there has to be a cleaner way to do this
                if (!IsValidIgnoringPassportId())
                {
                    return false;
                }

                int dummy = -1;
                return ValidateIntString(_birthYear, 1920, 2002) && 
                       ValidateIntString(_issueYear, 2010, 2020) &&
                       ValidateIntString(_expirationYear, 2020, 2030) &&
                       ValidateHeight(_height) &&
                       ValidateHairColor(_hairColor) &&
                       _validEyes.Contains(_eyeColor) &&
                       _passportId.Length == 9 && int.TryParse(_passportId, out dummy);
            }
        }
    }
}