using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2
{
    public class Employee : StaffMember
    {
       
        protected string socialSecurityNumber;

        public string SSN { get {return socialSecurityNumber;}}
        public Employee(string ssn,Department department):base()
        {

            socialSecurityNumber = ssn;
        }

        public override double pay()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() +$"\nSSN: {socialSecurityNumber}";
        }
    }
}
