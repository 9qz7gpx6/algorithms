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
}