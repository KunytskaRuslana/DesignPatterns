using FactoryMethodPattern.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Developer
{
    abstract class OneDeveloper
    {
        public string Name { get; set; }

        public OneDeveloper(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public OneHouse Create();
    }
}
