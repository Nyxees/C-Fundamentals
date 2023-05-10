namespace _05_HomeWork
{
    using System;
    using System.Collections.Generic;

    //------------- 1.1 Task
    interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }

    //-------------- 1.2 Task
    class Programmer : IDeveloper, IComparable<Programmer>
    {
        public string Tool { get; set; }
        public string Language { get; set; }

        public void Create()
        {
            Console.WriteLine($"Creating {Language} program with {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Destroying {Language} program with {Tool}");
        }

        public int CompareTo(Programmer other)
        {
            return this.Language.CompareTo(other.Language);
        }
    }

    class Builder : IDeveloper, IComparable<Builder>
    {
        public string Tool { get; set; }
        public string Building { get; set; }

        public void Create()
        {
            Console.WriteLine($"Creating {Building} with {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Destroying {Building} with {Tool}");
        }

        public int CompareTo(Builder other)
        {
            return this.Building.CompareTo(other.Building);
        }
    }

    //--------------- 1.3 Task
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer { Language = "C#", Tool = "Visual Studio" });
            developers.Add(new Programmer { Language = "Java", Tool = "Eclipse" });
            developers.Add(new Builder { Building = "House", Tool = "Hammer" });
            developers.Add(new Builder { Building = "Bridge", Tool = "Crane" });

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }

            //------------------ 1.4 Task
            developers.Sort();

            Console.WriteLine("Sorted list:");
            foreach (var developer in developers)
            {
                Console.WriteLine(developer.GetType().Name + " using " + developer.Tool);
            }
        }
    }

}
namespace App
{
    //---------- 2.1 Task
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> dictionary = new Dictionary<uint, string>();

            //------------- 2.2 Task
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter ID {i + 1}: ");
                uint id = uint.Parse(Console.ReadLine());
                Console.Write($"Enter name for ID {id}: ");
                string name = Console.ReadLine();
                dictionary.Add(id, name);
            }

            //-------------- 2.3 Task
            Console.Write("Enter ID to find name: ");
            uint searchID = uint.Parse(Console.ReadLine());
            if (dictionary.ContainsKey(searchID))
            {
                string name = dictionary[searchID];
                Console.WriteLine($"Name for ID {searchID} is {name}");
            }
            else
            {
                Console.WriteLine($"No name found for ID {searchID}");
            }
        }
    }
}