using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBookAssignment
{
   public class CSVtoJson
    {
        public static void ImplementCSVToJson()
        {
            string importFilePath = @"C:\Users\HP\source\repos\AddressBookAssignment\AddressBookDetail.csv";
            string exportFilePath = @"C:\Users\HP\source\repos\AddressBookAssignment\AddressBookFile.json";

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList(); ////records converted to list
                Console.WriteLine("Data reading successfull");

                ////printing information stored
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
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamwriter = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(streamwriter))
                {
                    jsonSerializer.Serialize(writer, records);

                }

            }
        }


        public static void ImplementJsonToCsv()
        {
            string jsonFilePath = @"C:\Users\HP\source\repos\ThirdPartyLibraryDemo\addressDetails.json";
            string csvFilePath = @"C:\Users\HP\source\repos\ThirdPartyLibraryDemo\addressDetails.csv";

            IList<Contact> addressData = JsonConvert.DeserializeObject<IList<Contact>>(File.ReadAllText(jsonFilePath));

            ////import from json file.
            Console.WriteLine("Reading from JSON file");

            using (var writer = new StreamWriter(csvFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }



        }
    }
}
