using System;
using Xunit;

namespace Sofe
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



            int[,] adjacencyMatrixMed = {
                {0,3,4,3,4},
                {3,0,4,3,4},
                {4,4,0,3,4},
                {3,3,3,0,4},
                {4,4,4,4,0}};
            int resultMed = Traveler.MinimizeTravel(adjacencyMatrixMed);
            Assert.Equal(17, resultMed);



			int[,] adjacencyMatrixHard = {
				{0, 57, 45, 59, 42, 53, 58, 59, 47, 57},
                {58, 0, 56, 42, 49, 41, 43, 43, 57, 56},
                {42, 43, 0, 59, 53, 45, 50, 59, 50, 55},
                {50, 52, 58, 0, 47, 48, 55, 54, 58, 52},
                {41, 51, 51, 51, 0, 40, 41, 56, 52, 40},
                {56, 42, 54, 57, 40, 0, 58, 40, 40, 49},
                {50, 43, 59, 48, 43, 43, 0, 42, 48, 54},
                {59, 51, 48, 47, 54, 42, 50, 0, 42, 46},
                {45, 50, 43, 58, 57, 53, 49, 42, 0, 47},
                {41, 53, 51, 59, 46, 47, 45, 44, 55, 0}};
			int resultHard = Traveler.MinimizeTravel(adjacencyMatrixHard);
			Assert.Equal(427, resultHard);



			int[,] adjacencyMatrixHarder = {
				{0, 43, 58, 40, 40, 59, 59, 51, 45, 52, 50, 44},
                {51, 0, 49, 46, 56, 53, 51, 42, 47, 59, 42, 47},
                {42, 53, 0, 59, 59, 54, 46, 59, 49, 58, 47, 53},
                {51, 45, 54, 0, 42, 52, 50, 44, 41, 48, 56, 44},
                {57, 48, 42, 47, 0, 46, 45, 50, 52, 56, 56, 52},
                {55, 56, 46, 40, 59, 0, 45, 44, 45, 43, 52, 56},
                {58, 57, 40, 42, 51, 59, 0, 51, 43, 57, 54, 51},
                {58, 55, 50, 57, 46, 40, 53, 0, 58, 45, 50, 56},
                {59, 49, 58, 55, 51, 50, 59, 56, 0, 42, 52, 52},
                {41, 50, 45, 46, 43, 54, 51, 41, 53, 0, 58, 57},
                {44, 58, 50, 50, 42, 58, 44, 52, 45, 46, 0, 45},
                {41, 57, 51, 44, 56, 48, 41, 43, 40, 52, 58, 0}};
			int resultHarder = Traveler.MinimizeTravel(adjacencyMatrixHarder);
			Assert.Equal(502, resultHarder);
        }
    }
}
