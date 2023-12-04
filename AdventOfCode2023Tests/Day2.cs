using AdventOfCode2023.Day2;

namespace AdventOfCode2023Tests
{
    public class Day2
    {
        [Fact]
        public void Day2_CubeConundrum_SumIds_ReturnsCorrectValue()
        {
            int result = CubeConundrum.sumIds(@"Day2TestInput.txt");
            Assert.Equal(8, result);
        }

        [Fact]
        public void Day2_Game_GetMinimumPower_ReturnsCorrectValue()
        {
            List<Tuple<string, int>> lines = new List<Tuple<string, int>>()
            {
                new Tuple<string, int>("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 48),
                new Tuple<string,int>("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 12),
                new Tuple<string,int>("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 1560),
                new Tuple<string,int>("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 630),
                new Tuple<string, int>("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 36)
            };

            foreach (var line in lines)
            {
                Game game = new Game(line.Item1);
                Assert.Equal(line.Item2, game.GetMinimumPower());
            }
        }

        [Fact]
        public void Day2_CubeConundrum_SumMinimumPower_ReturnsCorrectValue()
        {
            int result = CubeConundrum.sumMinimumPower(@"Day2TestInput.txt");            
            Assert.Equal(2286, result);
            
        }
    }
}
