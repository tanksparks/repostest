using System;
using System.Runtime.InteropServices.ComTypes;

namespace DansGame
{

    class Program
    {
        static void Main(string[] args)
        {
            // Doing this on Basement computer
            Random r = new Random();
            int num = r.Next(100);
            Console.WriteLine("Game was tested");
            Console.WriteLine("Sept 11, 2020");
            Console.WriteLine("Num:" + num);
            string userInput;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Enter a number from 0 to 100");
                userInput = Console.ReadLine();

                if (userInput == num.ToString())
                {
                    Console.WriteLine("You win!!!");
                    break;
                }
                else Console.WriteLine("You lose!!");
            }
            Console.WriteLine("Game Over!");
            Console.ReadLine();
        }
    }
}
