using JsonDataOperations;

namespace JsonPraticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice you want \n 1.JsonSerialization\n 2.jsonDeserializeation\n 3.XMLserialization\n 4.XMLDeserialization\n 5.CSVSerialization\n 6.CSVdeserialization\n 7.ReadFreomCsvWriteToJson\n 8.ReadFromJsonWriteIntoCsv");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    JsonDataOperations.jsonSerialize();
                    break;
                case 2:
                    JsonDataOperations.JsonDeserialization();
                    break;
                case 3:
                    XMLDataOperation.xmlSerialize();
                    break;
                case 4:
                    XMLDataOperation.DXmlDeSerialize();
                    break;
                case 5:
                    CSVOperation.csvSerilaization();
                    break;

                case 6:
                    CSVOperation.CSVDeserialize();
                    break;

                case 7:
                    JsonAndCSVOperation.ReadFromCsvWriteIntoJson();
                    break;
                case 8:
                    JsonAndCSVOperation.ReadFromJsonWriteIntoCsv();
                    break;

            }


        }


    }

}
