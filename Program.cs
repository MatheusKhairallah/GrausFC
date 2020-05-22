using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converta 0°F para °C");
            Console.ReadKey();
            double FC=0 - 32 / 1.8;
            Console.WriteLine($"°C={FC}");
        }
    }
}
