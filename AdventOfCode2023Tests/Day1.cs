using AdventOfCode2023.Day1;

namespace AdventOfCode2023Tests
{
    public class Day1
    {
        [Fact]
        public void trebuchet_GetCalibrationCodes_ReturnValid()
        {
            Dictionary<string, int> calText = new Dictionary<string, int>()
            {
                {"1abc2", 12 },
                {"pqr3stu8vwx", 38 },
                {"a1b2c3d4e5f", 15 },
                {"treb7uchet", 77 }
            };

            foreach (var cal in calText)
            {
                Assert.True(Trebuchet.GetCalibrationCode(cal.Key) == cal.Value);
                Assert.True(Trebuchet.GetCalibrationCodeWithLetters(cal.Key) == cal.Value);
            }

        }

        [Fact]
        public void trebuchet_GetCalibrationCodesWithLetters_ReturnValid()
        {
            Dictionary<string, int> calText = new Dictionary<string, int>()
            {
                {"two1nine", 29 },
                {"eighttwothree", 83 },
                {"abcone2threexyz", 13 },
                {"xtwone3four", 24 },
                {"7pqrstsixteen", 76 }
            };

            foreach (var cal in calText)
            {
                Assert.True(Trebuchet.GetCalibrationCodeWithLetters(cal.Key) == cal.Value);
            }

        }

        [Fact]
        public void trebuchet_sumCalibrationCodes_ReturnValid()
        {
            string[] calText = new string[]
            {
               "two1nine",
                "eightwothree",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "7pqrstsixteen"
            };

            int sum = 0;

            foreach (var cal in calText)
            {
                Console.WriteLine($"{cal} = {Trebuchet.GetCalibrationCodeWithLetters(cal)}");
                sum += Trebuchet.GetCalibrationCodeWithLetters(cal);
                Console.WriteLine($"sum = {sum}");

            }

            Assert.True(sum == 281);
        }
    }
}