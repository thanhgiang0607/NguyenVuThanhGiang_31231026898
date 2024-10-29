using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVuThanhGiang_31231026898
{
    internal class Session_04_Operators
    {
        public static void Main3(string[] args)
        {
            Exercise_01();
            Exercise_02();
            Exercise_03();
            Exercise_04();
            Exercise_05();
        }
        public static void Exercise_01()
        {
            Console.Write("Enter the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            double b = double.Parse(Console.ReadLine());
            double plus = a + b;
            double minus = a - b;
            double multiply = a * b;
            double divide = a / b;
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
            }
            else Console.WriteLine($"a/b={divide}");
            Console.WriteLine($"a + b = {plus}");
            Console.WriteLine($"a - b = {minus}");
            Console.WriteLine($"a * b = {multiply}");
        }
        public static void Exercise_02()
        {
            Console.Write("Enter y =");
            int y = int.Parse(Console.ReadLine());
            if (y < -5 || y > 5)
            {
                Console.WriteLine("Chi cho phep trong doan t [-5,5]");
            }
            else
            { 
                double x = Math.Pow(y,2)+ 2 * y + 1;
                Console.WriteLine($"The value of x = {x}");
            }    

        }
        public static void Exercise_03()
        {
            Console.Write("Enter the distance in kilometres:");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter time in hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter time in minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter time in seconds:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            double totalhours = hours + (minutes / 60.0) + (seconds / 3600.0);
            double kmh = distance / totalhours;
            double mph = kmh * 0.621371192;
            Console.WriteLine($"kmh = {kmh}");
            Console.WriteLine($"mph = {mph}");
        }
        public static void Exercise_04()
        {
            Console.Write("Enter the radius of a sphere:");
            double radius = double.Parse (Console.ReadLine());
            double pi = Math.PI;
            double surface = 4 * Math.Pow(radius,2) * pi;
            double volume = 4 / 3 * pi * Math.Pow(radius, 3);
            Console.WriteLine($"The surface of the sphere is: {surface}");
            Console.WriteLine($"The volume of the sphere is: {volume}");
        }
        public static void Exercise_05()
        {
            Console.Write("Enter a character:");
            char character = char.Parse(Console.ReadLine());
            if ("aeiouAEIOU".IndexOf(character) >= 0)
            {
                Console.WriteLine($"{character} is a vowel");
            }
            else if (char.IsDigit(character))
            {
                Console.WriteLine($"{character} is a digit");
            }
            else
            {
                Console.WriteLine($"{character} is any other symbol");
            }
        }
        

            
            
                 
            










        }
}
