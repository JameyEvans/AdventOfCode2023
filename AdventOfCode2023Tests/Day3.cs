using AdventOfCode2023.Day3;

namespace AdventOfCode2023Tests
{
    public class Day3
    {
        [Fact]
        public void GearRatio_GenerateMatrix()
        {
            GearRatio gearRatio = new GearRatio();
            gearRatio.PopulateMatrix();
            Assert.True(gearRatio.Matrix.Count > 0);
        }

        [Fact]
        public void GearRatio_SumPartNumbers_ReturnsCorrectValue()
        {
            GearRatio gearRatio = new GearRatio();
            gearRatio.PopulateMatrix(@"Day3TestInput.txt");
            int result = gearRatio.SumPartNumbers();
            Assert.Equal(4361, result);
        }

        
    }
}
