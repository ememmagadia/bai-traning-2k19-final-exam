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

            foreach (var item in words)
            {
                Console.Write("{0} and {1} =>> ", item.Key, item.Value);
                // bool IfAnagram = CompareWords(first, second);

                int firstWord = ConvertToInt(item.Key);
                int secondWord = ConvertToInt(item.Value);

                if (firstWord == secondWord)
                {
                    Console.WriteLine("ANAGRAM");
                }
                else
                {
                    Console.WriteLine("NOT ANAGRAM");
                }
            }
            
        }

        static int ConvertToInt(string word)
        {
            int total = 0;
            word = word.Replace(" ", "");

            for(int index = 0; index<word.Length; index++)
            {
                total += (int)word[index];
            }

            return total;
        }

        //static bool CompareWords(string first, string second)
        //{
        //    char[] secondArr = second.ToCharArray();

        //    foreach (var index in first)
        //    {
        //        if (second.Contains(index))
        //        {
        //            int i = second.IndexOf(index);
        //            Console.Write(second);
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //static object ContainsLetter(char letter, string second)
        //{
        //    if (second.Contains(letter))
        //    {
        //        int i = second.IndexOf(letter);
        //        second = second.Remove(i);
        //        Console.Write(second);
        //        return second;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
