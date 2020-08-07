using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeeTester
{
    class EmployeeTester
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter employee id");
            int id = int.Parse(ReadLine());

            WriteLine("Please enter empoyee's first name");
            string fn = ReadLine();
            WriteLine("Please enter employee's last name");
            string ln =ReadLine();

            WriteLine("Please enter date hire(MM/DD/YY): ");
            string doh = ReadLine();

            WriteLine("Please enter a job description");
            string jobDes = ReadLine();

            WriteLine("Please enter a department");
            string depart = ReadLine();

            WriteLine("Please enter monthy sallary");
            double sal = double.Parse(ReadLine());

             Emploeyee e1 = new Emploeyee(id,fn,ln,doh,jobDes,depart,sal);
            WriteLine(e1.AlphaName());
            WriteLine(e1.GetName());
            WriteLine(e1);
            ReadKey();
        }
    }
}
