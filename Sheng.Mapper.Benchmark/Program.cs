using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBenchmark.Core;

namespace Sheng.Mapper.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Initialize();

            BenchmarkRunner.Run<MapperBenchmarks>();

            Console.ReadKey();
        }
    }
}
