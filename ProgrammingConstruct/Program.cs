namespace ProgrammingConstruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come To Programming Construct");
            Console.WriteLine("1:Check Integer Equal");
            Console.WriteLine("1:Check Even Or Odd");
            
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
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;

            }
           
        }
    }
}