// Find the largest sum of two numbers in the matrix,
// where the two numbers are neither in the same row nor in the same column
//[[1,5],
// [3,4],
// [1,2,4]];
using Algorithms.LargestSum;
using BenchmarkDotNet.Attributes;
using System.IO;

public class LargestSum
{
    public LargestSum() : this(Console.Out)
    { }
    public LargestSum(TextWriter console)
    {
        this.console = console ?? throw new ArgumentNullException(nameof(console));
        ;
    }

    int[][] matrix = new int[0][];
    private TextWriter console;

    [GlobalSetup]
    public void Setup()
    {
        Random r = new();

        int ilength = r.Next(5, 10);
        matrix = new int[ilength][];
        for (int i = 0; i < ilength; i++)
        {
            int jlenght = r.Next(5, 10);
            matrix[i] = new int[jlenght];
            console?.Write("[");
            for (int j = 0; j < jlenght; j++)
            {
                if (j > 0) console?.Write(",");
                matrix[i][j] = r.Next(-100, 100);
                console?.Write(matrix[i][j].ToString().PadLeft(3, ' '));
            }
            console?.WriteLine("]");
        }
    }


    [Benchmark]
    public int MaxDiagonalSumBruteForce()
    {
        ILargestSum maxDiagonal = new MaxDiagonalBruteForce(matrix);
        return maxDiagonal.MaxDiagonalSum().sum;
    }

    [Benchmark]
    public int MaxDiagonal3Loops()
    {
        ILargestSum maxDiagonal = new MaxDiagonal3Loops(matrix);
        return maxDiagonal.MaxDiagonalSum().sum;
    }
}