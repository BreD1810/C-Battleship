using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BattleshipConsole
{
    //Represents an instance of a Battleship game
    class Game
    {

        private static Player[] _players;

        public Game()
        {
            _players = DeterminePlayers();
        }

        //Get the player names and create the objects
        private static Player[] DeterminePlayers()
        {
            Player[] players = new Player[2];
            
            Console.WriteLine("Enter the first player's name:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            players[0] = new Player(name1);
            Console.WriteLine("Enter the second player's name:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            players[1] = new Player(name2);

            return players;
        }

    }
}
