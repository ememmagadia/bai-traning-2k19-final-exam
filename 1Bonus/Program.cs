using System;
using System.Collections.Generic;
namespace _1Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            String y, x;
            var words = new Dictionary<string, string>() {
                {"heater","reheat"},
                { "Arc","car"} ,
                { "Elbow","below"} ,
                { "NIght","thing"} ,
                { "cshark","csharp"} ,
                { "Dormitory","Dirty room"} ,
                { "School master","The classroom"} ,
                { "php","hpp,." },
                {"Astronomer ", "Moon starer" }

            };
            foreach(var w in words)
            {
                y = w.Key.Replace(" ", "");
                x = w.Value.Replace(" ", "");
                if(y.Length != x.Length)
                {
                    if (y.Contains(x))
                    {
                        Console.WriteLine($"{x} And {y} ANAGRAM");
                    }
                    else
                    {
                        Console.WriteLine($"{x} And {y} NOT ANAGRAM ");
                    }
                }
                else
                {
                    Console.WriteLine($"{x} And {y} ANAGRAM");

                }

            }

        }
    }
}
