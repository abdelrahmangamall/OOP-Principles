using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2.inherite_From_StaffMember.inherite_From_Employee.inherite_From_SalEmployee
{
    internal class ExecutiveEmployee : SalariedEmployee 
    {
        private double bonus;

        public ExecutiveEmployee(string ssn, double sal , double bonus, Department d) : base(ssn, sal,d)
        {
            this.bonus = bonus;
        }

        public void addBonus(double moreBonus)
        {
            bonus += moreBonus; 
        }
        public override double pay()
        {
            return salary+bonus;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBonus: {bonus}";

        }
    }
}
