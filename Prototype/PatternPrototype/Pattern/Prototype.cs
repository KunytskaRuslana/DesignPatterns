using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Pattern
{
    abstract class Prototype
    {
        public string Name { get; private set; }

        public Prototype(string name)
        {
            this.Name = name;
        }

        public abstract Prototype Clone();
    }
}
