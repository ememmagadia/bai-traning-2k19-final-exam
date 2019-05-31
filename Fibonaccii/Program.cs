using System;

namespace Fibonaccii
{
    class Program
    {

        public int PrintFibonacci(int currentNo, int lastNo)
        {
            if (currentNo == 0 || currentNo == 1)
            {
                currentNo++;
                return currentNo;
            }
            else
            {
                currentNo += lastNo;
            }
            return currentNo;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int currentNo = 0;
            int lastNo;
            while (num > 0)
            {
                lastNo = currentNo;
                currentNo = p.PrintFibonacci(currentNo, lastNo);
                Console.Write(currentNo + " ");
                //Console.WriteLine("Current: {0} Last: {1}", currentNo, lastNo);
                num--;
            }
        }
    }
}