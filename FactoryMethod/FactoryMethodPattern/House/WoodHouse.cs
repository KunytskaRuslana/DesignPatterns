using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.House
{
    class WoodHouse : OneHouse
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house built");
        }
    }
}
