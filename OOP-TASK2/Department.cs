using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2
{
    public class Department
    {

      private int departID;
      private string departName;

     public int DepartID { get {return departID ;} set{departID= value; } }
     public string DepartmentName { get {return departName ;} set {departName = value ;} }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Department Id: {departID}");
            sb.AppendLine($"Department Name: {departName}");
            return sb.ToString();
        }
    }
}
