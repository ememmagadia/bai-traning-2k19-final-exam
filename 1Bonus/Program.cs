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
                char[] word1 = y.ToLower().ToCharArray();
                char[] word2 = x.ToLower().ToCharArray();
                Array.Sort(word1);
                Array.Sort(word2);
                string a = new string(word1);
                string b = new string(word2);
                if( a == b)
                {
                    Console.WriteLine($"{y} And {x} Anagram");
                }
                else
                {
                    Console.WriteLine($"{y} And {x} Not Anagram");

                }

            }

        }
    }
}
