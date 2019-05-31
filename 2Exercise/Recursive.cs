using System;
using System.Collections.Generic;
using System.Text;

namespace _2Exercise
{
   public class Recursive
    {
        public int Action(int number)
        {

            int num1 = 0, num2 = 1, num3, i;
            if(number == 1)
            {
                return 1;
            }
            if ( number == 0)
            {
                return 0;
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
             for(i = 0; i < number; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
            return number;
        }
    }
}
