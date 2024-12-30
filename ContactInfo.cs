using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactList
{
    public class ContactInfo
    {
        public string Name {get; set;}
        public string Phonenumber {get; set;}
        public string Email {get; set;}

        public ContactInfo(string name,string phoneNumber,string email)
    {
        Name = name;
        Phonenumber = phoneNumber;
        Email = email;
    }

        public override string ToString()
        {
            return $"Name :{Name} , Telephone: {Phonenumber}, Email: {Email}";
        }
    }
    
    
}