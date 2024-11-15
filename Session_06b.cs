using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVuThanhGiang_31231026898
{
    internal class Session_06b
    {
        static int[] addarray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;

        }
        static double averagearray(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            return average;
        }
        static bool containisvalue(int[] array, int value)
        {
            foreach (int i in array)
            {
                if (value == i)
                {
                    return true;
                }
            }
            return false;
        }
        static int findindex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                    return i;
            }
            return -1;
        }
        static int findmax(int[] array, int max)
        {
            max = array[0];
            foreach(int i in array)
            {
                if (max < i)
                max = i;
            }
            return max;
        }
        static int findmin(int[] array, int min)
        {
            min = array[0];
            foreach (int i in array)
            {
                if (min >i)
                min = i;
            }
            return min;
        }
        static void reversearray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            for (int i = start; i >= end; i--)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
            }         
        }

        static void Main7(string[] args)
        {
            int min = 1;
            int max = 100;
            int size = 10;
            int[] randomarray = addarray(size, min, max);
            double averagevalue = averagearray(randomarray);
            int findvalue = 10;
            bool foundvalue = containisvalue(randomarray, findvalue);

            Console.WriteLine($"Random array:" + string.Join(",", randomarray));
            Console.WriteLine($"Average of the array: {averagevalue}");

            Console.WriteLine($"Does the array have {findvalue}?");
            if (foundvalue == true)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
            int valuetofind = 50;
            int index = findindex(randomarray, valuetofind);
            if (index != -1)
            {
                Console.WriteLine($"{valuetofind} is found in the index {index} of the array");
            }
            else
            {
                Console.WriteLine($"{valuetofind} is not found");
            }
            int minvalue = findmin(randomarray, min);
            int maxvalue = findmax(randomarray, max);
            Console.WriteLine($"Max of the array is: {maxvalue}");
            Console.WriteLine($"Min of the array is: {minvalue}");
            Console.WriteLine("The original array:" + string.Join(",", randomarray));
            reversearray(randomarray);
            Console.WriteLine("The reversed array:" + string.Join(",", randomarray));

        }
    }
}
