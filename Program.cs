using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um valor que corresponderá em °F e será convertido para °C");
            Console.Write("°F= ");
            double F=Convert.ToDouble(Console.ReadLine());
            double FC=F - 32;
            double FC2=FC / 1.8;
            
            Console.Clear();
            Console.WriteLine($"{F}°F em °C é={FC2}");
        }
    }
}
