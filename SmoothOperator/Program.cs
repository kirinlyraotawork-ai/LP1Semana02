using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
    
            Console.WriteLine("PLZ gimme a num inteiro");
            string str_1 = Console.ReadLine();
            sbyte n = Convert.ToSByte(str_1);
            Console.WriteLine($"incremento de n = {n+1}, e o decremento é {n-1}");
        }
    }
}
