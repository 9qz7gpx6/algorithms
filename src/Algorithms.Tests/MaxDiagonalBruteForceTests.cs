using Algorithms.LargestSum;

namespace Algorithms.Tests
{
    [TestFixture]
    public class MaxDiagonalBruteForceTests
    {
        [Test]
        public void MaxDiagonalSum_MatrixWithPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
            };
            MaxDiagonalBruteForce maxDiagonal = new(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(14, result);
        }

        [Test]
        public void MaxDiagonalSum_MatrixWithNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            new int[] { -1, -2, -3 },
            new int[] { -4, -5, -6 },
            new int[] { -7, -8, -9 }
            };
            MaxDiagonalBruteForce maxDiagonal = new MaxDiagonalBruteForce(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(-6, result);
        }

        [Test]
        public void MaxDiagonalSum_MatrixWithMixedNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            new int[] { 1, -2, 3 },
            new int[] { -4, 5, -6 },
            new int[] { 7, -8, 9 }
            };
            MaxDiagonalBruteForce maxDiagonal = new MaxDiagonalBruteForce(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(14, result);
        }

        [Test]

        public void MaxDiagonalSum_MatrixWithSingleElement_ReturnsElementValue()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            new int[] { 5 }
            };
            Assert.Throws<ArgumentException>(() => new MaxDiagonalBruteForce(matrix),"Invalid matrix");
           
        }

        [Test]
        public void MaxDiagonalSum_MatrixWithZeroes_ReturnsZero()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 }
            };
            MaxDiagonalBruteForce maxDiagonal = new MaxDiagonalBruteForce(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaxDiagonalSum_EmptyMatrix_ReturnsMinValue()
        {
            // Arrange
            int[][] matrix = new int[0][];
            MaxDiagonalBruteForce maxDiagonal = new MaxDiagonalBruteForce(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(int.MinValue, result);
        }

        [Test]
        public void MaxDiagonalSum_MatrixWithSingleRow_ReturnsMinValue()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
        new int[] { 1, 2, 3 }
            };
            MaxDiagonalBruteForce maxDiagonal = new MaxDiagonalBruteForce(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(int.MinValue, result);
        }

        [Test]
        public void MaxDiagonalSum_MatrixWithDifferentRowLengths_ReturnsCorrectSum()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };
            MaxDiagonalBruteForce maxDiagonal = new MaxDiagonalBruteForce(matrix);

            // Act
            int result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.AreEqual(14, result);
        }
    }

}