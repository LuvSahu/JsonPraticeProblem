using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace JsonPraticeProblem
{
    internal class XMLDataOperation
    {
        public static void xmlSerialize()
        {
            try
            {
                string xmlpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\xmlDataOperation.xml";
                //List<Person> person = new List<Person>();
                //person.Add(new Person() { PersonId = 12, Name = "Luv", Address = "Jaipur" });
                //person.Add(new Person() { PersonId = 13, Name = "Atul", Address = "A;war" });
                //person.Add(new Person() { PersonId = 14, Name = "Rohit", Address = "Ajmer" });
                Person person = new Person() { PersonId = 98, Name = "Luv", Address = "Jaipur" };
                XmlSerializer xml = new XmlSerializer(typeof(Person));

                StreamWriter sw = new StreamWriter(xmlpath);
                xml.Serialize(sw, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    sw.Close();
            //}
        }
        public static void DXmlDeSerialize()
        {
            string xmlpath = @"D:\Bridgelabz\JsonPraticeProblem\JsonPraticeProblem\xmlDataOperation.xml";
            using (StreamReader sr = new StreamReader(xmlpath))

            {
                if (File.Exists(xmlpath))
                {
                    Person person = new Person() { PersonId = 98, Name = "Luv", Address = "Jaipur" };
                    XmlSerializer xml = new XmlSerializer(typeof(Person));
                    //sr = new StreamReader(xmlpath);
                    Person res = (Person)xml.Deserialize(sr);//expicit catsing
                    Console.WriteLine(person);
                }
            }
        }


    }
}
