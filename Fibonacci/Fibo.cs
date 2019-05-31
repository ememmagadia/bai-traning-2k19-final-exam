using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public static class Fibo
    {
        public static int DoFibo(int num,int val1 = 0,int val2 = 1)
        {
            int result = val1 + val2;
            val2 = result - val1;            
            if (num == 1)
            {
                return 0;
            }
            else
            {
                num--;
                //val1 = result - val1;
                Console.Write(" "+ result+ " ");
                result = Fibo.DoFibo(num,val2,result);
                
                return result;
            }

        }

    }
}
