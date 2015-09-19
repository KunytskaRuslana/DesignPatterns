using Builder.BuilderPattern;
using Builder.BuilderPattern.Builder;
using Builder.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            OneBuilder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.Construct();

            OneHouse house = builder.GetResult();

            // Delay.
            Console.ReadKey();
        }
    }
}
