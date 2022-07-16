using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JsonPraticeProblem
{
    internal class JsonDataOperations
    {

        public static void jsonSerialize()
        {
            string jsonPath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\JsonTextFile.json";

 
            List<Person> person = new List<Person>();
            person.Add(new Person() { PersonId = 12, Name = "Luv", Address = "Dehli" });
            person.Add(new Person() { PersonId = 13, Name = "Atul", Address = "Ajmer" });
            person.Add(new Person() { PersonId = 14, Name = "Rohit", Address = "Alwar" });
            string result = JsonConvert.SerializeObject(person);//objcet to string
            using (StreamWriter sw = new StreamWriter(jsonPath))
            {
                sw.Write(result);
            }

        }

        public static void JsonDeserialization()//string to object
        {
            string jsonPath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\JsonTextFile.json";
            if (FileExist(jsonPath))
            {
                string JsonData = File.ReadAllText(jsonPath);
                var result = JsonConvert.DeserializeObject<List<Person>>(JsonData);
                foreach (Person person in result)
                {

                    Console.WriteLine(person.ToString());
                }

            }
            else
            {
                Console.WriteLine("File not exist");
            }



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
    }
}
