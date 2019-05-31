using System;
using System.Collections.Generic;

namespace Anagram
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

                foreach(var val in words)
                {
                Console.WriteLine(val.Key +" and  "+ val.Value "=>" result);
                }
            
        }
    }
}
