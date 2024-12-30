using ContactList;

bool running = true;

while (running)
{
    Console.WriteLine("\n------Contacts Manager------");
    Console.WriteLine(""""
    1.Add Contact
    2.Remove Contact
    3.Search Contact
    4.List all Contacts
    5.Edit Contact
    6.Exit Application
    """");
    Console.WriteLine("");
    Console.WriteLine("Choose an option");
    int choice = int.Parse(Console.ReadLine()!);
    
    switch(choice)
    {
        case 1:
        Method.AddContact(Method.contacts);
        break;
        case 2:
        Method.RemoveContact();
        break;
        case 3:
        Method.SearchContact();
        break;
        case 4:
        Method.ListAllContacts();
        break;
        case 5:
        Method.UpdateDetails();
        break;
        case 6:
        running = false;
        break;

        default:
        Console.WriteLine("Invalid option!,Try again.");
        break;
    }

}