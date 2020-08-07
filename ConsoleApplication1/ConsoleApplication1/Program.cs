using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter2HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 100;
            scores[1] = 65;
            scores[2] = 75;
            scores[3] = 83;
            scores[4] = 99;

            WriteLine("Class grades are:");
            double classAve = 0.0;
            for (int i = 0; i < scores.Length; i++)
            {
                WriteLine(scores[i]+"%");
                classAve += scores[i];
            }
            classAve = classAve / 5.00;
            WriteLine("Class average is: ");
            WriteLine("{0:F2}%", classAve);
            WriteLine("Value = "+"{ 0:N0}", 12345.9032);
            ReadKey();

        }
    }
}
