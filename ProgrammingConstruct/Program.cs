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
            Console.WriteLine("5:Check Addmision Eligibility");
            Console.WriteLine("6:Check Week Day Number");
             Console.WriteLine("7:Arithmetic Operation");
            
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
                case 5:
                    /*Write a C# Sharp program to find the eligibility of admission for a
                        professional course based on the following criteria:
                        Marks in Maths >=65
                        Marks in Physics >=55
                        Marks in Physics >=50
                        Total in all three subject >=180 or
                        Total in Math and (Physics or Chemistry) >=140

                        Test Data :
                            Input the marks obtained in Physics :65
                            Input the marks obtained in Chemistry :51
                            Input the marks obtained in Mathematics :72
                            Expected Output :
                            The candidate is eligible for admission..*/
                    AddmisionEligibility.addmisionCriteria();
                    break;
                case 6:
                    /*Take user input has weekday number to calculate the weekday name:*/
                    WeekDayNumber.weekDayNum();
                    break; 
                case 7:
                    /*TTake 2 numbers has user inputs and perform arithmetic operations on it.
                        i.e Addition, Subtraction, Multiplication and Division using switch Case.*/
                    ArithmeticOperation.arithmeticOperation();
                    break;
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;

            }
           
        }
    }
}