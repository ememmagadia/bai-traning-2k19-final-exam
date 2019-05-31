using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inp1 = "";
            string Inp2 = "";
            bool result = true;
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
            foreach (var i in words)
            {
                result = true;
                Inp1 = i.Key.Replace(" ", "");
                Inp2 = i.Value.Replace(" ", "");
                Inp1=Inp1.ToLower();
                Inp2 = Inp2.ToLower();
                if (Inp1.Length != Inp2.Length)
                {
                    result = false;
                }
                foreach (char c in Inp1)
                {
                    if (!Inp2.Contains(c))
                    {
                        result = false;
                    }
                }
                Console.Write("{0} and {1}=>>", i.Key, i.Value);
                Console.WriteLine(result ? "ANAGRAM" : "NOT-ANAGRAM");

            }
        }
    }
}
