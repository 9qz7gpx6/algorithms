using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LargestSum
{
    // O(n^4)
    public class MaxDiagonalBruteForce
    {
        private int[][] matrix;

        public MaxDiagonalBruteForce(int[][] matrix)
        {
            if (matrix.Length <= 1)
            {
                throw new ArgumentException("Invalid matrix");
            }
            this.matrix = matrix;
        }


        public int MaxDiagonalSum()
        {
            int maxSum = int.MinValue;
            int n = matrix.Length;
            int m = matrix[0].Length;
            int f1, f2;
            int nextLine = 0;
            int tracker = 0;
            for (int i = 0; i < n; i++)
            {
                nextLine += i;

                for (int j = 0; j < m; j++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        for (int y = 0; y < m; y++)
                        {
                            if ((i != x || j != y) && !(i == x || j == y))
                            {
                                try
                                {
                                    //if (i >= matrix.Length || j >= matrix[i].Length) continue;
                                    //if (x >= matrix.Length && y >= matrix[x].Length) continue;

                                    f1 = matrix[i][j];
                                    tracker = 1;
                                    f2 = matrix[x][y];
                                    maxSum = Math.Max(maxSum, f1 + f2);
                                }
                                catch (Exception ex)
                                {
                                    ex.Data.Add("i", i);
                                    ex.Data.Add("j", j);
                                    ex.Data.Add("x", x);
                                    ex.Data.Add("y", y);
                                    ex.Data.Add("tracker", tracker);
                                    ex.Data.Add("matrix", matrix);
                                    throw;
                                }
                            }
                        }
                    }
                }
            }

            return maxSum;
        }
    }


}
