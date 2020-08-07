using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace OtheloGame
{ 
    class Othelo
    {
        static void Main(string[] args)
        {
            /*GameBoard b = new GameBoard();
            b.GameStatus();
            WriteLine(b);
            int player = 1;
            while (!b.GameStatus())
            {
                WriteLine("Curents player's turn: " + player + ".\nPlease enter a row: ");
                int col = int.Parse(ReadLine().ToString());
                WriteLine("Please enter coloumn");
                int row = int.Parse(ReadLine().ToString());
                if (b.IsValid(row, col, player))
                {
                    //Clear();
                    WriteLine(b);
                    if (player == 1)
                        player = 2;
                    else
                        player = 1;
                    b.GameStatus();
                }
                else
                {
                    //Clear();
                    WriteLine(b);
                    WriteLine("Invalid move\n");
                }
            }
            WriteLine("Game over");
            ReadKey();*/
            WriteLine(25%13);
            ReadKey();
        }
    }
}
