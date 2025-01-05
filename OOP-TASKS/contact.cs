using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASKS
{
    public class contact
    {
        private int count=0;
        List<User> userInfo = new List<User>();
        public contact() { }

        public void AddUser()
        {

            Console.Write("Enter your first name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            DateTime addedDate = DateTime.Now;
            int id = userInfo.Count + 1;
            User newUser = new User(id, fname, lname, gender, city, addedDate);

            Console.WriteLine("Would you like to add an email? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Type:");
                string Type = Console.ReadLine();
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                Console.Write("Enter Description: ");
                string des = Console.ReadLine();
                Email em = new Email(email,des,Type );
                newUser.addEmails(em);
            }

            Console.WriteLine("Would you like to add a phone number? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Type:");
                string Type = Console.ReadLine();
                Console.Write("Enter Phone Number: ");
                string phone = Console.ReadLine();
                Console.Write("Enter Description: ");
                string des = Console.ReadLine();
                Phone ph = new Phone(phone, Type, des);
                newUser.addPhones(ph);
            }

            Console.WriteLine("Would you like to add an address? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Type:");
                string Type = Console.ReadLine();
                Console.Write("Enter Address: ");
                string add = Console.ReadLine();
                Console.Write("Enter Description: ");
                string des = Console.ReadLine();
                Address ad = new Address(add, Type, des);
                newUser.addAddress(ad);
            }

            // Add the new user to the list
            userInfo.Add(newUser);

            // Output the details of the new user
            Console.WriteLine("\nUser added successfully!");
            Console.WriteLine(newUser.ToString());
        }

        public void editUser()
        {

            Console.Write("Enter You Id: ");
            int id =Convert.ToInt32( Console.ReadLine());
            foreach (var i in userInfo)
            {
                if (id == i.Id)
                {
                    Console.WriteLine("update your name...");
                    i.Fname = Console.ReadLine();
                }
                else Console.WriteLine("Invailed ID");

            }
        }

        public void deleteUser()
        {
            Console.Write("Enter User ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            User userToDelete = userInfo.Find(u => u.Id == id);

            if (userToDelete != null)
            {
                userInfo.Remove(userToDelete);
                Console.WriteLine("User deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid ID. No user found.");
            }

        }

        public int CountUsers()
        {
            return userInfo.Count;
        }
        public void ShowAllUsers()
        {
            if (userInfo.Count == 0)
            {
                Console.WriteLine("No users found.");
                return;
            }

            foreach (var user in userInfo)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public void displayAllServices()
        {
            Console.WriteLine("===================== CRUD =========================");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Update User");
            Console.WriteLine("3. Delete User");
            Console.WriteLine("4. Display all User");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                AddUser();

            }
            else if (choice == 2)
            {
                editUser();
            }
            else if (choice == 3)
            {
                deleteUser();
            }
            else if (choice == 4)
            {
                ShowAllUsers();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine("=============================================");
        }
    }
}
