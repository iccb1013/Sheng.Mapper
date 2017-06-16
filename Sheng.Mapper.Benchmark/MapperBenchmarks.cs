using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticAutoMapper = AutoMapper.Mapper;
using SimpleBenchmark.Core;

namespace Sheng.Mapper.Benchmark
{
    public class MapperBenchmarks
    {
        const int iteration = 1000000;

        private readonly A source;

        public MapperBenchmarks()
        {
            StaticAutoMapper.Initialize(config =>
            {
                config.CreateMap<A, B>();
            });

            source = new A()
            {
                Name = "张三",
                Age = 10,
                Class = "一班",
                CObject = new SubC()
                {
                    Message = "Hello"
                },
                P1 = "1",
                P2 = "2",
                P3 = "3",
                P4 = "4",
                P5 = "5",
                P6 = "6"
            };
        }

        [Benchmark("Sheng.Mapper", iteration)]
        public void ShengMapperBenchmark()
        {
            var target = new B();
            ShengMapper.SetValues(source, target);
        }

        [Benchmark("AutoMapper 6.1.0", iteration)]
        public void AutoMapperBenchmark()
        {
            var target = StaticAutoMapper.Map<B>(source);
        }
    }

    public class A
    {
        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public string Class
        {
            get; set;
        }

        public SubC CObject
        {
            get; set;
        }

        public string P1
        {
            get; set;
        }

        public string P2
        {
            get; set;
        }

        public string P3
        {
            get; set;
        }

        public string P4
        {
            get; set;
        }

        public string P5
        {
            get; set;
        }

        public string P6
        {
            get; set;
        }

    }

    public class B
    {
        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public C CObject
        {
            get; set;
        }

        public string P1
        {
            get; set;
        }

        public string P2
        {
            get; set;
        }

        public string P3
        {
            get; set;
        }

        public string P4
        {
            get; set;
        }

        public string P5
        {
            get; set;
        }

        public string P6
        {
            get; set;
        }
    }

    public class C
    {
        public string Message
        {
            get; set;
        }
    }

    public class SubC : C
    {

    }
}
