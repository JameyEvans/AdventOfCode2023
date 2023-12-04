using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode2023.Day1
{
    public static class Trebuchet
    {

        public static int GetCalibrationCode(string txt)
        {
            string? first = null;
            string? last = null;
            foreach (char c in txt)
            {
                int result = 0;
                try
                {
                    int val = Convert.ToInt32(c.ToString());
                    if (first == null)
                    {
                        first = c.ToString();
                        last = c.ToString();
                    }
                    else
                    {
                        last = c.ToString();
                    }

                }
                catch (Exception ex)
                {
                    continue;
                }
               
            }
            return Convert.ToInt32(first + last);
        }
        public static string ReplaceWrittenNumbers(string txt)
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>()
            {
                {"one", "one1one"},
                {"two", "two2two" },
                {"three", "three3three" },
                {"four", "four4four" },
                {"five", "five5five" },
                {"six", "six6six" },
                {"seven", "seven7seven" },
                {"eight", "eight8eight" },
                {"nine", "nine9nine" }
            };

            string result = "";
            for (int i = 0; i < txt.Length; i++)
            {
                result += txt[i];
                foreach (KeyValuePair<string, string> number in numbers)
                {
                    result = result.Replace(number.Key, number.Value);
                }

            }

            

            return result;
        }

        public static string ReplaceWrittenNumbers2(string txt)
        {
            
            string result = txt.ToLower().Replace("one", "one1one")
                .Replace("two", "two2two")
                .Replace("three", "three3three")
                .Replace("four", "four4four")
                .Replace("five", "five5five")
                .Replace("six", "six6six")
                .Replace("seven", "seven7seven")
                .Replace("eight", "eight8eight")
                .Replace("nine", "nine9nine");

            
            return result;
        }

        public static int GetCalibrationCodeWithLetters(string txt)
        {
            txt = ReplaceWrittenNumbers2(txt);
            return GetCalibrationCode(txt);           

        }

        public static int sumCalibrationCodes(bool convertNumbers = false)
        {
            string fileLoc = @"Day1\CalibrationDocument.txt";
            IEnumerable<string> lines = File.ReadLines(fileLoc);
            int result = 0;
            foreach (string line in lines)
            {
                int calibrationCode = 0;
                if (convertNumbers)
                {
                    calibrationCode = GetCalibrationCodeWithLetters(line);
                }
                else
                {
                    calibrationCode = GetCalibrationCode(line);
                }
                

                Console.WriteLine($"{line}: {calibrationCode}");
                result += calibrationCode;

            }
            return result;

        }
    }
}
