using Algorithms.LargestSum;

namespace Algorithms.Tests
{
    public interface IObjectFactory
    {
        ILargestSum New(int[][] matrix);
    }

    public class MaxDiagonalBruteForceBuilder : IObjectFactory
    {
        public ILargestSum New(int[][] matrix)
        {
            return new MaxDiagonalBruteForce(matrix);
        }
    }

    public class MaxDiagonal3LoopsBuilder : IObjectFactory
    {
        public ILargestSum New(int[][] matrix)
        {
            return new MaxDiagonal3Loops(matrix);
        }
    }


    public class MaxDiagonalConvertingMatrixToOrderedListBuilder : IObjectFactory
    {
        public ILargestSum New(int[][] matrix)
        {
            return new MaxDiagonalConvertingMatrixToOrderedList(matrix);
        }
    }

    public class MaxDiagonalConvertingMatrixToArrayBuilder : IObjectFactory
    {
        public ILargestSum New(int[][] matrix)
        {
            return new MaxDiagonalConvertingMatrixToArray(matrix);
        }
    }

    public class MaxDiagonalTwoLargestNumbersBuilder : IObjectFactory
    {
        public ILargestSum New(int[][] matrix)
        {
            return new MaxDiagonalTwoLargestNumbers(matrix);
        }
    }

    
}