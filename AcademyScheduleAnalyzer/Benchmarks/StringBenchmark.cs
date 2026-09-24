using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benchmarks;
[MemoryDiagnoser]
public class StringBenchmark
{
    [Params(100, 1000, 10000, 100000)]
    public int Iterations;

    [Benchmark]
    public void StringConcatenation()
    {
        string text = "";

        for (int i = 0; i < Iterations; i++)
        {
            text += "Hello";
        }
    }
    
    [Benchmark]
    public void StringBuilderConcatenation()
    {
        StringBuilder text = new StringBuilder();

        for (int i = 0; i < Iterations; i++)
        {
            text.Append("Hello");
        }
    }
}