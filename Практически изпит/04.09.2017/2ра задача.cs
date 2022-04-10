using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startPos = int.Parse(Console.ReadLine());
            int damage = 1;
            int position = startPos;

            bool isRunning = true;

            while (isRunning)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command.Length == 1)
                {
                    Console.WriteLine(string.Join(" ", sequence));
                    isRunning = false;
                }
                else if (command[0] == "left")
                {
                    int moves = int.Parse(command[1]);
                    for (int i = 1; i <= moves; i++)
                    {
                        position--;
                        try
                        {
                            sequence[position] -= damage;
                        }
                        catch
                        {
                            damage++;
                            position = sequence.Length - 1;
                            sequence[position] -= damage;
                        }
                        
                    }
                }
                else if (command[0] == "right")
                {
                    int moves = int.Parse(command[1]);

                    for (int i = 1; i <= moves; i++)
                    {
                        position++;
                        try
                        {
                            sequence[position] -= damage;
                        }
                        catch
                        {
                            damage++;
                            position = 0;
                            sequence[position] -= damage;
                        }

                    }
                }
            }
        }
    }
}
