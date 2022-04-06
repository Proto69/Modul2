using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        //Не съм баш сигурен, объркваща е задачата
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.Append(Console.ReadLine());
            Start(sb);
        }

        static void Start(StringBuilder text)
        {
            int ostatyk = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    int power = int.Parse(text[i + 1].ToString()) + ostatyk;
                    bool check = true;
                    int indexOfNextHit = 0;
                    for (int j = 0; j < power; j++)
                    {
                        if (text[j + i + 1] == '>') { check = false; indexOfNextHit = 1 + i + j; j = power; }
                    }
                    if (check)
                    {
                        text = text.Remove(i + 1, power);
                    }
                    else
                    {
                        ostatyk += power - (indexOfNextHit - i - 1);
                        text = text.Remove(i + 1, indexOfNextHit - i - 1);
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
