using System;
using System.Collections.Generic;

namespace Anagrams
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

            string x = "reheat";
            string y = "heater";

            string newX = x.ToLower(); newX = newX.Replace(" ", "");
            string newY = y.ToLower(); newY = newY.Replace(" ", "");

            List<char> listy1 = new List<char>();
            List<char> listy2 = new List<char>();

            foreach (var i in newX)
            {
                listy1.Add(i);
                listy1.Sort();
            }
            foreach (var i in newY)
            {
                listy2.Add(i);
                listy2.Sort();
            }
            

        }
    }
}
