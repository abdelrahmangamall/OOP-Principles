using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2.inherite_From_StaffMember.inherite_From_Employee
{
     class SalariedEmployee: Employee
    {
        public double salary;

        public SalariedEmployee(string ssn, double sal,Department d) : base(ssn,d)
        {
            this.salary = sal;
        }

        public override double pay()
        {
           
            return salary;
        }

        public override string ToString()
        {
            return base.ToString()+ $"\nSalary: {salary}";
        }
    }
}
