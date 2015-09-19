using PatternPrototype.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = null;
            Prototype bud = null;

            prototype = new Worm("Worm");
            bud = prototype.Clone();
            Console.WriteLine(bud.Name);

            prototype = new CaseWorm("CaseWorm");
            bud = prototype.Clone();
            Console.WriteLine(bud.Name);

            prototype = new Butterfly("Butterfly");
            bud = prototype.Clone();
            Console.WriteLine(bud.Name);

            Console.ReadKey();
        }
    }
}
