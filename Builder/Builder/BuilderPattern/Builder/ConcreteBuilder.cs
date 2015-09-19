﻿using Builder.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderPattern.Builder
{
    class ConcreteBuilder : OneBuilder
    {
        OneHouse house = new OneHouse();

        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildStorey()
        {
            house.Add(new Storey());
        }

        public override void BuildRoof()
        {
            house.Add(new Roof());
        }

        public override OneHouse GetResult()
        {
            return house;
        }
    }
}
