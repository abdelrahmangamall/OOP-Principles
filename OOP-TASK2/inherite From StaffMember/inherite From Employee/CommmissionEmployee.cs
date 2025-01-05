using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2.inherite_From_StaffMember.inherite_From_Employee
{
     sealed class CommisionEmployee : Employee
    {
        public double target;
       // public double CommissionRate { get; private set; } = 0.05; 

        public CommisionEmployee(string ssn,double target, Department d) : base(ssn,d)
        {
            this.target = target;
        }

        public override double pay()
        {
            return (target*(0.05*target));
        }

        public override string ToString()
        {
            return base.ToString()+$"Commission or your target: {pay()}" ;
        }
    }
}
