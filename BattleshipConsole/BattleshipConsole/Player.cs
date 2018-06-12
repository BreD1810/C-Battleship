using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BattleshipConsole
{
    //Represents a player in the game
    class Player
    {

        public string Name { get; }
        private PlayerBoard _playerBoard = new PlayerBoard();
        private GuessingBoard _guessingBoard = new GuessingBoard();
        private Ship[] _ships = {new Ship(5), new Ship(4), new Ship(3), new Ship(3), new Ship(2)};

        public Player(string name)
        {
            Name = name;
            PlaceShips();
        }

        //Place all of the ships on the board
        private void PlaceShips()
        {
            foreach (Ship ship in _ships)
            {
                bool placed = false;
                do
                {
                    //Get the coordinates from the player
                    Console.WriteLine("Where would you like to place your ship of length " + ship.Length + "?");
                    int x;
                    Console.Write("X: ");
                    while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > Board.BoardSize)
                        Console.Write("Please enter a valid X coordinate between 1 and " + Board.BoardSize + ".\nX: ");
                    int y;
                    Console.Write("Y: ");
                    while (!int.TryParse(Console.ReadLine(), out y) || y < 1 || y > Board.BoardSize)
                        Console.Write("Please enter a valid Y coordinate between 1 and " + Board.BoardSize + ".\nY: ");

                    if (_playerBoard.Place(ship))
                        placed = true;
                } while (!placed);
                
            }
        }

    }
}
