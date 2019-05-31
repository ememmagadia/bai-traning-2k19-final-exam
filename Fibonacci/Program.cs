using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of sequence:");
            int seq = Convert.ToInt32(Console.ReadLine());
            Console.Write("0 ");

            Fibo.DoFibo(seq);


            

        }
    }
}
