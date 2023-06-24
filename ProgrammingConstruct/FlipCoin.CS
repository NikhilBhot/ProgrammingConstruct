using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    //Perform Flip Coin problem till either Heads or Tails wins 20 times.
    public class FlipCoin
    {
        public static void flipCoinOperation()
        {
            int headsCount = 0;
            int tailsCount = 0;
            int totalFlips = 0;

            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                int flip = random.Next(2); // 0 represents heads, 1 represents tails

                if (flip == 0)
                {
                    headsCount++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tailsCount++;
                    Console.WriteLine("Tails");
                }

                totalFlips++;
            }

            if (headsCount == 20)
                Console.WriteLine("Heads wins!");
            else
                Console.WriteLine("Tails wins!");

            Console.WriteLine($"Total flips: {totalFlips}");
        }
    }
}
