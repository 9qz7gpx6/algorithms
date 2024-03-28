using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

[SimpleJob(RuntimeMoniker.Net80)]
[RPlotExporter]
public class Program
{
    public static void Main(string[] args)
    {

        var summary = BenchmarkRunner.Run<LargestSum>();
    }
}