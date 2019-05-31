using System;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;
            
            Fibo(10, x, y);
        }

        static int Fibo(int i, int x, int y)
        {
            int z;
            if (i == 0)
            {
                return 1;
            }
            else
            {
                z = x;
                x = x + y;
                y = z;
                Console.Write(y); Console.Write(" ");
                i--;
                return Fibo(i, x, y);
            }
        }
    }
}
