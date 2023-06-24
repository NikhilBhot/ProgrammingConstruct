using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    //while loop to compute sum of first 5 natural numbers
    public class FirstFiveNaturalNo
    {
        public static void NaturalNo()
        {
            int n = 5;
            int sum = 0;
            int count = 1;

            while (count <= n)
            {
                sum += count;
                count++;
            }

            Console.WriteLine($"Sum of the first {n} natural numbers: {sum}");
        }
    }
}
