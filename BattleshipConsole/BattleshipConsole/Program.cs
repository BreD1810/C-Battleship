using System;
using System.Threading;

namespace BattleshipConsole
{

    //Create a game instance. When it is completed, loop if required.
    static class Program
    {

        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.Clear();
                Game game = new Game();
                Console.WriteLine("Do you wish to play another game?");
                bool check = true;
                //Exit if no, new game if yes, loop until a valid input.
                do
                {
                    Console.Write("Y/N: ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "n")
                    {
                        Console.WriteLine("Press enter to close the window...");
                        loop = false;
                        check = false;
                    }
                    else if (answer.ToLower() == "y")
                    {
                        Console.WriteLine("Starting a new game...");
                        Thread.Sleep(2000);
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N.");
                    }
                } while (check);
            } while (loop);
        }

    }
}
