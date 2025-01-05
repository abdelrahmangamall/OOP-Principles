using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2.inherite_From_StaffMember.inherite_From_Employee
{
    sealed class HourlyEmployee:Employee
    {
        private double hoursWorked;
        private double hourlyRate;


        public HourlyEmployee(double hoursWorked, double rate,string ssn,Department d):base(ssn,d)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = rate;
        }

        public void addHours(int moreHours)
        {
            hoursWorked += moreHours;   
        }
        public override double pay()
        {
            return hourlyRate*hoursWorked;
        }
        public override string ToString()
        {
            return base.ToString() 
                + $", Hourly Rate: {hourlyRate}, Hours Worked: {hoursWorked}";
        }
    }
}
