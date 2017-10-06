using System;
using Xunit;

namespace Sofe.Extra
{
    
    public class TravelerTest
    {
        [Fact]
        public void MinimizeTravelTest()
        {
            int[,] adjacencyMatrix = {
                {0,1,2},
                {1,0,1},
                {2,1,0}};
			int result = Traveler.MinimizeTravel(adjacencyMatrix);
			Assert.Equal(4, result);
        }

        [Fact]
        public void TestMinimizeTravelMedium()
        {
            int[,] adjacencyMatrixMed = {
                {0,3,4,3,4},
                {3,0,4,3,4},
                {4,4,0,3,4},
                {3,3,3,0,4},
                {4,4,4,4,0}};
            int resultMed = Traveler.MinimizeTravel(adjacencyMatrixMed);
            Assert.Equal(17, resultMed);
        }

        [Fact]
        public void TestMinimizeTravelHard()
        {
            int[,] adjacencyMatrixHard = {
				{0, 54, 41, 41, 43, 40, 55, 50, 54, 56},
                {54, 0, 42, 47, 50, 53, 57, 54, 54, 46},
                {41, 42, 0, 47, 53, 41, 56, 46, 57, 58},
                {41, 47, 47, 0, 55, 45, 56, 57, 53, 49},
                {43, 50, 53, 55, 0, 59, 49, 58, 46, 40},
                {40, 53, 41, 45, 59, 0, 40, 59, 51, 53},
                {55, 57, 56, 56, 49, 40, 0, 48, 51, 48},
                {50, 54, 46, 57, 58, 59, 48, 0, 51, 52},
                {54, 54, 57, 53, 46, 51, 51, 51, 0, 51},
                {56, 46, 58, 49, 40, 53, 48, 52, 51, 0}};
			int resultHard = Traveler.MinimizeTravel(adjacencyMatrixHard);
			Assert.Equal(440, resultHard);
        }

        [Fact]
        public void TestMinimizeTravelCrazy()
        {
            int[,] adjacencyMatrixHarder = {
                {0, 42, 45, 48, 46, 58, 52, 55, 52, 51, 41},
                {42, 0, 51, 42, 40, 49, 52, 50, 56, 59, 52},
                {45, 51, 0, 50, 41, 59, 58, 54, 42, 56, 54},
                {48, 42, 50, 0, 53, 40, 48, 43, 44, 48, 43},
                {46, 40, 41, 53, 0, 55, 47, 52, 59, 58, 46},
                {58, 49, 59, 40, 55, 0, 50, 47, 47, 57, 49},
                {52, 52, 58, 48, 47, 50, 0, 44, 51, 45, 52},
                {55, 50, 54, 43, 52, 47, 44, 0, 44, 49, 48},
                {52, 56, 42, 44, 59, 47, 51, 44, 0, 50, 58},
                {51, 59, 56, 48, 58, 57, 45, 49, 50, 0, 54},
                {41, 52, 54, 43, 46, 49, 52, 48, 58, 54, 0}};
			int resultHarder = Traveler.MinimizeTravel(adjacencyMatrixHarder);
			Assert.Equal(475, resultHarder);
        }
    }
}
