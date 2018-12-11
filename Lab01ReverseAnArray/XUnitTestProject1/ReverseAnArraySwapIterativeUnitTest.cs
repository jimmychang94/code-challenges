using System;
using Xunit;
using Lab01ReverseAnArray;

namespace XUnitTestProject1
{
    public class ReverseAnArraySwapIterativeUnitTest
    {
        [Fact]
        public void CanReverseAnOddNumberedArray()
        {
            // Arrange
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[] { 5, 4, 3, 2, 1 };

            // Act
            Program.ReverseAnArrayIterative(array);

            // Assert
            Assert.Equal(array, reversedArray);
        }
        [Fact]
        public void CanReverseAnEvenNumberedArray()
        {
            // Arrange
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] reversedArray = new int[] { 6, 5, 4, 3, 2, 1 };

            // Act
            Program.ReverseAnArrayIterative(array);

            // Assert
            Assert.Equal(array, reversedArray);
        }
    }
}
