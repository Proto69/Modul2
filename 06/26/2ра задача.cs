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
            string[,] arr = new string[3, 3];

            ToMatrix(arr);

            int result = 0;

            CheckForAWinner(arr, result);
        }
        static void ToMatrix(string[,] arr)
        {
            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                string[] row = Console.ReadLine().Split(' ').ToArray();
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    arr[rows, cols] = row[cols];
                }
            }
        }

        static void CheckForAWinner(string[,] arr, int result)
        {
            if (arr[0, 0] == arr[0, 1] && arr[0, 1] == "X" && arr[0, 1] == arr[0, 2]) { Console.WriteLine("The winner is: X"); }
            else if (arr[0, 0] == arr[0, 1] && arr[0, 1] == "O" && arr[0, 1] == arr[0, 2]) { Console.WriteLine("The winner is: O"); }
            else if (arr[1, 0] == arr[1, 1] && arr[1, 1] == "X" && arr[1, 1] == arr[1, 2]) { Console.WriteLine("The winner is: X"); }
            else if (arr[1, 0] == arr[1, 1] && arr[1, 1] == "O" && arr[1, 1] == arr[1, 2]) { Console.WriteLine("The winner is: O"); }
            else if (arr[2, 0] == arr[1, 1] && arr[2, 1] == "X" && arr[2, 1] == arr[2, 2]) { Console.WriteLine("The winner is: X"); }
            else if (arr[2, 0] == arr[1, 1] && arr[2, 1] == "O" && arr[2, 1] == arr[2, 2]) { Console.WriteLine("The winner is: O"); }
            else if (arr[0, 1] == arr[1, 1] && arr[2, 1] == "X" && arr[2, 1] == arr[0, 1]) { Console.WriteLine("The winner is: X"); }
            else if (arr[0, 1] == arr[1, 1] && arr[2, 1] == "O" && arr[2, 1] == arr[0, 1]) { Console.WriteLine("The winner is: O"); }
            else if (arr[0, 0] == arr[2, 0] && arr[1, 0] == "X" && arr[2, 0] == arr[1, 0]) { Console.WriteLine("The winner is: X"); }
            else if (arr[0, 0] == arr[2, 0] && arr[1, 0] == "O" && arr[2, 0] == arr[1, 0]) { Console.WriteLine("The winner is: O"); }
            else if (arr[0, 2] == arr[1, 2] && arr[0, 2] == "X" && arr[0, 2] == arr[2, 2]) { Console.WriteLine("The winner is: X"); }
            else if (arr[0, 2] == arr[1, 2] && arr[0, 2] == "O" && arr[0, 2] == arr[2, 2]) { Console.WriteLine("The winner is: O"); }
            else if (arr[0, 0] == arr[1, 1] && arr[0, 0] == "X" && arr[1, 1] == arr[2, 2]) { Console.WriteLine("The winner is: X"); }
            else if (arr[0, 0] == arr[1, 1] && arr[0, 0] == "O" && arr[1, 1] == arr[2, 2]) { Console.WriteLine("The winner is: O"); }
            else if (arr[0, 2] == arr[1, 1] && arr[2, 0] == "X" && arr[1, 1] == arr[2, 0]) { Console.WriteLine("The winner is: X"); }
            else if (arr[0, 2] == arr[1, 1] && arr[2, 0] == "O" && arr[1, 1] == arr[2, 0]) { Console.WriteLine("The winner is: O"); }
            else Console.WriteLine("There is no winner");
        }
    }
}
