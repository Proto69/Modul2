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
            int[] result = new int[cols];
            ToMatrix(arr, result);

            for (int cols1 = 0; cols1 < arr.GetLength(1); cols1++)
            {
                int min = int.MaxValue;
                for (int rows1 = 0; rows1 < arr.GetLength(0); rows1++)
                {
                    if (arr[rows1, cols1] < min) min = arr[rows1, cols1];
                }
                result[cols1] = min;
            }
            Console.WriteLine();
            PrintMatrix(arr, result);
        }
        static void ToMatrix(int[,] arr, int[] result)
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

        static void PrintMatrix(int[,] arr, int[] result)
        {
            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    Console.Write(arr[rows, cols] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
