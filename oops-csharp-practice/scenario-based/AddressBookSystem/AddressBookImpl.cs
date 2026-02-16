using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBookImpl : IAddressBook
    {
        private Contact[] contacts = new Contact[50];
        private int count = 0;

        public string Name;

        public AddressBookImpl(string name)
        {
            Name = name;
        }

        // UC-2 Add Contact
        public void AddContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is Full\n");
                return;
            }

            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine() ?? "";

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine() ?? "";

            // Duplicate check
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName == contact.FirstName &&
                    contacts[i].LastName == contact.LastName)
                {
                    Console.WriteLine("Duplicate Contact Found\n");
                    return;
                }
            }

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine() ?? "";

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine() ?? "";

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine() ?? "";

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine() ?? "";

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine() ?? "";

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine() ?? "";

            contacts[count++] = contact;

            Console.WriteLine("Contact Added Successfully\n");
        }

        // UC-3 Edit Contact
        public void EditContact()
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine() ?? "";

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName == name)
                {
                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine() ?? "";
                    Console.WriteLine("Contact Updated\n");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found\n");
        }

        // UC-4 Delete Contact
        public void DeleteContact()
        {
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine() ?? "";

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName == name)
                {
                    for (int j = i; j < count - 1; j++)
                        contacts[j] = contacts[j + 1];

                    contacts[--count] = null!;
                    Console.WriteLine("Contact Deleted\n");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found\n");
        }

        // UC-5 Add Multiple Contacts
        public void AddMultipleContactsMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Add New Contact");
                Console.WriteLine("0. Go Back");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                    AddContact();

            } while (choice != 0);
        }

        // UC-8 Search By City
        public void SearchByCity(string city)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City == city)
                    Console.WriteLine($"{contacts[i].FirstName} {contacts[i].LastName} | {Name}");
            }
        }

        // UC-8 Search By State
        public void SearchByState(string state)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].State == state)
                    Console.WriteLine($"{contacts[i].FirstName} {contacts[i].LastName} | {Name}");
            }
        }

        // UC-9 Add To City-State Map
        public void AddToCityStateMap(
            string[] cityNames, string[] cityPersons, ref int cityCount,
            string[] stateNames, string[] statePersons, ref int stateCount)
        {
            for (int i = 0; i < count; i++)
            {
                cityNames[cityCount] = contacts[i].City;
                cityPersons[cityCount] = contacts[i].FirstName + " " + contacts[i].LastName;
                cityCount++;

                stateNames[stateCount] = contacts[i].State;
                statePersons[stateCount] = contacts[i].FirstName + " " + contacts[i].LastName;
                stateCount++;
            }
        }

        // UC-10 Count By City
        public int GetCountByCity(string city)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City == city)
                    total++;
            }
            return total;
        }

        // UC-10 Count By State
        public int GetCountByState(string state)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].State == state)
                    total++;
            }
            return total;
        }

        // ===============================
        // UC-12 Sort By Name
        // ===============================
        public void SortContactsByName()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].FirstName, contacts[j + 1].FirstName) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nContacts Sorted By Name\n");
        }

        // Sort By City
        public void SortContactsByCity()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].City, contacts[j + 1].City) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nContacts Sorted By City\n");
        }

        // Sort By State
        public void SortContactsByState()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].State, contacts[j + 1].State) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nContacts Sorted By State\n");
        }

        // Sort By Zip
        public void SortContactsByZip()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].Zip, contacts[j + 1].Zip) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nContacts Sorted By Zip\n");
        }
    }
}
