using System;

namespace MaRoConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Are you ready for an adventure? (Y/N)");
            char playerInput = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (Char.ToUpper(playerInput))
            {
                case 'Y':
                    Console.WriteLine("Yay, Let's Go!");
                    break;
                case 'N':
                    Console.WriteLine("Aww, why not?");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
