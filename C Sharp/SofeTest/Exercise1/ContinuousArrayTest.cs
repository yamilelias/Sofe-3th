using System;
using Xunit;
using Sofe.Exercise3;

namespace Sofe.Exercise1
{
    public class ContinuousArrayTest 
    {

        [Fact]
        public void TestAlmostIncreasingSequenceOne() 
        {
            int[] array = {-30, -19, 123, -17, -5, 1, 2, 3, 12, 43, 45};
            bool isSequence = ContinuousArray.IsAlmostIncreasingSequence(array);
            Assert.Equal(true, isSequence);

        }

        [Fact]
        public void TestAlmostIncreasingSequenceTwo() 
        {
            int[] array = {1, 2, 3, 6, 3, 7};
            bool isSequence = ContinuousArray.IsAlmostIncreasingSequence(array);
            Assert.Equal(true, isSequence);
        }

        [Fact]
        public void TestAlmostIncreasingSequenceThree() 
        {
            int[] array = {10, 1, 2, 3, 4, 5, 6, 1};
            bool isSequence = ContinuousArray.IsAlmostIncreasingSequence(array);
            Assert.Equal(false, isSequence);
        }

        [Fact]
        public void TestAlmostIncreasingSequenceFour()
        {
            int[] array = { -127, -64, -50, -10, 2, 4, 5, 6, 7, 8, 12, 16, 40 };
            bool isSequence = ContinuousArray.IsAlmostIncreasingSequence(array);
            Assert.Equal(true, isSequence);
        }
    }
}
