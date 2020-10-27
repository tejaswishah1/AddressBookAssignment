using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBookAssignment
{
   public class CsvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\HP\source\repos\AddressBookAssignment\AddressBookDetail.csv"; ////orignal csv file created
            string exportFilePath = @"C:\Users\HP\source\repos\AddressBookAssignment\ExportAddressDetails.csv"; ////exporting data 

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Data reading successfull");

                ////printing all data present
                foreach (Contact addressData in records)
                {
                    Console.Write("First Name: " + addressData.fName);
                    Console.Write("Second Name: " + addressData.lName);
                    Console.Write("Address " + addressData.address);
                    Console.Write("City " + addressData.city);
                    Console.Write("State " + addressData.state);
                    Console.Write("Code " + addressData.zipcode);
                    Console.Write("\n");
                }
                ////export:
                using (var writer = new StreamWriter(exportFilePath))  
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }

        }
    }
}
