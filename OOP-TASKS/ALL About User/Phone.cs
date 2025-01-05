using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASKS
{
    public class Phone : Parent
    {
        private string phone;
       
        public string PHone { get { return phone; } set { phone = value; } }
       
        public Phone(string phone, string type, string description):base()
        {
            this.phone = phone;
            base.Type = type;
            base.Description = description;
        }
        public override string getfullAtt()
        {
            return  $"{Type}: {phone}, Description: {Description}";
        }
    }
}
