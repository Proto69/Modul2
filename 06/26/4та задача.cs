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
            int n = int.Parse(Console.ReadLine());

            List<string> result = new List<string>();

            string lastRow = "";

            for (int i = 0; i < n; i++)
            {
                int[] parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int rows = parameters[0];
                int cols = parameters[1];
                int[,] arr = new int[rows, cols];
                lastRow += ToMatrix(arr, result, lastRow);
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine(lastRow);
        }
        static string ToMatrix(int[,] arr, List<string> result, string lastRow)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;
            double count = 0;

            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    arr[rows, cols] = row[cols];
                    count++;
                    sum += arr[rows, cols];
                    if (arr[rows, cols] > max) max = arr[rows, cols];
                    if (arr[rows, cols] < min) min = arr[rows, cols];
                }
            }

            double avarage = Math.Round(sum / count, 2);

            int newCount = 0;
            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    if (arr[rows, cols] > Math.Round(avarage)) newCount++;
                }
            } 

            string a = $"{min} {max} {avarage}";
            lastRow = $"{newCount} ";
            result.Add(a);
            return lastRow;
        }
    }
}
