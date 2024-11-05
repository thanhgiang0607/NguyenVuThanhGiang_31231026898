using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVuThanhGiang_31231026898
{
    public class Session_05
    {
        public static void Main(string[] args)
        {
            Exercise_01a();
            Exercise_01b();
            Exercise_02();
            Exercise_03();
            Exercise_04a();
            Exercise_04b();
            Exercise_05a();
            Exercise_05b();
            Exercise_06();
            
        }
        static int Maxofthree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        static void Exercise_01a()
        {
            int max = Maxofthree(8, 10, 15);
            Console.WriteLine($"Max of 8,10,15 is: {max}");
        }
        static int Maxofparams(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new Exception("At least one number is required");
            }
            return numbers.Max();
        }
        static void Exercise_01b()
        {
            int max = Maxofparams(8, 10, 15);
            int max2 = Maxofparams(19, 20, 21, 22, 30);
            Console.WriteLine($"Max of 8,10,15 is: {max}");
            Console.WriteLine($"Max of 19,20,21,22,30 is: {max2}");
        }
        static long Factorial(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("The number must be positive. Try again");
            }
            if (a == 0 || a == 1)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }
        static void Exercise_02()
        {
            int a = 6;
            Console.WriteLine($"Factorial number of {a} is:" + Factorial(a));
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Exercise_03()
        {
            int num = 20;
            if (IsPrime(num))
            {
                Console.WriteLine($"{num} is a prime number");

            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }
        }

        static bool IsPrime(long num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) { return false; }
            }
            return true;
        }
        static void Exercise_04a()
        {
            Console.Write("Enter a limit number:");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine($"All prime numbers less than {limit} are:");
            for (int i=1; i <limit; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
        }
        static void Exercise_04b()
        {
            Console.Write("Enter the number of prime numbers:");
            int primenum = int.Parse(Console.ReadLine());
            int count = 0;
            int start = 2;
            Console.WriteLine($"The first {primenum} prime numbers are:");
            while (count < primenum)
            {
                if (IsPrime(start))
                {
                    Console.Write(start + " ");
                    count++;
                }
                start++;
            }
            Console.WriteLine();
        }
        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
            
        }
        static void Exercise_05a()
        {
            int num = 26;
            if (IsPerfect(num))
            {
                Console.WriteLine($"{num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }

        }
        static void Exercise_05b()
        {
            Console.Write("All perfect numbers that are less than 1000:");
            for (int i=1; i<1000; i++)
            {
                if (IsPerfect(i))
                {
                    Console.Write(i + " ");
                    
                }
            }
            Console.WriteLine();
        }
        static bool IsPangram(string input)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (char c in input.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    set.Add(c.ToString());
                }
            }
            if (set.Count == 26)
            {
                return true;
            }
            return false;
        }
        static void Exercise_06()
        {
            Console.Write("Write a string:");
            string str = Console.ReadLine();
            if (IsPangram(str))
            {
                Console.WriteLine($"{str} is a pangram");
            }
            else
            {
                Console.WriteLine($"{str} is not a pangram");
            } 
            

        }

       
       


            
    }

        









}


