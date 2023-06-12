using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _12_HomeWork
{
    [Serializable]
    internal class Program
    {
        public static object JsonConvert { get; private set; }

        private static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            float num3 = float.Parse(Console.ReadLine());

            bool allInRange = num1 >= -5.0 && num1 <= 5.0 && num2 >= -5.0 && num2 <= 5.0 && num3 >= -5.0 && num3 <= 5.0;

            if (allInRange)
            {
                Console.WriteLine("All numbers are in the range [-5, 5].");
            }
            else
            {
                Console.WriteLine("Not all numbers are in the range [-5, 5].");
            }


            // ------- 1 Task binary Serialization
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("program.bin", FileMode.Create))
            {
                formatter.Serialize(stream, new Program());
            }

            // Deserialization
            using (FileStream stream = new FileStream("program.bin", FileMode.Open))
            {
                Program deserializedProgram = (Program)formatter.Deserialize(stream);
            }

            //------- 2 task xml serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Program));
            using (StreamWriter writer = new StreamWriter("program.xml"))
            {
                serializer.Serialize(writer, new Program());
            }

            // Deserialization
            using (StreamReader reader = new StreamReader("program.xml"))
            {
                Program deserializedProgram = (Program)serializer.Deserialize(reader);
            }

            //------- task 3 json serialization
            Program program = new Program();
            program.GetUserInput();

            string json = JsonConvert.SerializeObject(program);
            Console.WriteLine("Serialized:");
            Console.WriteLine(json);

            // Deserialization
            Program deserializedProgram = JsonConvert.DeserializeObject<Program>(json);
            Console.WriteLine("\nDeserialized:");
            deserializedProgram.PrintResult();
        }

        private void PrintResult()
        {
            throw new NotImplementedException();
        }

        private void GetUserInput()
        {
            throw new NotImplementedException();
        }
    }
}