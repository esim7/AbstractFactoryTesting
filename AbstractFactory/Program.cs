using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Good afternoon! \n" +
                              "Please enter which phone you need to create \n\n" +
                              "1: Nokiaphone \n" + 
                              "2. Samsungophone");
            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                        new Client().MadePhone(new NokiaFactory());                  
                    break;
                case "2":
                        new Client().MadePhone(new SamsungFactory());
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;

            }
            
        }
    }
}
