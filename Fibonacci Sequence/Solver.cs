using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_Sequence
{
    public class Solver
    {
        public int Solve(int i)
        {
            if (i==2)
            {
                return 1;
            }
            else if (i == 1)
            {
                return 0;
            }
            else
            {
                return Solve(i - 1) + Solve(i - 2);
            }
            
        }
    }
}
