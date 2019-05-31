using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Solver s = new Solver();
            Console.WriteLine("Please enter a number");
            string Inp = Console.ReadLine();
            for(int i = 1; i<=Convert.ToInt32(Inp);i++)
            {
                Console.Write("{0} ",s.Solve(i));
            }
            
        }
    }
}
