using System;
using System.Runtime.InteropServices.ComTypes;

namespace DansGame
{

    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter a number from 0 to 100");
            userInput = Console.ReadLine();
            if (userInput == "5")
            {
                Console.WriteLine("You win!!!");

            }
            else Console.WriteLine("You lose!!");

            Console.ReadLine();

        }

    }
}
