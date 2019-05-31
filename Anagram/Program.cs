using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = "";
            var word2 = "";
            string isAnagram = "";
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

            foreach (var item in words)
            {
                word1 = item.Key.Replace(" ", "");
                word2 = item.Value.Replace(" ", "");
                word1 = toLower(word1);
                word2 = toLower(word2);

                foreach (char c in word1)
                {
                    if (word2.Contains(c)) isAnagram = "ANAGRAM";
                    else isAnagram = "NOT-ANAGRAM";
                    if (word1.Length != word2.Length) isAnagram = "NOT-ANAGRAM";
                }
                Console.WriteLine("{0} and {1} =>> {2}", item.Key, item.Value, isAnagram); 
            }

        }

        private static string toLower(string word)
        {
            word = word.ToLower();
            return word;
        }
    }
}
