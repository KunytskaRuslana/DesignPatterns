using FactoryMethodPattern.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Developer
{
    class PanelDeveloper : OneDeveloper
    {
        public PanelDeveloper(string n)
            : base(n)
        { }

        public override OneHouse Create()
        {
            return new PanelHouse();
        }
    }
}
