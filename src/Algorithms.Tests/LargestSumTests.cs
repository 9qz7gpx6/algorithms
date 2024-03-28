using Algorithms.LargestSum;

namespace Algorithms.Tests
{
    [TestFixture]
    public class LargestSumTests
    {
       
        private ILargestSum NewLargestSum(Type iLargestSumConcreteType, int[][] matrix)
        {
            return Activator.CreateInstance(iLargestSumConcreteType) is IObjectFactory instance
                ? instance.New(matrix)
                : throw new Exception("Invalid Type");
        }

        [TestCase(typeof(MaxDiagonalBruteForceBuilder))]
        [TestCase(typeof(MaxDiagonal3LoopsBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToOrderedListBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToArrayBuilder))]
        [TestCase(typeof(MaxDiagonalTwoLargestNumbersBuilder))]
        
        public void MaxDiagonalSum_MatrixWithPositiveNumbers_ReturnsCorrectSum(Type iLargestSumConcreteType)
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
            };
            ILargestSum maxDiagonal = NewLargestSum(iLargestSumConcreteType, matrix);

            // Act
            var result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.That(result.sum, Is.EqualTo(14));
        }


        [TestCase(typeof(MaxDiagonalBruteForceBuilder))]
        [TestCase(typeof(MaxDiagonal3LoopsBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToOrderedListBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToArrayBuilder))]
        [TestCase(typeof(MaxDiagonalTwoLargestNumbersBuilder))]
        public void MaxDiagonalSum_MatrixWithNegativeNumbers_ReturnsCorrectSum(Type iLargestSumConcreteType)
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            [-1, -2, -3],
            [-4, -5, -6],
            [-7, -8, -9]
            };

            ILargestSum maxDiagonal = NewLargestSum(iLargestSumConcreteType, matrix);

            // Act
            var result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.That(result.sum, Is.EqualTo( - 6));
        }

        [TestCase(typeof(MaxDiagonalBruteForceBuilder))]
        [TestCase(typeof(MaxDiagonal3LoopsBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToOrderedListBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToArrayBuilder))]
        [TestCase(typeof(MaxDiagonalTwoLargestNumbersBuilder))]
        public void MaxDiagonalSum_MatrixWithMixedNumbers_ReturnsCorrectSum(Type iLargestSumConcreteType)
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            [1, -2, 3],
            [-4, 5, -6],
            [7, -8, 9]
            };

            ILargestSum maxDiagonal = NewLargestSum(iLargestSumConcreteType, matrix);

            // Act
            var result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.That(result.sum, Is.EqualTo(14));
        }

        [TestCase(typeof(MaxDiagonalBruteForceBuilder))]
        [TestCase(typeof(MaxDiagonal3LoopsBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToOrderedListBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToArrayBuilder))]
        [TestCase(typeof(MaxDiagonalTwoLargestNumbersBuilder))]
        public void MaxDiagonalSum_MatrixWithZeroes_ReturnsZero(Type iLargestSumConcreteType)
        {
            // Arrange
            int[][] matrix = new int[][]
            {
            [0, 0, 0],
            [0, 0, 0],
            [0, 0, 0]
            };
            ILargestSum maxDiagonal = NewLargestSum(iLargestSumConcreteType, matrix);

            // Act
            var result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.That(result.sum, Is.EqualTo(0));
        }


        [TestCase(typeof(MaxDiagonalBruteForceBuilder))]
        [TestCase(typeof(MaxDiagonal3LoopsBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToOrderedListBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToArrayBuilder))]
        [TestCase(typeof(MaxDiagonalTwoLargestNumbersBuilder))]
        public void MaxDiagonalSum_MatrixWithSingleRow_ThrowsArgumentEx(Type iLargestSumConcreteType)
        {
            Assert.Throws<ArgumentException>(() => NewLargestSum(iLargestSumConcreteType, [[1, 2, 3]]), "Invalid matrix");
            Assert.Throws<ArgumentException>(() => NewLargestSum(iLargestSumConcreteType, [[1]]), "Invalid matrix");
            Assert.Throws<ArgumentException>(() => NewLargestSum(iLargestSumConcreteType, []), "Invalid matrix");
        }

        [TestCase(typeof(MaxDiagonalBruteForceBuilder))]
        [TestCase(typeof(MaxDiagonal3LoopsBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToOrderedListBuilder))]
        [TestCase(typeof(MaxDiagonalConvertingMatrixToArrayBuilder))]
        [TestCase(typeof(MaxDiagonalTwoLargestNumbersBuilder))]
        public void MaxDiagonalSum_MatrixWithDifferentRowLengths_ReturnsCorrectSum(Type iLargestSumConcreteType)
        {
            // Arrange
            int[][] matrix =
            [
                [1, 2, 3],
                [4, 5],
                [6, 7, 8, 9],
                
            ];
            ILargestSum maxDiagonal = NewLargestSum(iLargestSumConcreteType, matrix);

            // Act
            var result = maxDiagonal.MaxDiagonalSum();

            // Assert
            Assert.That(result.sum, Is.EqualTo(14));
        }
    }
    

}