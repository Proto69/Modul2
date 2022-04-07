using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int[] parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            int[,] arr = new int[rows, cols];
            bool check = false;

            ToMatrix(arr);
            check = CheckDiagonals(arr, check);

            if (check)
            {
                CalculatePrice(arr);
            }
            else Console.WriteLine("NO");
        }
        static void ToMatrix(int[,] arr)
        {
            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    arr[rows, cols] = row[cols];
                }
            }
        }

        static bool CheckDiagonals(int[,] arr, bool check)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;

            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    if (rows == cols) sum1 += arr[rows, cols];
                    if (rows + cols == arr.GetLength(0) - 1) sum2 += arr[rows, cols];
                    if (cols > rows) sum3 += arr[rows, cols];
                    if (rows > cols) sum4 += arr[rows, cols];
                }
            }
            if (sum1 == sum2 && sum3 % 2 == 0 && sum4 % 2 == 1) check = true;
            return check;
        }
        
        static void CalculatePrice(int[,] arr)
        {
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;

            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    if (rows == cols && arr[rows, cols] % 2 == 0)
                    {
                        sum1 += arr[rows, cols];
                    }
                    if (rows == 0 && arr[rows, cols] % 2 == 0 || rows == arr.GetLength(0) - 1 && arr[rows, cols] % 2 == 0)
                    {
                        sum2 += arr[rows, cols];
                    }
                    if (cols == 0 && arr[rows, cols] % 2 == 1 || cols == arr.GetLength(0) - 1 && arr[rows, cols] % 2 == 1)
                    {
                        sum3 += arr[rows, cols];
                    }
                    if (rows > cols)
                    {
                        sum4 += arr[rows, cols];
                    }
                }
            }
            Console.WriteLine("YES");
            Console.WriteLine($"The amount of money won is: {(sum1 + sum2 + sum3 + sum4) / 4:F2}");
        }
    }
}
