using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenVuThanhGiang_31231026898
{
    internal class Session_04_Controlflow
    {
        public static void Main4(string[] args)
        { 
            Exercise_01();
            Exercise_02();
            Exercise_03();
            Exercise_04();
            Exercise_05();
            Exercise_06(); 
            Exercise_07();
            Exercise_08();
            Exercise_09();
            Exercise_10();
        } 
        public static void Exercise_01()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            } 
            else
            {
                Console.WriteLine($"{number} is odd");
            }
                
        }
        public static void Exercise_02()
        {
            Console.Write("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The largest number is: {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The largest number is: {num2}");
            }
            else
            {
                Console.WriteLine($"The largest number is: {num3}");
            }
        }
        public static void Exercise_03()
        {
            Console.Write("Enter the X coordinate:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the Y coordinate:");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the first quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the third quadrant");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y} lies in the fourth quadrant");
            }

        }
        public static void Exercise_04()
        {
            Console.Write("Enter the length of the first edge:");
            int edge1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the second edge:");
            int edge2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the third edge:");
            int edge3 = Convert.ToInt32(Console.ReadLine());
            if (edge1 == edge2 && edge3 == edge1 && edge2==edge3)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else if (edge1 == edge2 || edge2 == edge3 || edge3 == edge1)
            {
                Console.WriteLine("The triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene");
            }
        }
        public static void Exercise_05()
        {
            int sum = 0;
            const int count = 10;
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}:");
                int number = int.Parse(Console.ReadLine());
                sum += number;

            }
            double average =  (double) sum / count;
            Console.WriteLine($"The sum of 10 numbers is: {sum}");
            Console.WriteLine(($"The average of 10 numbers is: {average}"));
        }
        public static void Exercise_06()
        {
            Console.Write("Enter an integer:");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication table of {integer}:");
            for (int i=1; i <=10; i++)
            {
                int result = integer * i;
                Console.WriteLine($"{integer} * {i} = {result}");
            } 
        }
        public static void Exercise_07()
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            int a = 4;
            int number = 1;
            for (int i=1; i<=a;i++)
            {
                for (int h=1; h<=i; h++)
                {
                    Console.Write(number + "");
                    number++;

                }
                Console.WriteLine();
            
            }
            int b = 4;
            int count = 1;
            for (int i=1; i<=b;i++)
            {
                for (int h=i; h<b;h++)
                {
                    Console.Write("");
                }
                for (int h=1; h<=i; h++)
                {
                    Console.Write(count + "");
                    count++;
                }
                Console.WriteLine();
            }

             
        }
        public static void Exercise_08()
        {
            double sum = 0.0;
            Console.Write("Enter the number of terms:");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n ; i++)
            {
                Console.Write("1/" + i );
                if (i<n)
                {
                    Console.Write("+");
                }
                sum += 1.0 / i;
          
              

            }
            Console.WriteLine($"Sum of the harmonic series is: {sum}");

        }
        public static void Exercise_09()
        {
            Console.Write("Enter the starting number of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Perfect numbers between {0} and {1} are:", start, end);
            for (int i = start; i <= end; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }


    
       

        public static void Exercise_10()
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i=1; i <=num ; i++)
            {
                if (num % i ==0)
                {
                    count++;
                }   
            }
            if (count ==2)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");

            }
        

        }  
    }

}
