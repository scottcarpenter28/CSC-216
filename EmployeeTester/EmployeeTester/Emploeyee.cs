using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTester
{
    class Emploeyee
    {
        int id;
        double sallary;
        string fName, lName, doh, jobDes, depart;

        public Emploeyee(int id, string fn, string ln, string doh, string jobDes, string department, double pay)
        {
            this.id = id;
            fName = fn;
            lName = ln;
            this.doh = doh;
            this.jobDes = jobDes;
            depart = department;
            sallary = pay;
        }

     public string GetName()
        {
            return fName + " " + lName;
        }

        public string AlphaName()
        {
            return lName+", "+fName;
        }

        public override string ToString()
        {
            return"Employee id: "+id+" Employee name: "+GetName()+" Date hired: "+doh+" Job description: "+jobDes+" Department: "+depart+" Monthly salary: $"+sallary;
        }

    }
}
