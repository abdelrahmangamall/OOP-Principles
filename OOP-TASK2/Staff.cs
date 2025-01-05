using System.Text;

namespace OOP_TASK2
{
    public class Staff
    {
        private List<StaffMember> staffList = new List<StaffMember>();


        public void calcPayroll()
        {

        }
        public void addMember(StaffMember member)
        {
            staffList.Add(member);
            //StaffMember staffMember = new StaffMember();
            //Console.Write("add an id:");
            //staffMember.EmploeeID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("add your name:");
            //staffMember.Name = Console.ReadLine();
            //Console.Write("add your phone number:");
            //staffMember.Phone = Console.ReadLine();
            //Console.Write("add your email:");
            //staffMember.Email = Console.ReadLine();
            //Console.Write("add your Department ID:");
            //staffMember.department.DepartID = Convert.ToInt32(Console.ReadLine());
            //Console.Write("add your Department Name:");
            //staffMember.department.DepartmentName = Console.ReadLine();
            //staffList.Add( staffMember);
            //Console.WriteLine("\nwelcome, You are added");
            //Console.WriteLine("there is your information.....");
            //Console.WriteLine(staffMember.ToString());
        }
        public void DelMember()
        {
            Console.Write("Enter ID of member wnat to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            List<StaffMember> mem =new List<StaffMember>(staffList);
             foreach (var member in mem)
             {
                 if (id == member.EmploeeID)
                 {
                     staffList.Remove(member);
                     Console.WriteLine("member deleted");
                 }
                 else Console.WriteLine("NA member ID...");
             }
        }
        
         public int Count => staffList.Count;

    public List<StaffMember> Search(string searchTerm)
    {
        return staffList.Where(m => m.EmploeeID.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                  m.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
    }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var member in staffList)
            {
               
                    sb.AppendLine($"Employe ID:    {member.EmploeeID}");
                    sb.AppendLine($"Employe Name:  {member.Name}");
                    sb.AppendLine($"Employe Phone: {member.Phone}");
                    sb.AppendLine($"Employe Email: {member.Email}\n");
                    sb.AppendLine( member.d.ToString());
            }
            return sb.ToString();
        }
        public void ShowAll()
        {
            foreach (var member in staffList)
            {
                Console.WriteLine(member.ToString());
            }
        }

    }
}
