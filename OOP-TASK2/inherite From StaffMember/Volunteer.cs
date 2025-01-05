using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2
{
    class Volunteer : StaffMember
    {
        private double amount;

        public double Amount { get { return amount; } }
        public Volunteer(double amount,Department d):base()
        {
            d = new Department();
            this.amount = amount;   
        }
        public override string ToString()
        {
            return base.ToString()+ $"\nvolunter amount: {amount}";
        }
        public override double pay()
        {
            return amount;
        }
    }
}
