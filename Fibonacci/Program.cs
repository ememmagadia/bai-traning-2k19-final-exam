using System;

namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number");
			int num = Convert.ToInt32(Console.ReadLine());
			int first = 0, second = 1, sum;
			Console.Write(first);
			for(int i=1; i <num; i++)
			{
				Console.Write(" " + second);
				sum = first + second;
				first = second;
				second = sum;
				
			}
			Console.ReadKey();
		}

		//public int fibo(int num,int num1, int num2)
		//{
		//	if (num == 0)
		//	{
		//		return (num1 + num2);
		//	}
		//	else
		//	{
		//		num--;

		//	}
		//}
	}
}
