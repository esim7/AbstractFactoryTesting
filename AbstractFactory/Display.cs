using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Display : Part, IAbstractDisplay
    {
        public string GetMyBattaryType(IAbstractAccumulator accumulator)
        {
            string result = accumulator.ShowMyInfo();
            return result;
        }

        public string ShowMyInfo()
        {
            return $"i am {this.ComponentType} maded {this.Manufacturer} corporation";
        }
    }
}
