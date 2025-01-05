using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASKS
{
    public class Email: Parent
    {
        private string email;
        public string EMail { get { return email; } set { email = value; } }
      
        public Email(string email, string type, string description):base()
        {
            this.email = email;
            base.Type = type;
            base.Description = description;
        }
        public override string getfullAtt()
        {
            return $"{Type}: {email}, Description: {Description}";
        }


    }
}

