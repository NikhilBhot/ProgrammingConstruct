using System.Runtime.ConstrainedExecution;

namespace ProgrammingConstruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come To Programming Construct");
            Console.WriteLine("1:Check Integer Equal");
            Console.WriteLine("2:Check Even Or Odd");
            Console.WriteLine("3:Check Vote Eligibility");
            Console.WriteLine("4:Check Largest No From Three");
            
            Console.WriteLine("_____________________________");
            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //1.Write a C# Sharp program to accept two integers and check whether they are equal or not.

                    IntegerEquality.checkIntEqual();
                    break;
               case 2:
                    //Write a C# Sharp program to check whether a given number is even or odd..
                    EvenOrOdd.checkEvenOrOdd();
                    break;
                case 3:
                    /*Write a C# Sharp program to read the age of a candidate and
                    determine whether it is eligible for casting his/ her own vote.*/
                    Voteeligiblity.voteEligibility();
                    break;
                case 4:
                    /*Write a C# Sharp program to find the largest of three numbers..*/
                    LargestFromThreeNo.largeFromThree();
                    break;
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;

            }
           
        }
    }
}