using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASKS
{
    public class Address : Parent 
    {
        private string place;


        public string Place { get {return place; } set {place = value; } }

        public Address(string place, string type, string description):base()
        {
            this.Place = place;
            base.Type = type;
            base.Description = description;
        }
        public override string getfullAtt()
        {
            return $"{Type}: {place}, Description: {Description}";
        }
    }
}
