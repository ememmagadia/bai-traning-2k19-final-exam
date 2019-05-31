using System;
using System.Collections.Generic;
using System.Linq;

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

            foreach (var w in words)
            {

                string key = w.Key.Replace(" ", "");
                string value = w.Value.Replace(" ", "");

                if (key.ToLower() == value.ToLower())
                {
                    Console.WriteLine("'{0}' and '{1} => ANAGRAM", w.Key, w.Value);
                } else {
                    Console.WriteLine("'{0}' and '{1} => NOT ANAGRAM", w.Key, w.Value);
                }

            }


        }


    }

}
