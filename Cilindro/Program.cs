using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string str_a = Console.ReadLine();
            string str_r = Console.ReadLine();
            double a = Convert.ToDouble(str_a);
            double r = Convert.ToDouble(str_r);
            Console.WriteLine($"Volume={MathF.PI*MathF.Pow((float)r,2)*a:f3}");
            Console.WriteLine($"Superfície={2*MathF.PI*r*(r+a):f3}");
        }
    }
}
