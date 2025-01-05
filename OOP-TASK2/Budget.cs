using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2
{
    public class Budget
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private double val;

		public double Value
		{
			get { return val; }
			set { val = value; }
		}

		public void increasBudget(double amount)
		{
			val *= amount;
		}

	}
}
