using System;

namespace FibonnaciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;
            int fibo = 0;

            Console.WriteLine("Please Enter the Number");
            fibo = int.Parse(Console.ReadLine());

            Console.Write(num1 + " " + num2 + " ");
            for (int i = 0; i < fibo; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

            //    Console.WriteLine("Please enter the number: ");
            //    int fibo = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i < fibo; i++)
            //    {
            //        Console.Write(" " + Recursive(fibo));
            //    }




            //}
            //public static int Recursive(int fibo)
            //{
            //    if (fibo == 0)
            //    {
            //        return 0;
            //    }
            //    else if (fibo == 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {

            //            return Recursive(fibo - 2) + Recursive(fibo - 1);

            //    }

            //}
        }
    }
}
