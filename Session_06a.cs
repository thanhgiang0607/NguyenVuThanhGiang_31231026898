using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVuThanhGiang_31231026898
{
    internal class Session_06a
    {
        public static void Main6(string[] args)
        {
            Console.Write("Enter the items of array:");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            addarray(array);
            printarray(array);
            sumarray(array);
            averagearray(array);
            minarray(array);
            maxarray(array);
        }
        static void addarray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
            }

        }
        static void printarray(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void sumarray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum of the array is: {sum}");
        }
        static void averagearray(int[] array)
        {
            double sum = 0;
            for (int i = 0;i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine($"Average of the array is: {average}");
        }
        static void minarray(int[] array)
        {
            int min = array[0];
            foreach (var item in array)

            {
                if (item < min)
                {
                    min = item;
                }
              
            }
            Console.WriteLine($"Min of the array is: {min}");
       
        }
        static void maxarray(int[] array)
        {
            int max = array[0];
            foreach(var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"Max of the array is: {max}");
        }

    }
}
