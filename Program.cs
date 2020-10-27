﻿using System;
using System.Collections.Generic;

namespace AddressBookAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleAddressBook collectionAddressBook = new MultipleAddressBook();
            AddressBook newAddressBook = new AddressBook();
            bool option1 = true;
            while (option1)
            {
            StartAddressBook:
                Console.WriteLine("Enter your choice: 1. Add adress book, 2.Open address book,3.Exit");
                int option = int.Parse(Console.ReadLine());
                string firstName;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name of contact to be added in address book");
                        firstName = Console.ReadLine();
                        bool duplicateFirstNameCheck = collectionAddressBook.CheckDuplicateFirstName(firstName);
                        if (duplicateFirstNameCheck == false)
                        {
                            Console.WriteLine("Address Book with this fist name already exists");
                            goto StartAddressBook;
                        }
                        collectionAddressBook.AddAddressBook(firstName);
                        newAddressBook = collectionAddressBook.GetAddressBook(firstName);
                        break;

                    case 2:
                        Console.WriteLine("Enter first name of address book to be opened");
                        firstName = Console.ReadLine();
                        newAddressBook = collectionAddressBook.GetAddressBook(firstName);
                        if (newAddressBook == null)
                        {
                            Console.WriteLine("No such Address Book");
                            goto StartAddressBook;
                        }
                        break;
                    case 3:
                        option1 = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        goto StartAddressBook;
                }
                Console.WriteLine("Welcome to Address Book!");
                int a = 1;
                while (a == 1)
                {
                    if (newAddressBook == null)
                    {
                        break;
                    }

                    List<Contact> list = new List<Contact>();
                    Console.WriteLine("Enter your choice: 0.Add the data, 1.View the data, 2.Edit the contact, 3.Remove contact, 4.Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            newAddressBook.Input();
                            break;
                        case 1:
                            newAddressBook.display();
                            break;
                        case 2:
                            Console.WriteLine("Enter the first name of contacts to be edited");
                            string first = Console.ReadLine();
                            int check = newAddressBook.Edit(first);
                            if (check == 0)
                            {
                                Console.WriteLine("Name not found");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the fist name of contact to be removed");
                            first = Console.ReadLine();
                            newAddressBook.Remove(first);
                            break;
                        case 4:
                            a = 0;
                            break;
                        default:
                            Console.WriteLine("Enter correct choice");
                            break;
                    }
                }
            }

        }
    }
}