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
            double systemHealth = double.Parse(Console.ReadLine());
            double remainingHealth = systemHealth;
            bool isRunnning = true;
            var dict = new Dictionary<string, int>();
            while (isRunnning)
            {
                string virusName = Console.ReadLine();
                if (virusName == "end")
                {
                    isRunnning = false;
                    Console.WriteLine($"Final Health: {Math.Round(remainingHealth)}");
                }
                else
                {
                    int virusPower = 0;

                    for (int i = 0; i < virusName.Length; i++)
                    {
                        virusPower += virusName[i];
                    }
                    virusPower /= 3;
                    double timeToDefeat = 0;

                    if (dict.ContainsKey(virusName))
                    {
                        timeToDefeat = virusPower * virusName.Length / 3;
                    }
                    else
                    {
                        dict.Add(virusName, 1);
                        timeToDefeat = virusPower * virusName.Length;
                    }

                    if (timeToDefeat >= remainingHealth)
                    {
                        Console.WriteLine("Immune System Defeated.");
                        isRunnning = false;
                    }
                    else
                    {
                        TimeSpan t = TimeSpan.FromSeconds(timeToDefeat);
                        Console.WriteLine($"Virus {virusName}: {virusPower} => {timeToDefeat} seconds");
                        Console.WriteLine($"{virusName} defeated in {string.Format("{0}m {1}s", t.Minutes, t.Seconds)}");
                        remainingHealth -= timeToDefeat;
                        Console.WriteLine($"Remaining health: {Math.Floor(remainingHealth)}");
                        remainingHealth += remainingHealth * 0.2;
                        if (systemHealth < remainingHealth) remainingHealth = systemHealth;
                    }
                }
            }
        }
    }
}
