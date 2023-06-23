using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class SquareOfNumber
    {
        //Write a program that reads a number N and prints the sum of squares of N numbers starting from 1.
        public static void squareOfNum()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());

            int sumOfSquares = 0;

            for (int i = 1; i <= N; i++)
            {
                int square = i * i;
                sumOfSquares += square;
            }

            Console.WriteLine($"Sum of squares of {N} numbers: {sumOfSquares}");
        }
    }
}
