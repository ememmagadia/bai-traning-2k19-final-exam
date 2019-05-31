using System;

namespace FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            int a = int.Parse(Console.ReadLine());
            int[] array ={ 0, 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            
            for (int i = 2; i < a; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

                for (int i = 0; i < a; i++)
                {
                    Console.Write(array[i] + " ");
                }


        }
    }
}
