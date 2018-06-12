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
        private Board myBoard = new Board();
        private Board guessBoard = new Board();

        public Player(string name){ Name = name; }

    }
}
