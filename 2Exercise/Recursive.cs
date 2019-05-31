using System;
using System.Collections.Generic;
using System.Text;

namespace _2Exercise
{
   public class Recursive
    {
        public int Action(int x)
        {
            
            int result;
            int j = 1;
            if(x == 0)
            {
                return 0;
            }
            if(x == 1)
            {
                return 1;
            }
            for(int i=0; i < x; i++, j++)
            {
                   result = i + j;
              
                   Console.WriteLine(result);    
            }
            return x;
        }
    }
}
