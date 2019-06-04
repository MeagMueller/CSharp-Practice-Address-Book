using System;
using System.Collections.Generic;

namespace address_book {

    public class AddressBook {
        public Dictionary<string, Contact> Contacts { get; set; } = new Dictionary<string, Contact>();

         public void AddContact(Contact Contact) {
            Contacts.Add(Contact.Email, Contact);
        }

        public Contact GetByEmail(string email) {
            return Contacts[email];
        }

        
    }
}