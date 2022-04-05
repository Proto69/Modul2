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
            Start(Console.ReadLine());
        }

        static void Start(string text)
        {
            bool isRunning = true;
            while (isRunning)
            {
                string[] test = Console.ReadLine().Split(' ').ToArray();
                bool isRunning2 = true;
                int startIndex = 0;
                while (isRunning2)
                {                    
                    int index = text.IndexOf(test[0], startIndex);
                    if (index == -1) isRunning2 = false;
                    else
                    {
                        int count = 0;
                        for (int i = index; i < text.Length; i++)
                        {
                            if (text[i].ToString() == test[0]) count++;
                            else break;
                        }
                        if (count >= int.Parse(test[1]))
                        {
                            Console.WriteLine($"Hideout found at index {index} and it is with size {count}!");
                            isRunning2 = false;
                        }
                        else
                        {
                            startIndex = index + 1;
                        }
                    }
                }
            }
        }
    }
}
