using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal interface IEmpoyee
    {
        string firstname { get; set; }
        string lastname { get; set; }
        string jobtitle { get; set; }
        string department { get; set; }
        double basicsalary { get; set; }
        void computeSalary(int hoursWorked, double ratePerHour);
    }
}
