using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASKS
{
    public class User
    {                               
       private int id       ;
       private string fname ;
       private string lname ;
       private string gender;
       private string city  ;
       private DateTime addedDate;

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime AddedDate { get; set; }

        private List<Email> emails;
        private List<Phone> phones;
        private List<Address> addresses;

        public User(int id, string fname, string lname, string gender,
            string city, DateTime addedDate)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.city = city;
            this.addedDate = addedDate;
            addresses = new List<Address>();
            phones = new List<Phone>();
            emails = new List<Email>();
        }
        public void addAddress(Address address) => addresses.Add(address);
        public void addPhones(Phone phone) => phones.Add(phone);
        public void addEmails(Email email) => emails.Add(email);
        public List<User> search(List<User> users, string query)
        {

         return users.Where
             (            
                user =>
                user.fname.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                user.lname.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                user.gender.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                user.city.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                phones.Any(p => p.PHone.Contains(query) || p.Description.Contains(query) || p.Type.Contains(query)) ||
                emails.Any(p => p.EMail.Contains(query) || p.Description.Contains(query) || p.Type.Contains(query)) ||
                addresses.Any(p => p.Place.Contains(query) || p.Description.Contains(query) || p.Type.Contains(query))
             ).ToList();  
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {id}");
            sb.AppendLine($"Name: {fname} {lname}");
            sb.AppendLine($"Gender: {gender}");
            sb.AppendLine($"City: {city}");
            sb.AppendLine($"Added Date: {AddedDate.ToShortDateString()}");
            sb.AppendLine("==========================");
            sb.AppendLine("ADDRESSES.......");
            foreach (var add in addresses)
            {
                sb.AppendLine(add.getfullAtt());
            }
            sb.AppendLine("==========================");
            sb.AppendLine("PHONE NUMBERS......");
            foreach (var phone in phones)
            {
                sb.AppendLine(phone.getfullAtt());
            }
            sb.AppendLine("==========================");
            sb.AppendLine("Emails........");
            foreach (var email in emails)
            {
                sb.AppendLine(email.getfullAtt());
            }

            return sb.ToString();

        }
    }

}
