using System;
using System.Collections;
using System.Globalization;
namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response; 
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature:");
            string temp_1 = Console.ReadLine();
            Console.Write("Unit(C/F):");
            question = Console.ReadLine();
            switch (question)
            {
                case "C":
                    response = "...C = ...F";
                    break;
                case "F":
                    response = " ...F = ...C";
                    break;
                default:
                    response = "I didn't understand you. Can you please repeat";
                    break;
            
        }
        Console.WriteLine(response);
    }
    }
}

