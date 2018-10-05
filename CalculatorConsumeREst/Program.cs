using System;
using ModelLibrary;

namespace CalculatorConsumeREst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data addingData = new Data
            {
                b = 4,
                a = 3
            };
            string result = DataAdder.AsyncAdd (addingData).Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
