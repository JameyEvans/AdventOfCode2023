// See https://aka.ms/new-console-template for more information

using AdventOfCode2023.Day1;
using AdventOfCode2023.Day2;
using AdventOfCode2023.Day3;

//int calibrationSum = Trebuchet.sumCalibrationCodes(true);
//Console.WriteLine("Day 1: trebuchet calibration codes = " + calibrationSum);


int cubeSum = CubeConundrum.sumIds();
Console.WriteLine("Day 2: cube conundrum sum of ids = " + cubeSum);

int powerSum = CubeConundrum.sumMinimumPower();
Console.WriteLine("Day 2: cube conundrum sum of minimum power = " + powerSum);

GearRatio gearRatio = new GearRatio();
gearRatio.PopulateMatrix();
int gearSum = gearRatio.SumPartNumbers();
Console.WriteLine("Day 3: gear ratio sum of part numbers = " + gearSum);
