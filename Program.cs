﻿using System.Security.Cryptography.X509Certificates;

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
                        Console.WriteLine("Write a word or scentence:");
                        string scentence = Console.ReadLine();
                        for (int i = 0; i < 10;i++)
                        {
                            Console.Write($"{i + 1}: {scentence} ");
                            
                        }
                        Console.WriteLine(" ");
                        break;
                    case "3":
                        Console.WriteLine("Find the third word in a scentence");
                        Console.WriteLine("Write your scentence: ");
                        string userInput = Console.ReadLine();
                        WordCount(userInput);
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
        //CASE 1 METHODS:
        //Checking the age of User to set the price on movieticket in case 1
        static int AgeCheck(int age)
        {
           
            if (age < 5 || age > 100)
            {
                Console.WriteLine("its free of charge for you youngsters");
                return 0;
            }
            else if (age < 20)
            {
                Console.WriteLine("Price for your age is 80kr");
                return 80;
            }
            else if (age > 64)
            {
                Console.WriteLine("Price for your age is 90kr");
                return 90;
            }
            else
            {
                Console.WriteLine("Price for your age is 120kr");
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

        //CASE 3 METHOD
        //Checking amount of words so that is not less then 3 and takes out the third word and writes it to the console.
        //For loop
        static void WordCount(string input)
        {
            string[] words = input.Split(' ');

            if (words.Length >= 3)
            {
                string thirdWord = words[2];
                Console.WriteLine("The third word is: " + thirdWord);
            }
            else if(words.Length < 3)
            {
                Console.WriteLine("You entered too few words in the sentence. Please enter 3 or more words.");
            }
            else
            {
                Console.WriteLine("Thank you for playing");
            }
            
            
        }

    }
}
