using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NokiaFactory : IAbstractFactory
    {
        public IAbstractAccumulator CreateAccumulator()
        {
            return new Accumulator()
            {
            Manufacturer = "Nokia",
            ComponentType = "Accumulator"
            };
        }

        public IAbstractDisplay CreateDisplay()
        {
            return new Display()
            {
                Manufacturer = "Nokia",
                ComponentType = "Display"
            };
        }
    }
}
