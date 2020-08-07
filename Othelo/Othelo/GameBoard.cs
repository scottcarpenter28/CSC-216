using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OtheloGame
{
    class GameBoard
    {
        char[,] board = new char[8, 8];
        int XChips, OChips;


        public GameBoard()
        {
            FillBoard();
        }


        public void FillBoard()
        {
            //fills the board 
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if ((r == 3 || r == 4) && (c == 3 || c == 4))
                    {
                        //fills start
                        if (r == 3 && c == 3)
                            board[r, c] = 'X';
                        else if (r == 3 && c == 4)
                            board[r, c] = 'O';
                        else if (r == 4 && c == 3)
                            board[r, c] = 'O';
                        else if (r == 4 && c == 4)
                            board[r, c] = 'X';
                    }
                    //fills empty spots with +
                    else
                        board[r, c] = '+';
                }
            }
        }


        public Boolean GameStatus()
        {
            int XCounter = 0, OCounter = 0, PCounter = 0;
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    //count the chips
                    if (board[r, c] == 'X')
                        XCounter++;
                    else if (board[r, c] == 'O')
                        OCounter++;
                    //if it gets to the else, game board is not full and game continues
                    else if (board[r, c] == '+')
                        PCounter++;
                }
            }
            XChips = XCounter;
            OChips = OCounter;
            if (PCounter>0)
                return false;


            //If the game board is full, game is over
            else
                return true;
        }


        public Boolean IsValid(int row, int col, int player)
        {
            row--;//takes one off row to align in matrix
            col--;//takes one off col to align in matrix
            if ((row > board.GetLength(0) || row < 1) || (col > board.GetLength(1) || col < 1))// Checks to see if player is in bounds
            {
                WriteLine("Out of bounds");
                return false;
            }
            else
                return PlaceChips(row, col, player);
        }


        public Boolean PlaceChips(int row, int col, int p)
        {
            Boolean bUpdate = false;
            char[,] initialBoard = board;
            char player,oppPlayer;
            //sets the player variable equal to which player is playing, X for p1, O for p2
            if (p == 1)
            {
                player = 'X';
                oppPlayer = 'O';
            }
            else
            {
                player = 'O';
                oppPlayer = 'X';
            }

            char[,] tmpBoard = board;//temporary matrix

            if (board[row, col] == '+')//checks to see if it can place the players chip, if it can not, returns false
                tmpBoard[row, col] = player;
            else
            {
                WriteLine("Could not place chip! Make sure it is not another chip.");
                return false;
            }

            //checks the same row
            int firstPos=-1,lastPos=-2;
            for(int r=0;r<board.GetLength(0);r++)
            {
                if (board[r, col] == player && firstPos == -1)//Checks to see if first posistion  has been found
                    firstPos = r;
                else if (firstPos >= 0 && board[r, col] == player && lastPos == -2) //If  last posistion was found 
                    lastPos = r;
                else if (firstPos >= 0 && board[r, col] == oppPlayer)//Checks  to see if players chips can be over turned
                    tmpBoard[r, col] = player;
                if ((firstPos == -1 || lastPos == -2) && r + 1 > board.GetLength(0))//If it fails to find another of the players chips, the tmpBoard is reset
                    tmpBoard = board;
                else if ((firstPos >= 0 && lastPos >= 0) && r + 1 > board.GetLength(0))//If at the end of loop and chips have been placed, update game board
                {
                    bUpdate = true;
                    board = tmpBoard;
                }
            }

            //Checks the same column
            firstPos = -1; lastPos = -2;
            tmpBoard[row, col] = player;
            for (int c = 0; c < board.GetLength(1); c++)
            {
                if (board[row, c] == player && firstPos == -1)//Checks to see if first posistion  has been found
                    firstPos = c;
                else if (firstPos >= 0 && board[row, c] == player && lastPos == -2) //If  last posistion was found 
                    lastPos = c;
                else if (firstPos >= 0 && board[row, c] == oppPlayer)//Checks  to see if players chips can be over turned
                    tmpBoard[row, c] = player;
                if ((firstPos == -1 || lastPos == -2) && c + 1 > board.GetLength(1))//If it fails to find another of the players chips, the tmpBoard is reset
                    tmpBoard = board;
                else if ((firstPos <= 0 && lastPos >= 0) && c + 1 > board.GetLength(1))//If at the end of loop and chips have been placed, update game board
                {
                    bUpdate = true;
                    board = tmpBoard;
                }
            }

            //finds starting point
            firstPos = -1; lastPos = -2;
            tmpBoard[row, col] = player;
            int cStart = col;//sets the starting point of the column
            int rStart = row;//sets starting posistion of the row
            while (cStart >0 && rStart>0)
            {
                cStart--;
                rStart--;
            }


            //Checks diagnol down and right
            while (rStart<board.GetLength(0) && cStart<board.GetLength(1))
            {
                if (board[rStart, cStart] == player && firstPos == -1)//Checks to see if first posistion  has been found
                    firstPos = cStart;
                else if (firstPos >= 0 && board[rStart, cStart] == player && lastPos == -2) //If  last posistion was found 
                    lastPos = cStart;
                else if (firstPos >= 0 && board[rStart, cStart] == oppPlayer)//Checks  to see if players chips can be over turned
                    tmpBoard[rStart, cStart] = player;
                if ((firstPos == -1 || lastPos == -2) && (cStart + 1 > board.GetLength(1) || rStart + 1 > board.GetLength(0)))//If it fails to find another of the players chips, the tmpBoard is reset
                    tmpBoard = board;
                else if ((firstPos <= 0 && lastPos >= 0) && (cStart + 1 > board.GetLength(1) || rStart + 1 > board.GetLength(0)))//If at the end of loop and chips have been placed, update game board
                {
                    bUpdate = true;
                    board = tmpBoard;
                }
                cStart++;
                rStart++;
            }

            //finds starting point
            cStart = col;//sets the starting point of the column
            rStart = row;//sets starting posistion of the row
            while (cStart<=0 && rStart<board.GetLength(0))
            {
                cStart--;
                rStart++;
            }
            //checks up and to the right from the bottom
            firstPos = -1; lastPos = -2;
            while (rStart < board.GetLength(0) && cStart < board.GetLength(1))
            {
                if (board[rStart, cStart] == player && firstPos == -1)//Checks to see if first posistion  has been found
                    firstPos = cStart;
                else if (firstPos >= 0 && board[rStart, cStart] == player && lastPos == -2) //If  last posistion was found 
                    lastPos = cStart;
                else if (firstPos >= 0 && board[rStart, cStart] == oppPlayer)//Checks  to see if players chips can be over turned
                    tmpBoard[rStart, cStart] = player;
                if ((firstPos == -1 || lastPos == -2) && (cStart + 1 > board.GetLength(1) || rStart + 1 > board.GetLength(0)))//If it fails to find another of the players chips, the tmpBoard is reset
                    tmpBoard = board;
                else if ((firstPos <= 0 && lastPos >= 0) && (cStart + 1 > board.GetLength(1) || rStart + 1 > board.GetLength(0)))//If at the end of loop and chips have been placed, update game board
                {
                    bUpdate = true;
                    board = tmpBoard;
                }
                rStart++;
                cStart--;
            }

            if(bUpdate)//if the board is updated
                return false;
            else//board fails to update
                return true;
        }


        public override String ToString()
        {
            String s = "\t1\t2\t3\t4\t5\t6\t7\t8\n_________________________________________________________________________\n";
            for (int r = 0; r < board.GetLength(0); r++)
            {
                s += "|\t";
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    s += board[r, c].ToString();
                    if((c+1)<board.GetLength(1))
                        s+="\t";
                }
                s += "\t|"+(r+1)+"\n|\t\t\t\t\t\t\t\t\t|\n";
            }
            return s+ "_________________________________________________________________________\n" + "\nX chips: " + XChips + "\nO chips: " + OChips;
        }
    }
}