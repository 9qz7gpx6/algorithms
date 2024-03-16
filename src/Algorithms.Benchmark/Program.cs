using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

[SimpleJob(RuntimeMoniker.Net80)]
[RPlotExporter]
public class Program
{
    public static void Main(string[] args)
    {
        using (var file = File.CreateText($"{DateTime.Now.Ticks}.txt"))
        {
            LargestSum largestSum = new LargestSum(file);
            largestSum.Setup();
            file.Write("Largest: ");
            file.Write(largestSum.MaxDiagonalSumBruteForce());
        }

        var summary = BenchmarkRunner.Run<LargestSum>();
    }
}