using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVuThanhGiang_31231026898
{
    internal class Consolidate_Exercise
    {
        public static void Main(string[] args)

        {
            Console.Write("Nhap so dong n:");
            int n = int.Parse(Console.ReadLine());
            if (n<1 || n>100)
            {
                Console.WriteLine("So dong phai nam trong khoang [1,100]");
                return;
            }
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so cot cua dong {i + 1}:");
                int m = int.Parse(Console.ReadLine());
                if (m < 1 || m > 100)
                {
                    Console.WriteLine("So cot phai nam trong khoang [1,100]");
                    return;
                }
                matrix[i] = new int[m];
          
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = new Random().Next(1, 101);
                }
            }
            Console.WriteLine("\nMa tran lom chom:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

        static void findmaxmin(int[][] matrix)
            {
                int max = int.MaxValue;
                int min = int.MinValue;
                for (int i = 0; i < matrix.Length; i++)
                {
                    int rowmax = matrix[i].Max();
                    int rowmin = matrix[i].Min();
                    Console.WriteLine($"Dong {i + 1}: Max = {rowmax}, Min = {rowmin}");
                    max = Math.Max(max, rowmax);
                    min = Math.Min(min, rowmin);
                }
                Console.WriteLine($"Lon nhat toan ma tran: {max}");
                Console.WriteLine($"Nho nhat toan ma tran: {min}");
            }
        static void sortrows(int[][] matrix)
            {
                var sortmatrix = matrix.OrderBy(row => row.Min()).ToArray();
                Console.Write(sortmatrix);
                Console.WriteLine();
            }
        static bool isprime(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        static void printprime(int[][] matrix)
            {
                Console.WriteLine("Cac phan tu la so nguyen to:");
                foreach(var row in matrix)
                {
                    foreach (var value in row)
                    {
                        if (isprime(value))
                        Console.WriteLine(value + "\t");
                    }
                }
                Console.WriteLine() ;
            }
        static void position(int[][] matrix)
            {
                Console.Write("Nhap X de tim vi tri:");
                int x = int.Parse(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == x)
                        {
                            Console.WriteLine($"So {x} xuat hien tai vi tri: ({i + 1}, {j + 1}");
                            found = true;
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"So {x} khong xuat hien trong ma tran");
                }
            }
        


                    
           
            



        }
    }
}
