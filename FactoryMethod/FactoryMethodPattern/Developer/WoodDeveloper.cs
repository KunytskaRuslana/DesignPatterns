using FactoryMethodPattern.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Developer
{
    class WoodDeveloper : OneDeveloper
    {
        public WoodDeveloper(string n)
            : base(n)
        { }

        public override OneHouse Create()
        {
            return new WoodHouse();
        }
    }
}
