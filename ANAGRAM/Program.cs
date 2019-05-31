using System;
using System.Collections.Generic;

namespace ANAGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
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
            String x;
           
            foreach (var i in words)
            {
                if (i.Key.Contains(i.Value))
                {
                    x = "Anagram";
                }
                else
                {
                    x = "Not Anagram";
                }
                Console.WriteLine(i + x);
            }
            


        }
    }
}
