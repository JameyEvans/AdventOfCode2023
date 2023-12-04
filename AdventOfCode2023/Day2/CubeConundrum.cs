
namespace AdventOfCode2023.Day2;

public static class CubeConundrum
{
    /// <summary>
    /// Validate the game by checking the number of cubes and the line
    /// </summary>
    /// <param name="numRedCubes"></param>
    /// <param name="numGreenCubes"></param>
    /// <param name="numBlueCubes"></param>
    /// <param name="line"></param>
    /// <returns></returns>
    public static bool ValidateGame(int numRedCubes, int numGreenCubes, int numBlueCubes, Game game)
    {
        
        int totalCubes = numRedCubes + numGreenCubes + numBlueCubes;
        bool result = true;
        foreach (GameSample sample in game.Samples)
        {
            int sampleTotal = sample.BlueCubes + sample.GreenCubes + sample.RedCubes;
            if (sampleTotal > totalCubes)
            {
                result = false;
                break;
            }
            if (sample.BlueCubes > numBlueCubes)
            {
                result = false;
                break;
            }
            if (sample.RedCubes > numRedCubes)
            {
                result = false;
                break;
            }
            if (sample.GreenCubes > numGreenCubes)
            {
                result = false;
                break;
            }
        }
        return result;
    }


    public static int sumIds(string fileLoc = @"Day2\Input.txt")
    {         
        IEnumerable<string> lines = File.ReadLines(fileLoc);
        int result = 0;
        foreach (string line in lines)
        {
            Game game = new Game(line);
            if (ValidateGame(12, 13, 14, game))
            {
                result += game.Id;
            }                

        }
        return result;

    }

    public static int sumMinimumPower(string fileLoc = @"Day2\Input.txt")
    {
        IEnumerable<string> lines = File.ReadLines(fileLoc);
        int result = 0;
        foreach (string line in lines)
        {
            Game game = new Game(line);
            result += game.GetMinimumPower();

        }
        return result;

    }
}
