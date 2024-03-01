namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Main menu. Please enter selected number for wanted action: ");
            
            
            Console.WriteLine("0. Exit program");

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
