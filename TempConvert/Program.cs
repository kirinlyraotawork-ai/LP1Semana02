using System;
using System.Collections;
using System.Globalization;
namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question_1, response, response_2; 
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            string temp_1 = Console.ReadLine();

            Console.Write("Unit(C/F): ");
            question_1 = Console.ReadLine();

            float conversion = Convert.ToSingle(temp_1);
            string a_1 = $"{conversion * 1.8 + 32:f2}";
            string a_2 = $"{(conversion-32)/1.8:f2}";
            
            switch (question_1)
            {
                case "C":
                    response = $"{conversion:f2} C = {a_1:f2} F";
                    response_2 = $"Absolute value: {Math.Abs(conversion * 1.8 + 32):f2}";
                    Console.WriteLine(response);
                    Console.WriteLine(response_2);
                    break;
                case "F":
                    response = $"{conversion:f2} F = {a_2:f2} C";
                    response_2 = $"Absolute value: {Math.Abs((conversion-32)/1.8):f2}";
                    Console.WriteLine(response);
                    Console.WriteLine(response_2);
                    break;
                default:
                    response = "Invalid unit.";
                    Console.WriteLine(response);
                    break;
        
        }
    

        
    }
    }
}

