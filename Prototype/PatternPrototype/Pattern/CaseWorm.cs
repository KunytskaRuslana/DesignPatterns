using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Pattern
{
    class CaseWorm : Prototype
    {
        public CaseWorm(string name)
            : base(name)
        {
        }

        public override Prototype Clone()
        {
            return new CaseWorm(Name);
        }
    }
}
