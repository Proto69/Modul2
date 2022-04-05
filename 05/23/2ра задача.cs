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
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            Start(text);
        }

        static void Start(StringBuilder text)
        {
            int lastIndex = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetter(text[i])) { lastIndex = i; break; }
            }
            for (int i = 0; i < lastIndex; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    try
                    {
                        if (Char.IsDigit(text[i + 1]))
                        {
                            text.Remove(i, 1);
                            i--;
                        }
                        else
                        {
                            text.Insert(i, text[i + 1]);
                            text.Remove(i + 1, 1);
                        }
                    }
                    catch { }
                }
            }
            Console.WriteLine(text);
        }
    }
}
