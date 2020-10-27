using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookAssignment
{
   public class Contact
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }

        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }   

        public Contact()
        {
            this.fName = "";
            this.lName = "";
            this.address = "";
            this.city = "";
            this.state = "";
            this.zipcode = "";
            this.phone = "";
            this.email = "";
        }

        public Contact(string firstName, string lastName, string address, string city, string state, string zipcode, string phone, string email)
        {
            this.fName = firstName;
            this.lName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phone = phone;
            this.email = email;
        }

        public void display()
        {
            Console.WriteLine("First Name:" + this.fName +
                              "Last Name:" + this.lName +
                              "Address:" + this.address +
                              "City:" + this.city +
                              "State:" + this.state +
                              "Zip:" + this.zipcode +
                              "Phone:" + this.phone +
                              "Email:" + this.email);
        }
    }
}
