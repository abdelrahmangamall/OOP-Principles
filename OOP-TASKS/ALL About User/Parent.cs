using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASKS
{
    public abstract class Parent
    {
        private string type;
        private string description;

        public string Type 
        { 
            get {return type; }
            set { type = value;}
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
       public abstract string getfullAtt();
    }

}
