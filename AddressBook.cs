using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Email { get; set; }
        public AddressBook()
        {
            Email = new Dictionary<string, Contact>();

        }

        public void AddContact(Contact contact)
        {
            try
            {
                Email.Add(contact.Email, contact);
            }

            catch
            {
                Console.WriteLine($"Contact {contact.FullName()} already exists.");
            }
        }



        public Contact GetByEmail(string email)
        {
            Email.TryGetValue(email, out Contact contact);
            return contact;
        }
    }
}