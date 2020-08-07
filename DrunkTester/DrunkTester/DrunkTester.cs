using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DrunkTester
{
    class DrunkTester
    {
        static void Main(string[] args)
        {
            int drownCount = 0;
            int stagerCount = 0;
            int aliveCount = 0;
            DrunkWalker dwi = new DrunkWalker();
            WriteLine(dwi);
            for (int i=0; i<50 ; i++)
            {
               String result=dwi.DrunkWalk();
                if (result == "Dead by drowning")
                    drownCount++;
                else if (result == "Dead by stagering")
                    stagerCount++;
                else
                    aliveCount++;
                dwi.Reset();
            }
            WriteLine("The Drunk:\n\t Drowned :\t\t"+drownCount+"\n\t Stagered to death :\t"+ stagerCount+"\n\t Found a Bridge :\t"+aliveCount);
            ReadKey();
        }
    }
}

