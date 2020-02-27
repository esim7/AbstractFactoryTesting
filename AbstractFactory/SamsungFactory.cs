using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SamsungFactory : IAbstractFactory
    {
        public IAbstractAccumulator CreateAccumulator()
        {
            return new Accumulator()
            {
                Manufacturer = "Samsung",
                ComponentType = "Accumulator"
            };
        }

        public IAbstractDisplay CreateDisplay()
        {
            return new Display()
            {
                Manufacturer = "Samsung",
                ComponentType = "Display"
            };
        }
    }
}
