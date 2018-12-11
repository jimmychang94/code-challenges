using Lab02DeleteDuplicatesInAnArray;
using System;
using Xunit;

namespace DeleteDuplicatesUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void BaseCase()
        {
            // Arrange
            int[] duplicates = new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 7, 7, 5, 6, 8, 8, 9, 10 };
            int[] result = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Act
            int[] noDuplicates = Program.DeleteDuplicates(duplicates);
        }

        [Fact]
        public void NoDuplicates()
        {
            // Arrange
            int[] duplicates = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] result = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Act
            int[] noDuplicates = Program.DeleteDuplicates(duplicates);
        }

        [Fact]
        public void OnlyOneValue()
        {
            // Arrange
            int[] duplicates = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            int[] result = new int[] { 1 };

            // Act
            int[] noDuplicates = Program.DeleteDuplicates(duplicates);
        }
    }
}
