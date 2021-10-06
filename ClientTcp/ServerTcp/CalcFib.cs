using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTcp
{
    class CalcFib
    {
        public static double Fib(double number)
        {
            if (number <= 1)
                return 1;

            return Fib(number - 1) + Fib(number - 2);
        }
    }
  
}
