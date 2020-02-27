using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public void MadePhone(IAbstractFactory factory)
        {
            var display = factory.CreateDisplay();
            var battary = factory.CreateAccumulator();
            Console.WriteLine(display.ShowMyInfo());
            Console.WriteLine(display.GetMyBattaryType(battary));
        }
    }
}
