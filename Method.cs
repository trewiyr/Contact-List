namespace ContactList 
{
    public class Method
    {
        public static Dictionary<string,ContactInfo> contacts = new Dictionary< string,ContactInfo>();
        private static string ?phoneNumber;
        private static string ?email;
        public static void AddContact(Dictionary<string,ContactInfo> contacts)
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine()!;
            
            if(contacts.ContainsKey(name))
            {
                Console.WriteLine("Contact Already Exists!");
                return;
            }

            Console.WriteLine("Enter PhoneNumber");
            phoneNumber = Console.ReadLine()!;

            Console.WriteLine("Enter Email");
            email = Console.ReadLine()!; 
             
             contacts[name] = new ContactInfo(name,phoneNumber,email);
             Console.WriteLine("Contact added sucessfully!");
        }

        public static void RemoveContact()
        {
            Console.WriteLine("Enter Contact name to delete");
            string name = Console.ReadLine()!;
            if(contacts.Remove(name))
            {
                Console.WriteLine("Contact deleted succesfully!");
            }
            else
            {
                Console.WriteLine("Contact does not exist!");
            }
        }

        public static void SearchContact()
        {
            Console.WriteLine("Ener a contact to search");
            string name = Console.ReadLine()!;

            if(contacts.TryGetValue(name,out var value))
            {
                Console.WriteLine(value.ToString()!);
            }
        }

        public static void ListAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No Contacts found!");
            }
            else
            {
                Console.WriteLine("\n------Contact List------");
                foreach (var name in contacts.Values)
                {
                    Console.WriteLine(name.ToString()!);
                }

            }
        }

        public static void UpdateDetails()
        {
            
            string newphoneNumber;
            string newemail;
            Console.WriteLine("Enter name of Contact to edit information");
            string name = Console.ReadLine()!;

            if(contacts.ContainsKey(name))
           {
            Console.WriteLine($""""
            what will you like to edit
            1.PhoneNumber
            2.Email
            3.PhoneNumber and Email
            (Select no. 1 ,2 or 3)
            """");
            int choice = int.Parse(Console.ReadLine()!);

            switch(choice)
            {
                case 3:
                Console.WriteLine("Enter PhoneNumber");
                newphoneNumber = Console.ReadLine()!;
                Console.WriteLine("Enter Email");
                newemail = Console.ReadLine()!;
                contacts[name] = new ContactInfo(name, newphoneNumber, newemail);
                Console.WriteLine("Done!");
                break;
                case 1:
                Console.WriteLine("Enter PhoneNumber");
                newphoneNumber = Console.ReadLine()!;
                contacts[name] = new ContactInfo(name, newphoneNumber, email!);
                Console.WriteLine("Done!");
                break;
                case 2:
                Console.WriteLine("Enter Email");
                newemail = Console.ReadLine()!;
                contacts[name] = new ContactInfo(name, phoneNumber!, newemail);
                Console.WriteLine("Done!");
                break;
                default:
                Console.WriteLine("Invalid option");
                break;
            }

            }
            else
            {
                Console.WriteLine("Name not found!");
            }
        }

        
    }
}