namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Main menu. Please enter selected number for wanted action:" +
                "\n1. Buy movietickets " +
                "\n2. You want to repeat yourself " +
                "\n3. Play the third word-Game " +
                "\n0. Exit application");

            string selectedAction = Console.ReadLine();

            //Menu creation
            switch(selectedAction){
                case "0":
                    Console.WriteLine("Exiting application");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
