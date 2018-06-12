using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipConsole
{
    //Represents a ship
    class Ship
    {

        public int Length { get; }
        public bool[] Hits { get; }
        public bool Destroyed { get; private set; }

        public Ship(int length)
        {
            Length = length;
            Hits = new bool[length];
        }

        private bool CheckDestroyed()
        {
            foreach (bool hit in Hits)
            {
                if (!hit)
                    return false;
            }

            Destroyed = true;
            return true;
        }

    }
}
