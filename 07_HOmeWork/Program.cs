namespace _07_HOmeWork
{
            //---------------------- 1 Task
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // Read data from "phones.txt"
            using (StreamReader reader = new StreamReader("phones.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string name = parts[0].Trim();
                        string phoneNumber = parts[1].Trim();
                        phoneBook[name] = phoneNumber;
                    }
                }
            }

            // Write numbers to "Phones.txt"
            using (StreamWriter writer = new StreamWriter("Phones.txt"))
            {
                foreach (string phoneNumber in phoneBook.Values)
                {
                    writer.WriteLine(phoneNumber);
                }
            }

            // Find and print phone numbers by name
            Console.Write("Enter a name to find phone number: ");
            string searchName = Console.ReadLine();

            if (phoneBook.TryGetValue(searchName, out string foundPhoneNumber))
            {
                Console.WriteLine($"Phone number for {searchName}: {foundPhoneNumber}");
            }
            else
            {
                Console.WriteLine($"No phone number found for {searchName}");
            }

            // Change phone numbers 
            using (StreamWriter writer = new StreamWriter("New.txt"))
            {
                foreach (KeyValuePair<string, string> entry in phoneBook)
                {
                    string name = entry.Key;
                    string phoneNumber = entry.Value;

                    if (phoneNumber.StartsWith("80") && phoneNumber.Length == 11)
                    {
                        phoneNumber = "+380" + phoneNumber.Substring(2);
                    }

                    writer.WriteLine($"{name}: {phoneNumber}");
                }
            }
        }
    }
}