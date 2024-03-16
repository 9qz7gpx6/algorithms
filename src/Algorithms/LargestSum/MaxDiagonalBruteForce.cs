using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LargestSum
{
    // O(n^4)
    public partial class MaxDiagonalBruteForce : ILargestSum
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


        public (int sum, MatrixPosition matrixPosition1, MatrixPosition matrixPosition2) MaxDiagonalSum()
        {
            int maxSum = int.MinValue;
            MatrixPosition matrixPosition1 = new(0, 0, 0);
            MatrixPosition matrixPosition2 = new(0, 0, 0);

            int m = matrix[0].Length;
            int f1, f2;
            int[] lineF1, lineF2;
            int currentSum = 0;
            for (int l1 = 0; l1 < matrix.Length; l1++)
            {
                lineF1 = matrix[l1];

                for (int l2 = 0; l2 < matrix.Length; l2++)
                {
                    if (l1 == l2)
                    {
#if DEBUG
                        Console.WriteLine(string.Format("Skip line: {0}", l2));
#endif
                        continue;
                    }
                    lineF2 = matrix[l2];

                    for (int c1 = 0; c1 < lineF1.Length; c1++)
                    {
                        f1 = lineF1[c1];

                        for (int c2 = 0; c2 < lineF2.Length && c1 != c2; c2++)
                        {
                            if (c1 == c2)
                            {
#if DEBUG
                                Console.WriteLine(string.Format("Skip column: {0}", c2));
#endif
                                continue;
                            }

                            f2 = lineF2[c2];
                            currentSum = f1 + f2;
                            if (currentSum > maxSum)
                            {
                                maxSum = currentSum;
                                matrixPosition1.Line = l1;
                                matrixPosition1.Column = c1;
                                matrixPosition1.Value = f1;

                                matrixPosition2.Line = l2;
                                matrixPosition2.Column = c2;
                                matrixPosition2.Value = f2;
                            }
#if DEBUG
                            Console.WriteLine(string.Format("f1:({0},{1}) = {2}", l1, c1, f1));
                            Console.WriteLine(string.Format("f1:({0},{1}) = {2} ", l1, c1, f1));
                            Console.WriteLine(string.Format("sm:({0}+{1}) = {2}", f1, f2, currentSum));
#endif
                        }
                    }

                }
            }
            return (maxSum, matrixPosition1, matrixPosition2);
        }
    }
}
