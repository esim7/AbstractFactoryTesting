using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Accumulator : Part, IAbstractAccumulator
    {
        public string ShowMyInfo()
        {
            return $"I am {this.ComponentType} manufactured by {this.Manufacturer} company";
        }
    }
}
