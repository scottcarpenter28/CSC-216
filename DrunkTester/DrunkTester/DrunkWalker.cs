using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DrunkTester
{
    class DrunkWalker
    {
        private char[,] island = new char[10, 10];
        private int rPos, cPos;
        private int stager = 0;
        private Random rnd;

        public DrunkWalker()
        {
            rnd = new Random();
            MakeIsland();
        }

        public void MakeIsland()
        {
            //fills array with +'s
            for (int r = 0; r < island.GetLength(0); r++)
            {
                for (int c = 0; c < island.GetLength(1); c++)
                    island[r, c] = '+';
            }

            //places letters in first row
            for (int c = 0; c < island.GetLength(1); c++)
            {
                int random = rnd.Next(0, 3);
                if (random < 2)
                    island[0, c] = 'W';
                else
                    island[0, c] = 'B';

                // Debug WriteLine("inputing first row "+ random); 
            }

            //places bottom row
            for (int c = 0; c < island.GetLength(1); c++)
            {
                int random = rnd.Next(0, 3);
                if (random < 2)
                    island[island.GetLength(0)-1,c] = 'W';
                else
                    island[island.GetLength(0)-1, c] = 'B';

               // Debug WriteLine("inputing last row "+ random);
            }

            //left side
            for (int r = 0; r < island.GetLength(0); r++)
            {
                int random = rnd.Next(0, 3);
                if (random < 3)
                    island[r, 0] = 'W';
                else
                    island[r, 0] = 'B';

              // Debug  WriteLine("inputing left side "+ random);
            }

            //right side
            for (int r = 0; r < island.GetLength(0); r++)
            {
                int random = rnd.Next(0, 2);
                if (random < 3)
                    island[r, island.GetLength(1)-1] = 'W';
                else
                    island[r, island.GetLength(1)-1] = 'B';

                // Debug  WriteLine("inputing right side "+ random);
            }

            //place the drunk
            int row = island.GetLength(0) / 2;
            rPos = row;
            int col = island.GetLength(1) / 2;
            cPos = col;
            island[row, col] = 'D';

        }

        public string DrunkWalk()
        {
            stager++;
            GetDirection();

            //Drunks status, ends recursion
            if (IsDeadOrAlive() == "Dead by drowning" || IsDeadOrAlive() == "Dead by stagering")
                return IsDeadOrAlive();
            else if (IsDeadOrAlive() == "Found a bridge")
                return IsDeadOrAlive();
            //Recusrsion
            else
            {
                island[rPos, cPos] = 'D';
                ToString();
                return DrunkWalk();
            }
        }

        public void GetDirection()
        {
            //Moves the drunks posistion. *NOTE* All movement is inverted
            int direction = rnd.Next(1,4);   
            //move up
            if(direction==1)
            {
                island[rPos, cPos] = '+';
                rPos++;
            }

            //move right
            else if(direction==2)
            {
                island[rPos, cPos] = '+';
                cPos++;
            }

            //move down
            else if (direction == 3)
            {
                island[rPos, cPos] = '+';
                rPos--;
            }

            //move left
            else
            {
                island[rPos, cPos] = '+';
                cPos--;
            }
        }

        public String IsDeadOrAlive()
        {
            //post: returns the statement of the drunk
            if (island[rPos, cPos] == 'W')
                return "Dead by drowning";
            else if (stager > 10)
                return "Dead by stagering";
            else if (island[rPos, cPos] == 'B')
                return "Found a bridge";
            else
                return "";
        }

        public void Reset()
        {
            stager = 0;
            
            //place the drunk
            int row = island.GetLength(0) / 2;
            rPos = row;
            int col = island.GetLength(1) / 2;
            cPos = col;
            island[row, col] = 'D';

        }

        public override String ToString()
        {
            string s = "";
            for (int r = 0; r < island.GetLength(0); r++)
            {
                for (int c = 0; c < island.GetLength(1); c++)
                    s += island[r, c].ToString()+"\t";
                s += "\n\n";
            }
            return s;
        }
    }
}
