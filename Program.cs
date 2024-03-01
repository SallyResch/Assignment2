using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu creation
            Console.WriteLine("Welcome to Main menu. Please enter selected number for wanted action:" +
               "\n1. Buy movietickets " +
               "\n2. You want to repeat yourself " +
               "\n3. Play the third word-Game " +
               "\n0. Exit application");
            string selectedAction = Console.ReadLine();

            //While loop to make menu stay even if the user made an action, unless user chooses 0
            while (selectedAction != "0") {
                switch (selectedAction)
                {
                    case "1":
                        Console.WriteLine("Please enter your age: ");
                        int.TryParse(Console.ReadLine(), out int age);
                        int price = AgeCheck(age);
                        Console.WriteLine($"The ticketprice for you is: {price}");
                        break;
                    case "2":
                        Console.WriteLine("Number two");
                        break;
                    case "3":
                        Console.WriteLine("Number three");
                        break;
                    case "0":
                        Console.WriteLine("Exiting application");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine("Welcome to Main menu. Please enter selected number for wanted action:" +
               "\n1. Buy movietickets " +
               "\n2. You want to repeat yourself " +
               "\n3. Play the third word-Game " +
               "\n0. Exit application");
                selectedAction = Console.ReadLine();
            }     
        }
        //Checking the age to set the price on movie ticket
        static int AgeCheck(int age)
        {
            if (age < 20)
            {
                return 80;
            }
            else if (age > 64)
            {
                return 90;
            }
            else
            {
                return 120;
            }


        }
    }
}
