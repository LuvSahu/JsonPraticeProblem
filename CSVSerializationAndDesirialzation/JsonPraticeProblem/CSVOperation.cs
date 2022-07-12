using CsvHelper;
using JsonPraticeProblem;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataOperations
{
    public class CSVOperation
    {
        public static void csvSerilaization()
        {
            try
            {
                string csvpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\DataOperationCSV.csv";
                List<Person> person = new List<Person>();
                person.Add(new Person() { PersonId = 89, Name = "Luv", Address = "Jaipur" });
                person.Add(new Person() { PersonId = 69, Name = "Atul", Address = "Alwar" });
                person.Add(new Person() { PersonId = 79, Name = "Rohit", Address = "Dehli" });


                using (StreamWriter sw = new StreamWriter(csvpath))
                {

                    CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    //this has to be written to write the records inside the file
                    csvWriter.WriteRecords(person);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static List<Person> CSVDeserialize()
        {
            try
            {
                string csvpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\DataOperationCSV.csv";
                StreamReader sr = new StreamReader(csvpath);
                CsvReader cr = new CsvReader(sr, CultureInfo.InvariantCulture);
                List<Person> res = cr.GetRecords<Person>().ToList();
                foreach (Person person in res)
                {
                    Console.WriteLine(person);
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }
}