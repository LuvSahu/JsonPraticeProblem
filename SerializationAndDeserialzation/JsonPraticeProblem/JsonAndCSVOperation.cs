using CsvHelper;
using JsonDataOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPraticeProblem
{
    internal class JsonAndCSVOperation
    {
        public static void ReadFromCsvWriteIntoJson()
        {
            string jsonpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\jsonDataOperation.json";
            List<Person> list = CSVOperation.CSVDeserialize();
            //jsonSerialize();
            string result = JsonConvert.SerializeObject(list);
            //objcet to string

            using (StreamWriter sw = new StreamWriter(jsonpath))
            {
                sw.Write(result);
            }

        }

        public static void ReadFromJsonWriteIntoCsv()
        {
            string csvpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\JsontocsvTextFile.csv";
            List<Person> persons = JsonDeserialization();
            csvSerilaization(persons, csvpath);

        }
        public static List<Person> JsonDeserialization()//string to object
        {
            string jsonPath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\JsonTextFile.json";
            if (FileExist(jsonPath))
            {

                string JsonData = File.ReadAllText(jsonPath);
                List<Person> result = JsonConvert.DeserializeObject<List<Person>>(JsonData);
                if (result.Count != 0)
                    foreach (Person person in result)
                    {

                        Console.WriteLine(person.ToString());
                    }
                return result;

            }
            else
            {
                Console.WriteLine("File not exist");
            }
            return null;



        }
        public static bool FileExist(string path)
        {
            string InputFile = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\JsonTextFile.json";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
                return true;
            }
            else
            {
                Console.WriteLine("not Exist");
                return false;
            }
        }
        public static void csvSerilaization(List<Person> person, string csvpath)
        {
            try
            {
                //csvpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\DataOperationCSV.csv";
                //person = new List<Person>();
                //person.Add(new Person() { PersonId = 22, Name = "Luv", Address = "Jaipur" });
                //person.Add(new Person() { PersonId = 33, Name = "Atul", Address = "Alwar" });
                //person.Add(new Person() { PersonId = 44, Name = "Rohit", Address = "Dehli" });


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
    }
}
