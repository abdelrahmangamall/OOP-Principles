using OOP_TASK2;
using OOP_TASK2.inherite_From_StaffMember.inherite_From_Employee;

namespace task2
{
    class program
    {
        public static void Main(string[] args)
        {
          
            Staff staff = new Staff();
            List<Department> department = new List<Department>();
            List<Project> project = new List<Project>();
            
            department.Add(new Department() { DepartmentName = "Human Resources",DepartID =1 });
            department.Add(new Department() { DepartmentName = "Finance", DepartID =2 });




            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Department");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Project");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("1. Add New Department");
                        Console.WriteLine("2. Print All Departments");
                        string deptChoice = Console.ReadLine();
                        if (deptChoice == "1")
                        {
                            Console.Write("Enter Department ID: ");
                            int deptId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Department Name: ");
                            string deptName = Console.ReadLine();
                            department.Add(new Department() { DepartID = deptId, DepartmentName = deptName });
                        }
                        else if (deptChoice == "2")
                        {
                            foreach (var dept in department)
                            {
                                Console.WriteLine(dept.ToString());
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("1. Add New Members");
                        Console.WriteLine("2. Print All Members");
                        Console.WriteLine("3. Calculate Payroll");
                        Console.WriteLine("4. Delete Member");
                        string staffChoice = Console.ReadLine();
                        if (staffChoice == "1")
                        {
                            Console.Write("Enter Member ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Phone: ");
                            string phone = Console.ReadLine();
                            Console.Write("Enter Email: ");
                            string email = Console.ReadLine();
                            Console.Write("Enter Department ID: ");
                            int departmentId = int.Parse(Console.ReadLine());

                            Department dep = department.FirstOrDefault(d => d.DepartID == departmentId);
                            //  staff.addMember();

                            Console.Write("Enter Member Type (Employee/Volunteer): ");
                            string memberType = Console.ReadLine();

                            if (memberType.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write("Enter SSN: ");
                                string ssn = Console.ReadLine();
                                Console.Write("Enter Salary (for Salaried) or Hourly Rate (for Hourly): ");
                                double salaryOrRate = double.Parse(Console.ReadLine());
                                Console.Write("Is this an Hourly Employee? (yes/no): ");
                                bool isHourly = Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);

                                if (isHourly)
                                {
                                    Console.Write("Enter Hours Worked: ");
                                    double hoursWorked = double.Parse(Console.ReadLine());
                                    staff.addMember(new HourlyEmployee(hoursWorked, salaryOrRate, ssn, dep) { EmploeeID = id, Name = name, Phone = phone, Email = email, });
                                }
                                else
                                {
                                    staff.addMember(new SalariedEmployee(ssn, salaryOrRate, dep) { EmploeeID = id, Name = name, Phone = phone });
                                }
                            }
                            else if (memberType.Equals("Volunteer", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write("Enter Amount: ");
                                double amount = double.Parse(Console.ReadLine());
                                staff.addMember(new Volunteer(amount, dep) { EmploeeID = id, Name = name, Phone = phone,Email= email,d = dep  });
                            }
                        }
                        else if (staffChoice == "2")
                        {
                            staff.ShowAll();
                        }
                        // else if (staffChoice == "3")
                        //{
                        // Console.WriteLine($"Total Payroll: ${staff.CallPayroll():F2}");
                        //}
                        else if (staffChoice == "4")
                        {
                            // Console.Write("Enter Member ID to delete: ");
                            //int memberId = int.Parse(Console.ReadLine());
                            staff.DelMember();
                        }
                        break;

                    case "3":
                        Console.WriteLine("1. Add New Project");
                        Console.WriteLine("2. Print All Projects");
                        string projectChoice = Console.ReadLine();
                        if (projectChoice == "1")
                        {
                            Console.Write("Enter Project ID: ");
                            int projectId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Location: ");
                            string location = Console.ReadLine();
                            Console.Write("Enter Current Cost: ");
                            double currentCost = double.Parse(Console.ReadLine());
                            Console.Write("Enter Manager ID: ");
                            int managerId = int.Parse(Console.ReadLine());
                            Employee manager = staff.Search(managerId.ToString()).FirstOrDefault() as Employee;

                            Project pr = new Project(manager) { ProjectID = projectId, Location = location, CurrentCost = currentCost };
                            project.Add(pr);
                        }
                        else if (projectChoice == "2")
                        {
                            foreach (var p in project)
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            }

        }
    }
}