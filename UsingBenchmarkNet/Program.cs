// Install-Package BenchmarkDotNet

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

namespace UsingBenchmarkNet;

[MemoryDiagnoser]
public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Program>();
    }

    [Benchmark]
    public void LoopString()
    {
        var str = "Hello World!";
        for (int i = 0; i < 1000; i++)
        {
            str += i;
        }
    }

    [Benchmark]
    public void LoopStringBuilder()
    {
        var sb = new StringBuilder();
        sb.Append("Hello World!");
        for (int i = 0; i < 1000; i++)
        {
            sb.Append(i);
        }
    }

}