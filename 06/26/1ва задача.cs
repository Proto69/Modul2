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
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            int[,] result = new int[2, 2];

            ToMatrix(arr);

            int maxSum = 0;

            FindMaxSumAndTheResultMatrix(arr, result, maxSum);
            Console.WriteLine($"{result[0, 0]} {result[0, 1]}");
            Console.WriteLine($"{result[1, 0]} {result[1, 1]}");

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

        static void FindMaxSumAndTheResultMatrix(int[,] arr, int[,] result, int maxSum)
        {
            maxSum = 0;

            for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1) - 1; cols++)
                {
                    int sum = arr[rows, cols] + arr[rows + 1, cols] + arr[rows, cols + 1] + arr[rows + 1, cols + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        result[0, 0] = arr[rows, cols];
                        result[0, 1] = arr[rows, cols + 1];
                        result[1, 0] = arr[rows + 1, cols];
                        result[1, 1] = arr[rows + 1, cols + 1];
                    }
                }
            }
        }
    }
}
