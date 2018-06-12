using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipConsole
{
    class Board
    {

        private const int BoardSize = 10;
        private char[,] _board = new char[BoardSize, BoardSize];

        public Board()
        {
            FillBoard();
        }

        //Set the default value of the board
        private void FillBoard()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    _board[i, j] = '-';
                }
            }
            
        }

        //Draw the board
        public void Draw()
        {
            //Method to get the top row of the board
            string TopRow()
            {
                var builder = new StringBuilder("  ");

                for (int i = 0; i < BoardSize; i++)
                {
                    builder.Append($"{i + 1,2}");
                }

                return builder.ToString();
            }

            Console.WriteLine(TopRow());
            for (int i = 0; i < BoardSize; i++)
            {
                Console.WriteLine($"{i+1, 2}");
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write('|');
                    Console.Write(_board[i, j]);
                }
                Console.Write('|');
                Console.WriteLine();
            }

            //Print the bottom of the board.
            Console.Write("  ");
            for (int i = 0; i < BoardSize; i++)
            {
                Console.Write("\u0305\u0305");
            }
            Console.WriteLine("\u0305");
        }

    }
}
