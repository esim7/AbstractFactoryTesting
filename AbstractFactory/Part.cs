using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Part
    {
        public string Manufacturer { get; set; }
        public string ComponentType { get; set; }
    }
}
