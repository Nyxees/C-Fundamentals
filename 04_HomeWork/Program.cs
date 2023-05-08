namespace _04_HomeWork
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public Person()
        {
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthYear.Year;
            if (now.Month < birthYear.Month || (now.Month == birthYear.Month && now.Day < birthYear.Day))
            {
                age--;
            }
            return age;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth year (yyyy-mm-dd): ");
            birthYear = DateTime.Parse(Console.ReadLine());
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1})", name, birthYear.ToString("yyyy-MM-dd"));
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, p2))
            {
                return true;
            }
            if ((object)p1 == null || (object)p2 == null)
            {
                return false;
            }
            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }

            //---------- 1 Task
    class Program
    {
        static void Main()
        {
            Person[] people = new Person[6];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }

            //--------------- 2 Task
            Console.WriteLine("Name\tAge");
            foreach (Person p in people)
            {
                Console.WriteLine("{0}\t{1}", p.Name, p.Age());
            }

            //--------------- 3 Task
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            //--------------- 4 Task
            Console.WriteLine("\nAll persons:");
            foreach (Person p in people)
            {
                p.Output();
            }

            //--------------- 5 Task
            Console.WriteLine("\nPersons with the same names:");
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine("{0} and {1}", people[i].ToString(), people[j].ToString());
                    }
                }
            }
        }
    }
}