﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookAssignment
{
    public class MultipleAddressBook
    {
        Dictionary<string, AddressBook> collectionAddressBook = new Dictionary<string, AddressBook>();

        public void AddAddressBook(string firstName)
        {
            AddressBook newAddressBook = new AddressBook();
            collectionAddressBook.Add(firstName, newAddressBook);
        }

        public AddressBook GetAddressBook(string firstName)
        {
            if (collectionAddressBook.ContainsKey(firstName))
            {
                return collectionAddressBook[firstName];
            }
            return null;
        }
    }
}
