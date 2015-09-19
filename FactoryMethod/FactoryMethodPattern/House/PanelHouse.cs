using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.House
{
    class PanelHouse : OneHouse
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house built");
        }
    }
}
