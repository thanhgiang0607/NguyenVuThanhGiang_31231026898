using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVuThanhGiang_31231026898
{
    internal class Session_03
    {
        public static void Main(string[] args)
        {
            Exercise_01();
            Exercise_02();
            Exercise_03();
        }
        public static void Exercise_01()
        {
            Console.Write("Enter the temperature in degree Celcius:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double celcius))
            { 
                double Kelvin = celcius + 273;
                double Fahrenheit = celcius * 18 / 10 + 32;
                Console.WriteLine($"Kelvin={Kelvin}");
                Console.WriteLine($"Fahrenheit={Fahrenheit}");
            }
            else
            {
                Console.WriteLine("Invalid input.Please enter a numeric value");
            }
        }
        public static void Exercise_02()
        {
            Console.Write("Enter the radius of a sphere:");
            string input = Console.ReadLine() ;
            if (double.TryParse(input, out double radius) && radius > 0)
            {
                double pi = Math.PI;
                double surface = 4 * pi * Math.Pow(radius, 2);
                double volume = 4 / 3 * pi * Math.Pow(radius, 3);
                Console.WriteLine($"Surface:{surface}");
                Console.WriteLine($"Volume:{volume}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive radius");
            }
        }
        public static void Exercise_03()
        {
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g= a % b;
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} - {b} = {d}");
            Console.WriteLine($"{a} * {b} = {e}");
            Console.WriteLine($"{a} / {b} = {f}");
            Console.WriteLine($"{a} mod {b} = {g}");

        }
        
    }
}
