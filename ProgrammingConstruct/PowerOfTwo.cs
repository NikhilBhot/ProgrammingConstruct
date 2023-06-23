using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class PowerOfTwo
    {
        /*Write a program that takes a user input n and prints a table of the powers
        of 2 that are less than or equal to 2^n.*/
        public static void twoPower()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Powers of 2 up to 2^n:");

            for (int i = 0; i <= n; i++)
            {
                long power = (long)Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {power}");
            }
        }
    }
}
