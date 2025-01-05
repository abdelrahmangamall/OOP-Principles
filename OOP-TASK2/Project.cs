using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK2
{
    public class Project
    {
        private int projectId;
		public int ProjectID
		{
			get { return projectId; }
			set { projectId = value; }
		}
		private string location;
		public string Location
		{
			get { return location; }
			set { location = value; }
		}
		private double currentCost;
        public double CurrentCost
		{
			get { return currentCost; }
			set { currentCost = value; }
		}


		private  Employee manager;
		private List<Budget> budgetList = new List<Budget>();
        public Project(Employee manage)
        {
			manager = manage;
			budgetList = new List<Budget>();
        }
         
        public void addBudget(Budget budget)
		{
			budgetList.Add(budget);
		}

		public void getTotalBudget(Budget budget) 
		{
			 budgetList.Sum(b=> b.Value);
		}
        public override string ToString()
        {
         string budgetInfo =
		 string.Join(", ", budgetList.Select(b => $"Budget ID: {b.ID}, Value: {b.Value}"));
            return $"Project ID: {ProjectID}, Location: {Location}," +
				$" Current Cost: {CurrentCost}," +
				$" Budgets: [{budgetInfo}]";
        }

    }
}
