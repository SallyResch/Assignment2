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
                        Console.WriteLine($"The ticketprice for your age is: {price}kr");
                        Console.WriteLine("Enter the number of people going to the movies with you:");
                        int numberOfPeople = int.Parse(Console.ReadLine());
                        int totalCost = TotalTicketCost(numberOfPeople);
                        Console.WriteLine($"The total cost of movietickets is: {totalCost + price}");
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
        //Checking the age of User to set the price on movieticket in case 1
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

        //Count total cost of tickets for the group of people going to the movies together
        //first ask for every persons age and add every result of the price/person to the total of ticketcost
        //Then print the totalticketcost in the console to the user.

        static int TotalTicketCost(int numberOfPeople)
        {
            int totalTicketCost = 0;

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.WriteLine($"Enter age of person {i}:");
                int age = int.Parse(Console.ReadLine());

                int ticketPrice = AgeCheck(age);
                totalTicketCost += ticketPrice;

            }
            return totalTicketCost;
        }
    }
}
