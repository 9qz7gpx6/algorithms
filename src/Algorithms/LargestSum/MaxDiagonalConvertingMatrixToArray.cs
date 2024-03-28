using Algorithms.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms.LargestSum.MaxDiagonalBruteForce;

namespace Algorithms.LargestSum
{
    public class MaxDiagonalConvertingMatrixToArray : ILargestSum
    {

        private int[][] _matrix;

        public MaxDiagonalConvertingMatrixToArray(int[][] matrix)
        {
            if (matrix.Length <= 1)
            {
                throw new ArgumentException("Invalid matrix");
            }

            _matrix = matrix;
        }

        public (int sum, MatrixPosition matrixPosition1, MatrixPosition matrixPosition2) MaxDiagonalSum()
        {
            List<MatrixPosition> list = [];

            for (int i = 0; i < _matrix.Length; i++)
            {
                for (int j = 0; j < _matrix[i].Length; j++)
                {
                    list.Add(new MatrixPosition(i, j, _matrix[i][j]));
                }
            }
            list.Sort(MPComparison);
            MatrixPosition f1, f2;
            f1 = list[0];
            f2 = NextAfter(list,f1,0) ?? throw new Exception("Element not found");

            return (f1.Value+f2.Value, f1, f2);

        }

        private int MPComparison(MatrixPosition x, MatrixPosition y)
        {
            if (x.Value == y.Value) return 0;
            if (x.Value > y.Value) return -1;
            return 1;
        }

        private MatrixPosition? NextAfter(List<MatrixPosition> list, MatrixPosition f1, int position)
        {
            int next = position;
            do next++; while (next < list.Count && !list[next].IsDiagonalTo(f1));
            return list[next];
        }
    }
}



