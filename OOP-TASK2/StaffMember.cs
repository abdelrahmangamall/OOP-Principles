using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2
{
     public class StaffMember
    {
        protected int employeeID;
        protected string name;    
        protected string phone;   
        protected string email ;
        public int EmploeeID
        {
            get { return employeeID;}
            set { employeeID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Department d = new Department();
        public StaffMember()
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employe ID: {employeeID}");
            sb.AppendLine($"Employe Name: {name}");
            sb.AppendLine($"Employe Phone: {phone}");
            sb.AppendLine($"Employe Email: {email}");
            sb.AppendLine(d.ToString());
            return sb.ToString();
        }
        public virtual double pay() 
        { 
            return 0;
        }
        
    }
}
