using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LargestSum
{
    // O(2n^2)
    public partial class MaxDiagonalTwoLargestNumbers : ILargestSum
    {
        private int[][] matrix;

        public MaxDiagonalTwoLargestNumbers(int[][] matrix)
        {
            if (matrix.Length <= 1)
            {
                throw new ArgumentException("Invalid matrix");
            }
            this.matrix = matrix;
        }

        public (int sum, MatrixPosition matrixPosition1, MatrixPosition matrixPosition2) MaxDiagonalSum()
        {

            MatrixPosition largestNumber = new(0, 0, int.MinValue);
            MatrixPosition secondLargest = new(0, 0, int.MinValue);

            largestNumber = GetLargestNumber(null,null);
            secondLargest = GetLargestNumber(largestNumber.Line, largestNumber.Column);
            return (largestNumber.Value + secondLargest.Value, largestNumber, secondLargest);
        }

        private MatrixPosition GetLargestNumber( int? lineRestriction, int? columnRestriction)
        {
            int[] lineF1;
            MatrixPosition largestNumber = new(0, 0, int.MinValue);
            for (int l1 = 0; l1 < matrix.Length; l1++)
            {
                if (l1 == lineRestriction) continue;
                lineF1 = matrix[l1];
                for (int c1 = 0; c1 < lineF1.Length; c1++)
                {
                    if(c1 == columnRestriction) continue;

                    if (lineF1[c1] > largestNumber.Value)
                    {
                        largestNumber.Line = l1;
                        largestNumber.Column = c1;
                        largestNumber.Value = lineF1[c1];
                    }
                }
            }

            return largestNumber;
        }
    }
}
