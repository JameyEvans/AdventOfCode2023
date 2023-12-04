using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Day2
{
    public class Game
    {
        public int Id { get; set; } 
        public List<GameSample> Samples { get; set; } = new List<GameSample>();

        public Game(string line)
        {
            // line is in the format: Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
            string[] parts = line.Split(':');
            Id = Convert.ToInt32(parts[0].Replace("Game ", "").Trim());
            string[] samples = parts[1].Split(';');
            foreach (string sample in samples)
            {
                GameSample gs = new GameSample();
                string[] cubes = sample.Split(',');
                foreach (string cube in cubes)
                {
                    string[] cubeParts = cube.Trim().Split(' ');
                    int numCubes = Convert.ToInt32(cubeParts[0]);
                    string color = cubeParts[1];
                    switch (color)
                    {
                        case "blue":
                            gs.BlueCubes = numCubes;
                            break;
                        case "red":
                            gs.RedCubes = numCubes;
                            break;
                        case "green":
                            gs.GreenCubes = numCubes;
                            break;
                    }
                }
                Samples.Add(gs);
            }
        }

        public int GetMinimumPower()
        {
            GameSample minSample = new GameSample();

            foreach (var sample in Samples)
            {
                if (sample.RedCubes > minSample.RedCubes)
                {
                    minSample.RedCubes = sample.RedCubes;
                }

                if (sample.BlueCubes > minSample.BlueCubes)
                {
                    minSample.BlueCubes = sample.BlueCubes;
                }

                if (sample.GreenCubes > minSample.GreenCubes)
                {
                    minSample.GreenCubes = sample.GreenCubes;
                }
            }

            return minSample.RedCubes * minSample.BlueCubes * minSample.GreenCubes;
        }
    }
}
