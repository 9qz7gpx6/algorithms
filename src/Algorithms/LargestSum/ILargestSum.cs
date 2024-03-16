namespace Algorithms.LargestSum
{
    // Find the largest sum of two numbers in the matrix,
    // where the two numbers are neither in the same row nor in the same column
    //[[1,5],
    // [3,4],
    // [1,2,4]];
    public interface ILargestSum
    {
        (int sum, MatrixPosition matrixPosition1, MatrixPosition matrixPosition2) MaxDiagonalSum();
    }



}
