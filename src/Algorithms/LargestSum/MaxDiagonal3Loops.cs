using Algorithms.LargestSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms.LargestSum.MaxDiagonalBruteForce;

namespace Algorithms.LargestSum
{
    public class MaxDiagonal3Loops : ILargestSum
    {

        private int[][] _matrix;

        public MaxDiagonal3Loops(int[][] matrix)
        {
            if (matrix.Length <= 1)
            {
                throw new ArgumentException("Invalid matrix");
            }

            _matrix = matrix;
        }



        public (int sum, MatrixPosition matrixPosition1, MatrixPosition matrixPosition2) MaxDiagonalSum()
        {
            IList<MatrixPosition> list = new List<MatrixPosition>();
            MatrixPosition currentMP;
            MatrixPosition matrixPosition1 = new MatrixPosition(0, 0, 0);
            MatrixPosition matrixPosition2 = new MatrixPosition(0, 0, 0);

            int maxSum = int.MinValue;
            for (int i = 0; i < _matrix.Length; i++)
            {
                for (int j = 0; j < _matrix[i].Length; j++)
                {
                    currentMP = new MatrixPosition(i, j, _matrix[i][j]);
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[k].Line == currentMP.Line || list[k].Column == currentMP.Column) continue;
                        int currentSum = currentMP.Value + list[k].Value;
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            matrixPosition1 = currentMP;
                            matrixPosition2 = list[k];
                        }
                    }
                    list.Add(currentMP);
                }
            }

            return (maxSum, matrixPosition1, matrixPosition2);

        }




    }
}



