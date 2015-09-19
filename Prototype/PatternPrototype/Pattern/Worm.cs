using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Pattern
{
    class Worm : Prototype
    {
        public Worm(string name)
            : base(name)
        {
        }

        public override Prototype Clone()
        {
            return new Worm(Name);
        }
    }
}
