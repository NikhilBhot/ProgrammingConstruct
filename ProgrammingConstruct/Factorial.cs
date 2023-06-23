using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class Factorial
    {
        /*
         * Write a program that computes a factorial of a number taken as input
                5 Factorial – 5! = 1 * 2 * 3 * 4 * 5
         */
        public static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
