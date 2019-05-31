using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
	class Program
	{
		static void Main(string[] args)
		{
			bool check = true;
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

			foreach (KeyValuePair<string, string> kvp in words)
			{
				string first = kvp.Key.Replace(",.","");
				string second = kvp.Value.Replace(",.", "");
				int len1 = first.Length;
				int len2 = first.Length;
				for(int i = 0; i<len1; i++)
				{
					for (int j = 0; j < len1; j++)
					{
						if(first[i]==second[j])
						{
							check = true;
							break;
						}
						else
						{
							check = false;
						}
					}
					
				}
				if (check)
				{
					Console.WriteLine(first + " and " + second + "=> ANAGRAM");
				}
				else
				{
					Console.WriteLine(first + " and " + second + "=> NOT - ANAGRAM");
				}
			}
			Console.ReadKey();
		}

	}
}
