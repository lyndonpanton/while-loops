namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option;
                Console.WriteLine("****************");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("****************");

                while (true)
                {
                    Console.WriteLine();
                    Console.Write("What option would you like to choose (1 - 4): ");
                    option = Convert.ToInt32(Console.ReadLine());

                    if (option >= 1 && option <= 4)
                    {
                        break;
                    }

                    Console.WriteLine("Error: Invalid option entered");
                }
            }
        }
    }
}