using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee: IEmpoyee
    {
        private string fname;
        private string lname;
        private string jobt;
        private string dept;
        private double salary;

        public PartTimeEmployee(string fn, string ln, string dep, string jt,int hw,double rph)
        {
            fname = fn;
            lname = ln;
            jobt = jt;
            dept = dep;
            computeSalary(hw, rph);
        }

        public string firstname{
            get { return fname; }
            set { fname = value; }
        }
        public string lastname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string jobtitle
        {
            get { return jobt; }
            set { jobt = value; }
        }
        public double basicsalary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string department
        {
            get { return dept; }
            set { dept = value; }
        }
        public void computeSalary(int hoursWorked, double ratePerHour) {
            salary = hoursWorked * ratePerHour;
        }
        public double getSalary() { 
            return salary;
        }


    }
}
